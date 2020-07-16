using Acr.UserDialogs;
using System;

namespace WPFMessageBox
{
    public static partial class WPFUserDialogs
    {
        static IUserDialogs currentInstance;

		public static IUserDialogs Instance
		{
			get 
			{
				currentInstance = currentInstance ?? new UserDialogsImpl();	
				return currentInstance; 
			}
			set => currentInstance = value;
		}

	}
}
