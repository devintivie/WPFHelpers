using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WPFMessageBox
{
    public class UserDialogsImpl : AbstractUserDialogs
    {
        public override IDisposable ActionSheet(ActionSheetConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Alert(AlertConfig config)
        {
            MessageBoxResult result = MessageBox.Show(config.Message, config.Title);
            return null;
            //throw new NotImplementedException();
        }

        public override IDisposable Confirm(ConfirmConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable DatePrompt(DatePromptConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Login(LoginConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Prompt(PromptConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable TimePrompt(TimePromptConfig config)
        {
            throw new NotImplementedException();
        }

        public override IDisposable Toast(ToastConfig config)
        {
            throw new NotImplementedException();
        }

        protected override IProgressDialog CreateDialogInstance(ProgressDialogConfig config)
        {
            throw new NotImplementedException();
        }
    }
}
