using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    public class CounterPoint : IImpactPoint
    {
        public int Count = 0;
        public float Radius = 15;

        public override void ImpactParticle(Particle particle)
        {
            float dX = X - particle.X;
            float dY = Y - particle.Y;

            if (dX * dX + dY * dY < Radius * Radius)
            {
                particle.Life = -1;
                Count++;
            }
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(Brushes.Cyan, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            g.DrawString(Count.ToString(), SystemFonts.DefaultFont, Brushes.White, X + Radius + 2, Y - 8);
        }
    }

    public class ReflectionPoint : IImpactPoint
    {
        public float Radius = 30;

        public override void ImpactParticle(Particle particle)
        {
            float dX = particle.X - X;
            float dY = particle.Y - Y;
            float dist2 = dX * dX + dY * dY;

            if (dist2 < Radius * Radius && dist2 > 0)
            { 
                float dist = (float)Math.Sqrt(dist2);
                float nX = dX / dist;
                float nY = dY / dist;

                float dot = particle.SpeedX * nX + particle.SpeedY * nY;
                particle.SpeedX -= 2 * dot * nX;
                particle.SpeedY -= 2 * dot * nY;


                particle.X = X + nX * (Radius + 1);
                particle.Y = Y + nY * (Radius + 1);
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.DeepSkyBlue, 2), 
                X - Radius, Y - Radius, 
                Radius * 2, Radius * 2
            );
        }
    }

    public class RadarPoint : IImpactPoint
    {
        public float Radius = 80;

        private List<Particle> inRange = new List<Particle>();

        public override void ImpactParticle(Particle particle)
        {
            float dX = particle.X - X;
            float dY = particle.Y - Y;

            if (dX * dX + dY * dY < Radius * Radius)
                inRange.Add(particle);
        }

        public override void Render(Graphics g)
        {
            foreach (var p in inRange)
            {
                g.FillEllipse(Brushes.LimeGreen,
                    p.X - p.Radius - 3,
                    p.Y - p.Radius - 3,
                    (p.Radius + 3) * 2,
                    (p.Radius + 3) * 2);
            }

            var pen = new Pen(Color.FromArgb(160, Color.LimeGreen), 2);
            g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(inRange.Count.ToString(), 
                SystemFonts.DefaultFont, 
                Brushes.LimeGreen,
                X, Y, 
                stringFormat
            );

            inRange.Clear();
        }
    }

    public class GravityPoint : IImpactPoint
    {
        public int Power = 100;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Radius < Power / 2) 
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            var text = $"Я гравитон\nc силой {Power}";
            var font = new Font("Verdana", 10);

            var size = g.MeasureString(text, font);

            g.FillRectangle(
                new SolidBrush(Color.Red),
                X - size.Width / 2,
                Y - size.Height / 2,
                size.Width,
                size.Height
            );

            g.DrawString(
                text,
                font,
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat
            );
        }
    }

    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; 
            particle.SpeedY -= gY * Power / r2; 
        }
    }
}
