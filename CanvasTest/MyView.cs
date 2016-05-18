using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace CanvasTest
{
    /// <summary>
    /// 自定义控件类,命名空间相当于包名
    /// </summary>
    public class MyView:View
    {
        /// <summary>
        /// 继承父类的构造方法,在代码中添加控件可以使用此构造方法
        /// </summary>
        /// <param name="context"></param>
        public MyView(Context context):base(context)
        {
            
        }

        /// <summary>
        /// 继承父类的构造方法,自定义控件必须实现此构造方法
        /// </summary>
        /// <param name="context"></param>
        /// <param name="attrs"></param>
        public MyView(Context context, IAttributeSet attrs) : base(context, attrs)
        {

        }

        /// <summary>
        /// 重写父类的方法,进行绘图
        /// </summary>
        /// <param name="canvas"></param>
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            // 把整张画布绘制成白色
            canvas.DrawColor(Color.White);
            Paint paint = new Paint();  // paint对象相当于颜料和画笔的作用
            // 去锯齿
            paint.AntiAlias = true;
            paint.Color = Color.Blue;
            paint.SetStyle(Paint.Style.Stroke);
            paint.StrokeWidth = 3f;
            // 绘制圆形
            canvas.DrawCircle(40, 40, 30, paint);
            // 绘制正方形
            canvas.DrawRect(10, 80, 70, 140, paint);
            // 绘制矩形
            canvas.DrawRect(10, 150, 70, 190, paint);
            RectF rel = new RectF(10, 200, 70, 230);
            // 绘制圆角矩形
            canvas.DrawRoundRect(rel, 15, 15, paint);
            RectF rell = new RectF(10, 240, 70, 270);
            // 绘制椭圆
            canvas.DrawOval(rell, paint);
            // 定义一个Path对象,封闭成一个三角形
            Path path1 = new Path();
            path1.MoveTo(10, 340);
            path1.LineTo(70, 340);
            path1.LineTo(40, 290);
            path1.Close();
            // 根据Path进行绘制,绘制三角形
            canvas.DrawPath(path1, paint);
            // 定义一个Path对象,封闭成一个五角形
            Path path2 = new Path();
            path2.MoveTo(26, 360);
            path2.LineTo(54, 360);
            path2.LineTo(70, 392);
            path2.LineTo(40, 420);
            path2.LineTo(10, 392);
            path2.Close();
            // 根据Path进行绘制,绘制五角形
            canvas.DrawPath(path2, paint);


            // ----设置填充风格后绘制-------
            paint.SetStyle(Paint.Style.Fill);
            paint.Color = Color.Red;
            canvas.DrawCircle(120, 40, 30, paint);
            // 绘制正方形
            canvas.DrawRect(90, 80, 150, 140, paint);
            // 绘制矩形
            canvas.DrawRect(90, 150, 150, 190, paint);
            RectF re2 = new RectF(90, 200, 150, 230);
            // 绘制圆角矩形
            canvas.DrawRoundRect(re2, 15, 15, paint);
            RectF re3 = new RectF(90, 240, 150, 270);
            // 绘制椭圆
            canvas.DrawOval(re3, paint);
            Path path3 = new Path();
            path3.MoveTo(90, 340);
            path3.LineTo(150, 340);
            path3.LineTo(120, 290);
            path3.Close();
            // 绘制三角形
            canvas.DrawPath(path3, paint);
            Path path4 = new Path();
            path4.MoveTo(106, 360);
            path4.LineTo(134, 360);
            path4.LineTo(150, 392);
            path4.LineTo(120, 420);
            path4.LineTo(90, 392);
            path4.Close();
            // 绘制五角形
            canvas.DrawPath(path4, paint);



            // ------设置渐变器后绘制--------
            // 为Paint设置渐变器
            Shader mShader = new LinearGradient(0, 0, 40, 60, new int[] { Color.Red, Color.Green, Color.Blue, Color.Yellow }, null, Shader.TileMode.Repeat);
            paint.SetShader(mShader);
            // 设置阴影
            paint.SetShadowLayer(45, 10, 10, Color.Gray);
            // 绘制圆形
            canvas.DrawCircle(200, 40, 30, paint);
            // 绘制正方形
            canvas.DrawRect(170, 80, 230, 140, paint);
            // 绘制矩形
            canvas.DrawRect(170, 150, 230, 190, paint);
            RectF re4 = new RectF(170, 200, 230, 230);
            // 绘制圆角矩形
            canvas.DrawRoundRect(re4, 15, 15, paint);
            RectF re5 = new RectF(170, 240, 230, 270);
            // 绘制椭圆
            canvas.DrawOval(re5, paint);
            Path path5 = new Path();
            path5.MoveTo(170, 340);
            path5.LineTo(230, 340);
            path5.LineTo(200, 290);
            path5.Close();
            // 根据Path进行绘制,绘制三角形
            canvas.DrawPath(path5, paint);
            Path path6 = new Path();
            path6.MoveTo(186, 360);
            path6.LineTo(214, 360);
            path6.LineTo(230, 392);
            path6.LineTo(200, 420);
            path6.LineTo(170, 392);
            path6.Close();
            // 根据Path进行绘制,绘制五角形
            canvas.DrawPath(path6, paint);


            // -------设置字符大小后绘制--------
            paint.TextSize = 24;
            paint.SetShader(null);  // 设置着色器,或者清除着色器
            //  绘制7个字符串
            canvas.DrawText(Resources.GetString(Resource.String.circle), 240, 50, paint);
            canvas.DrawText(Resources.GetString(Resource.String.square), 240, 120, paint);
            canvas.DrawText(Resources.GetString(Resource.String.rect), 240, 175, paint);
            canvas.DrawText(Resources.GetString(Resource.String.round_rect), 230, 220, paint);
            canvas.DrawText(Resources.GetString(Resource.String.oval), 240, 260, paint);
            canvas.DrawText(Resources.GetString(Resource.String.triangle), 240, 325, paint);
            canvas.DrawText(Resources.GetString(Resource.String.pentagon), 240, 390, paint);
            // 只要将此自定义控件显示在Activity中,既可以看到效果
        }
    }
}