using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask5
{
    public class FootballPlayer
    {

        public Random random1 = new Random();
        protected string Name;
        protected int uniformNo, speed, endurance, pass, shoot, skill, stability, naturalForm, luck;

        public FootballPlayer()
        { }

        public void randomizeGeneralSkills()
        {
            speed = random1.Next(50, 100);
            endurance = random1.Next(50, 100);
            pass = random1.Next(50, 100);
            shoot = random1.Next(50, 100);
            skill = random1.Next(50, 100);
            stability = random1.Next(50, 100);
            naturalForm = random1.Next(50, 100);
            luck = random1.Next(50, 100);
        }

        public virtual Boolean TryToPass()
        { return true; }
        public virtual Boolean TryToShoot()
        { return true; }

    }

    public class Defense : FootballPlayer
    {
        int positioning, header, jumping;

        public Defense(string adsoyad, int formano)
        {
            this.Name = adsoyad;
            this.uniformNo = formano;
            positioning = random1.Next(50, 90);
            header = random1.Next(50, 90);
            jumping = random1.Next(50, 90);
            randomizeGeneralSkills();
        }

        public override bool TryToPass()
        {
            if (80 <= pass * 0.3 + skill * 0.3 + endurance * 0.1 + naturalForm * 0.1 + positioning * 0.1 + luck * 0.2)
                return true;
            else
                return false;
        }
        public override bool TryToShoot()
        {
            //defansa özel yetenekler ile gol atma şansı oluşturulmalı
            return true;
        }

    }
    public class MidFielder : FootballPlayer
    {
        int longBall, firstControl, creativity, dribbling, specialSkill;

        public MidFielder(string adsoyad, int formano)
        {
            this.Name = adsoyad;
            this.uniformNo = formano;
            longBall = random1.Next(60, 100);
            firstControl = random1.Next(60, 100);
            creativity = random1.Next(60, 100);
            dribbling = random1.Next(60, 100);
            specialSkill = random1.Next(60, 100);
            randomizeGeneralSkills();

        }

        public override bool TryToPass()
        {
            if (80 <= pass * 0.3 + skill * 0.2 + specialSkill * 0.2 + endurance * 0.1 + naturalForm * 0.1 + longBall * 0.1 + dribbling * 0.1 + luck * 0.1)
                return true;
            else
                return false;

        }
        public override bool TryToShoot()
        {
            //orta sahaya özel yetenekler ile gol atma şansı oluşturulmalı
            return true;
        }
    }

    public class Striker : FootballPlayer
    {
        int finisher, firstControl, header, specialSkill, coldBlooded;

        public Striker(string adsoyad, int formano)
        {
            this.Name = adsoyad;
            this.uniformNo = formano;
            finisher = random1.Next(70, 100);
            firstControl = random1.Next(70, 100);
            header = random1.Next(70, 100);
            specialSkill = random1.Next(70, 100);
            coldBlooded = random1.Next(70, 100);
            randomizeGeneralSkills();

        }
        public override bool TryToPass()
        {
            if (80 <= pass * 0.3 + skill * 0.2 + specialSkill * 0.2 + endurance * 0.1 + naturalForm * 0.1 + luck * 0.1)
                return true;
            else
                return false;

        }
        public override bool TryToShoot()
        {
            if (75 < finisher * 0.5 + firstControl * 0.2 + coldBlooded * 0.2 + header * 0.2)
                return true;
            else
                return false;

        }
    }
}
