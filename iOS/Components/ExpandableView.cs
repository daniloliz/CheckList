using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using UIKit;

namespace CheckList.iOS.Components
{
    [Register("ExpandableView"), DesignTimeVisible(true)]
    public class ExpandableView : UIView
    {
        UILabel titleLabel;
        UILabel descriptionLabel;
        
        [Export("TitleText"), Browsable(true)]
        public string TitleText { get; set; }

        [Export("DescriptionText"), Browsable(true)]
        public string DescriptionText { get; set; }

        [Export("TitleLabel"), Browsable(true)]
        public UILabel TitleLabel 
        { 
            get { return titleLabel; }
            set 
            { 
                titleLabel = value;
                SetNeedsDisplay();
            } 
        }

        [Export("DescriptionLabel"), Browsable(true)]
        public UILabel DescriptionLabel 
        { 
            get { return descriptionLabel; } 
            set 
            {
                descriptionLabel = value;
                SetNeedsDisplay();
            } 
        }

        [Export("Collapsed"), Browsable(true)]
        public bool Collapsed { get; set; }

        public ExpandableView(IntPtr handle) : base(handle) { }

        public ExpandableView()
        {
            Initialize();
        }

        public override void AwakeFromNib()
        {
            Initialize();
        }

        void Initialize()
        {
            Collapsed = false;
            TitleText = "Exemplo Title";
            DescriptionText = "Exemplo Descrição";
            SetNeedsDisplay();
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            if(titleLabel != null && descriptionLabel != null)
            {
                titleLabel.Text = TitleText;
                descriptionLabel.Text = DescriptionText;
                this.Add(titleLabel);
                this.Add(descriptionLabel);
            }
        }
    }
}
