﻿using ProteoformSuiteInternal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProteoformSuiteGUI
{
    public class DisplayUtility
    {

        #region Public Methods

        public static void FillDataGridView(DataGridView dgv, IEnumerable<object> someList)
        {
            SortableBindingList<object> sbl = new SortableBindingList<object>(someList);
            dgv.DataSource = sbl;
            dgv.ReadOnly = false;
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgv.AllowUserToAddRows = false;
            dgv.DefaultCellStyle.BackColor = Color.LightGray;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
            foreach (DataGridViewColumn col in dgv.Columns) col.SortMode = DataGridViewColumnSortMode.Automatic;
        }

        public static void tooltip_graph_display(ToolTip t, MouseEventArgs e, Chart c, Point? p)
        {
            t.RemoveAll();
            Point pos = e.Location;
            if (p.HasValue && pos == p.Value) return;

            HitTestResult[] results = new HitTestResult[4];

            try
            {
                results = c.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

                foreach (HitTestResult result in results)
                {
                    if (result.ChartElementType == ChartElementType.DataPoint)
                    {
                        DataPoint prop = result.Object as DataPoint;
                        if (prop != null)
                        {
                            double pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                            double pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                            // check if the cursor is really close to the point (2 pixels around the point)
                            if (Math.Abs(pos.X - pointXPixel) < 2) //&& Math.Abs(pos.Y - pointYPixel) < 2)
                                t.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], c, pos.X, pos.Y - 15);
                        }
                    }
                }
            }
            catch
            { }
        }

        public static void GraphRelationsChart(Chart ct, List<ProteoformRelation> relations, string series, bool gaps_zeroed)
        {
            ct.Series[series].Points.Clear();
            ct.Series[series].XValueMember = "delta_mass";
            ct.Series[series].YValueMembers = "nearby_relations_count";
            List<ProteoformRelation> relations_ordered = relations.OrderByDescending(r => r.DeltaMass).ToList();
            for (int i = 0; i < relations_ordered.Count; i++)
            {
                ProteoformRelation relation = relations_ordered[i];
                ProteoformRelation next_relation = relations_ordered[i];
                ct.Series[series].Points.AddXY(relation.DeltaMass, relation.nearby_relations_count);
                if (gaps_zeroed)
                {
                    ct.Series[series].Points.AddXY(relation.DeltaMass + 1e-5, 1e-5);
                    ct.Series[series].Points.AddXY(relation.DeltaMass - 1e-5, 1e-5);
                }
            }
            ct.ChartAreas[0].AxisX.Title = "Delta Mass (Da)";
            ct.ChartAreas[0].AxisY.Title = "Nearby Count";
            ct.ChartAreas[0].AxisX.LabelStyle.Format = "#";
            ct.ChartAreas[0].AxisY.LabelStyle.Format = "#";
            ct.Series[series].Color = Color.DodgerBlue;
        }

        public static void GraphDeltaMassPeaks(Chart ct, List<DeltaMassPeak> peaks, string peak_series, string decoy_series, List<ProteoformRelation> relations, string relations_series)
        {
            ct.Series[peak_series].Points.Clear();
            ct.Series[decoy_series].Points.Clear();
            ct.Series[relations_series].Points.Clear();

            //if no relations, return, don't crash
            if (relations.Count == 0) return;

            double peak_threshold;
            if (typeof(TheoreticalProteoform).IsAssignableFrom(relations[0].connected_proteoforms[1].GetType())) peak_threshold = SaveState.lollipop.min_peak_count_et;
            else peak_threshold = SaveState.lollipop.min_peak_count_ee;
            List<DeltaMassPeak> peaks_ordered = peaks.OrderBy(r => r.DeltaMass).ToList();
            foreach (DeltaMassPeak peak in peaks_ordered)
            {
                ct.Series[peak_series].Points.AddXY(peak.DeltaMass, peak.peak_relation_group_count);
                ct.Series[decoy_series].Points.AddXY(peak.DeltaMass, peak.decoy_relation_count);
            }

            List<ProteoformRelation> relations_ordered = relations.OrderBy(r => r.DeltaMass).ToList();
            foreach (ProteoformRelation relation in relations_ordered)
            {
                ct.Series[relations_series].Points.AddXY(relation.DeltaMass, relation.nearby_relations_count);
            }
            ct.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.00}";
            if (peaks_ordered.Count > 0) GraphSelectedDeltaMassPeak(ct, peaks_ordered[0], relations);
        }

        public static void GraphSelectedDeltaMassPeak(Chart ct, DeltaMassPeak peak, List<ProteoformRelation> relations)
        {
            ct.ChartAreas[0].AxisY.StripLines.Clear();
            double peak_width_base;
            if (typeof(TheoreticalProteoform).IsAssignableFrom(relations[0].connected_proteoforms[1].GetType())) peak_width_base = SaveState.lollipop.peak_width_base_et;
            else peak_width_base = SaveState.lollipop.peak_width_base_ee;
            ct.ChartAreas[0].AxisX.Minimum = peak.DeltaMass - peak_width_base;
            ct.ChartAreas[0].AxisX.Maximum = peak.DeltaMass + peak_width_base;

            ct.ChartAreas[0].AxisX.StripLines.Clear();
            double stripline_tolerance = peak_width_base * 0.5;
            StripLine lowerPeakBound_stripline = new StripLine() { BorderColor = Color.Red, IntervalOffset = peak.DeltaMass - stripline_tolerance };
            StripLine upperPeakBound_stripline = new StripLine() { BorderColor = Color.Red, IntervalOffset = peak.DeltaMass + stripline_tolerance };
            ct.ChartAreas[0].AxisX.StripLines.Add(lowerPeakBound_stripline);
            ct.ChartAreas[0].AxisX.StripLines.Add(upperPeakBound_stripline);

            ct.ChartAreas[0].AxisY.Maximum = 1 + Math.Max(
                Convert.ToInt32(peak.peak_relation_group_count * 1.2),
                Convert.ToInt32(relations.Where(r => r.DeltaMass >= peak.DeltaMass - peak_width_base
                    && r.DeltaMass <= peak.DeltaMass + peak_width_base).Select(r => r.nearby_relations_count).Max())
            ); //this automatically scales the vertical axis to the peak height plus 20%, also accounting for the nearby trace of unadjusted relation group counts

            ct.ChartAreas[0].AxisX.Title = "Delta Mass (Da)";
            ct.ChartAreas[0].AxisY.Title = "Count";
        }

        public static void FormatPeakListGridView(DataGridView dgv, bool mask_mass_shifter)
        {
            if (dgv.Columns.Count <= 0) return;

            dgv.AllowUserToAddRows = false;

            //making all columns invisible first - faster
            foreach (DataGridViewColumn column in dgv.Columns) { column.Visible = false; }
            if (!mask_mass_shifter)
            {
                dgv.Columns[nameof(DeltaMassPeak.mass_shifter)].Visible = true;
                dgv.Columns[nameof(DeltaMassPeak.mass_shifter)].ReadOnly = false; //user can say how much they want to change monoisotopic by for each
            }
            dgv.Columns[nameof(DeltaMassPeak.DeltaMass)].DefaultCellStyle.Format = "0.####";
            dgv.Columns[nameof(DeltaMassPeak.peak_group_fdr)].DefaultCellStyle.Format = "0.##";

            dgv.Columns[nameof(DeltaMassPeak.peak_relation_group_count)].HeaderText = "Peak Center Count";
            dgv.Columns[nameof(DeltaMassPeak.decoy_relation_count)].HeaderText = "Decoy Count under Peak";
            dgv.Columns[nameof(DeltaMassPeak.DeltaMass)].HeaderText = "Peak Center Delta Mass";
            dgv.Columns[nameof(DeltaMassPeak.peak_group_fdr)].HeaderText = "Peak FDR";
            dgv.Columns[nameof(DeltaMassPeak.Accepted)].HeaderText = "Peak Accepted";
            dgv.Columns[nameof(DeltaMassPeak.possiblePeakAssignments_string)].HeaderText = "Peak Assignment Possibilites";

            dgv.Columns[nameof(DeltaMassPeak.peak_relation_group_count)].Visible = true;
            //dgv.Columns[nameof(DeltaMassPeak.decoy_relation_count)].Visible = true;
            dgv.Columns[nameof(DeltaMassPeak.DeltaMass)].Visible = true;
            dgv.Columns[nameof(DeltaMassPeak.peak_group_fdr)].Visible = true;
            dgv.Columns[nameof(DeltaMassPeak.Accepted)].Visible = true;
            dgv.Columns[nameof(DeltaMassPeak.possiblePeakAssignments_string)].Visible = true;
        }

        public static object[] get_selected_objects(DataGridView dgv)
        {
            List<object> items = new List<object>();
            if (dgv.SelectedRows.Count > 0)
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                    items.Add(dgv.SelectedRows[i].DataBoundItem);
            else
            {
                List<int> rows = new List<int>();
                for (int i = 0; i < dgv.SelectedCells.Count; i++) rows.Add(dgv.SelectedCells[i].RowIndex);
                rows = rows.Distinct().ToList();
                foreach (int row_index in rows)
                    items.Add(dgv.Rows[row_index].DataBoundItem);
            }

            List<DisplayObject> display_objects = items.OfType<DisplayObject>().ToList();
            return display_objects.Count > 0 ?
                display_objects.Select(d => d.display_object).ToArray() :
                items.ToArray();
        }

        #endregion Public Methods

    }
}
