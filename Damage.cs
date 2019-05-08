	public static Dictionary<Type, int[]> Damages = new Dictionary<Type, int[]>() 
//[Injury Type], new int[]{[Headshot Damage], [Body Damage], <Stunning Time>}
        {
            {typeof(AT9mm), new int[2]{51, 25} },
            {typeof(ATSniper), new int[2]{100, 75} },
            {typeof(ATShrapnel), new int[2]{23, 17} },
            {typeof(Sharpshot), new int[3]{100, 100, 10} },
            {typeof(Sniper), new int[2]{100, 75} },
            {typeof(Pistol), new int[2]{51, 25} },
            {typeof(SnubbyPistol), new int[2]{51, 25} },
            {typeof(PewPewLaser), new int[2]{34, 25} },
            {typeof(LaserRifle), new int[2]{45, 31} },
            {typeof(Chaingun), new int[2]{34, 25} },
            {typeof(SMG), new int[2]{26, 19} },
            {typeof(PlasmaBlaster), new int[2]{26, 19} },
            {typeof(Shotgun), new int[2]{21, 18} },
            {typeof(Blunderbuss), new int[2]{32, 24} },
            {typeof(CombatShotgun), new int[2]{21, 18} },
            {typeof(VirtualShotgun), new int[2]{21, 18} },
            {typeof(CowboyPistol), new int[2]{94, 65} },
            {typeof(Magnum), new int[2]{94, 65} },
            {typeof(DuelingPistol), new int[2]{100, 100} },
            {typeof(G18), new int[2]{12, 7} },
            {typeof(MagBlaster), new int[2]{100, 100} },
            {typeof(GrenadeLauncher), new int[2]{100, 100} },
            {typeof(Musket), new int[2]{74, 61} },
            {typeof(OldPistol), new int[2]{74, 61} },
            {typeof(SuicidePistol), new int[2]{94, 65} },
            {typeof(Bazooka), new int[2]{100, 100} },
        };
		
	public static Dictionary<Type, int[,]> SpecialDamages = new Dictionary<Type, int[,]>() 
//[Injury Type], new int[N, 3]{[ChargeLevel-N Headshot Damage], [ChargeLevel-N Body Damage], [ChargeLevel-N Stunning Time]},
        {
            {typeof(ATPhaser), new int[3, 3]{
                {25, 17, 0},
                {71, 53, 5},
                {100, 100, 10},
            } },

        };