var arrows = new Dictionary<char, (int i, int j)> {
    { '⇐',(0,-1) }, { '⇑', (-1, 0)}, { '⇒', (0, 1)}, { '⇓', (1, 0) },
    { '⇖',(-1, -1) }, { '⇗', (-1, 1) }, { '⇘', (1, 1) }, { '⇙', (1, -1) }   };
var maze = new[,]
{
    {'⇓','W','H','e','⇓','M','⇓'},
    {'H','!','e','l','l','o','W'},
    {'e','W','⇗','o','o','⯃','⇐'},
    {'l','⇓',' ',',','⇐','!','e'},
    {'l','W','⇗','o',',','d','e'},
    {' ','⇒','o','r','l','⇑','⇓'},
    {'⇒','h','e','r','e','e','⇓'},
};
void TraverseIt((int i, int j) p, (int i, int j) d)
{
    var stop = '⯃';
    var c = maze[p.i, p.j];
    while (c != stop)
    {
        if (arrows.TryGetValue(c, out var nd))
            d = nd;
        else 
            Console.Write(c);
        p = (p.i + d.i, p.j + d.j);
        c = maze[p.i, p.j];
    }
}
TraverseIt((i: 0, j: 2), (1, 0));