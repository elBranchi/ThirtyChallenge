var letterPak = new Dictionary<char, (int w, long bm)> { { '!', (1, 0x3d) }, { ',', (2, 0x6) }, { 'l', (3, 0x32498 /*0x6498*/) }, { ' ', (4, 0x0) }, { 'e', (5, 0xe8d1c0) }, { 'o', (5, 0xe8c5c0) }, { 'r', (5, 0x16cc200) }, { 'd', (5, 0x62749c0) }, { 'H', (6, 0x861fe1840) }, { 'W', (6, 0x861b6d480) }, };
var msg = "Hello, World!";
void WriteItWPack(string msg, Dictionary<char, (int w, long bm)> letterPak)
{
    var c = Console.WindowLeft;
    var r = Console.WindowTop;
    var bits = msg.Select(c => letterPak[c]);
    foreach(var cm in bits)
    {
        if(c +cm.w > Console.WindowWidth)
        {
            c = Console.WindowLeft;
            r += 6;
        }
        foreach(var b in Enumerable.Range(0, cm.w * 6))
        {
            var m = (1L << (cm.w * 6) - 1) >> b;
            Console.SetCursorPosition(c + b % cm.w, r + b / cm.w);
            Console.Write((cm.bm & m) != 0 ? '#': ' ');
        }
        c += cm.w + 1;
    }
}
Console.Clear();
WriteItWPack(msg, letterPak);