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
    /// �Զ���ؼ���,�����ռ��൱�ڰ���
    /// </summary>
    public class MyView:View
    {
        /// <summary>
        /// �̳и���Ĺ��췽��,�ڴ�������ӿؼ�����ʹ�ô˹��췽��
        /// </summary>
        /// <param name="context"></param>
        public MyView(Context context):base(context)
        {
            
        }

        /// <summary>
        /// �̳и���Ĺ��췽��,�Զ���ؼ�����ʵ�ִ˹��췽��
        /// </summary>
        /// <param name="context"></param>
        /// <param name="attrs"></param>
        public MyView(Context context, IAttributeSet attrs) : base(context, attrs)
        {

        }

        /// <summary>
        /// ��д����ķ���,���л�ͼ
        /// </summary>
        /// <param name="canvas"></param>
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            // �����Ż������Ƴɰ�ɫ
            canvas.DrawColor(Color.White);
            Paint paint = new Paint();  // paint�����൱�����Ϻͻ��ʵ�����
            // ȥ���
            paint.AntiAlias = true;
            paint.Color = Color.Blue;
            paint.SetStyle(Paint.Style.Stroke);
            paint.StrokeWidth = 3f;
            // ����Բ��
            canvas.DrawCircle(40, 40, 30, paint);
            // ����������
            canvas.DrawRect(10, 80, 70, 140, paint);
            // ���ƾ���
            canvas.DrawRect(10, 150, 70, 190, paint);
            RectF rel = new RectF(10, 200, 70, 230);
            // ����Բ�Ǿ���
            canvas.DrawRoundRect(rel, 15, 15, paint);
            RectF rell = new RectF(10, 240, 70, 270);
            // ������Բ
            canvas.DrawOval(rell, paint);
            // ����һ��Path����,��ճ�һ��������
            Path path1 = new Path();
            path1.MoveTo(10, 340);
            path1.LineTo(70, 340);
            path1.LineTo(40, 290);
            path1.Close();
            // ����Path���л���,����������
            canvas.DrawPath(path1, paint);
            // ����һ��Path����,��ճ�һ�������
            Path path2 = new Path();
            path2.MoveTo(26, 360);
            path2.LineTo(54, 360);
            path2.LineTo(70, 392);
            path2.LineTo(40, 420);
            path2.LineTo(10, 392);
            path2.Close();
            // ����Path���л���,���������
            canvas.DrawPath(path2, paint);


            // ----�������������-------
            paint.SetStyle(Paint.Style.Fill);
            paint.Color = Color.Red;
            canvas.DrawCircle(120, 40, 30, paint);
            // ����������
            canvas.DrawRect(90, 80, 150, 140, paint);
            // ���ƾ���
            canvas.DrawRect(90, 150, 150, 190, paint);
            RectF re2 = new RectF(90, 200, 150, 230);
            // ����Բ�Ǿ���
            canvas.DrawRoundRect(re2, 15, 15, paint);
            RectF re3 = new RectF(90, 240, 150, 270);
            // ������Բ
            canvas.DrawOval(re3, paint);
            Path path3 = new Path();
            path3.MoveTo(90, 340);
            path3.LineTo(150, 340);
            path3.LineTo(120, 290);
            path3.Close();
            // ����������
            canvas.DrawPath(path3, paint);
            Path path4 = new Path();
            path4.MoveTo(106, 360);
            path4.LineTo(134, 360);
            path4.LineTo(150, 392);
            path4.LineTo(120, 420);
            path4.LineTo(90, 392);
            path4.Close();
            // ���������
            canvas.DrawPath(path4, paint);



            // ------���ý����������--------
            // ΪPaint���ý�����
            Shader mShader = new LinearGradient(0, 0, 40, 60, new int[] { Color.Red, Color.Green, Color.Blue, Color.Yellow }, null, Shader.TileMode.Repeat);
            paint.SetShader(mShader);
            // ������Ӱ
            paint.SetShadowLayer(45, 10, 10, Color.Gray);
            // ����Բ��
            canvas.DrawCircle(200, 40, 30, paint);
            // ����������
            canvas.DrawRect(170, 80, 230, 140, paint);
            // ���ƾ���
            canvas.DrawRect(170, 150, 230, 190, paint);
            RectF re4 = new RectF(170, 200, 230, 230);
            // ����Բ�Ǿ���
            canvas.DrawRoundRect(re4, 15, 15, paint);
            RectF re5 = new RectF(170, 240, 230, 270);
            // ������Բ
            canvas.DrawOval(re5, paint);
            Path path5 = new Path();
            path5.MoveTo(170, 340);
            path5.LineTo(230, 340);
            path5.LineTo(200, 290);
            path5.Close();
            // ����Path���л���,����������
            canvas.DrawPath(path5, paint);
            Path path6 = new Path();
            path6.MoveTo(186, 360);
            path6.LineTo(214, 360);
            path6.LineTo(230, 392);
            path6.LineTo(200, 420);
            path6.LineTo(170, 392);
            path6.Close();
            // ����Path���л���,���������
            canvas.DrawPath(path6, paint);


            // -------�����ַ���С�����--------
            paint.TextSize = 24;
            paint.SetShader(null);  // ������ɫ��,���������ɫ��
            //  ����7���ַ���
            canvas.DrawText(Resources.GetString(Resource.String.circle), 240, 50, paint);
            canvas.DrawText(Resources.GetString(Resource.String.square), 240, 120, paint);
            canvas.DrawText(Resources.GetString(Resource.String.rect), 240, 175, paint);
            canvas.DrawText(Resources.GetString(Resource.String.round_rect), 230, 220, paint);
            canvas.DrawText(Resources.GetString(Resource.String.oval), 240, 260, paint);
            canvas.DrawText(Resources.GetString(Resource.String.triangle), 240, 325, paint);
            canvas.DrawText(Resources.GetString(Resource.String.pentagon), 240, 390, paint);
            // ֻҪ�����Զ���ؼ���ʾ��Activity��,�ȿ��Կ���Ч��
        }
    }
}