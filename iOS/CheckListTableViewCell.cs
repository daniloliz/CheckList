using CheckList.Enum;
using CheckList;
using Foundation;
using System;
using System.Globalization;
using UIKit;

namespace CheckList.iOS
{
    public partial class CheckListTableViewCell : UITableViewCell
    {
        private UIViewController Controller;

        public CheckListTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public CheckListTableViewCell (NSString cellId, CarteiraVacinacao cart, UIViewController controller) : base(UITableViewCellStyle.Default, cellId)
        {
            double min = Math.Min(StatusContainerView.Frame.Width, StatusContainerView.Frame.Height);

            VencimentoContainerView.BackgroundColor = ValidadePeticao(cart.IsVencido(), cart.IsVencer());
            StatusContainerView.Layer.CornerRadius = (float)(min / 2.0);
            StatusContainerView.Layer.MasksToBounds = false;
            StatusContainerView.ClipsToBounds = true;
            StatusContainerView.BackgroundColor = StatusPeticao(cart.Status);
            DataVencimentoLabel.Text = cart.Vencimento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            ResponsavelLabel.Text = cart.Responsavel;
            PetLabel.Text = cart.Pet;
            Controller = controller;
        }

        public void UpdateCell(CarteiraVacinacao cart, UIViewController controller)
        {
            double min = Math.Min(StatusContainerView.Frame.Width, StatusContainerView.Frame.Height);

            VencimentoContainerView.BackgroundColor = ValidadePeticao(cart.IsVencido(), cart.IsVencer());
            StatusContainerView.Layer.CornerRadius = (float)(min / 2.0);
            StatusContainerView.Layer.MasksToBounds = false;
            StatusContainerView.ClipsToBounds = true;
            StatusContainerView.BackgroundColor = StatusPeticao(cart.Status);
            DataVencimentoLabel.Text = cart.Vencimento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            ResponsavelLabel.Text = cart.Responsavel;
            PetLabel.Text = cart.Pet;
            Controller = controller;
        }

        private UIColor ValidadePeticao(bool isVencido, bool isVencer)
        {
            return isVencido && !isVencer ? UIColor.FromRGB(246, 1, 2) :
                                                   !isVencido && isVencer ? UIColor.FromRGB(254, 197, 0) :
                                                   UIColor.FromRGB(0, 184, 212);
        }

        private UIColor StatusPeticao(StatusVacinacaoEnum status)
        {
            return status == StatusVacinacaoEnum.NAO ? UIColor.FromRGB(246, 1, 2) :
                                                   UIColor.FromRGB(0, 184, 212);
        }
    }
}