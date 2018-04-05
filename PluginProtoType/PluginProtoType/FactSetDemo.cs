using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Excel.Controls;
using Microsoft.Office.Tools.Ribbon;

namespace PluginProtoType
{
    public partial class FactSetDemo
    {
        private void save_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                string urlText = URL.Text;
                var form = new BrowserForm(urlText);
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                //need to add HappyException here 
                throw;
            }
        }
    }
}
