using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPOCalculator
{

    public partial class MainForm : XtraForm
    {
        #region ConstantRegion
        private static readonly List<decimal> list = new List<decimal>
        {
            0.06m, 
            0.09m, 
            0.10m, 
            0.10m, 
            0.11m, 
            0.09m,
            0.09m, 
            0.09m, 
            0.09m, 
            0.08m, 
            0.07m, 
            0.08m,
            0.07m, 
            0.07m, 
            0.06m, 
            0.05m, 
            0.06m, 
            0.05m,
            0.05m, 
            0.05m, 
            0.04m, 
            0.04m,
            0.03m,
            0.03m,
            0.03m,
            0.02m,
            0.03m,
            -0.01m,
            -0.03m,
            -0.02m,
            -0.02m,
            0.02m,
            0.02m,
            0.03m,
            0.02m,
            0.01m,
            0.02m,
            -0.01m,
            -0.01m,
            -0.01m,
            -0.01m,
            -0.01m,
            -0.01m,
            -0.01m,
            -0.01m,
            -0.01m
        };

        private static readonly string PATTERN = @"(\d{4})年(\d{1,2})月 至 (\d{4})年(\d{1,2})月";
        #endregion

        public MainForm()
        {
            InitializeComponent();

            // 任职时间
            repositoryItemTextEdit_servingTime.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            repositoryItemTextEdit_servingTime.Mask.EditMask = PATTERN;
            repositoryItemTextEdit_servingTime.Mask.IgnoreMaskBlank = false;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            // 工作经历
            var changes = dataSet.WorkExperienceTable.GetChanges();
            var firstWork = changes.Rows[0].ItemArray;
            var secondWork = changes.Rows[1].ItemArray;

            var firstWorkStartYear = int.Parse(Regex.Match(firstWork[0] as string, PATTERN).Groups[1].Value);
            var firstWorkSalary = firstWork[1];
            var secondWorkStartYear = int.Parse(Regex.Match(secondWork[0] as string, PATTERN).Groups[1].Value);
            var secondWorkSalary = secondWork[1];

            // 出生年份
            var yearOfBirth = int.Parse(txtEdit_year.Text);

            // 70岁的年份
            var year = yearOfBirth + 70;

            // TODO:
            var diffYear = secondWorkStartYear - firstWorkStartYear;
            //var sum = 1.0m;
            //decimal temp;
            //for (int i = 0; i < diffYear; i++)
            //{
            //    temp = list[i];
            //    sum *= (1 + temp == null ? -0.01m : temp);
            //}
        }
    }
}
