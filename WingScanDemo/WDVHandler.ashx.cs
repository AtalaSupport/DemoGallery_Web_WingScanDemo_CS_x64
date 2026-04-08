using Atalasoft.Imaging.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class WDVHandler : Atalasoft.Imaging.WebControls.WebDocumentRequestHandler
{
    public WDVHandler()
    {
        /// IMPORTANT!: This is added for security purposes - it fully disables file upload
        this.FileUpload += new FileUploadEventHandler(delegate(object sender, FileUploadEventArgs e) { e.Cancel = true; e.Overwrite = false; });
    }
}