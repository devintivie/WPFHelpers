using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFToggleButtons
{
    public class LedIndicator : Control
    {
        static LedIndicator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LedIndicator), new FrameworkPropertyMetadata(typeof(LedIndicator)));
        }

        #region IsOnProperty
        public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register("IsOn", typeof(bool), typeof(LedIndicator), null);
        public bool IsOn
        {
            get { return (bool)GetValue(IsOnProperty); }
            set { SetValue(IsOnProperty, value); }
        }
        #endregion

        #region OnColorProperty
        public static readonly DependencyProperty OnColorProperty = DependencyProperty.Register("OnColor", typeof(Brush), typeof(LedIndicator), null);
        public Brush OnColor
        {
            get { return (Brush)GetValue(OnColorProperty); }
            set { SetValue(OnColorProperty, value); }
        }
        #endregion

        #region OffColorProperty
        public static readonly DependencyProperty OffColorProperty = DependencyProperty.Register("OffColor", typeof(Brush), typeof(LedIndicator), null);
        public Brush OffColor
        {
            get { return (Brush)GetValue(OffColorProperty); }
            set { SetValue(OffColorProperty, value); }
        }
        #endregion


    }
}
