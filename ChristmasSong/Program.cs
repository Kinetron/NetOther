namespace ChristmasSong
{
	internal class Program
	{
		private const int NoteDuration = 300;

		//"A Christmas tree was born in the forest". 2012 a micro controller project for Atmega8
		static PianoEnum[] melodia = new[]
			{
			   PianoEnum.Do1Okt, PianoEnum.Lya1Okt, PianoEnum.Lya1Okt, PianoEnum.Sol1Okt,
			   PianoEnum.Lya1Okt, PianoEnum.Fa1Okt, PianoEnum.Do1Okt, PianoEnum.Do1Okt,
			   PianoEnum.Do1Okt,  PianoEnum.Lya1Okt,  PianoEnum.Lya1Okt, PianoEnum.SiBemol1Okt,
			   PianoEnum.Sol1Okt, PianoEnum.Do2Okt, PianoEnum.Do2Okt, PianoEnum.Do2Okt,
			   PianoEnum.Do2Okt, PianoEnum.Re1Okt, PianoEnum.Re1Okt, PianoEnum.SiBemol1Okt,
			   PianoEnum.SiBemol1Okt, PianoEnum.Lya1Okt, PianoEnum.Sol1Okt, PianoEnum.Fa1Okt,
			   PianoEnum.Fa1Okt, PianoEnum.Lya1Okt, PianoEnum.Lya1Okt, PianoEnum.Sol1Okt,
			   PianoEnum.Lya1Okt, PianoEnum.Fa1Okt
			};

		static void Main(string[] args)
		{
			Console.WriteLine("Merry Christmas");

			//All notes have the same duration.
			for (int i = 0; i < melodia.Length; i++)
			{
				BeepNota((int)melodia[i], NoteDuration);
				Console.Write('.');
			}
		}

		/// <summary>
		/// 12-note piano
		/// </summary>
		/// <param name="nota"></param>
		/// <param name="duration"></param>
		private static void BeepNota(int nota, int duration)
		{
			int frequency = 0;

			switch ((PianoEnum)nota)
			{
				case PianoEnum.Do: frequency = 130; break; // 130.82 hz   "do" small okt
				case PianoEnum.DoDiez: frequency = 138; break; // 138.59 hz   "do diez" small okt
				case PianoEnum.Re: frequency = 147; break; // 147.83 hz   "re" small okt
				case PianoEnum.ReDiez: frequency = 155; break; // 155.56 hz   "re dies" small okt
				case PianoEnum.Mi: frequency = 164; break; // 164.81 hz   "mi" small okt
				case PianoEnum.Fa: frequency = 174; break; // 174.62 hz   "fa" small okt
				case PianoEnum.FaDiez: frequency = 185; break; // 185.00 hz   "fa diez" small okt
				case PianoEnum.Sol: frequency = 196; break; // 196.00 hz   "sol" small okt
				case PianoEnum.SolDiez: frequency = 207; break; // 207.00 hz   "sol diez" small okt
				case PianoEnum.Lya: frequency = 220; break; // 220.00 hz   "lya" small okt
				case PianoEnum.SiBemol: frequency = 233; break; // 233.08 hz   "si bemol" small okt
				case PianoEnum.Si: frequency = 247; break; // 246,96 hz   "si" small okt
				case PianoEnum.Do1Okt: frequency = 261; break; // 261,63 hz   "do" 1 okt
				case PianoEnum.DoDies1Okt: frequency = 277; break; // 277,18 hz   "do diez" 1 okt
				case PianoEnum.Re1Okt: frequency = 294; break; // 293,66 hz   "re" 1 okt
				case PianoEnum.ReDies1Okt: frequency = 311; break;  // 311,13 hz   "re diez" 1 okt
				case PianoEnum.Mi1Okt: frequency = 330; break;  // 329,63 hz   "mi" 1 okt
				case PianoEnum.Fa1Okt: frequency = 349; break;  // 349,23 hz   "fa" 1 okt
				case PianoEnum.FaDies1Okt: frequency = 370; break;  // 369,99 hz   "fa diez" 1 okt
				case PianoEnum.Sol1Okt: frequency = 392; break;  // 392,00 hz   "sol" 1 okt
				case PianoEnum.SoiDiez1Okt: frequency = 415; break;   // 415,30 hz   "soi-diez" 1 okt
				case PianoEnum.Lya1Okt: frequency = 440; break;  // 440,00 hz   "lya" 1 okt
				case PianoEnum.SiBemol1Okt: frequency = 466; break;  // 466,16 hz   "si-bemol" 1 okt
				case PianoEnum.Si1Okt: frequency = 494; break;  // 493,88 hz   "si" 1 okt
				case PianoEnum.Do2Okt: frequency = 523; break; // 523.25 hz   "do" 2 okt
				case PianoEnum.Dodiez2Okt: frequency = 554; break; // 554.36 hz   "do-diez" 2 okt
				case PianoEnum.Re2Okt: frequency = 587; break; // 587.32 hz   "re" 2 okt
				case PianoEnum.Rediez2Okt: frequency = 622; break; // 622.26 hz   "re-diez" 2 okt
				case PianoEnum.Mi2Okt: frequency = 660; break; // 659.26 hz   "mi" 2 okt
				case PianoEnum.Fa2Okt: frequency = 698; break; // 698.46 hz   "fa" 2 okt
				case PianoEnum.Fadiez2Okt: frequency = 740; break; // 739.98 hz   "fa-diez" 2 okt
				case PianoEnum.Sol2Okt: frequency = 784; break; // 784.00 hz   "sol" 2 okt
				case PianoEnum.Soldiez2Okt: frequency = 831; break; // 830.60 hz   "sol-diez" 2 okt
				case PianoEnum.Lya2Okt: frequency = 880; break; // 880.00 hz   "lya" 2 okt
				case PianoEnum.Sibemol2Okt: frequency = 932; break; // 932.32 hz   "si-bemol" 2 okt
				case PianoEnum.Si2Okt: frequency = 987; break; // 987.75 hz   "si" 2 okt
				case PianoEnum.Do3Okt: frequency = 1046; break; // 1046.50 hz   "do" 3 okt
			}

			Console.Beep(frequency, duration);
		}
	}
}