using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PikachuUWP
{
    public sealed partial class Control : UserControl
    {
        DispatcherTimer dtReloj, dtReloj2;

        public Control()
        {
            this.InitializeComponent();
            //Storyboard sbojod = (Storyboard)this.ojod.Resources["pupilaRojaDKey"];
            //Storyboard sbojoi = (Storyboard)this.ojoi.Resources["pupilaRojaIKey"];
        }
        
         void usarPocima(object sender, object e)
        {
            dtReloj = new DispatcherTimer();
            dtReloj.Interval = TimeSpan.FromMilliseconds(100);
            dtReloj.Tick += subirVida;
            dtReloj.Start();
            imgPocima.Opacity = 0.5;
        }
         void usarEscudo(object sender, object e)
        {
            dtReloj2 = new DispatcherTimer();
            dtReloj2.Interval = TimeSpan.FromMilliseconds(100);
            dtReloj2.Tick += subirescudo;
            dtReloj2.Start();
            imgEscudo.Opacity = 0.5;
        }

         void subirVida(object sender, object e)
        {
            //pocion();
            pbVida.Value += 0.2;

            if (pbVida.Value == 100)
            {
                dtReloj.Stop();
                imgPocima.Visibility = 0;
            }
        }


        void bajarVida(object sender, object e)
        {
            //pocion();
            pbVida.Value -= 0.3;

        }

        void bajarVidaplus(object sender, object e)
        {
            //pocion();
            pbVida.Value -= 0.7;

        }

        void subirescudo(object sender, object e)
        {

            pbEscudo.Value += 0.2;

            if (pbEscudo.Value == 100)
            {
                dtReloj2.Stop();
                imgEscudoRecuperacion.Visibility = 0;
            }
        }

        void bajarescudo(object sender, object e)
        {

            pbEscudo.Value -= 0.4;

        }

        void bajarescudoplus(object sender, object e)
        {

            pbEscudo.Value -= 0.8;

        }

        void derrotadoanim()
        {
            Storyboard sb2 = this.Resources["derrotado"] as Storyboard;
            sb2.Begin();
        }
        void escudoregeneraranim()
        {
            Storyboard sb2 = this.Resources["escudoregenerar"] as Storyboard;
            sb2.Begin();
        }
        void danoanim()
        {
            Storyboard sb2 = this.Resources["dano"] as Storyboard;
            sb2.Begin();
        }
        void ataquefuerteanim()
        {
            Storyboard sb2 = this.Resources["ataquefuerte"] as Storyboard;
            sb2.Begin();
        }
        void pocionanim()
        {
            Storyboard sb2 = this.Resources["pocion"] as Storyboard;
            sb2.Begin();
        }
        void ataqueleveanim()
        {
            Storyboard sb2 = this.Resources["ataqueleve"] as Storyboard;
            sb2.Begin();
        }

        void pocion()
        {
            DoubleAnimation boca = new DoubleAnimation();
            boca.From = 0.2f;
            boca.To = 0.4f;
            boca.AutoReverse = true;
            boca.Duration = new Duration(TimeSpan.FromSeconds(1));
            boca.RepeatBehavior = new RepeatBehavior(2);

            Storyboard sb2 = new Storyboard();
            Storyboard.SetTargetProperty(boca, "Height");
            Storyboard.SetTarget(boca, this.boca);
            sb2.Begin();
        }
    }
}
