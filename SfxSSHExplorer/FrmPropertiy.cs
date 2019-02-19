using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfxSSHExplorer
{
    public partial class FrmPropertiy : Form
    {
        public FrmPropertiy(FileProperty fileProperty)
        {
            InitializeComponent();
            this.txtSize.Text = fileProperty.Size;
            this.txtDate.Text = fileProperty.Date;
            this.txtOwner.Text = fileProperty.Owner;
            this.txtGroup.Text = fileProperty.Group;
            this.txtAccess.Text = fileProperty.Access;
            
        }
    }
    public class FileProperty
    {
        public string Size { get; set; }
        public string Date { get; set; }
        public string Owner { get; set; }
        public string Group { get; set; }
        public string Access { get; set; }
    }
}
