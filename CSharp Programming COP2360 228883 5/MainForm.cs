using System.Windows.Forms;

#pragma warning disable 1587
///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_5>                              
///   Class:          <Class Program>                                   
///   Description:    <Description Assignment 5>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 04/17/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                              
///   Name:Initial  Date:04/17/2017 Description:Last Modification Date                  
///------------------------------------------------------------------------------
#pragma warning restore 1587

namespace CSharp_Programming_COP2360_228883_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            reset();
        }

        private void DropDown_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var dropdown = sender as ComboBox;
            reset();
            new Presentation(dropdown, ref DataLabel);
        }

        private void reset()
        {
            #region Hide and Clear Label
            DataLabel.Visible = false;
            DataLabel.Text = string.Empty;
            #endregion
        }
    }
}
