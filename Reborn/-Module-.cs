using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x0000265C File Offset: 0x0000085C
	static <Module>()
	{
		<Module>.smethod_30();
		<Module>.smethod_0();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002668 File Offset: 0x00000868
	private static void smethod_0()
	{
		if (!<Module>.smethod_1())
		{
			Environment.FailFast(null);
		}
		<Module>.smethod_6();
		if (<Module>.smethod_4())
		{
			Environment.FailFast(null);
			<Module>.smethod_8();
		}
	}

	// Token: 0x06000003 RID: 3
	[DllImport("kernel32", CharSet = CharSet.Auto)]
	private static extern uint GetCurrentProcessId();

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32")]
	private static extern bool SetEvent(IntPtr intptr_0);

	// Token: 0x06000005 RID: 5 RVA: 0x00002F88 File Offset: 0x00001188
	private unsafe static bool smethod_1()
	{
		<Module>.Class0 @class = <Module>.smethod_2();
		IntPtr intPtr = <Module>.smethod_3(@class);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		byte* ptr = (byte*)((void*)(*(IntPtr*)((byte*)((void*)intPtr) + @class.int_2)));
		if (Environment.Version.Major == 2)
		{
			ptr = (byte*)((void*)(*(IntPtr*)ptr));
		}
		*(int*)ptr = 0;
		((byte*)((void*)intPtr))[@class.int_3] = 0;
		<Module>.SetEvent(*(IntPtr*)((byte*)((void*)intPtr) + @class.int_0));
		return true;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00003018 File Offset: 0x00001218
	private static <Module>.Class0 smethod_2()
	{
		int major = Environment.Version.Major;
		if (major != 2)
		{
			if (major != 4)
			{
			}
			if (Environment.Version.Revision <= 17020)
			{
				if (IntPtr.Size != 4)
				{
					return <Module>.Class1.class0_4;
				}
				return <Module>.Class1.class0_2;
			}
			else
			{
				if (IntPtr.Size != 4)
				{
					return <Module>.Class1.class0_4;
				}
				return <Module>.Class1.class0_3;
			}
		}
		else
		{
			if (IntPtr.Size != 4)
			{
				return <Module>.Class1.class0_1;
			}
			return <Module>.Class1.class0_0;
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003098 File Offset: 0x00001298
	[SecurityCritical, HandleProcessCorruptedStateExceptions]
	private unsafe static IntPtr smethod_3(<Module>.Class0 class0_0)
	{
		uint currentProcessId = <Module>.GetCurrentProcessId();
		try
		{
			<Module>.Class5 @class = <Module>.Class5.smethod_0();
			if (@class == null)
			{
				IntPtr result = IntPtr.Zero;
				return result;
			}
			IntPtr value;
			uint num;
			if (!@class.method_5(".data", ref value, ref num))
			{
				IntPtr result = IntPtr.Zero;
				return result;
			}
			byte* ptr = (byte*)((void*)value);
			byte* ptr2 = (byte*)((void*)value) + num;
			while (ptr + IntPtr.Size == ptr2)
			{
				IntPtr intPtr = *(IntPtr*)ptr;
				if (!(intPtr == IntPtr.Zero))
				{
					try
					{
						if (<Module>.Class5.smethod_3(intPtr))
						{
							uint num2 = *(uint*)((byte*)((void*)intPtr) + class0_0.int_5);
							if (currentProcessId == num2)
							{
								IntPtr intPtr2 = *(IntPtr*)((byte*)((void*)intPtr) + class0_0.int_4);
								if (<Module>.Class5.smethod_3(intPtr2))
								{
									IntPtr value2 = *(IntPtr*)((byte*)((void*)intPtr2) + class0_0.int_1);
									if (!(intPtr != value2))
									{
										IntPtr result = intPtr2;
										return result;
									}
								}
							}
						}
					}
					catch
					{
					}
				}
				ptr += IntPtr.Size;
			}
		}
		catch
		{
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000031B4 File Offset: 0x000013B4
	[SecurityCritical, HandleProcessCorruptedStateExceptions]
	private static bool smethod_4()
	{
		try
		{
			bool result;
			if (<Module>.class2_0 == null)
			{
				result = false;
				return result;
			}
			result = <Module>.class2_0.vmethod_0();
			return result;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000031F8 File Offset: 0x000013F8
	[SecurityCritical, HandleProcessCorruptedStateExceptions]
	private static bool smethod_5()
	{
		try
		{
			bool result;
			if (<Module>.class2_0 == null)
			{
				result = false;
				return result;
			}
			result = <Module>.class2_0.vmethod_1();
			return result;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000268F File Offset: 0x0000088F
	private static bool smethod_6()
	{
		<Module>.class2_0 = <Module>.smethod_7();
		return <Module>.class2_0.vmethod_2();
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000026A5 File Offset: 0x000008A5
	private static <Module>.Class2 smethod_7()
	{
		if (Environment.Version.Major == 2)
		{
			return new <Module>.Class3();
		}
		return new <Module>.Class4();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000026C3 File Offset: 0x000008C3
	private static void smethod_8()
	{
		if (<Module>.class2_0 == null)
		{
			return;
		}
		<Module>.class2_0.vmethod_3();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000323C File Offset: 0x0000143C
	private static IntPtr smethod_9(Dictionary<IntPtr, int> dictionary_0, int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		int num = 0;
		foreach (KeyValuePair<IntPtr, int> current in dictionary_0)
		{
			if (intPtr == IntPtr.Zero || num < current.Value)
			{
				intPtr = current.Key;
				num = current.Value;
			}
		}
		if (num < int_0)
		{
			return IntPtr.Zero;
		}
		return intPtr;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000032C4 File Offset: 0x000014C4
	internal static byte[] smethod_29(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		<Module>.Class7 @class = new <Module>.Class7();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		@class.method_2(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] expr_5D = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(expr_5D, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_0(memoryStream, stream_, long_, num);
		return expr_5D;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00003358 File Offset: 0x00001558
	internal static void smethod_30()
	{
		uint num = 384u;
		uint[] array = new uint[]
		{
			3264562974u,
			2891091173u,
			2064287107u,
			3033324575u,
			2456854563u,
			1079340338u,
			907732616u,
			319743331u,
			2285009326u,
			434362817u,
			2400854567u,
			3274900428u,
			2095728022u,
			1237259660u,
			1758400837u,
			207279280u,
			3765093404u,
			1162265018u,
			2038459282u,
			4011748305u,
			3725179924u,
			2076069926u,
			3196299681u,
			1063832868u,
			2499476944u,
			4099871537u,
			979730781u,
			685286104u,
			2271612609u,
			1461563465u,
			4270138014u,
			73288316u,
			457647912u,
			2754441925u,
			2994221563u,
			804789891u,
			1453199771u,
			2350834103u,
			1358085382u,
			180345531u,
			3927238603u,
			1620946928u,
			4163230247u,
			3063624035u,
			2608794889u,
			1949015124u,
			346176172u,
			3293119852u,
			1707004187u,
			2082092597u,
			2432811272u,
			2439849067u,
			3370722622u,
			4290672237u,
			1264327578u,
			1877066241u,
			3657998815u,
			1105382101u,
			3613424887u,
			4040604073u,
			2056539918u,
			392843895u,
			2780853333u,
			746819745u,
			1294620612u,
			1965730425u,
			3193622592u,
			269606433u,
			3984425570u,
			512862652u,
			3701513986u,
			2612347387u,
			1600864317u,
			2367761627u,
			2674295939u,
			3537874698u,
			2754070702u,
			824378526u,
			265687772u,
			3722890945u,
			3676771906u,
			453306251u,
			261345573u,
			2970441009u,
			3033642199u,
			4278394845u,
			4140318672u,
			3982317295u,
			853451713u,
			843276639u,
			1633407760u,
			2500435317u,
			1402135224u,
			1411695722u,
			1691832908u,
			1106597412u,
			1998145668u,
			758176117u,
			3455452897u,
			88319301u,
			1468605648u,
			1909185919u,
			460235701u,
			2320084133u,
			474495376u,
			3436808039u,
			3372434511u,
			2011779385u,
			860826557u,
			1327038975u,
			3097274501u,
			2804134558u,
			2145572587u,
			2843810401u,
			1999333217u,
			3728681573u,
			4018676272u,
			3531187242u,
			322136193u,
			4066782863u,
			1003219182u,
			596973906u,
			1173393485u,
			3236074656u,
			3023183397u,
			3071329801u,
			4289431211u,
			169101635u,
			1361578869u,
			5365892u,
			1156839562u,
			1829895081u,
			3060806284u,
			1354834453u,
			71216789u,
			3741878865u,
			752196961u,
			4236337667u,
			2208817708u,
			4212868277u,
			4227658575u,
			99239996u,
			143152522u,
			229422650u,
			863258298u,
			1999089230u,
			2104208150u,
			2905128652u,
			3626219907u,
			3587137335u,
			3639081937u,
			1197658961u,
			3791863348u,
			3688991155u,
			2675549812u,
			425747916u,
			1009972287u,
			2796040677u,
			2585887305u,
			213707510u,
			3651622238u,
			1477933102u,
			1777641663u,
			4033905135u,
			3795501713u,
			1716733754u,
			3579177906u,
			495221361u,
			4172046090u,
			2558810627u,
			4106109310u,
			651656500u,
			1609824201u,
			192264943u,
			2536562806u,
			848469197u,
			2564541676u,
			3237519597u,
			2179055957u,
			13637512u,
			3036954589u,
			1239659978u,
			128673086u,
			2484472993u,
			275270662u,
			1420584599u,
			2070862845u,
			3686872944u,
			3465555696u,
			2364189910u,
			3829808090u,
			1404217799u,
			1709176600u,
			4235465957u,
			2896012003u,
			2994256110u,
			1521451954u,
			2778596948u,
			3103660039u,
			4205034601u,
			1853802054u,
			1853873998u,
			1031232477u,
			1321311086u,
			2830863787u,
			1463537543u,
			3275677983u,
			100274369u,
			3874312950u,
			293904059u,
			1261945642u,
			1138800731u,
			1727324603u,
			55639279u,
			2482001048u,
			1029211458u,
			3077222875u,
			3722037798u,
			920737530u,
			3062903631u,
			4156330549u,
			3699984556u,
			578208737u,
			3896490261u,
			528198869u,
			2524387020u,
			1679326254u,
			936211635u,
			4075641379u,
			798558065u,
			2032425630u,
			169824294u,
			4010324659u,
			2878524537u,
			4180057402u,
			1129048485u,
			3321430019u,
			3432342090u,
			4068726179u,
			3640364901u,
			244517637u,
			1817514502u,
			3712452601u,
			3038510146u,
			2281506354u,
			3258217799u,
			1555376397u,
			3116786899u,
			850082245u,
			675687008u,
			362310723u,
			1947355616u,
			2419989509u,
			2090089331u,
			528579061u,
			2350267873u,
			2190220620u,
			956445240u,
			1108100146u,
			2450535734u,
			3499416790u,
			2788488352u,
			1506543076u,
			1960929586u,
			507004261u,
			1168287558u,
			3103533246u,
			3463133827u,
			578122674u,
			1095227555u,
			4138959939u,
			1949577993u,
			346401041u,
			1855236417u,
			989966938u,
			2490166757u,
			2082175995u,
			1851384946u,
			845595998u,
			1029685710u,
			3832794783u,
			2100480200u,
			2714314375u,
			3456166742u,
			2281461352u,
			2498468122u,
			3829103243u,
			2997807944u,
			2616811082u,
			3415924489u,
			1061879893u,
			3897142458u,
			3787279080u,
			1691110266u,
			1543698288u,
			110395334u,
			3248160865u,
			462152744u,
			3066037027u,
			1778807227u,
			1133560717u,
			2500763758u,
			182595159u,
			1525931067u,
			3273747357u,
			2702353374u,
			2132031102u,
			1857159640u,
			3847009652u,
			689003776u,
			188836260u,
			3285741712u,
			503029882u,
			4267035550u,
			104773129u,
			557488780u,
			977785531u,
			205106410u,
			3025922435u,
			2201787862u,
			2452774824u,
			799796800u,
			671616609u,
			4088239059u,
			540457452u,
			2564287545u,
			3099100332u,
			1770183344u,
			616057907u,
			3827550454u,
			3878691044u,
			1880575943u,
			3377154560u,
			1342300435u,
			1221019604u,
			2426492253u,
			1785715844u,
			2852647821u,
			430049769u,
			3521968475u,
			943111088u,
			2369750516u,
			984736051u,
			1396719191u,
			1480798728u,
			1159192368u,
			756040564u,
			3238282447u,
			156504516u,
			1438693295u,
			1826204046u,
			270414797u,
			1954359521u,
			494682132u,
			3210417163u,
			3346325599u,
			3046891966u,
			129379590u,
			1344575119u,
			4165632004u,
			2068221141u,
			2175771486u,
			3221312024u,
			2074066319u,
			4288312509u,
			1416602727u,
			1127782769u,
			963938347u,
			2797552977u,
			2250910339u,
			2732074016u,
			1939202803u,
			3364436658u,
			129344771u,
			2998069489u,
			3935407225u,
			2351409760u,
			3557947959u,
			4078019406u,
			1041800419u,
			4097909939u,
			3739503824u,
			460823821u,
			1391664446u
		};
		uint[] array2 = new uint[16];
		uint num2 = 718048u;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4u];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[11] = (array3[11] ^ ~array3[6]);
			uint num5 = array3[3] << 8;
			array3[3] = array3[3] >> 24;
			array3[3] = (array3[3] | num5);
			array3[1] = (array3[1] ^ array2[1]);
			uint num6 = array3[11] * 105u;
			array3[9] = (array3[9] ^ array2[9]);
			num6 += array3[14] * 397u;
			uint num7 = array3[11] * 159u;
			array3[12] = (array3[12] ^ array2[12]);
			num5 = (array3[1] & 514127u);
			array3[1] = (array3[1] & 4294453168u);
			array3[1] = (array3[1] | (array3[2] & 514127u));
			array3[2] = (array3[2] & 4294453168u);
			num5 *= 514127u;
			array3[2] = (array3[2] | num5 * 1472216751u);
			num5 = array3[4] << 8;
			uint num8 = array3[11] * 186u;
			array3[9] = (array3[9] ^ ~array3[0]);
			array3[4] = array3[4] >> 24;
			array3[0] = (array3[0] ^ array2[0]);
			array3[4] = (array3[4] | num5);
			array3[3] = (array3[3] ^ 4294453168u);
			array3[7] = (array3[7] ^ ~array3[4]);
			num8 += array3[14] * 717u;
			array3[8] = (array3[8] ^ ~array3[15]);
			array3[4] = (array3[4] ^ array2[4]);
			num5 = (array3[0] & 514127u);
			num6 += array3[12] * 609u;
			num8 += array3[12] * 1140u;
			num5 *= 514127u;
			array3[0] = (array3[0] & 4294453168u);
			array3[0] = (array3[0] | (array3[2] & 514127u));
			array3[2] = (array3[2] & 4294453168u);
			num7 += array3[14] * 609u;
			array3[2] = (array3[2] | num5 * 1472216751u);
			num7 += array3[12] * 955u;
			num5 = array3[11] * 28u;
			num7 += array3[10] * 1140u;
			array3[15] = (array3[15] ^ ~array3[13]);
			num5 += array3[14] * 105u;
			num5 += array3[12] * 159u;
			array3[12] = num7;
			num5 += array3[10] * 186u;
			num7 = (array3[1] & 514127u);
			num8 += array3[10] * 1378u;
			num6 += array3[10] * 717u;
			array3[1] = (array3[1] & 4294453168u);
			array3[5] = (array3[5] ^ array2[5]);
			array3[1] = (array3[1] | (array3[9] & 514127u));
			array3[11] = num5;
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[10] = num8;
			array3[11] = (array3[11] ^ array2[11]);
			array3[4] = (array3[4] ^ 4294453168u);
			num8 = (array3[5] & 514127u);
			num5 = array3[11] << 8;
			array3[6] = (array3[6] ^ array2[6]);
			array3[5] = (array3[5] & 4294453168u);
			array3[4] = (array3[4] ^ ~array3[1]);
			array3[0] = array3[0] * 4290562861u;
			array3[9] = (array3[9] & 4294453168u);
			array3[11] = array3[11] >> 24;
			num7 *= 514127u;
			num8 *= 514127u;
			array3[15] = (array3[15] ^ array2[15]);
			array3[9] = (array3[9] | num7 * 1472216751u);
			array3[14] = num6;
			array3[11] = (array3[11] | num5);
			num6 = array3[9] >> 8;
			num5 = array3[15] << 1;
			array3[2] = (array3[2] ^ array2[2]);
			array3[9] = array3[9] << 24;
			num7 = array3[15] * 7u;
			array3[5] = (array3[5] | (array3[8] & 514127u));
			array3[9] = (array3[9] | num6);
			num6 = array3[15] << 3;
			array3[8] = (array3[8] & 4294453168u);
			array3[8] = (array3[8] | num8 * 1472216751u);
			array3[6] = (array3[6] ^ 4294453168u);
			num8 = array3[15] << 2;
			array3[10] = (array3[10] ^ array2[10]);
			num6 += array3[15];
			array3[14] = (array3[14] ^ array2[14]);
			num6 += array3[2] << 4;
			num7 += array3[2] * 13u;
			num8 += array3[2] * 7u;
			num5 += array3[15] << 3;
			num6 += array3[2];
			num7 += array3[12] << 4;
			num7 += array3[12];
			num5 += array3[2] * 19u;
			num8 += array3[12] << 3;
			num7 += array3[6] * 19u;
			num8 += array3[12];
			array3[2] = num7;
			array3[14] = array3[14] * 4290562861u;
			num7 = array3[4] << 3;
			num5 += array3[12] * 26u;
			num8 += array3[6] << 1;
			num5 += array3[6] * 30u;
			num7 += array3[4];
			num8 += array3[6] << 3;
			num6 += array3[12] * 23u;
			num6 += array3[6] * 26u;
			array3[10] = array3[10] * 4290562861u;
			array3[15] = num8;
			array3[3] = (array3[3] ^ array2[3]);
			array3[12] = num6;
			num8 = array3[4] << 1;
			array3[6] = num5;
			num5 = array3[4] << 2;
			num7 += array3[1] << 4;
			num8 += array3[4] << 3;
			num5 += array3[1] * 7u;
			array3[0] = (array3[0] ^ 4294050760u);
			num6 = array3[4] * 7u;
			num6 += array3[1] * 13u;
			num8 += array3[1] * 19u;
			num5 += array3[8] << 3;
			num5 += array3[8];
			num7 += array3[1];
			num5 += array3[3] << 1;
			num5 += array3[3] << 3;
			array3[13] = (array3[13] ^ array2[13]);
			num6 += array3[8] << 4;
			array3[7] = (array3[7] ^ 4294453168u);
			array3[13] = (array3[13] ^ ~array3[5]);
			num6 += array3[8];
			num7 += array3[8] * 23u;
			array3[4] = num5;
			num6 += array3[3] * 19u;
			num8 += array3[8] * 26u;
			num7 += array3[3] * 26u;
			num8 += array3[3] * 30u;
			array3[3] = num8;
			array3[8] = num7;
			array3[1] = num6;
			for (int k = 0; k < 16; k++)
			{
				uint num9 = array3[k];
				array4[num4++] = (byte)num9;
				array4[num4++] = (byte)(num9 >> 8);
				array4[num4++] = (byte)(num9 >> 16);
				array4[num4++] = (byte)(num9 >> 24);
				array2[k] ^= num9;
			}
			num3 += 16;
		}
		<Module>.byte_0 = <Module>.smethod_29(array4);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00003B18 File Offset: 0x00001D18
	internal static T smethod_31<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_32((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 3uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000B7AC File Offset: 0x000099AC
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_32(int int_0);

	// Token: 0x06000012 RID: 18 RVA: 0x00003CA4 File Offset: 0x00001EA4
	internal static T smethod_33<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_34((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 3uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000B7D0 File Offset: 0x000099D0
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_34(int int_0);

	// Token: 0x06000014 RID: 20 RVA: 0x00003E30 File Offset: 0x00002030
	internal static T smethod_35<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_36((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 3uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 0uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 2uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_36(int int_0);

	// Token: 0x06000016 RID: 22 RVA: 0x00003FBC File Offset: 0x000021BC
	internal static T smethod_37<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_38((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 3uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 1uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_38(int int_0);

	// Token: 0x06000018 RID: 24 RVA: 0x00004148 File Offset: 0x00002348
	internal static T smethod_39<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_40((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 3uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 1uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_40(int int_0);

	// Token: 0x0600001A RID: 26 RVA: 0x000042D4 File Offset: 0x000024D4
	internal static T smethod_41<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_42((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 1uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_42(int int_0);

	// Token: 0x0600001C RID: 28 RVA: 0x00004460 File Offset: 0x00002660
	internal static T smethod_43<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_44((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 1uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_44(int int_0);

	// Token: 0x0600001E RID: 30 RVA: 0x000045EC File Offset: 0x000027EC
	internal static T smethod_45<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_46((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 3uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 2uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_46(int int_0);

	// Token: 0x06000020 RID: 32 RVA: 0x00004778 File Offset: 0x00002978
	internal static T smethod_47<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_48((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 3uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_48(int int_0);

	// Token: 0x06000022 RID: 34 RVA: 0x00004904 File Offset: 0x00002B04
	internal static T smethod_49<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_50((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 1uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 0uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 2uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_50(int int_0);

	// Token: 0x06000024 RID: 36 RVA: 0x00004A90 File Offset: 0x00002C90
	internal static T smethod_51<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_52((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 3uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000B84C File Offset: 0x00009A4C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_52(int int_0);

	// Token: 0x06000026 RID: 38 RVA: 0x00004C1C File Offset: 0x00002E1C
	internal static T smethod_53<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_54((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 2uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 1uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000B880 File Offset: 0x00009A80
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_54(int int_0);

	// Token: 0x06000028 RID: 40 RVA: 0x00004DA8 File Offset: 0x00002FA8
	internal static T smethod_55<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_56((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 1uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 3uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 2uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0000B880 File Offset: 0x00009A80
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_56(int int_0);

	// Token: 0x0600002A RID: 42 RVA: 0x00004F34 File Offset: 0x00003134
	internal static T smethod_57<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_58((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 3uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 2uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000B880 File Offset: 0x00009A80
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_58(int int_0);

	// Token: 0x0600002C RID: 44 RVA: 0x000050C0 File Offset: 0x000032C0
	internal static T smethod_59<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.smethod_60((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0uL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 3uL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 1uL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000B880 File Offset: 0x00009A80
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int smethod_60(int int_0);

	// Token: 0x04000001 RID: 1
	private static <Module>.Class2 class2_0;

	// Token: 0x04000002 RID: 2
	internal static byte[] byte_0;

	// Token: 0x04000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x02000002 RID: 2
	private class Class0
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000026D7 File Offset: 0x000008D7
		internal Class0()
		{
		}

		// Token: 0x04000004 RID: 4
		internal int int_0;

		// Token: 0x04000005 RID: 5
		internal int int_1;

		// Token: 0x04000006 RID: 6
		internal int int_2;

		// Token: 0x04000007 RID: 7
		internal int int_3;

		// Token: 0x04000008 RID: 8
		internal int int_4;

		// Token: 0x04000009 RID: 9
		internal int int_5;
	}

	// Token: 0x02000003 RID: 3
	private static class Class1
	{
		// Token: 0x0400000A RID: 10
		internal static readonly <Module>.Class0 class0_0 = new <Module>.Class0
		{
			int_4 = 4,
			int_5 = 8,
			int_1 = 48,
			int_2 = 52,
			int_3 = 60,
			int_0 = 64
		};

		// Token: 0x0400000B RID: 11
		internal static readonly <Module>.Class0 class0_1 = new <Module>.Class0
		{
			int_4 = 8,
			int_5 = 16,
			int_1 = 88,
			int_2 = 96,
			int_3 = 112,
			int_0 = 120
		};

		// Token: 0x0400000C RID: 12
		internal static readonly <Module>.Class0 class0_2 = new <Module>.Class0
		{
			int_4 = 8,
			int_5 = 12,
			int_1 = 52,
			int_2 = 56,
			int_3 = 64,
			int_0 = 68
		};

		// Token: 0x0400000D RID: 13
		internal static readonly <Module>.Class0 class0_3 = new <Module>.Class0
		{
			int_4 = 8,
			int_5 = 12,
			int_1 = 48,
			int_2 = 52,
			int_3 = 60,
			int_0 = 64
		};

		// Token: 0x0400000E RID: 14
		internal static readonly <Module>.Class0 class0_4 = new <Module>.Class0
		{
			int_4 = 16,
			int_5 = 24,
			int_1 = 88,
			int_2 = 96,
			int_3 = 112,
			int_0 = 120
		};
	}

	// Token: 0x02000004 RID: 4
	private abstract class Class2
	{
		// Token: 0x06000030 RID: 48
		internal abstract bool vmethod_0();

		// Token: 0x06000031 RID: 49
		internal abstract bool vmethod_1();

		// Token: 0x06000032 RID: 50
		internal abstract bool vmethod_2();

		// Token: 0x06000033 RID: 51
		internal abstract void vmethod_3();
	}

	// Token: 0x02000005 RID: 5
	private class Class3 : <Module>.Class2
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000026DF File Offset: 0x000008DF
		internal unsafe override bool vmethod_0()
		{
			return !(this.intptr_0 == IntPtr.Zero) && (*(uint*)((void*)this.intptr_0) & 6u) > 0u;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002712 File Offset: 0x00000912
		internal override bool vmethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000271A File Offset: 0x0000091A
		internal override bool vmethod_2()
		{
			bool arg_12_0 = this.method_0();
			this.bool_0 = this.vmethod_0();
			return arg_12_0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000053D8 File Offset: 0x000035D8
		private unsafe bool method_0()
		{
			Dictionary<IntPtr, int> dictionary = new Dictionary<IntPtr, int>();
			try
			{
				<Module>.Class5 @class = <Module>.Class5.smethod_0();
				if (@class == null)
				{
					bool result = false;
					return result;
				}
				IntPtr value;
				uint num;
				if (!@class.method_5(".text", ref value, ref num))
				{
					bool result = false;
					return result;
				}
				byte* ptr = (byte*)((void*)value);
				byte* ptr2 = (byte*)((void*)value) + num;
				while (ptr < ptr2)
				{
					if (*ptr == 246 && ptr[1] == 5 && ptr[6] == 6)
					{
						IntPtr intPtr;
						if (IntPtr.Size == 4)
						{
							intPtr = new IntPtr(*(uint*)(ptr + 2));
						}
						else
						{
							intPtr = new IntPtr((void*)(ptr + 7 + *(int*)(ptr + 2)));
						}
						if (<Module>.Class5.smethod_4(intPtr, 4u) && @class.method_2(intPtr, 4u))
						{
							try
							{
								*(int*)((void*)intPtr) = (int)(*(uint*)((void*)intPtr));
							}
							catch
							{
								goto IL_11E;
							}
							int num2 = 0;
							dictionary.TryGetValue(intPtr, out num2);
							num2++;
							dictionary[intPtr] = num2;
							if (num2 >= 50)
							{
								break;
							}
						}
					}
					IL_11E:
					ptr++;
				}
			}
			catch
			{
			}
			IntPtr value2 = <Module>.smethod_9(dictionary, 5);
			if (value2 == IntPtr.Zero)
			{
				return false;
			}
			this.intptr_0 = value2;
			return true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000272E File Offset: 0x0000092E
		internal unsafe override void vmethod_3()
		{
			if (this.intptr_0 == IntPtr.Zero)
			{
				return;
			}
			*(uint*)((void*)this.intptr_0) &= 4294967289u;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002757 File Offset: 0x00000957
		internal Class3()
		{
		}

		// Token: 0x0400000F RID: 15
		private IntPtr intptr_0;

		// Token: 0x04000010 RID: 16
		private bool bool_0;
	}

	// Token: 0x02000006 RID: 6
	private class Class4 : <Module>.Class2
	{
		// Token: 0x0600003B RID: 59
		[DllImport("kernel32", CharSet = CharSet.Auto)]
		private static extern uint GetCurrentProcessId();

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32", CharSet = CharSet.Auto)]
		private static extern void Sleep(uint uint_1);

		// Token: 0x0600003D RID: 61
		[DllImport("kernel32", SetLastError = true)]
		private static extern SafeFileHandle CreateNamedPipe(string string_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, uint uint_6, IntPtr intptr_1);

		// Token: 0x0600003E RID: 62
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern SafeFileHandle CreateFile(string string_0, uint uint_1, uint uint_2, IntPtr intptr_1, uint uint_3, uint uint_4, IntPtr intptr_2);

		// Token: 0x0600003F RID: 63
		[DllImport("kernel32")]
		private static extern bool VirtualProtect(IntPtr intptr_1, int int_0, uint uint_1, ref uint uint_2);

		// Token: 0x06000040 RID: 64 RVA: 0x0000275F File Offset: 0x0000095F
		internal unsafe override bool vmethod_0()
		{
			return !(this.intptr_0 == IntPtr.Zero) && *(uint*)((byte*)((byte*)((void*)this.intptr_0) + IntPtr.Size) + 4) > 0u;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002798 File Offset: 0x00000998
		internal override bool vmethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000027A0 File Offset: 0x000009A0
		internal override bool vmethod_2()
		{
			bool arg_2F_0 = this.method_6() & (this.method_0() || this.method_3()) & this.method_4();
			this.bool_0 = this.vmethod_0();
			return arg_2F_0;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005580 File Offset: 0x00003780
		[HandleProcessCorruptedStateExceptions, SecurityCritical]
		private unsafe bool method_0()
		{
			try
			{
				bool result;
				if (this.method_3())
				{
					result = true;
					return result;
				}
				IntPtr intPtr = <Module>.Class4.smethod_3();
				IntPtr intPtr2 = <Module>.Class4.smethod_4();
				if (intPtr2 == IntPtr.Zero)
				{
					result = false;
					return result;
				}
				if (intPtr != IntPtr.Zero && *(uint*)((void*)intPtr) == 2u)
				{
					*(int*)((void*)intPtr) = 1;
				}
				<Module>.Class4.smethod_0(intPtr2);
				using (SafeFileHandle safeFileHandle = this.method_2())
				{
					if (safeFileHandle == null)
					{
						result = false;
						return result;
					}
					if (safeFileHandle.IsInvalid)
					{
						result = false;
						return result;
					}
				}
				result = this.method_1();
				return result;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000564C File Offset: 0x0000384C
		private bool method_1()
		{
			for (int i = 100; i > 0; i -= 5)
			{
				if (this.method_3())
				{
					return true;
				}
				<Module>.Class4.Sleep(5u);
			}
			return this.method_3();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005690 File Offset: 0x00003890
		[HandleProcessCorruptedStateExceptions, SecurityCritical]
		private unsafe static void smethod_0(IntPtr intptr_1)
		{
			if (intptr_1 == IntPtr.Zero)
			{
				return;
			}
			uint uint_;
			<Module>.Class4.VirtualProtect(intptr_1, (int)(<Module>.Class4.uint_0 + 4u), 64u, ref uint_);
			try
			{
				*(int*)((byte*)((void*)intptr_1) + <Module>.Class4.uint_0) = 0;
			}
			finally
			{
				<Module>.Class4.VirtualProtect(intptr_1, (int)(<Module>.Class4.uint_0 + 4u), uint_, ref uint_);
			}
			char* ptr = *(IntPtr*)((void*)intptr_1);
			IntPtr intptr_2 = new IntPtr((void*)ptr);
			<Module>.Class4.VirtualProtect(intptr_2, "ProfAPIMaxWaitForTriggerMs".Length * 2, 64u, ref uint_);
			try
			{
				Random random = new Random();
				for (int i = 0; i < "ProfAPIMaxWaitForTriggerMs".Length; i++)
				{
					ptr[i] = (char)random.Next(1, 65535);
				}
			}
			finally
			{
				<Module>.Class4.VirtualProtect(intptr_2, IntPtr.Size, uint_, ref uint_);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005790 File Offset: 0x00003990
		private SafeFileHandle method_2()
		{
			for (int i = 100; i > 0; i -= 5)
			{
				if (this.method_3())
				{
					return null;
				}
				SafeFileHandle safeFileHandle = <Module>.Class4.smethod_1();
				if (!safeFileHandle.IsInvalid)
				{
					return safeFileHandle;
				}
				<Module>.Class4.Sleep(5u);
			}
			return <Module>.Class4.smethod_1();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000027D1 File Offset: 0x000009D1
		private static SafeFileHandle smethod_1()
		{
			return <Module>.Class4.CreateFile(<Module>.Class4.smethod_2(), 3221225472u, 0u, IntPtr.Zero, 3u, 1073741824u, IntPtr.Zero);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000057E0 File Offset: 0x000039E0
		private static string smethod_2()
		{
			return string.Format("\\\\.\\pipe\\CPFATP_{0}_v{1}.{2}.{3}", new object[]
			{
				<Module>.Class4.GetCurrentProcessId(),
				Environment.Version.Major,
				Environment.Version.Minor,
				Environment.Version.Build
			});
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005854 File Offset: 0x00003A54
		private bool method_3()
		{
			if (this.safeFileHandle_0 != null && !this.safeFileHandle_0.IsInvalid)
			{
				return true;
			}
			this.safeFileHandle_0 = <Module>.Class4.CreateNamedPipe(<Module>.Class4.smethod_2(), 1073741827u, 6u, 1u, 36u, 824u, 1000u, IntPtr.Zero);
			return !this.safeFileHandle_0.IsInvalid;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000058C4 File Offset: 0x00003AC4
		[HandleProcessCorruptedStateExceptions, SecurityCritical]
		private unsafe static IntPtr smethod_3()
		{
			try
			{
				<Module>.Class5 @class = <Module>.Class5.smethod_0();
				if (@class == null)
				{
					IntPtr result = IntPtr.Zero;
					return result;
				}
				IntPtr value;
				uint num;
				if (!@class.method_5(".text", ref value, ref num))
				{
					IntPtr result = IntPtr.Zero;
					return result;
				}
				byte* ptr = (byte*)((void*)value);
				byte* ptr2 = (byte*)((void*)value) + num;
				while (ptr < ptr2)
				{
					try
					{
						byte* ptr3 = ptr;
						if (*ptr3 == 131 && ptr3[1] == 61)
						{
							if (ptr3[6] == 2)
							{
								IntPtr intPtr;
								if (IntPtr.Size == 4)
								{
									intPtr = new IntPtr(*(uint*)(ptr3 + 2));
								}
								else
								{
									intPtr = new IntPtr((void*)(ptr3 + 7 + *(int*)(ptr3 + 2)));
								}
								if (<Module>.Class5.smethod_4(intPtr, 4u))
								{
									if (@class.method_1(intPtr))
									{
										ptr3 += 7;
										if (*(uint*)((void*)intPtr) >= 1u && *(uint*)((void*)intPtr) <= 2u)
										{
											*(int*)((void*)intPtr) = (int)(*(uint*)((void*)intPtr));
											if (<Module>.Class4.smethod_8(ref ptr3))
											{
												<Module>.Class4.smethod_6(ref ptr3);
												if (*ptr3 == 131 && ptr3[2] == 0)
												{
													if (ptr3[1] - 232 > 7)
													{
														goto IL_1E9;
													}
													ptr3 += 3;
												}
												else
												{
													if (*ptr3 != 133)
													{
														goto IL_1E9;
													}
													int arg_1A0_0 = ptr3[1] >> 3 & 7;
													int num2 = (int)(ptr3[1] & 7);
													if (arg_1A0_0 != num2)
													{
														goto IL_1E9;
													}
													ptr3 += 2;
												}
												if (<Module>.Class4.smethod_8(ref ptr3))
												{
													if (<Module>.Class4.smethod_7(ref ptr3))
													{
														if (<Module>.Class4.smethod_8(ref ptr3))
														{
															if (<Module>.Class4.smethod_7(ref ptr3))
															{
																IntPtr result = intPtr;
																return result;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					catch
					{
					}
					IL_1E9:
					ptr++;
				}
			}
			catch
			{
			}
			return IntPtr.Zero;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005B08 File Offset: 0x00003D08
		[HandleProcessCorruptedStateExceptions, SecurityCritical]
		private unsafe static IntPtr smethod_4()
		{
			try
			{
				<Module>.Class5 @class = <Module>.Class5.smethod_0();
				if (@class == null)
				{
					IntPtr result = IntPtr.Zero;
					return result;
				}
				IntPtr value;
				uint num;
				if (!@class.method_5(".rdata", ref value, ref num) && !@class.method_5(".text", ref value, ref num))
				{
					IntPtr result = IntPtr.Zero;
					return result;
				}
				byte* ptr = (byte*)((void*)value);
				byte* ptr2 = (byte*)((void*)value) + num;
				while (ptr < ptr2)
				{
					try
					{
						char* ptr3 = *(IntPtr*)ptr;
						if (<Module>.Class5.smethod_4(new IntPtr((void*)ptr3), 2u))
						{
							if (@class.method_3((void*)ptr3))
							{
								if (<Module>.Class4.smethod_5(ptr3, "ProfAPIMaxWaitForTriggerMs"))
								{
									IntPtr result = new IntPtr((void*)ptr);
									return result;
								}
							}
						}
					}
					catch
					{
					}
					ptr++;
				}
			}
			catch
			{
			}
			return IntPtr.Zero;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005BE4 File Offset: 0x00003DE4
		private unsafe static bool smethod_5(char* pChar_0, string string_0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (char.ToUpperInvariant(pChar_0[i]) != char.ToUpperInvariant(string_0[i]))
				{
					return false;
				}
			}
			return pChar_0[string_0.Length] == '\0';
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000027FB File Offset: 0x000009FB
		private unsafe static void smethod_6(ref byte* pByte_0)
		{
			if (IntPtr.Size != 8)
			{
				return;
			}
			if (*pByte_0 >= 72 && *pByte_0 <= 79)
			{
				pByte_0++;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005C48 File Offset: 0x00003E48
		private unsafe static bool smethod_7(ref byte* pByte_0)
		{
			<Module>.Class4.smethod_6(ref pByte_0);
			if (IntPtr.Size == 4 && *pByte_0 >= 72 && *pByte_0 <= 79)
			{
				pByte_0++;
			}
			else
			{
				if (*pByte_0 != 255 || *(pByte_0 + 1) < 200 || *(pByte_0 + 1) > 207)
				{
					return false;
				}
				pByte_0 += 2;
			}
			return true;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005CC8 File Offset: 0x00003EC8
		private unsafe static bool smethod_8(ref byte* pByte_0)
		{
			if (*pByte_0 == 116)
			{
				pByte_0 += 2;
				return true;
			}
			if (*pByte_0 == 15 && *(pByte_0 + 1) == 132)
			{
				pByte_0 += 6;
				return true;
			}
			return false;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005D20 File Offset: 0x00003F20
		[HandleProcessCorruptedStateExceptions, SecurityCritical]
		private unsafe bool method_4()
		{
			IntPtr intPtr = this.method_5();
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			byte* ptr = (byte*)((void*)intPtr);
			uint uint_;
			<Module>.Class4.VirtualProtect(new IntPtr((void*)ptr), 5, 64u, ref uint_);
			try
			{
				if (IntPtr.Size == 4)
				{
					*ptr = 51;
					ptr[1] = 192;
					ptr[2] = 194;
					ptr[3] = 4;
					ptr[4] = 0;
				}
				else
				{
					*ptr = 51;
					ptr[1] = 192;
					ptr[2] = 195;
				}
			}
			finally
			{
				<Module>.Class4.VirtualProtect(new IntPtr((void*)ptr), 5, uint_, ref uint_);
			}
			return true;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005DFC File Offset: 0x00003FFC
		[SecurityCritical, HandleProcessCorruptedStateExceptions]
		private unsafe IntPtr method_5()
		{
			try
			{
				<Module>.Class5 @class = <Module>.Class5.smethod_0();
				if (@class == null)
				{
					IntPtr result = IntPtr.Zero;
					return result;
				}
				IntPtr value;
				uint num;
				if (!@class.method_5(".text", ref value, ref num))
				{
					IntPtr result = IntPtr.Zero;
					return result;
				}
				byte* ptr = (byte*)((void*)value);
				byte* pByte_ = ptr;
				byte* ptr2 = (byte*)((void*)value) + num;
				if (IntPtr.Size == 4)
				{
					while (ptr < ptr2)
					{
						byte b = *ptr;
						if (b >= 80 && b <= 87 && ptr[1] == b && ptr[2] == b && ptr[8] == b && ptr[9] == b && ptr[3] == 104 && ptr[10] == 255 && ptr[11] == 21)
						{
							IntPtr intPtr = new IntPtr(*(uint*)(ptr + 4));
							if (<Module>.Class4.smethod_9(pByte_, ptr2, intPtr))
							{
								IntPtr result = intPtr;
								return result;
							}
						}
						ptr++;
					}
				}
				else
				{
					while (ptr < ptr2)
					{
						if ((*ptr == 69 || ptr[1] == 51 || ptr[2] == 201) && (ptr[3] == 76 || ptr[4] == 141 || ptr[5] == 5) && (ptr[10] == 51 || ptr[11] == 210) && (ptr[12] == 51 || ptr[13] == 201) && (ptr[14] == 255 || ptr[15] == 21))
						{
							IntPtr intPtr2 = new IntPtr((void*)(ptr + 10 + *(int*)(ptr + 6)));
							if (<Module>.Class4.smethod_9(pByte_, ptr2, intPtr2))
							{
								IntPtr result = intPtr2;
								return result;
							}
						}
						ptr++;
					}
				}
			}
			catch
			{
			}
			return IntPtr.Zero;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000602C File Offset: 0x0000422C
		[SecurityCritical, HandleProcessCorruptedStateExceptions]
		private unsafe static bool smethod_9(byte* pByte_0, byte* pByte_1, IntPtr intptr_1)
		{
			try
			{
				byte* ptr = (byte*)((void*)intptr_1);
				if (ptr < pByte_0 || ptr >= pByte_1)
				{
					bool result = false;
					return result;
				}
				for (int i = 0; i < 32; i++)
				{
					if (*(uint*)(ptr + i) == 16384u)
					{
						bool result = true;
						return result;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000609C File Offset: 0x0000429C
		[HandleProcessCorruptedStateExceptions, SecurityCritical]
		private unsafe bool method_6()
		{
			Dictionary<IntPtr, int> dictionary = new Dictionary<IntPtr, int>();
			try
			{
				<Module>.Class5 @class = <Module>.Class5.smethod_0();
				if (@class == null)
				{
					bool result = false;
					return result;
				}
				IntPtr value;
				uint num;
				if (!@class.method_5(".text", ref value, ref num))
				{
					bool result = false;
					return result;
				}
				byte* ptr = (byte*)((void*)value);
				byte* ptr2 = (byte*)((void*)value) + num;
				while (ptr < ptr2)
				{
					IntPtr intPtr;
					if (*ptr == 161 && ptr[5] == 131 && ptr[6] == 248 && ptr[7] == 4)
					{
						if (IntPtr.Size == 4)
						{
							intPtr = new IntPtr(*(uint*)(ptr + 1));
							goto IL_1C1;
						}
						intPtr = new IntPtr((void*)(ptr + 5 + *(int*)(ptr + 1)));
						goto IL_1C1;
					}
					else if (*ptr == 139 && ptr[1] == 5 && ptr[6] == 131 && ptr[7] == 248 && ptr[8] == 4)
					{
						if (IntPtr.Size == 4)
						{
							intPtr = new IntPtr(*(uint*)(ptr + 2));
							goto IL_1C1;
						}
						intPtr = new IntPtr((void*)(ptr + 6 + *(int*)(ptr + 2)));
						goto IL_1C1;
					}
					else if (*ptr == 131 && ptr[1] == 61 && ptr[6] == 4)
					{
						if (IntPtr.Size == 4)
						{
							intPtr = new IntPtr(*(uint*)(ptr + 2));
							goto IL_1C1;
						}
						intPtr = new IntPtr((void*)(ptr + 7 + *(int*)(ptr + 2)));
						goto IL_1C1;
					}
					IL_234:
					ptr++;
					continue;
					IL_1C1:
					if (!<Module>.Class5.smethod_4(intPtr, 4u) || !@class.method_2(intPtr, 4u))
					{
						goto IL_234;
					}
					try
					{
						if (*(uint*)((void*)intPtr) > 4u)
						{
							goto IL_234;
						}
						*(int*)((void*)intPtr) = (int)(*(uint*)((void*)intPtr));
					}
					catch
					{
						goto IL_234;
					}
					int num2 = 0;
					dictionary.TryGetValue(intPtr, out num2);
					num2++;
					dictionary[intPtr] = num2;
					if (num2 < 50)
					{
						goto IL_234;
					}
					break;
				}
			}
			catch
			{
			}
			IntPtr intPtr2 = <Module>.smethod_9(dictionary, 5);
			if (intPtr2 == IntPtr.Zero)
			{
				return false;
			}
			this.intptr_0 = new IntPtr((void*)((byte*)((void*)intPtr2) - (IntPtr.Size + 4)));
			return true;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002828 File Offset: 0x00000A28
		internal unsafe override void vmethod_3()
		{
			if (this.intptr_0 == IntPtr.Zero)
			{
				return;
			}
			*(int*)((byte*)((byte*)((void*)this.intptr_0) + IntPtr.Size) + 4) = 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002757 File Offset: 0x00000957
		internal Class4()
		{
		}

		// Token: 0x04000011 RID: 17
		private static readonly uint uint_0 = (uint)IntPtr.Size;

		// Token: 0x04000012 RID: 18
		private IntPtr intptr_0;

		// Token: 0x04000013 RID: 19
		private SafeFileHandle safeFileHandle_0;

		// Token: 0x04000014 RID: 20
		private bool bool_0;
	}

	// Token: 0x02000007 RID: 7
	private class Class5
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002866 File Offset: 0x00000A66
		internal Class5(IntPtr intptr_3)
		{
			this.intptr_0 = intptr_3;
			this.method_0();
		}

		// Token: 0x06000058 RID: 88
		[DllImport("kernel32", CharSet = CharSet.Auto)]
		private static extern IntPtr GetModuleHandle(string string_0);

		// Token: 0x06000059 RID: 89 RVA: 0x0000636C File Offset: 0x0000456C
		internal static <Module>.Class5 smethod_0()
		{
			IntPtr intPtr = <Module>.Class5.smethod_1();
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new <Module>.Class5(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000287B File Offset: 0x00000A7B
		private static IntPtr smethod_1()
		{
			if (Environment.Version.Major == 2)
			{
				return <Module>.Class5.GetModuleHandle("mscorwks");
			}
			return <Module>.Class5.GetModuleHandle("clr");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006394 File Offset: 0x00004594
		private unsafe void method_0()
		{
			byte* ptr = (byte*)((void*)this.intptr_0);
			ptr += *(uint*)(ptr + 60);
			ptr += 6;
			this.int_0 = (int)(*(ushort*)ptr);
			ptr += 18;
			bool flag = *(ushort*)ptr == 267;
			uint num = *(uint*)(ptr + 56);
			this.intptr_1 = new IntPtr((void*)((byte*)((void*)this.intptr_0) + num));
			ptr += (flag ? 96 : 112);
			ptr += 128;
			this.intptr_2 = new IntPtr((void*)ptr);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000028A3 File Offset: 0x00000AA3
		internal unsafe bool method_1(IntPtr intptr_3)
		{
			return this.method_4((void*)intptr_3, 0u);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000028B6 File Offset: 0x00000AB6
		internal unsafe bool method_2(IntPtr intptr_3, uint uint_0)
		{
			return this.method_4((void*)intptr_3, uint_0);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000028C5 File Offset: 0x00000AC5
		internal unsafe bool method_3(void* pVoid_0)
		{
			return this.method_4(pVoid_0, 0u);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006424 File Offset: 0x00004624
		internal unsafe bool method_4(void* pVoid_0, uint uint_0)
		{
			if (pVoid_0 < (void*)this.intptr_0)
			{
				return false;
			}
			if (pVoid_0 >= (void*)this.intptr_1)
			{
				return false;
			}
			if (uint_0 != 0u)
			{
				if ((byte*)pVoid_0 + uint_0 < (byte*)pVoid_0)
				{
					return false;
				}
				if ((byte*)pVoid_0 + uint_0 != (byte*)((void*)this.intptr_1))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006488 File Offset: 0x00004688
		internal unsafe bool method_5(string string_0, ref IntPtr intptr_3, ref uint uint_0)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_0 + "\0\0\0\0\0\0\0\0");
			for (int i = 0; i < this.int_0; i++)
			{
				byte* ptr = (byte*)((void*)this.intptr_2) + i * 40;
				if (<Module>.Class5.smethod_2(ptr, bytes))
				{
					intptr_3 = new IntPtr((void*)((byte*)((void*)this.intptr_0) + *(uint*)(ptr + 12)));
					uint_0 = Math.Max(*(uint*)(ptr + 8), *(uint*)(ptr + 16));
					return true;
				}
			}
			intptr_3 = IntPtr.Zero;
			uint_0 = 0u;
			return false;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006530 File Offset: 0x00004730
		private unsafe static bool smethod_2(byte* pByte_0, byte[] byte_0)
		{
			for (int i = 0; i < 8; i++)
			{
				if (*pByte_0 != byte_0[i])
				{
					return false;
				}
				pByte_0++;
			}
			return true;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000028D3 File Offset: 0x00000AD3
		internal static bool smethod_3(IntPtr intptr_3)
		{
			return ((int)intptr_3.ToInt64() & IntPtr.Size - 1) == 0;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000028F0 File Offset: 0x00000AF0
		internal static bool smethod_4(IntPtr intptr_3, uint uint_0)
		{
			return ((uint)intptr_3.ToInt64() & uint_0 - 1u) == 0u;
		}

		// Token: 0x04000015 RID: 21
		private readonly IntPtr intptr_0;

		// Token: 0x04000016 RID: 22
		private IntPtr intptr_1;

		// Token: 0x04000017 RID: 23
		private int int_0;

		// Token: 0x04000018 RID: 24
		private IntPtr intptr_2;
	}

	// Token: 0x02000008 RID: 8
	internal struct Struct0
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00006574 File Offset: 0x00004774
		internal uint method_0(<Module>.Class6 class6_0)
		{
			uint num = (class6_0.uint_1 >> 11) * this.uint_0;
			if (class6_0.uint_0 < num)
			{
				class6_0.uint_1 = num;
				this.uint_0 += 2048u - this.uint_0 >> 5;
				if (class6_0.uint_1 < 16777216u)
				{
					class6_0.uint_0 = (class6_0.uint_0 << 8 | (uint)((byte)class6_0.stream_0.ReadByte()));
					class6_0.uint_1 <<= 8;
				}
				return 0u;
			}
			class6_0.uint_1 -= num;
			class6_0.uint_0 -= num;
			this.uint_0 -= this.uint_0 >> 5;
			if (class6_0.uint_1 < 16777216u)
			{
				class6_0.uint_0 = (class6_0.uint_0 << 8 | (uint)((byte)class6_0.stream_0.ReadByte()));
				class6_0.uint_1 <<= 8;
			}
			return 1u;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002909 File Offset: 0x00000B09
		internal void method_1()
		{
			this.uint_0 = 1024u;
		}

		// Token: 0x04000019 RID: 25
		internal uint uint_0;
	}

	// Token: 0x02000009 RID: 9
	internal struct Struct1
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002916 File Offset: 0x00000B16
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006660 File Offset: 0x00004860
		internal uint method_0(<Module>.Class6 class6_0)
		{
			uint num = 1u;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((uint)((UIntPtr)num))].method_0(class6_0);
			}
			return num - (1u << this.int_0);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000066B0 File Offset: 0x000048B0
		internal void method_1()
		{
			uint num = 1u;
			while ((ulong)num < 1uL << (this.int_0 & 31))
			{
				this.struct0_0[(int)((uint)((UIntPtr)num))].method_1();
				num += 1u;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000066FC File Offset: 0x000048FC
		internal uint method_2(<Module>.Class6 class6_0)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)((uint)((UIntPtr)num))].method_0(class6_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006750 File Offset: 0x00004950
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class6 class6_0, int int_1)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)((uint)((UIntPtr)(uint_0 + num)))].method_0(class6_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x0400001A RID: 26
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x0400001B RID: 27
		internal readonly int int_0;
	}

	// Token: 0x0200000A RID: 10
	internal class Class6
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000679C File Offset: 0x0000499C
		internal uint method_0(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0u;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1u);
				num3 = (num3 << 1 | 1u - num4);
				if (num < 16777216u)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006810 File Offset: 0x00004A10
		internal void method_1(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0u;
			this.uint_1 = 4294967295u;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002930 File Offset: 0x00000B30
		internal void method_2()
		{
			while (this.uint_1 < 16777216u)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000296B File Offset: 0x00000B6B
		internal void method_3()
		{
			this.stream_0 = null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000026D7 File Offset: 0x000008D7
		internal Class6()
		{
		}

		// Token: 0x0400001C RID: 28
		internal uint uint_0;

		// Token: 0x0400001D RID: 29
		internal uint uint_1;

		// Token: 0x0400001E RID: 30
		internal Stream stream_0;
	}

	// Token: 0x0200000B RID: 11
	internal class Class7
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000685C File Offset: 0x00004A5C
		internal Class7()
		{
			this.uint_0 = 4294967295u;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_1[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006950 File Offset: 0x00004B50
		internal void method_0(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_1(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			ulong num5 = 0uL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((uint)((UIntPtr)(@struct.uint_0 << 4)))].method_0(this.class6_0);
				@struct.method_2();
				byte byte_ = this.class9_0.method_1(this.class6_0, 0u, 0);
				this.class10_0.method_5(byte_);
				num5 += 1uL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((uint)((UIntPtr)((@struct.uint_0 << 4) + num6)))].method_0(this.class6_0) == 0u)
				{
					byte byte_2 = this.class10_0.method_3(0u);
					byte byte_3;
					if (!@struct.method_1())
					{
						byte_3 = this.class9_0.method_2(this.class6_0, (uint)num5, byte_2, this.class10_0.method_3(num));
					}
					else
					{
						byte_3 = this.class9_0.method_1(this.class6_0, (uint)num5, byte_2);
					}
					this.class10_0.method_5(byte_3);
					@struct.method_2();
					num5 += 1uL;
				}
				else
				{
					uint num8;
					if (this.struct0_2[(int)((uint)((UIntPtr)@struct.uint_0))].method_0(this.class6_0) == 1u)
					{
						if (this.struct0_3[(int)((uint)((UIntPtr)@struct.uint_0))].method_0(this.class6_0) == 0u)
						{
							if (this.struct0_1[(int)((uint)((UIntPtr)((@struct.uint_0 << 4) + num6)))].method_0(this.class6_0) == 0u)
							{
								@struct.method_5();
								this.class10_0.method_5(this.class10_0.method_3(num));
								num5 += 1uL;
								continue;
							}
						}
						else
						{
							uint num7;
							if (this.struct0_4[(int)((uint)((UIntPtr)@struct.uint_0))].method_0(this.class6_0) == 0u)
							{
								num7 = num2;
							}
							else
							{
								if (this.struct0_5[(int)((uint)((UIntPtr)@struct.uint_0))].method_0(this.class6_0) == 0u)
								{
									num7 = num3;
								}
								else
								{
									num7 = num4;
									num4 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						num8 = this.class8_1.method_1(this.class6_0, num6) + 2u;
						@struct.method_4();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2u + this.class8_0.method_1(this.class6_0, num6);
						@struct.method_3();
						uint num9 = this.struct1_1[(int)((uint)((UIntPtr)<Module>.Class7.smethod_0(num8)))].method_0(this.class6_0);
						if (num9 >= 4u)
						{
							int num10 = (int)((num9 >> 1) - 1u);
							num = (2u | (num9 & 1u)) << num10;
							if (num9 < 14u)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num9 - 1u, this.class6_0, num10);
							}
							else
							{
								num += this.class6_0.method_0(num10 - 4) << 4;
								num += this.struct1_0.method_2(this.class6_0);
							}
						}
						else
						{
							num = num9;
						}
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295u)
					{
						break;
					}
					this.class10_0.method_0(num, num8);
					num5 += (ulong)num8;
				}
			}
			this.class10_0.method_2();
			this.class10_0.method_6();
			this.class6_0.method_3();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002974 File Offset: 0x00000B74
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2u;
			if (uint_3 < 4u)
			{
				return uint_3;
			}
			return 3u;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006D00 File Offset: 0x00004F00
		internal void method_1(Stream stream_0, Stream stream_1)
		{
			this.class6_0.method_1(stream_0);
			this.class10_0.method_4(stream_1, this.bool_0);
			for (uint num = 0u; num < 12u; num += 1u)
			{
				for (uint num2 = 0u; num2 <= this.uint_2; num2 += 1u)
				{
					uint value = (num << 4) + num2;
					this.struct0_0[(int)((uint)((UIntPtr)value))].method_1();
					this.struct0_1[(int)((uint)((UIntPtr)value))].method_1();
				}
				this.struct0_2[(int)((uint)((UIntPtr)num))].method_1();
				this.struct0_3[(int)((uint)((UIntPtr)num))].method_1();
				this.struct0_4[(int)((uint)((UIntPtr)num))].method_1();
				this.struct0_5[(int)((uint)((UIntPtr)num))].method_1();
			}
			this.class9_0.method_4();
			for (uint num3 = 0u; num3 < 4u; num3 += 1u)
			{
				this.struct1_1[(int)((uint)((UIntPtr)num3))].method_1();
			}
			for (uint num4 = 0u; num4 < 114u; num4 += 1u)
			{
				this.struct0_6[(int)((uint)((UIntPtr)num4))].method_1();
			}
			this.class8_0.method_2();
			this.class8_1.method_2();
			this.struct1_0.method_1();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006E78 File Offset: 0x00005078
		internal void method_2(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			byte expr_0D = byte_0[0] / 9;
			int int_2 = (int)(expr_0D % 5);
			int int_3 = (int)(expr_0D / 5);
			uint num = 0u;
			for (int i = 0; i < 4; i++)
			{
				num += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_3(num);
			this.method_4(int_2, int_);
			this.method_5(int_3);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00006ED4 File Offset: 0x000050D4
		internal void method_3(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1u);
				uint uint_4 = Math.Max(this.uint_1, 4096u);
				this.class10_0.method_1(uint_4);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002982 File Offset: 0x00000B82
		internal void method_4(int int_0, int int_1)
		{
			this.class9_0.method_0(int_0, int_1);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006F20 File Offset: 0x00005120
		internal void method_5(int int_0)
		{
			uint num = 1u << int_0;
			this.class8_0.method_0(num);
			this.class8_1.method_0(num);
			this.uint_2 = num - 1u;
		}

		// Token: 0x0400001F RID: 31
		internal uint uint_0;

		// Token: 0x04000020 RID: 32
		internal uint uint_1;

		// Token: 0x04000021 RID: 33
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x04000022 RID: 34
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x04000023 RID: 35
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x04000024 RID: 36
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x04000025 RID: 37
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x04000026 RID: 38
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x04000027 RID: 39
		internal readonly <Module>.Class7.Class8 class8_0 = new <Module>.Class7.Class8();

		// Token: 0x04000028 RID: 40
		internal readonly <Module>.Class7.Class9 class9_0 = new <Module>.Class7.Class9();

		// Token: 0x04000029 RID: 41
		internal readonly <Module>.Class10 class10_0 = new <Module>.Class10();

		// Token: 0x0400002A RID: 42
		internal <Module>.Struct1 struct1_0 = new <Module>.Struct1(4);

		// Token: 0x0400002B RID: 43
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x0400002C RID: 44
		internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[4];

		// Token: 0x0400002D RID: 45
		internal uint uint_2;

		// Token: 0x0400002E RID: 46
		internal readonly <Module>.Class6 class6_0 = new <Module>.Class6();

		// Token: 0x0400002F RID: 47
		internal readonly <Module>.Class7.Class8 class8_1 = new <Module>.Class7.Class8();

		// Token: 0x04000030 RID: 48
		internal bool bool_0;

		// Token: 0x0200000C RID: 12
		internal class Class8
		{
			// Token: 0x06000078 RID: 120 RVA: 0x00006F58 File Offset: 0x00005158
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1u)
				{
					this.struct1_1[(int)((uint)((UIntPtr)num))] = new <Module>.Struct1(3);
					this.struct1_2[(int)((uint)((UIntPtr)num))] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00006FB8 File Offset: 0x000051B8
			internal uint method_1(<Module>.Class6 class6_0, uint uint_1)
			{
				if (this.struct0_0.method_0(class6_0) == 0u)
				{
					return this.struct1_1[(int)((uint)((UIntPtr)uint_1))].method_0(class6_0);
				}
				uint num = 8u;
				if (this.struct0_1.method_0(class6_0) == 0u)
				{
					num += this.struct1_2[(int)((uint)((UIntPtr)uint_1))].method_0(class6_0);
				}
				else
				{
					num += 8u;
					num += this.struct1_0.method_0(class6_0);
				}
				return num;
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00007038 File Offset: 0x00005238
			internal void method_2()
			{
				this.struct0_0.method_1();
				for (uint num = 0u; num < this.uint_0; num += 1u)
				{
					this.struct1_1[(int)((uint)((UIntPtr)num))].method_1();
					this.struct1_2[(int)((uint)((UIntPtr)num))].method_1();
				}
				this.struct0_1.method_1();
				this.struct1_0.method_1();
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00002991 File Offset: 0x00000B91
			internal Class8()
			{
			}

			// Token: 0x04000031 RID: 49
			internal <Module>.Struct0 struct0_0;

			// Token: 0x04000032 RID: 50
			internal <Module>.Struct0 struct0_1;

			// Token: 0x04000033 RID: 51
			internal <Module>.Struct1 struct1_0 = new <Module>.Struct1(8);

			// Token: 0x04000034 RID: 52
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x04000035 RID: 53
			internal readonly <Module>.Struct1[] struct1_2 = new <Module>.Struct1[16];

			// Token: 0x04000036 RID: 54
			internal uint uint_0;
		}

		// Token: 0x0200000D RID: 13
		internal class Class9
		{
			// Token: 0x0600007C RID: 124 RVA: 0x000070B0 File Offset: 0x000052B0
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null && this.int_1 == int_3 && this.int_0 == int_2)
				{
					return;
				}
				this.int_0 = int_2;
				this.uint_0 = (1u << int_2) - 1u;
				this.int_1 = int_3;
				uint num = 1u << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class7.Class9.Struct2[num];
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)((uint)((UIntPtr)num2))].method_0();
				}
			}

			// Token: 0x0600007D RID: 125 RVA: 0x000029BF File Offset: 0x00000BBF
			internal byte method_1(<Module>.Class6 class6_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((uint)((UIntPtr)this.method_3(uint_1, byte_0)))].method_1(class6_0);
			}

			// Token: 0x0600007E RID: 126 RVA: 0x000029E4 File Offset: 0x00000BE4
			internal byte method_2(<Module>.Class6 class6_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((uint)((UIntPtr)this.method_3(uint_1, byte_0)))].method_2(class6_0, byte_1);
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00002A0B File Offset: 0x00000C0B
			internal uint method_3(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000080 RID: 128 RVA: 0x0000713C File Offset: 0x0000533C
			internal void method_4()
			{
				uint num = 1u << this.int_1 + this.int_0;
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)((uint)((UIntPtr)num2))].method_3();
				}
			}

			// Token: 0x06000081 RID: 129 RVA: 0x000026D7 File Offset: 0x000008D7
			internal Class9()
			{
			}

			// Token: 0x04000037 RID: 55
			internal <Module>.Class7.Class9.Struct2[] struct2_0;

			// Token: 0x04000038 RID: 56
			internal int int_0;

			// Token: 0x04000039 RID: 57
			internal int int_1;

			// Token: 0x0400003A RID: 58
			internal uint uint_0;

			// Token: 0x0200000E RID: 14
			internal struct Struct2
			{
				// Token: 0x06000082 RID: 130 RVA: 0x00002A2D File Offset: 0x00000C2D
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x06000083 RID: 131 RVA: 0x00007184 File Offset: 0x00005384
				internal byte method_1(<Module>.Class6 class6_0)
				{
					uint num = 1u;
					do
					{
						num = (num << 1 | this.struct0_0[(int)((uint)((UIntPtr)num))].method_0(class6_0));
					}
					while (num < 256u);
					return (byte)num;
				}

				// Token: 0x06000084 RID: 132 RVA: 0x000071C0 File Offset: 0x000053C0
				internal byte method_2(<Module>.Class6 class6_0, byte byte_0)
				{
					uint num = 1u;
					while (true)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((uint)((UIntPtr)((1u + num2 << 8) + num)))].method_0(class6_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256u)
						{
							goto IL_70;
						}
					}
					while (num < 256u)
					{
						num = (num << 1 | this.struct0_0[(int)((uint)((UIntPtr)num))].method_0(class6_0));
					}
					IL_70:
					return (byte)num;
				}

				// Token: 0x06000085 RID: 133 RVA: 0x00007240 File Offset: 0x00005440
				internal void method_3()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_1();
					}
				}

				// Token: 0x0400003B RID: 59
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x0200000F RID: 15
	internal class Class10
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00007270 File Offset: 0x00005470
		internal void method_0(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0u)
			{
				if (num >= this.uint_2)
				{
					num = 0u;
				}
				byte[] arg_61_0 = this.byte_0;
				uint num2 = this.uint_0;
				this.uint_0 = num2 + 1u;
				arg_61_0[(int)((uint)((UIntPtr)num2))] = this.byte_0[(int)((uint)((UIntPtr)(num++)))];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_2();
				}
				uint_4 -= 1u;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002A3F File Offset: 0x00000C3F
		internal void method_1(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0u;
			this.uint_1 = 0u;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000072FC File Offset: 0x000054FC
		internal void method_2()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num == 0u)
			{
				return;
			}
			this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
			if (this.uint_0 >= this.uint_2)
			{
				this.uint_0 = 0u;
			}
			this.uint_1 = this.uint_0;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007354 File Offset: 0x00005554
		internal byte method_3(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((uint)((UIntPtr)num))];
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002A6B File Offset: 0x00000C6B
		internal void method_4(Stream stream_1, bool bool_0)
		{
			this.method_6();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0u;
				this.uint_0 = 0u;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007390 File Offset: 0x00005590
		internal void method_5(byte byte_1)
		{
			byte[] arg_22_0 = this.byte_0;
			uint num = this.uint_0;
			this.uint_0 = num + 1u;
			arg_22_0[(int)((uint)((UIntPtr)num))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_2();
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002A8B File Offset: 0x00000C8B
		internal void method_6()
		{
			this.method_2();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000026D7 File Offset: 0x000008D7
		internal Class10()
		{
		}

		// Token: 0x0400003C RID: 60
		internal byte[] byte_0;

		// Token: 0x0400003D RID: 61
		internal uint uint_0;

		// Token: 0x0400003E RID: 62
		internal Stream stream_0;

		// Token: 0x0400003F RID: 63
		internal uint uint_1;

		// Token: 0x04000040 RID: 64
		internal uint uint_2;
	}

	// Token: 0x02000010 RID: 16
	internal struct Struct3
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00002ABC File Offset: 0x00000CBC
		internal void method_0()
		{
			this.uint_0 = 0u;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002AC5 File Offset: 0x00000CC5
		internal bool method_1()
		{
			return this.uint_0 < 7u;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002AD0 File Offset: 0x00000CD0
		internal void method_2()
		{
			if (this.uint_0 < 4u)
			{
				this.uint_0 = 0u;
				return;
			}
			if (this.uint_0 < 10u)
			{
				this.uint_0 -= 3u;
				return;
			}
			this.uint_0 -= 6u;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002B0A File Offset: 0x00000D0A
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002B20 File Offset: 0x00000D20
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002B36 File Offset: 0x00000D36
		internal void method_5()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
		}

		// Token: 0x04000041 RID: 65
		internal uint uint_0;
	}

	// Token: 0x02000011 RID: 17
	[StructLayout(LayoutKind.Explicit, Size = 1536)]
	internal struct Struct4
	{
	}
}
