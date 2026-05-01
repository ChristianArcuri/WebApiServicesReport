using log4net;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace DevExpress.XtraReports.UI
{    
    public class XRLineExtension : DevExpress.XtraReports.UI.XRLine
    {        
        public XRLineExtension() : base() { }
        [
            Bindable(true),
            Browsable(false),
            EditorBrowsable(EditorBrowsableState.Never)
        ]

        private string _color;
        public string Color
        {
            get { return this._color; }
            set { 
                this._color = value;
            if (string.IsNullOrEmpty(Color)) {
                base.ForeColor = System.Drawing.Color.Black;
                base.BorderColor = System.Drawing.Color.Black;
                return;
                }
                base.ForeColor = System.Drawing.ColorTranslator.FromHtml(this._color);
                base.BorderColor = System.Drawing.ColorTranslator.FromHtml(this._color);                }
        }
    }
    public class XRTableExtension : XRTable
    {
        public XRTableExtension() : base() { }
        [
            Bindable(true),
            Browsable(false),
            EditorBrowsable(EditorBrowsableState.Never)
        ]

        private string _borderColor;
        new public string BorderColor
        {
            get { return this._borderColor; }
            set
            {
                this._borderColor = value;
                if (string.IsNullOrEmpty(_borderColor))
                {
                    base.BorderColor = System.Drawing.Color.Black;
                    return;
                }
                base.BorderColor = System.Drawing.ColorTranslator.FromHtml(this._borderColor);
            }
        }
    }

    public class XRPanelExtension : XRPanel
    {
        public XRPanelExtension() : base() { }
        [
            Bindable(true),
            Browsable(false),
            EditorBrowsable(EditorBrowsableState.Never)
        ]

        private string _borderColor;
        new public string BorderColor
        {
            get { return this._borderColor; }
            set
            {
                this._borderColor = value;
                if (string.IsNullOrEmpty(_borderColor))
                {
                    base.BorderColor = System.Drawing.Color.Black;
                    return;
                }
                base.BorderColor = System.Drawing.ColorTranslator.FromHtml(this._borderColor);
            }
        }
    }
    public class XRTableCellExtension : XRTableCell
    {
        public XRTableCellExtension() : base() { }
        [
            Bindable(true),
            Browsable(false),
            EditorBrowsable(EditorBrowsableState.Never)
        ]

        private string _borderColor;
        new public string BorderColor
        {
            get { return this._borderColor; }
            set
            {
                this._borderColor = value;
                if (string.IsNullOrEmpty(_borderColor))
                {
                    base.BorderColor = System.Drawing.Color.Black;
                    return;
                }
                base.BorderColor = System.Drawing.ColorTranslator.FromHtml(this._borderColor);
            }
        }

        private string _hexaForeColor;
        public string HexaForeColor
        {
            get { return this._hexaForeColor; }
            set
            {
                this._hexaForeColor = value;
                if (string.IsNullOrEmpty(_hexaForeColor))
                {
                    base.BorderColor = System.Drawing.Color.Black;
                    return;
                }
                base.ForeColor = System.Drawing.ColorTranslator.FromHtml(this._hexaForeColor);
            }
        }
    }
    public class XRLabelExtension : XRLabel
    {
        public XRLabelExtension() : base() { }
        [
            Bindable(true),
            Browsable(false),
            EditorBrowsable(EditorBrowsableState.Never)
        ]

        private string _borderColor;
        new public string BorderColor
        {
            get { return this._borderColor; }
            set
            {
                this._borderColor = value;
                if (string.IsNullOrEmpty(_borderColor))
                {
                    base.BorderColor = System.Drawing.Color.Black;
                    return;
                }
                base.BorderColor = System.Drawing.ColorTranslator.FromHtml(this._borderColor);
            }
        }

        private string _hexaForeColor;
        public string HexaForeColor
        {
            get { return this._hexaForeColor; }
            set
            {
                this._hexaForeColor = value;
                if (string.IsNullOrEmpty(_hexaForeColor))
                {
                    base.BorderColor = System.Drawing.Color.Black;
                    return;
                }
                base.ForeColor = System.Drawing.ColorTranslator.FromHtml(this._hexaForeColor);
            }
        }

        private string _backColor;
        new public string BackColor
        {
            get { return this._backColor; }
            set
            {
                this._backColor = value;
                if (string.IsNullOrEmpty(_backColor))
                {
                    base.BackColor = System.Drawing.Color.Black;
                    return;
                }
                base.BackColor = System.Drawing.ColorTranslator.FromHtml(this._backColor);
            }
        }
    }
    public class PictureBoxExtension : XRPictureBox
    {        
        public PictureBoxExtension() : base() { }
        [
            Bindable(true),
            Browsable(false),
            EditorBrowsable(EditorBrowsableState.Never)
        ]

        private string _bgColor;
        public string BGColor
        {
            get { return this._bgColor; }
            set
            {
                this._bgColor = value;
                if (string.IsNullOrEmpty(_bgColor))
                {
                    base.BackColor = System.Drawing.Color.Transparent;
                    return;
                }
                base.BackColor = System.Drawing.ColorTranslator.FromHtml(this._bgColor);
            }
        }

        private byte[] _logo;
        public byte[] Logo
        {
            get { return this._logo; }
            set
            {
                this._logo = value;
                if (_logo is null)
                {
                    return;
                }
                base.Image = GetImageFormBinary(value);              
            }
        }

        private Image GetImageFormBinary(byte[] b)
        {
            ILog log = LogManager.GetLogger(typeof(PictureBoxExtension));
            try
            {
                using (MemoryStream ms = new MemoryStream(b, 0, b.Length))
                {
                    ms.Write(b, 0, b.Length);
                    Image logo = Image.FromStream(ms);
                    return logo;
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("GetImageFormBinary ERROR: {0}", ex.Message);
                return null;
            }
        }
    }
}
