	public static Dictionary<Type, int[]> Damages = new Dictionary<Type, int[]>()
		//[Damage Type], new int[]{[Headshot Damage], [Body Damage], <Stun Time>(60unit/s)}
        {
            {typeof(AT9mm), new int[2]{51, 25} },
            {typeof(ATSniper), new int[2]{100, 75} },
            {typeof(ATShrapnel), new int[2]{23, 17} },
            {typeof(ATWagnus), new int[2]{30, 25} },
            {typeof(Sharpshot), new int[3]{120, 120, 60} },
            {typeof(Sniper), new int[3]{100, 100, 30} },
            {typeof(Pistol), new int[2]{51, 25} },
            {typeof(SnubbyPistol), new int[2]{51, 39} },
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
            {typeof(DuelingPistol), new int[2]{110, 110} },
            {typeof(G18), new int[2]{12, 7} },
            {typeof(MagBlaster), new int[2]{100, 100} },
            {typeof(GrenadeLauncher), new int[2]{120, 120} },
            {typeof(Musket), new int[2]{74, 61} },
            {typeof(OldPistol), new int[2]{74, 61} },
            {typeof(SuicidePistol), new int[2]{94, 65} },
            {typeof(Bazooka), new int[2]{120, 120} },
            
        };

        internal static Dictionary<Type, int[,]> SpecialDamages = new Dictionary<Type, int[,]>()
		//[Damage Type], new int[N, 3]{[ChargeLevel-N Headshot Damage], [ChargeLevel-N Body Damage], [ChargeLevel-N Stun Time](60unit/s)},
        {
            {typeof(ATPhaser), new int[4, 3]{
                {0, 0, 0},
                {25, 17, 0},
                {71, 53, 20},
                {120, 100, 40},
            } },

        };

		//There are some differences in calculating the damage of grenades/mines/RCCars.
		//If you are in the maximum explosion range of 7/10, Damage = 100, Stunning Time = 60
		//Else Damage = 90 * (1.7 - Your range), Stunning Time = 40 * (1.7 - Your range)
		
		
		
