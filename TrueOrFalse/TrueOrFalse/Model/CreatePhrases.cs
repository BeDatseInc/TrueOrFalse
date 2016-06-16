using System.Collections.Generic;

namespace TrueOrFalse
{
    class CreatePhrases
    {
        public static void CreateOriginalPhrases()
        {
            using (DataAccess data = new DataAccess())
            {

                if (data.GetListPhrases().Count == 0)
                {
                    foreach (Phrases phrase in OriginalPhrases)
                    {
                        data.Insert(phrase);
                    }
                }
            }
        }

        static readonly List<Phrases> OriginalPhrases = new List<Phrases>
        {
            new Phrases
            {
                Phrase = "Risotto is a common Italian rice dish.",
                PhrasePtBr = "Risotto é um prato de arroz italiano",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The Godfather: Part II (1974) was the only film sequel to win an Academy Award for best picture.",
                PhrasePtBr = "O Poderoso Chefão: Parde II (1974) foi a única continuação do filme a ganhar o Oscar de melhor filme.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The thigh bone (femur) is the largest bone in the human body.",
                PhrasePtBr = "O osso da coxa (fêmur) é o maior osso do corpo humano.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The prefix \"mega-\" represents one million.",
                PhrasePtBr = "O prefixo \"mega \" representa um milhão.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "\"Cost\" is one of the \"4 C's\" of diamond grading.",
                PhrasePtBr = "\"Custo\" é um dos \"4 C's\" da classificação de diamantes.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In Shakespeare's play, Hamlet commits suicide.",
                PhrasePtBr = "Na peça de Shakespeare, Hamlet comete suicídio.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The mint julep is the signature drink of the Kentucky Derby of horseracing.",
                PhrasePtBr = "A mint julep é uma bebida alcoólica mista ou coquetel, associado com a culinária do Sul dos Estados Unidos.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Hurricanes and typhoons are the same thing.",
                PhrasePtBr = "Furacões e tufões são a mesma coisa.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "An American was the first man in space.",
                PhrasePtBr = "Um americano foi o primeiro homem no espaço.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The \"Forbidden City\" is in Beijing.",
                PhrasePtBr = "A \"Cidade Proibida\" se encontra em Pequim.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "As far as has ever been reported, no-one has ever seen an ostrich bury its head in the sand.",
                PhrasePtBr = "Tanto quanto já foi relatado, ninguém jamais viu um avestruz enterrar a cabeça na areia.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Approximately one quarter of human bones are in the feet.",
                PhrasePtBr = "Cerca de um quarto dos ossos humanos estão nos pés.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Popeye’s nephews were called Peepeye, Poopeye, Pipeye and Pupeye.",
                PhrasePtBr = "Os sobrinhos de Popeye eram chamados Peepeye, Poopeye, Pipeye e Pupeye.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase ="In ancient Rome, a special room called a vomitorium was available for dinners to purge food in during meals.",
                PhrasePtBr = "Na Roma antiga, uma sala especial chamada vomitorium estava disponível durante os jantares para limpar alimentos durante as refeições.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The average person will shed 10 pounds of skin during their lifetime.",
                PhrasePtBr = "A pessoa comum terá perdido 6 kilos de pele durante sua vida.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Sneezes regularly exceed 100 m.p.h.",
                PhrasePtBr = "Espirros normalmente excedem 160 km/h",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "A slug’s blood is green.",
                PhrasePtBr = "O sangue da lesma é verde.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The Great Wall Of China is visible from the moon.",
                PhrasePtBr = "A Grande Muralha da China é visível da lua.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Virtually all Las Vegas gambling casinos ensure that they have no clocks.",
                PhrasePtBr = "Praticamente todos os cassinos de Las Vegas não têm relógios.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The total surface area of two human lungs vary from 50 to 75 square metres(540 to 810 sq ft).",
                PhrasePtBr = "A área de superfície total de dois pulmões humanos pode variar de 50 a 75 metros quadrados",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "A man from the USA consumed his 26,000th Big Mac on 11th October 2012, after eating at least one a day for forty years.",
                PhrasePtBr = "Um homem nos Estados Unidos consumiu 26 mil Big Mac em 11 de outubro de 2012, depois de comer, pelo menos uma por dia durante quarenta anos.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The longest distance swam underwater in one breath is 200metres.",
                PhrasePtBr = "A maior distância nadada debaixo d'água com uma respiração foi 200 metros.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The record for most needles inserted into the head is 15,000.",
                PhrasePtBr = "O recorde para a maior quantidade de agulhas inseridas na cabeça é 15 mil.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The fastest time to eat 15 Ferrero Rocher is 1 minute 10 seconds.",
                PhrasePtBr = "O tempo mais rápido para se comer 15 Ferrero Rocher é de 1 minuto 10 segundos.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The world’s longest legs belong to a Russian lady and measure 132cm(51.9 inches).",
                PhrasePtBr = "As pernas mais longas do mundo pertencem a uma mulher russa e medem 132 centímetros.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The heaviest aircraft pulled by a single man weighed 188.83 tonnes and was pulled 8.8 metres.",
                PhrasePtBr = "O avião mais pesado puxado por um único homem pesava 188,83 toneladas e foi puxado por 8,8 metros.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The record for the fastest time to solve a Rubik’s Cube one-handed is 37 seconds.",
                PhrasePtBr = "O recorde de tempo mais rápido para resolver um cubo mágico com uma mão é de 37 segundos.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The world’s tallest living man is 251cm / 8 ft 3 in.",
                PhrasePtBr = "O homem vivo mais alto do mundo tem 251 centímetros",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "The most expensive car number plate, showing only the number ‘1’, was bought in the United Arab Emirates for 52.2 million dirham, the approximate equivalent of £7.2 million.",
                PhrasePtBr =
                    "A placa do carro mais cara, mostrando apenas o número \"1\", foi comprada nos Emirados Árabes Unidos por 52,2 milhões de dirhans, o equivalente aproximado de 7,2 milhões de euros.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "The record for the longest rail tunnel is held by the Channel Tunnel between Britain and France.",
                PhrasePtBr = "O recorde para o mais longo túnel ferroviário é mantido pelo Eurotúnel entre Grã-Bretanha e França.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Sir Paul McCartney’s middle name is James.",
                PhrasePtBr = "O nome do meio de Paul McCartney é James.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Jupiter is the fifth planet from the sun.",
                PhrasePtBr = "Júpiter é o quinto planeta do sol.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Gillian Anderson was born in Chicago, Illinois.",
                PhrasePtBr = "Gillian Anderson(Dana Scully - Arquivo X) nasceu em Chicago, Illinois.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Lithium has the atomic number 17.",
                PhrasePtBr = "Lítio tem o número atômico 17.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "The Guinness World Record for most fingers and toes at birth is held by an " +
                    "Indian man born with 14 fingers and 20 toes in total.",
                PhrasePtBr = "O Recorde mundial do Guinnes para a pessoa com mais dedos nas mãos e " +
                             "pés no nascimento é mantido por um homem indiano que nasceu com 14 dedos " +
                             "nas mãos e 20 dedos nos pés no total.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The oldest building in the world is the Pyramid of Djoser in Egypt.",
                PhrasePtBr = "O edifício mais antigo do mundo é a pirâmide de Djoser no Egito.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Engelbert Humperdinck(Singer) was born in 1928.",
                PhrasePtBr = "Engelbert Humperdinck(Cantor) nasceu em 1928.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "Sir Steve Redgrave is the only rower to have received the award of BBC Sports Personality of the Year.",
                PhrasePtBr = "",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Hotmail was launched in 1996.",
                PhrasePtBr = "Hotmail foi lançado em 1996.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "From the ground to the torch, the Statue of Liberty is 93 metres high.",
                PhrasePtBr = "A partir do solo até a tocha, a Estátua da Liberdade tem 93 metros de altura.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "There are some wasps that make honey.",
                PhrasePtBr = "Existem algumas vespas que fazem mel.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Marie Curie’s husband was called Pierre.",
                PhrasePtBr = "O marido de Marie Curie(Física) se chamava Pierre.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The Lutine Bell can be found in Lloyds of London.",
                PhrasePtBr = "",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Seoul is the capital of North Korea.",
                PhrasePtBr = "Seul é a capital da Coreia do Norte.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "According to Scottish law, it is illegal to be drunk in charge of a cow.",
                PhrasePtBr = "Segundo a lei escocesa, é ilegal beber no comando de uma vaca.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The violent gang of youths in ‘A Clockwork Orange’ were called the ‘Groods’.",
                PhrasePtBr = "A gangue de jovens no filme Laranja Mecânica era chamada de 'grugues'.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Danny Jones is a member of the band McFly.",
                PhrasePtBr = "Danny Jones é um membro da banda McFly.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In the television series ‘Mork and Mindy’, Mindy was played by Erin Moran.",
                PhrasePtBr = "Na série de televisão \"Mork e Mindy\", Mindy foi interpretada por Erin Moran.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Beth Tweddle won a Silver Medal at the 2012 London Olympic Games.",
                PhrasePtBr = "Elizabeth Tweddle(Ginasta) ganhou uma medalha de prata nos Jogos Olímpicos de Londres 2012.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Marie Antoinette was married to Louis XVI of France.",
                PhrasePtBr = "Maria Antonieta era casada com Luís XVI de França.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In Mexico they celebrate ‘El Día de los muertos’ (The Day of the Dead), which instead of " +
                    "being one day, as the title suggests, starts at midnight on October 31st and lasts until November 2nd.",
                PhrasePtBr = "No México, eles celebram \"El Día de los Muertos\"(O dia dos mortos), " +
                             "que em vez de ser um dia, como o título sugere, começa à meia-noite em 31 " +
                             "de outubro e dura até 02 de novembro.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "UK shops earn more revenue from Halloween than they do from Bonfire Night.",
                PhrasePtBr = "As lojas do Reino Unido faturam mais no Dia das Bruxas, que na Bonfire Night.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In the year 2020, Halloween will fall on a Tuesday.",
                PhrasePtBr = "No ano de 2020, o Dia das Bruxas vai cair em uma terça-feira.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "The Celtic festival of ‘Samhain’ marks the end of the harvest season and " +
                    "takes place from sunset on October 31st until sunset on November 1st.",
                PhrasePtBr = "O festival celta de \"Samhain\" marca o fim da época de colheita e ocorre a partir do " +
                             "por do sol no dia 31 de outubro até o por do sol no dia 1º de novembro.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "The child actress Heather O’Rourke, famous for playing Carol Anne Freeling in Spielberg’s ‘Poltergeist’, " +
                    "died in February 1988, aged 12, four months before the third ‘Poltergeist’ film was released.",
                PhrasePtBr = "A atriz Heather O'Rourke, famosa por interpretar Carol Anne Freeling em \"Poltergeist - O Fenômeno\", " +
                             "morreu em fevereiro de 1988, com 12 anos, quatro meses antes do terceiro filme de \"Poltergeist\" ser lançado.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "Christopher Lee, famous for portraying Count Dracula in Hammer Horror films, was born on Halloween in 1922.",
                PhrasePtBr = "Christopher Lee, famoso por interpretar o Conde Drácula pelos estúdios da britânica Hammer Film Productions, " +
                             "nasceu no Dia das Bruxas, em 1922.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "Brandon Lee died during filming for ‘The Crow’ in 1994 after an accident with a prop gun during a shooting scene.",
                PhrasePtBr = "Brandon Lee morreu durante as filmagens de \"O Corvo\", " +
                             "em 1994, depois de um acidente com uma arma durante uma cena de tiroteio.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "Michael Keaton was originally offered Johnny Depp’s leading role in the 1990 film ‘Edward Scissorhands’.",
                PhrasePtBr = "Originalmente, o papel de Johnny Depp no filme de 1990 \"Edward Mãos de Tesoura\" " +
                             "foi oferecido ao ator Michael Keaton",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "Jack MacGowran and Vasiliki Maliaros both acted in the film ‘The Exorcist’ and died in the same year it was released.",
                PhrasePtBr = "Jack MacGowran e Vasiliki Maliaros ambos atuaram no " +
                             "filme 'O Exorcista' e morreram no mesmo ano em que o filme foi lançado.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Stephen King’s ‘The Shining’ was originally called ‘Halloween Hotel’.",
                PhrasePtBr = "'O Iluminado' de Stephen King foi originalmente chamado de 'Hotel Halloween'.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Alliumphobia is a fear of garlic.",
                PhrasePtBr = "Aliumfobia é o medo de alho",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "‘Fauntleroy’ is the middle name of Donald Duck.",
                PhrasePtBr = "\"Fauntleroy\" é o nome do meio do Pato Donald.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Henry VIII had an extra finger on each hand.",
                PhrasePtBr = "Henrique VIII de Inglaterra tinha um dedo a mais em cada mão.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The singer ‘Cher’ was born Cherilyn Sarkisian.",
                PhrasePtBr = "A cantora \"Cher\" recebeu o nome Cherilyn Sarkisian ao nascer.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Alfred Hitchcock had no belly button as it was removed during surgery.",
                PhrasePtBr = "Alfred Hitchcock não tinha umbigo, uma vez que foi removido durante uma cirurgia.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The ‘black box’ in an aeroplane is black.",
                PhrasePtBr = "A \"caixa preta\" em um avião é preto.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Michael Jackson had a pet python called ‘Crusher’.",
                PhrasePtBr = "Michael Jackson tinha uma cobra python de estimação chamada 'Crusher'.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "The distance, as the crow flies, from London to Edinburgh, is greater than the distance from London to Glasgow.",
                PhrasePtBr = "A distância, em linha reta, de Londres a Edimburgo, Escócia, é maior do que a distância de Londres para Glasgow, Escócia.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Geri Halliwell named her daughter ‘Bluebell Madonna’.",
                PhrasePtBr = "A cantora Geri Halliwell(Spice Girls) deu o nome de \"Bluebell Madonna\" a sua filha.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "Brendan O’Carroll, famous as ‘Mrs Brown’ from ‘Mrs Brown’s Boys’ is the cousin of Kenneth Branagh.",
                PhrasePtBr = "",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "There are 259 steps up to the ‘Whispering Gallery’ in St Paul’s Cathedral.",
                PhrasePtBr = "Existem 259 degraus até a galeria 'Whispering' na Catedral de São Paulo em Londres.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "The reverse of the Nobel Peace Prize, shows three naked men, standing with their hands on each other’s shoulders.",
                PhrasePtBr = "O inverso do Prémio Nobel da Paz, mostra três homens nus, em pé com as mãos nos ombros uns dos outros.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Centipedes always have 100 feet.",
                PhrasePtBr = "As centopéias sempre têm 100 pés.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The world record for a human to hold their breath underwater is 8 minutes 27 seconds.",
                PhrasePtBr = "O recorde mundial que um ser humano pode manter a sua respiração " +
                             "debaixo d'água é de 8 minutos e 27 segundos.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Olympus Mons, Mount Olympus on Mars, is taller than Mount Everest.",
                PhrasePtBr = "Olympus Mons, Monte Olimpo em Marte, é mais alto do que o Monte Everest.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The world’s oldest known tree is over 9000 years old.",
                PhrasePtBr = "A mais antiga árvore conhecida do mundo tem mais de 9000 anos de idade.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "A cross between a horse and a zebra is called a Hobra.",
                PhrasePtBr = "Um cruzamento entre um cavalo e uma zebra é chamado de Zevalo.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "111,111,111 x 111,111,111 = 12,345,678,987,654,321",
                PhrasePtBr = "111.111.111 x 111.111.111 = 12.345.678.987.654.321",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Muscle turns to fat if you stop exercising.",
                PhrasePtBr = "Músculo se transforma em gordura se você parar de se exercitar.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "The world’s smallest book is 1cm wide, 1cm tall and 4mm deep.",
                PhrasePtBr = "O menor livro do mundo tem um centímetro de largura, um centímetro de altura e quatro milímetros de profundidade.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In Cuba, tourists use a different currency to local people.",
                PhrasePtBr = "Em Cuba, os turistas usam uma moeda diferente da a população local.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In Colombia, by law all the radio stations and " +
                    "TV stations must play the National Anthem at 6:00 am and 6:00 pm every day.",
                PhrasePtBr = "Na Colômbia, por lei todas as estações de rádio e " +
                             "TV devem tocar o Hino Nacional às 6:00 am e 18:00 todos os dias.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In West Virginia, USA, if you accidentally hit an animal with your car, you are free to take it home to eat.",
                PhrasePtBr = "Em West Virginia, EUA, se você acidentalmente " +
                             "atingiu um animal com seu carro, você pode leva-lo para casa para comer.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "Despite China’s policy (preventing people from having more than one child), " +
                    "families are allowed to have THREE children if neither parent has siblings.",
                PhrasePtBr = "Apesar da política da China (impedindo as pessoas de terem mais de um filho), " +
                             "as famílias têm permissão para ter três filhos, se nenhum dos pais tem irmãos.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In Portugal you can be fined if caught driving whilst wearing flip-flops or not wearing a shirt.",
                PhrasePtBr = "Em Portugal, você pode ser multado se for apanhado dirigindo " +
                             "usando sandálias ou sem camisa.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In Bogota, Colombia, each year there is " +
                    "an entire week where personal vehicles are not permitted to be driven on the streets.",
                PhrasePtBr = "Em Bogotá, Colômbia, a cada ano há uma " +
                             "semana inteira onde os veículos pessoais são proibidos de serem conduzidos nas ruas.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "It is a common practice for married people to wear a ring on their left-hand wedding finger " +
                    "(i.e. the ring finger). In China, if you wear a ring on the thumb of your right-hand it means " +
                    "that you are looking for a partner (boyfriend or girlfriend).",
                PhrasePtBr = "É uma prática comum para as pessoas casadas usarem um anel no dedo do casamento da mão esquerda " +
                             "(ou seja, o dedo anular). Na China, se você usar um anel no dedo polegar da sua mão direita, " +
                             "isso significa que você está procurando um parceiro (namorado ou namorada).",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In London, UK, if you happen to die in the House of Parliament, " +
                    "you are technically entitled to a state funeral, because the building is considered too sacred a place.",
                PhrasePtBr = "Em Londres, Reino Unido, se acontecer de você morrer na Casa do Parlamento, " +
                             "você tecnicamente tem direito a um funeral de estado, porque o edifício é considerado um local muito sagrado.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Valentine’s day is banned in Saudi Arabia.",
                PhrasePtBr = "Dia dos Namorados é proibido na Arábia Saudita.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In China you cannot use Facebook or YouTube, but you can use Twitter.",
                PhrasePtBr = "Na China você não pode usar o Facebook ou YouTube, mas você pode usar o Twitter.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In the UK it is fine to scribble on money.",
                PhrasePtBr = "No Reino Unido, é bom para rabiscar em dinheiro.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In Saudi Arabia, drugs such as anti-depressants and sleeping pills have been banned by the government.",
                PhrasePtBr = "Na Arábia Saudita, medicamentos como antidepressivos e pílulas para dormir foram proibidos pelo governo.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Newlyweds in France are forced to drink leftovers from their wedding out of a toilet bowl.",
                PhrasePtBr = "Recem casados na França são obrigados a beber sobras de seu casamento de um vaso sanitário.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In Barcelona you are free to wear a bikini, swimming trunks or go bare-chested on the streets.",
                PhrasePtBr = "Em Barcelona, você é livre para usar um biquíni, sunga ou sair de peito nu nas ruas.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In France, it is illegal to cover your face in museums and on public transport, " +
                    "however you are free to cover your face whilst in parks.",
                PhrasePtBr = "Na França, é ilegal cobrir seu rosto em museus e nos transportes públicos, " +
                             "no entanto você é livre para cobrir seu rosto em parques.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Port (also known as Port wine) is made exclusively in Porto, Portugal.",
                PhrasePtBr = "Porto (também conhecido como vinho do Porto) é feito exclusivamente em Porto, Portugal.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "Cheddar cheese is made exclusively in the English village of Cheddar in Somerset.",
                PhrasePtBr = "Queijo Cheddar é feito exclusivamente na aldeia Inglêsa de Cheddar em Somerset, Inglaterra.",
                IsTrue = false,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In Egypt you may be detained or arrested if you use binoculars near an airport.",
                PhrasePtBr = "No Egito você pode ser detido ou preso, se você usar binóculos perto de um aeroporto.",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase =
                    "In Singapore, you will be fined for chewing gum on the metro trains (Mass Rapid Transit (MTR) system).",
                PhrasePtBr = "Em Cingapura, você será multado se mascar goma dentro dos trens ",
                IsTrue = true,
                IsCustom = false
            },
            new Phrases
            {
                Phrase = "In Portugal, McDonald’s, the fast food restaurant serves up to ten varieties of soup.",
                PhrasePtBr = "Em Portugal, o McDonald, serve até dez variedades de sopa.",
                IsTrue = true,
                IsCustom = false
            }
        };

        
    }
}
