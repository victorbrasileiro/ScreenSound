Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Joao");
ep1.AdicionarConvidados("Jorge");
Console.WriteLine(ep1.Resumo);


Episodio ep2 = new(2, "Ferramentas", 20);
ep2.AdicionarConvidados("Suarez");
ep2.AdicionarConvidados("Luiza");
Console.WriteLine(ep2.Resumo);


Episodio ep3 = new(3, "Técnicas de Mecanica", 40);
ep3.AdicionarConvidados("Zacarias");
ep3.AdicionarConvidados("Eliveltom");
Console.WriteLine(ep3.Resumo);

Podcast podcast = new("PodPah", "Igão e Mítico");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);