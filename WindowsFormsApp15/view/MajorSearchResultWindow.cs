using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.view
{
    public partial class MajorSearchResultWindow : Form
    {
        private Major major;
        public MajorSearchResultWindow(Major major)
        {
            InitializeComponent();
            this.major = major;
            label1.Text = major.Name;
        }
    }
}
