using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSync
{
    class LVUserItem : ListViewItem
    {
        public ChatEndpoint relatedEndpoint;
        public LVUserItem(ChatEndpoint ce)
        {
            relatedEndpoint = ce;
            base.Text = ce.ToString();
            base.ForeColor = (relatedEndpoint.online ? System.Drawing.Color.Black : System.Drawing.Color.DarkGray);
        }
        public void updateElement()
        {
            base.Text = relatedEndpoint.ToString();
            base.ForeColor = (relatedEndpoint.online ? System.Drawing.Color.Black : System.Drawing.Color.DarkGray);

        }
    }
}
