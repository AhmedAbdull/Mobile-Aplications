using Android.App;
using Android.Widget;
using Android.OS;

namespace ButtonsAhmed
{
    [Activity(Label = "ButtonsAhmed", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        TextView textView1;
        TextView textView2;
        TextView textView3;
        TextView textView4;
        
        int i;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button3 = FindViewById<Button>(Resource.Id.button3);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button5 = FindViewById<Button>(Resource.Id.button5);

            textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView2 = FindViewById<TextView>(Resource.Id.textView2);
            textView3 = FindViewById<TextView>(Resource.Id.textView3);
            textView4 = FindViewById<TextView>(Resource.Id.textView4);
            //Обработка нажатий

            //первый способ -подпиской метода
            button1.Click += button1_click; ///СМОТРЕТЬ НИЖЕ

            //второй способ -подписка делегата

            button2.Click += delegate (object sender, System.EventArgs e)
              {
                  textView2.Text = "Делегатом";
              };
            //третий способ - подписка лямбда-выражения
            button3.Click += (sender, e) => textView3.Text = "Лямбда-выражением";
            //четвертый способ- Лямба-оператором

            button4.Click += (sender, e) =>
            {
                textView4.Text = "Лямбда-оператором";
  
            };

            button5.Click += (sender, e) =>
            {
               
                    
                        textView1.Text = "Текст";              
                        textView2.Text = "Текст";
                        textView3.Text = "Текст";
                        textView4.Text = "Текст";


            };
            void button1_click(object sender, System.EventArgs e)
            {

                textView1.Text = "Методом";
            }
        }
    }
}

