using Microsoft.EntityFrameworkCore.Migrations;

namespace RoutingDemo.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "LicenseNumber", "Make", "Model" },
                values: new object[,]
                {
                    { 1, "BMW122", "BMW", "Polo" },
                    { 658, "BMW100", "BMW", "Polo" },
                    { 659, "FOR521", "Ford", "Focus" },
                    { 660, "BMW100", "BMW", "Focus" },
                    { 661, "SAA536", "Saab", "Kadett" },
                    { 662, "OPE787", "Opel", "Golf" },
                    { 663, "FOR344", "Ford", "M5" },
                    { 664, "KIA681", "Kia", "M5" },
                    { 665, "SAA771", "Saab", "9-3" },
                    { 666, "OPE477", "Opel", "Ceed" },
                    { 667, "OPE514", "Opel", "Kadett" },
                    { 668, "LEX781", "Lexus", "Mondeo" },
                    { 669, "OPE844", "Opel", "Ceed" },
                    { 670, "LEX501", "Lexus", "Touareg" },
                    { 671, "FOR563", "Ford", "Mondeo" },
                    { 672, "FOR593", "Ford", "Egde" },
                    { 673, "VOL415", "Volkswagen", "Kadett" },
                    { 674, "VOL739", "Volkswagen", "V90" },
                    { 675, "BMW654", "BMW", "Egde" },
                    { 676, "LEX964", "Lexus", "900" },
                    { 677, "FOR804", "Ford", "Golf" },
                    { 678, "KIA293", "Kia", "740" },
                    { 679, "VOL297", "Volkswagen", "V90" },
                    { 680, "MAZ469", "Mazda", "M3" },
                    { 681, "LEX791", "Lexus", "Fiesta" },
                    { 682, "BMW502", "BMW", "M5" },
                    { 683, "KIA153", "Kia", "Focus" },
                    { 684, "FOR235", "Ford", "M3" },
                    { 657, "SAA648", "Saab", "Up" },
                    { 685, "KIA161", "Kia", "M3" },
                    { 656, "OPE213", "Opel", "M5" },
                    { 654, "OPE120", "Opel", "900" },
                    { 627, "OPE770", "Opel", "Polo" },
                    { 628, "LEX918", "Lexus", "Rio" },
                    { 629, "KIA673", "Kia", "Passat" },
                    { 630, "LEX780", "Lexus", "9-3" },
                    { 631, "OPE590", "Opel", "Mondeo" },
                    { 632, "VOL200", "Volkswagen", "Rio" },
                    { 633, "MAZ799", "Mazda", "i8" },
                    { 634, "KIA779", "Kia", "Golf" },
                    { 635, "KIA896", "Kia", "XC60" },
                    { 636, "VOL587", "Volkswagen", "M5" },
                    { 637, "LEX673", "Lexus", "900" },
                    { 638, "BMW176", "BMW", "Polo" },
                    { 639, "BMW346", "BMW", "Golf" },
                    { 640, "BMW745", "BMW", "Polo" },
                    { 641, "FOR704", "Ford", "Polo" },
                    { 642, "FOR460", "Ford", "M5" },
                    { 643, "KIA546", "Kia", "Ascona" },
                    { 644, "VOL231", "Volkswagen", "M5" },
                    { 645, "LEX802", "Lexus", "C30" },
                    { 646, "LEX532", "Lexus", "Up" },
                    { 647, "KIA560", "Kia", "9000" },
                    { 648, "KIA795", "Kia", "Ceed" },
                    { 649, "KIA209", "Kia", "Ascona" },
                    { 650, "OPE169", "Opel", "Up" },
                    { 651, "BMW944", "BMW", "Touareg" },
                    { 652, "KIA703", "Kia", "Up" },
                    { 653, "KIA256", "Kia", "M5" },
                    { 655, "KIA372", "Kia", "XC60" },
                    { 686, "MAZ720", "Mazda", "Focus" },
                    { 687, "KIA356", "Kia", "9000" },
                    { 688, "BMW877", "BMW", "Passat" },
                    { 721, "LEX134", "Lexus", "9000" },
                    { 722, "BMW546", "BMW", "M5" },
                    { 723, "FOR546", "Ford", "Mondeo" },
                    { 724, "MAZ281", "Mazda", "C30" },
                    { 725, "OPE885", "Opel", "Polo" },
                    { 726, "SAA152", "Saab", "Rio" },
                    { 727, "BMW706", "BMW", "Golf" },
                    { 728, "VOL662", "Volkswagen", "900" },
                    { 729, "OPE309", "Opel", "900" },
                    { 730, "MAZ301", "Mazda", "M3" },
                    { 731, "SAA622", "Saab", "Egde" },
                    { 732, "KIA179", "Kia", "Passat" },
                    { 733, "VOL686", "Volkswagen", "C30" },
                    { 734, "FOR487", "Ford", "Polo" },
                    { 735, "BMW352", "BMW", "Focus" },
                    { 736, "VOL553", "Volkswagen", "9000" },
                    { 737, "LEX405", "Lexus", "Fiesta" },
                    { 738, "SAA649", "Saab", "Up" },
                    { 739, "KIA813", "Kia", "V90" },
                    { 740, "OPE230", "Opel", "C30" },
                    { 741, "FOR930", "Ford", "9000" },
                    { 742, "FOR906", "Ford", "XC60" },
                    { 743, "VOL794", "Volkswagen", "XC60" },
                    { 744, "BMW501", "BMW", "Polo" },
                    { 745, "OPE722", "Opel", "Kadett" },
                    { 746, "FOR170", "Ford", "Polo" },
                    { 747, "SAA720", "Saab", "Up" },
                    { 720, "MAZ815", "Mazda", "Kadett" },
                    { 719, "VOL463", "Volkswagen", "Passat" },
                    { 718, "LEX870", "Lexus", "9000" },
                    { 717, "BMW847", "BMW", "M5" },
                    { 689, "MAZ534", "Mazda", "Mondeo" },
                    { 690, "SAA681", "Saab", "Kadett" },
                    { 691, "SAA460", "Saab", "Up" },
                    { 692, "LEX766", "Lexus", "Ascona" },
                    { 693, "LEX110", "Lexus", "Ceed" },
                    { 694, "FOR168", "Ford", "Up" },
                    { 695, "LEX540", "Lexus", "Ceed" },
                    { 696, "VOL300", "Volkswagen", "i8" },
                    { 697, "KIA881", "Kia", "Polo" },
                    { 698, "VOL255", "Volkswagen", "Ascona" },
                    { 699, "KIA379", "Kia", "Rio" },
                    { 700, "LEX532", "Lexus", "Mondeo" },
                    { 701, "LEX305", "Lexus", "Up" },
                    { 626, "VOL761", "Volkswagen", "C30" },
                    { 702, "OPE880", "Opel", "Touareg" },
                    { 704, "SAA854", "Saab", "Up" },
                    { 705, "MAZ458", "Mazda", "i8" },
                    { 706, "FOR419", "Ford", "M3" },
                    { 707, "SAA908", "Saab", "Ceed" },
                    { 708, "FOR612", "Ford", "Mondeo" },
                    { 709, "BMW955", "BMW", "Up" },
                    { 710, "FOR332", "Ford", "Up" },
                    { 711, "OPE633", "Opel", "Ceed" },
                    { 712, "VOL753", "Volkswagen", "Egde" },
                    { 713, "BMW920", "BMW", "900" },
                    { 714, "VOL620", "Volkswagen", "M5" },
                    { 715, "FOR736", "Ford", "Up" },
                    { 716, "KIA404", "Kia", "Touareg" },
                    { 703, "MAZ149", "Mazda", "Focus" },
                    { 748, "MAZ471", "Mazda", "Polo" },
                    { 625, "FOR710", "Ford", "Up" },
                    { 623, "MAZ991", "Mazda", "900" },
                    { 533, "OPE469", "Opel", "M5" },
                    { 534, "KIA905", "Kia", "9-3" },
                    { 535, "LEX139", "Lexus", "i8" },
                    { 536, "VOL861", "Volkswagen", "V90" },
                    { 537, "OPE159", "Opel", "Golf" },
                    { 538, "VOL228", "Volkswagen", "Kadett" },
                    { 539, "OPE334", "Opel", "9000" },
                    { 540, "KIA421", "Kia", "Passat" },
                    { 541, "KIA821", "Kia", "Fiesta" },
                    { 542, "OPE568", "Opel", "Fiesta" },
                    { 543, "MAZ140", "Mazda", "9000" },
                    { 544, "VOL726", "Volkswagen", "Golf" },
                    { 545, "FOR929", "Ford", "Touareg" },
                    { 546, "SAA313", "Saab", "Up" },
                    { 547, "FOR862", "Ford", "Mondeo" },
                    { 548, "OPE922", "Opel", "C30" },
                    { 549, "BMW821", "BMW", "Egde" },
                    { 550, "VOL350", "Volkswagen", "9-3" },
                    { 551, "VOL934", "Volkswagen", "740" },
                    { 552, "KIA144", "Kia", "Rio" },
                    { 553, "KIA498", "Kia", "900" },
                    { 554, "OPE582", "Opel", "Touareg" },
                    { 555, "BMW762", "BMW", "M5" },
                    { 556, "SAA544", "Saab", "740" },
                    { 557, "FOR466", "Ford", "Mondeo" },
                    { 558, "LEX349", "Lexus", "Touareg" },
                    { 559, "OPE620", "Opel", "Kadett" },
                    { 532, "KIA830", "Kia", "Rio" },
                    { 560, "BMW802", "BMW", "9-3" },
                    { 531, "BMW779", "BMW", "Golf" },
                    { 529, "MAZ325", "Mazda", "740" },
                    { 502, "VOL344", "Volkswagen", "Kadett" },
                    { 503, "VOL123", "Volkswagen", "Up" },
                    { 504, "SAA922", "Saab", "Ascona" },
                    { 505, "BMW982", "BMW", "Rio" },
                    { 506, "BMW432", "BMW", "M5" },
                    { 507, "MAZ895", "Mazda", "Polo" },
                    { 508, "FOR477", "Ford", "Ascona" },
                    { 509, "OPE123", "Opel", "Kadett" },
                    { 510, "OPE669", "Opel", "V90" },
                    { 511, "SAA809", "Saab", "Ceed" },
                    { 512, "BMW937", "BMW", "740" },
                    { 513, "SAA817", "Saab", "Egde" },
                    { 514, "SAA735", "Saab", "Focus" },
                    { 515, "SAA476", "Saab", "Golf" },
                    { 516, "MAZ360", "Mazda", "Mondeo" },
                    { 517, "KIA953", "Kia", "Up" },
                    { 518, "BMW908", "BMW", "9000" },
                    { 519, "BMW228", "BMW", "Egde" },
                    { 520, "VOL751", "Volkswagen", "Mondeo" },
                    { 521, "FOR315", "Ford", "Ceed" },
                    { 522, "SAA356", "Saab", "Rio" },
                    { 523, "KIA442", "Kia", "i8" },
                    { 524, "KIA479", "Kia", "9000" },
                    { 525, "VOL454", "Volkswagen", "C30" },
                    { 526, "FOR605", "Ford", "Touareg" },
                    { 527, "LEX306", "Lexus", "Polo" },
                    { 528, "MAZ281", "Mazda", "900" },
                    { 530, "BMW949", "BMW", "M5" },
                    { 561, "MAZ683", "Mazda", "Ceed" },
                    { 562, "MAZ104", "Mazda", "Ceed" },
                    { 563, "MAZ543", "Mazda", "Rio" },
                    { 596, "OPE991", "Opel", "Up" },
                    { 597, "KIA845", "Kia", "Up" },
                    { 598, "VOL169", "Volkswagen", "i8" },
                    { 599, "FOR502", "Ford", "740" },
                    { 600, "FOR147", "Ford", "Touareg" },
                    { 601, "VOL523", "Volkswagen", "9-3" },
                    { 602, "OPE790", "Opel", "XC60" },
                    { 603, "OPE247", "Opel", "Mondeo" },
                    { 604, "OPE398", "Opel", "Passat" },
                    { 605, "KIA447", "Kia", "Ascona" },
                    { 606, "FOR420", "Ford", "M5" },
                    { 607, "VOL974", "Volkswagen", "i8" },
                    { 608, "FOR357", "Ford", "Golf" },
                    { 609, "SAA184", "Saab", "9000" },
                    { 610, "BMW386", "BMW", "Egde" },
                    { 611, "MAZ613", "Mazda", "9-3" },
                    { 612, "VOL131", "Volkswagen", "XC60" },
                    { 613, "SAA235", "Saab", "i8" },
                    { 614, "MAZ445", "Mazda", "Ceed" },
                    { 615, "BMW888", "BMW", "Golf" },
                    { 616, "OPE216", "Opel", "9000" },
                    { 617, "MAZ316", "Mazda", "i8" },
                    { 618, "KIA640", "Kia", "Kadett" },
                    { 619, "KIA618", "Kia", "V90" },
                    { 620, "FOR580", "Ford", "Mondeo" },
                    { 621, "MAZ737", "Mazda", "Kadett" },
                    { 622, "BMW857", "BMW", "Kadett" },
                    { 595, "OPE552", "Opel", "Polo" },
                    { 594, "BMW841", "BMW", "M5" },
                    { 593, "MAZ702", "Mazda", "Passat" },
                    { 592, "SAA288", "Saab", "i8" },
                    { 564, "BMW173", "BMW", "Fiesta" },
                    { 565, "BMW120", "BMW", "Kadett" },
                    { 566, "SAA266", "Saab", "Ascona" },
                    { 567, "FOR554", "Ford", "9000" },
                    { 568, "SAA227", "Saab", "C30" },
                    { 569, "BMW351", "BMW", "9000" },
                    { 570, "MAZ275", "Mazda", "9-3" },
                    { 571, "OPE675", "Opel", "Egde" },
                    { 572, "MAZ580", "Mazda", "Up" },
                    { 573, "BMW658", "BMW", "Ceed" },
                    { 574, "MAZ150", "Mazda", "Ascona" },
                    { 575, "LEX681", "Lexus", "XC60" },
                    { 576, "SAA970", "Saab", "Egde" },
                    { 624, "SAA690", "Saab", "Touareg" },
                    { 577, "FOR777", "Ford", "Egde" },
                    { 579, "SAA447", "Saab", "740" },
                    { 580, "OPE305", "Opel", "M5" },
                    { 581, "MAZ354", "Mazda", "Focus" },
                    { 582, "SAA784", "Saab", "C30" },
                    { 583, "OPE602", "Opel", "Focus" },
                    { 584, "OPE364", "Opel", "740" },
                    { 585, "VOL670", "Volkswagen", "740" },
                    { 586, "OPE794", "Opel", "V90" },
                    { 587, "OPE121", "Opel", "9-3" },
                    { 588, "SAA162", "Saab", "C30" },
                    { 589, "OPE298", "Opel", "Rio" },
                    { 590, "BMW206", "BMW", "C30" },
                    { 591, "KIA877", "Kia", "C30" },
                    { 578, "SAA796", "Saab", "Golf" },
                    { 501, "OPE150", "Opel", "i8" },
                    { 749, "BMW207", "BMW", "i8" },
                    { 751, "SAA755", "Saab", "Focus" },
                    { 908, "SAA645", "Saab", "Focus" },
                    { 909, "MAZ637", "Mazda", "Passat" },
                    { 910, "BMW433", "BMW", "Focus" },
                    { 911, "MAZ127", "Mazda", "V90" },
                    { 912, "FOR342", "Ford", "9-3" },
                    { 913, "KIA351", "Kia", "Rio" },
                    { 914, "FOR551", "Ford", "i8" },
                    { 915, "FOR456", "Ford", "XC60" },
                    { 916, "MAZ177", "Mazda", "Egde" },
                    { 917, "FOR516", "Ford", "C30" },
                    { 918, "SAA714", "Saab", "Passat" },
                    { 919, "VOL587", "Volkswagen", "Ascona" },
                    { 920, "MAZ567", "Mazda", "Polo" },
                    { 921, "OPE508", "Opel", "Touareg" },
                    { 922, "MAZ489", "Mazda", "Egde" },
                    { 923, "LEX382", "Lexus", "Mondeo" },
                    { 924, "BMW961", "BMW", "Egde" },
                    { 925, "VOL510", "Volkswagen", "M3" },
                    { 926, "SAA547", "Saab", "Focus" },
                    { 927, "FOR307", "Ford", "Rio" },
                    { 928, "OPE512", "Opel", "Kadett" },
                    { 929, "LEX388", "Lexus", "740" },
                    { 930, "SAA703", "Saab", "Golf" },
                    { 931, "MAZ127", "Mazda", "740" },
                    { 932, "MAZ878", "Mazda", "Polo" },
                    { 933, "KIA876", "Kia", "9000" },
                    { 934, "LEX798", "Lexus", "Passat" },
                    { 907, "KIA808", "Kia", "Golf" },
                    { 935, "MAZ934", "Mazda", "XC60" },
                    { 906, "SAA900", "Saab", "V90" },
                    { 904, "LEX998", "Lexus", "i8" },
                    { 877, "BMW626", "BMW", "Mondeo" },
                    { 878, "SAA226", "Saab", "Passat" },
                    { 879, "MAZ646", "Mazda", "Egde" },
                    { 880, "FOR546", "Ford", "9000" },
                    { 881, "LEX284", "Lexus", "Passat" },
                    { 882, "KIA706", "Kia", "V90" },
                    { 883, "SAA896", "Saab", "Focus" },
                    { 884, "BMW891", "BMW", "Passat" },
                    { 885, "MAZ887", "Mazda", "Rio" },
                    { 886, "KIA995", "Kia", "Fiesta" },
                    { 887, "MAZ785", "Mazda", "Touareg" },
                    { 888, "LEX432", "Lexus", "Egde" },
                    { 889, "OPE726", "Opel", "Passat" },
                    { 890, "SAA440", "Saab", "9-3" },
                    { 891, "SAA264", "Saab", "C30" },
                    { 892, "BMW946", "BMW", "Passat" },
                    { 893, "KIA623", "Kia", "i8" },
                    { 894, "VOL485", "Volkswagen", "900" },
                    { 895, "VOL302", "Volkswagen", "Ceed" },
                    { 896, "MAZ404", "Mazda", "Kadett" },
                    { 897, "FOR682", "Ford", "Kadett" },
                    { 898, "VOL416", "Volkswagen", "9000" },
                    { 899, "MAZ281", "Mazda", "Ceed" },
                    { 900, "BMW381", "BMW", "Passat" },
                    { 901, "LEX364", "Lexus", "M5" },
                    { 902, "OPE116", "Opel", "9000" },
                    { 903, "MAZ179", "Mazda", "Touareg" },
                    { 905, "OPE228", "Opel", "Mondeo" },
                    { 936, "OPE529", "Opel", "Passat" },
                    { 937, "FOR315", "Ford", "Fiesta" },
                    { 938, "KIA479", "Kia", "900" },
                    { 971, "VOL677", "Volkswagen", "Golf" },
                    { 972, "MAZ985", "Mazda", "Passat" },
                    { 973, "OPE699", "Opel", "XC60" },
                    { 974, "BMW883", "BMW", "Rio" },
                    { 975, "BMW777", "BMW", "M3" },
                    { 976, "VOL199", "Volkswagen", "Touareg" },
                    { 977, "VOL777", "Volkswagen", "Mondeo" },
                    { 978, "LEX503", "Lexus", "C30" },
                    { 979, "FOR758", "Ford", "Ceed" },
                    { 980, "MAZ536", "Mazda", "9-3" },
                    { 981, "VOL688", "Volkswagen", "9000" },
                    { 982, "BMW806", "BMW", "Polo" },
                    { 983, "MAZ224", "Mazda", "C30" },
                    { 984, "VOL676", "Volkswagen", "740" },
                    { 985, "VOL212", "Volkswagen", "Passat" },
                    { 986, "KIA173", "Kia", "M5" },
                    { 987, "VOL819", "Volkswagen", "Mondeo" },
                    { 988, "FOR909", "Ford", "Golf" },
                    { 989, "VOL166", "Volkswagen", "9-3" },
                    { 990, "FOR414", "Ford", "9-3" },
                    { 991, "FOR542", "Ford", "Golf" },
                    { 992, "FOR355", "Ford", "Egde" },
                    { 993, "FOR910", "Ford", "Ceed" },
                    { 994, "LEX301", "Lexus", "Touareg" },
                    { 995, "LEX531", "Lexus", "Ceed" },
                    { 996, "KIA497", "Kia", "900" },
                    { 997, "SAA882", "Saab", "Ceed" },
                    { 970, "SAA376", "Saab", "XC60" },
                    { 969, "MAZ383", "Mazda", "M3" },
                    { 968, "MAZ426", "Mazda", "V90" },
                    { 967, "OPE102", "Opel", "900" },
                    { 939, "SAA972", "Saab", "M5" },
                    { 940, "LEX541", "Lexus", "Up" },
                    { 941, "KIA216", "Kia", "Ascona" },
                    { 942, "VOL529", "Volkswagen", "Mondeo" },
                    { 943, "LEX888", "Lexus", "Touareg" },
                    { 944, "VOL369", "Volkswagen", "Fiesta" },
                    { 945, "VOL213", "Volkswagen", "Fiesta" },
                    { 946, "OPE111", "Opel", "Golf" },
                    { 947, "VOL508", "Volkswagen", "C30" },
                    { 948, "BMW306", "BMW", "Focus" },
                    { 949, "OPE725", "Opel", "Passat" },
                    { 950, "VOL643", "Volkswagen", "900" },
                    { 951, "BMW504", "BMW", "Ceed" },
                    { 876, "MAZ527", "Mazda", "Up" },
                    { 952, "SAA806", "Saab", "Touareg" },
                    { 954, "OPE618", "Opel", "9-3" },
                    { 955, "VOL754", "Volkswagen", "Kadett" },
                    { 956, "LEX961", "Lexus", "740" },
                    { 957, "SAA904", "Saab", "Up" },
                    { 958, "LEX220", "Lexus", "900" },
                    { 959, "KIA304", "Kia", "Fiesta" },
                    { 960, "LEX267", "Lexus", "Egde" },
                    { 961, "BMW194", "BMW", "XC60" },
                    { 962, "FOR918", "Ford", "Passat" },
                    { 963, "BMW208", "BMW", "Fiesta" },
                    { 964, "SAA403", "Saab", "Up" },
                    { 965, "KIA595", "Kia", "Rio" },
                    { 966, "BMW288", "BMW", "Fiesta" },
                    { 953, "VOL924", "Volkswagen", "Focus" },
                    { 750, "LEX215", "Lexus", "i8" },
                    { 875, "KIA296", "Kia", "Focus" },
                    { 873, "VOL426", "Volkswagen", "M3" },
                    { 783, "LEX174", "Lexus", "Egde" },
                    { 784, "OPE671", "Opel", "M5" },
                    { 785, "BMW587", "BMW", "C30" },
                    { 786, "LEX597", "Lexus", "Up" },
                    { 787, "LEX272", "Lexus", "9-3" },
                    { 788, "LEX193", "Lexus", "Kadett" },
                    { 789, "BMW473", "BMW", "V90" },
                    { 790, "BMW821", "BMW", "Ceed" },
                    { 791, "MAZ136", "Mazda", "Kadett" },
                    { 792, "BMW655", "BMW", "Fiesta" },
                    { 793, "FOR792", "Ford", "Mondeo" },
                    { 794, "OPE659", "Opel", "V90" },
                    { 795, "MAZ527", "Mazda", "XC60" },
                    { 796, "VOL692", "Volkswagen", "XC60" },
                    { 797, "VOL502", "Volkswagen", "XC60" },
                    { 798, "MAZ962", "Mazda", "Fiesta" },
                    { 799, "OPE419", "Opel", "Kadett" },
                    { 800, "OPE636", "Opel", "740" },
                    { 801, "KIA906", "Kia", "Egde" },
                    { 802, "SAA110", "Saab", "Passat" },
                    { 803, "VOL871", "Volkswagen", "Ceed" },
                    { 804, "LEX444", "Lexus", "Up" },
                    { 805, "BMW956", "BMW", "9-3" },
                    { 806, "VOL133", "Volkswagen", "Egde" },
                    { 807, "VOL708", "Volkswagen", "Fiesta" },
                    { 808, "MAZ492", "Mazda", "Egde" },
                    { 809, "SAA217", "Saab", "i8" },
                    { 782, "SAA520", "Saab", "Mondeo" },
                    { 810, "KIA398", "Kia", "XC60" },
                    { 781, "VOL614", "Volkswagen", "V90" },
                    { 779, "SAA392", "Saab", "9000" },
                    { 752, "OPE997", "Opel", "M3" },
                    { 753, "OPE530", "Opel", "9-3" },
                    { 754, "SAA919", "Saab", "i8" },
                    { 755, "MAZ287", "Mazda", "Egde" },
                    { 756, "BMW883", "BMW", "M3" },
                    { 757, "LEX332", "Lexus", "Touareg" },
                    { 758, "MAZ366", "Mazda", "Rio" },
                    { 759, "OPE535", "Opel", "9000" },
                    { 760, "OPE187", "Opel", "C30" },
                    { 761, "BMW151", "BMW", "Kadett" },
                    { 762, "VOL439", "Volkswagen", "900" },
                    { 763, "MAZ486", "Mazda", "M5" },
                    { 764, "MAZ933", "Mazda", "Golf" },
                    { 765, "VOL565", "Volkswagen", "M3" },
                    { 766, "BMW351", "BMW", "i8" },
                    { 767, "FOR786", "Ford", "i8" },
                    { 768, "FOR858", "Ford", "Ceed" },
                    { 769, "BMW807", "BMW", "Ascona" },
                    { 770, "OPE225", "Opel", "Ceed" },
                    { 771, "OPE917", "Opel", "i8" },
                    { 772, "SAA174", "Saab", "Ascona" },
                    { 773, "BMW490", "BMW", "Rio" },
                    { 774, "BMW789", "BMW", "Mondeo" },
                    { 775, "OPE879", "Opel", "Egde" },
                    { 776, "SAA847", "Saab", "Focus" },
                    { 777, "BMW336", "BMW", "Passat" },
                    { 778, "FOR209", "Ford", "V90" },
                    { 780, "FOR671", "Ford", "Polo" },
                    { 811, "FOR515", "Ford", "Golf" },
                    { 812, "FOR828", "Ford", "XC60" },
                    { 813, "MAZ451", "Mazda", "900" },
                    { 846, "VOL940", "Volkswagen", "XC60" },
                    { 847, "OPE996", "Opel", "900" },
                    { 848, "FOR728", "Ford", "Ascona" },
                    { 849, "MAZ734", "Mazda", "Ascona" },
                    { 850, "LEX255", "Lexus", "Fiesta" },
                    { 851, "KIA686", "Kia", "740" },
                    { 852, "FOR568", "Ford", "V90" },
                    { 853, "KIA561", "Kia", "Fiesta" },
                    { 854, "OPE750", "Opel", "900" },
                    { 855, "KIA988", "Kia", "Fiesta" },
                    { 856, "MAZ368", "Mazda", "M5" },
                    { 857, "OPE589", "Opel", "Rio" },
                    { 858, "FOR625", "Ford", "Polo" },
                    { 859, "OPE510", "Opel", "i8" },
                    { 860, "SAA281", "Saab", "900" },
                    { 861, "VOL214", "Volkswagen", "V90" },
                    { 862, "KIA401", "Kia", "Ascona" },
                    { 863, "MAZ246", "Mazda", "V90" },
                    { 864, "SAA814", "Saab", "Ascona" },
                    { 865, "OPE754", "Opel", "i8" },
                    { 866, "FOR182", "Ford", "Focus" },
                    { 867, "MAZ488", "Mazda", "Ceed" },
                    { 868, "OPE923", "Opel", "740" },
                    { 869, "VOL441", "Volkswagen", "Touareg" },
                    { 870, "KIA124", "Kia", "Up" },
                    { 871, "KIA557", "Kia", "Kadett" },
                    { 872, "SAA927", "Saab", "Touareg" },
                    { 845, "VOL882", "Volkswagen", "Golf" },
                    { 844, "MAZ466", "Mazda", "Ceed" },
                    { 843, "FOR376", "Ford", "Passat" },
                    { 842, "FOR375", "Ford", "Rio" },
                    { 814, "OPE134", "Opel", "Ceed" },
                    { 815, "BMW335", "BMW", "Kadett" },
                    { 816, "KIA445", "Kia", "i8" },
                    { 817, "LEX238", "Lexus", "Touareg" },
                    { 818, "SAA902", "Saab", "Touareg" },
                    { 819, "LEX770", "Lexus", "V90" },
                    { 820, "OPE477", "Opel", "M3" },
                    { 821, "BMW475", "BMW", "9000" },
                    { 822, "VOL819", "Volkswagen", "Kadett" },
                    { 823, "LEX960", "Lexus", "Ascona" },
                    { 824, "KIA519", "Kia", "Touareg" },
                    { 825, "VOL946", "Volkswagen", "Mondeo" },
                    { 826, "VOL354", "Volkswagen", "M3" },
                    { 874, "MAZ390", "Mazda", "M5" },
                    { 827, "FOR748", "Ford", "V90" },
                    { 829, "FOR651", "Ford", "M3" },
                    { 830, "VOL799", "Volkswagen", "Fiesta" },
                    { 831, "KIA340", "Kia", "Fiesta" },
                    { 832, "LEX320", "Lexus", "Ascona" },
                    { 833, "VOL743", "Volkswagen", "V90" },
                    { 834, "OPE195", "Opel", "Mondeo" },
                    { 835, "OPE778", "Opel", "Touareg" },
                    { 836, "MAZ461", "Mazda", "Passat" },
                    { 837, "LEX159", "Lexus", "V90" },
                    { 838, "OPE426", "Opel", "V90" },
                    { 839, "MAZ249", "Mazda", "Focus" },
                    { 840, "FOR501", "Ford", "XC60" },
                    { 841, "FOR173", "Ford", "XC60" },
                    { 828, "MAZ287", "Mazda", "Rio" },
                    { 998, "MAZ222", "Mazda", "Focus" },
                    { 500, "FOR804", "Ford", "M3" },
                    { 498, "LEX111", "Lexus", "Kadett" },
                    { 158, "MAZ681", "Mazda", "Egde" },
                    { 159, "MAZ891", "Mazda", "Up" },
                    { 160, "KIA410", "Kia", "V90" },
                    { 161, "OPE180", "Opel", "Polo" },
                    { 162, "KIA486", "Kia", "Fiesta" },
                    { 163, "KIA811", "Kia", "Golf" },
                    { 164, "OPE319", "Opel", "Focus" },
                    { 165, "OPE870", "Opel", "Mondeo" },
                    { 166, "SAA266", "Saab", "V90" },
                    { 167, "KIA301", "Kia", "Ceed" },
                    { 168, "LEX835", "Lexus", "Golf" },
                    { 169, "FOR402", "Ford", "Touareg" },
                    { 170, "MAZ990", "Mazda", "Kadett" },
                    { 171, "VOL408", "Volkswagen", "Touareg" },
                    { 172, "MAZ536", "Mazda", "M3" },
                    { 173, "VOL886", "Volkswagen", "Focus" },
                    { 174, "MAZ284", "Mazda", "Egde" },
                    { 175, "BMW572", "BMW", "i8" },
                    { 176, "MAZ807", "Mazda", "Fiesta" },
                    { 177, "BMW346", "BMW", "XC60" },
                    { 178, "MAZ985", "Mazda", "M5" },
                    { 179, "KIA758", "Kia", "900" },
                    { 180, "FOR220", "Ford", "M3" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "LicenseNumber", "Make", "Model" },
                values: new object[,]
                {
                    { 181, "KIA818", "Kia", "V90" },
                    { 182, "BMW118", "BMW", "Up" },
                    { 183, "LEX946", "Lexus", "Passat" },
                    { 184, "SAA899", "Saab", "Polo" },
                    { 157, "OPE100", "Opel", "M3" },
                    { 185, "SAA578", "Saab", "900" },
                    { 156, "FOR611", "Ford", "Egde" },
                    { 154, "OPE658", "Opel", "9000" },
                    { 127, "VOL239", "Volkswagen", "i8" },
                    { 128, "BMW144", "BMW", "900" },
                    { 129, "KIA245", "Kia", "900" },
                    { 130, "KIA984", "Kia", "C30" },
                    { 131, "LEX600", "Lexus", "Touareg" },
                    { 132, "LEX750", "Lexus", "Mondeo" },
                    { 133, "VOL900", "Volkswagen", "Fiesta" },
                    { 134, "OPE228", "Opel", "Polo" },
                    { 135, "OPE538", "Opel", "Passat" },
                    { 136, "OPE647", "Opel", "V90" },
                    { 137, "FOR733", "Ford", "M5" },
                    { 138, "FOR427", "Ford", "i8" },
                    { 139, "LEX269", "Lexus", "Passat" },
                    { 140, "MAZ623", "Mazda", "9-3" },
                    { 141, "SAA336", "Saab", "Ceed" },
                    { 142, "VOL162", "Volkswagen", "XC60" },
                    { 143, "LEX407", "Lexus", "C30" },
                    { 144, "BMW502", "BMW", "9000" },
                    { 145, "KIA926", "Kia", "Mondeo" },
                    { 146, "LEX564", "Lexus", "740" },
                    { 147, "VOL929", "Volkswagen", "Kadett" },
                    { 148, "VOL300", "Volkswagen", "Touareg" },
                    { 149, "SAA621", "Saab", "Passat" },
                    { 150, "FOR277", "Ford", "Ceed" },
                    { 151, "VOL465", "Volkswagen", "Up" },
                    { 152, "SAA533", "Saab", "Rio" },
                    { 153, "BMW173", "BMW", "M5" },
                    { 155, "FOR181", "Ford", "740" },
                    { 186, "LEX520", "Lexus", "Fiesta" },
                    { 187, "SAA415", "Saab", "740" },
                    { 188, "VOL114", "Volkswagen", "M3" },
                    { 221, "FOR402", "Ford", "V90" },
                    { 222, "BMW745", "BMW", "Fiesta" },
                    { 223, "SAA434", "Saab", "XC60" },
                    { 224, "SAA413", "Saab", "Kadett" },
                    { 225, "MAZ692", "Mazda", "Kadett" },
                    { 226, "MAZ144", "Mazda", "M3" },
                    { 227, "KIA569", "Kia", "Egde" },
                    { 228, "KIA988", "Kia", "Golf" },
                    { 229, "FOR340", "Ford", "Touareg" },
                    { 230, "KIA996", "Kia", "Up" },
                    { 231, "MAZ324", "Mazda", "M5" },
                    { 232, "MAZ826", "Mazda", "Touareg" },
                    { 233, "FOR151", "Ford", "Kadett" },
                    { 234, "OPE180", "Opel", "Ascona" },
                    { 235, "VOL810", "Volkswagen", "Kadett" },
                    { 236, "FOR262", "Ford", "Ceed" },
                    { 237, "BMW674", "BMW", "Passat" },
                    { 238, "SAA157", "Saab", "9-3" },
                    { 239, "SAA361", "Saab", "Focus" },
                    { 240, "SAA207", "Saab", "Passat" },
                    { 241, "OPE297", "Opel", "Egde" },
                    { 242, "SAA524", "Saab", "Ascona" },
                    { 243, "KIA554", "Kia", "Rio" },
                    { 244, "BMW125", "BMW", "9000" },
                    { 245, "LEX393", "Lexus", "9000" },
                    { 246, "OPE849", "Opel", "9-3" },
                    { 247, "FOR611", "Ford", "M3" },
                    { 220, "VOL868", "Volkswagen", "9-3" },
                    { 219, "OPE427", "Opel", "Touareg" },
                    { 218, "MAZ530", "Mazda", "Rio" },
                    { 217, "LEX609", "Lexus", "Passat" },
                    { 189, "MAZ690", "Mazda", "M5" },
                    { 190, "SAA258", "Saab", "Ascona" },
                    { 191, "MAZ911", "Mazda", "Fiesta" },
                    { 192, "MAZ693", "Mazda", "9-3" },
                    { 193, "OPE906", "Opel", "i8" },
                    { 194, "OPE337", "Opel", "Touareg" },
                    { 195, "BMW381", "BMW", "740" },
                    { 196, "SAA247", "Saab", "C30" },
                    { 197, "OPE972", "Opel", "Focus" },
                    { 198, "FOR308", "Ford", "i8" },
                    { 199, "BMW135", "BMW", "9-3" },
                    { 200, "BMW688", "BMW", "Rio" },
                    { 201, "SAA827", "Saab", "9-3" },
                    { 126, "KIA926", "Kia", "M3" },
                    { 202, "MAZ312", "Mazda", "Ascona" },
                    { 204, "BMW984", "BMW", "Ascona" },
                    { 205, "VOL381", "Volkswagen", "Polo" },
                    { 206, "KIA348", "Kia", "Passat" },
                    { 207, "MAZ323", "Mazda", "XC60" },
                    { 208, "OPE316", "Opel", "M5" },
                    { 209, "FOR106", "Ford", "900" },
                    { 210, "MAZ774", "Mazda", "M3" },
                    { 211, "VOL655", "Volkswagen", "Kadett" },
                    { 212, "FOR134", "Ford", "Focus" },
                    { 213, "OPE574", "Opel", "Rio" },
                    { 214, "KIA587", "Kia", "C30" },
                    { 215, "VOL291", "Volkswagen", "Ascona" },
                    { 216, "LEX924", "Lexus", "Passat" },
                    { 203, "LEX665", "Lexus", "9-3" },
                    { 248, "KIA874", "Kia", "XC60" },
                    { 125, "SAA574", "Saab", "Polo" },
                    { 123, "KIA588", "Kia", "M5" },
                    { 33, "FOR180", "Ford", "XC60" },
                    { 34, "OPE733", "Opel", "i8" },
                    { 35, "OPE523", "Opel", "i8" },
                    { 36, "FOR637", "Ford", "9-3" },
                    { 37, "BMW200", "BMW", "Kadett" },
                    { 38, "MAZ436", "Mazda", "Focus" },
                    { 39, "BMW879", "BMW", "M3" },
                    { 40, "LEX134", "Lexus", "V90" },
                    { 41, "LEX126", "Lexus", "Kadett" },
                    { 42, "FOR165", "Ford", "900" },
                    { 43, "MAZ375", "Mazda", "Golf" },
                    { 44, "FOR514", "Ford", "Golf" },
                    { 45, "MAZ895", "Mazda", "9000" },
                    { 46, "LEX649", "Lexus", "900" },
                    { 47, "SAA561", "Saab", "740" },
                    { 48, "LEX949", "Lexus", "900" },
                    { 49, "VOL155", "Volkswagen", "9000" },
                    { 50, "VOL522", "Volkswagen", "Kadett" },
                    { 51, "LEX800", "Lexus", "V90" },
                    { 52, "KIA189", "Kia", "740" },
                    { 53, "MAZ324", "Mazda", "Fiesta" },
                    { 54, "SAA619", "Saab", "9000" },
                    { 55, "SAA668", "Saab", "Passat" },
                    { 56, "MAZ424", "Mazda", "i8" },
                    { 57, "OPE277", "Opel", "M5" },
                    { 58, "FOR651", "Ford", "9-3" },
                    { 59, "VOL905", "Volkswagen", "Rio" },
                    { 32, "OPE856", "Opel", "Passat" },
                    { 60, "KIA701", "Kia", "Golf" },
                    { 31, "FOR972", "Ford", "900" },
                    { 29, "VOL583", "Volkswagen", "XC60" },
                    { 2, "LEX367", "Lexus", "Polo" },
                    { 3, "VOL564", "Volkswagen", "Polo" },
                    { 4, "BMW224", "BMW", "Polo" },
                    { 5, "MAZ393", "Mazda", "9-3" },
                    { 6, "SAA213", "Saab", "Ceed" },
                    { 7, "LEX126", "Lexus", "740" },
                    { 8, "SAA944", "Saab", "Rio" },
                    { 9, "KIA428", "Kia", "Ceed" },
                    { 10, "VOL612", "Volkswagen", "Passat" },
                    { 11, "KIA278", "Kia", "M3" },
                    { 12, "OPE682", "Opel", "C30" },
                    { 13, "VOL937", "Volkswagen", "Ceed" },
                    { 14, "VOL136", "Volkswagen", "Focus" },
                    { 15, "SAA991", "Saab", "Ceed" },
                    { 16, "LEX450", "Lexus", "Mondeo" },
                    { 17, "MAZ929", "Mazda", "9-3" },
                    { 18, "MAZ896", "Mazda", "Mondeo" },
                    { 19, "VOL499", "Volkswagen", "900" },
                    { 20, "KIA506", "Kia", "Up" },
                    { 21, "LEX811", "Lexus", "Ceed" },
                    { 22, "LEX591", "Lexus", "Passat" },
                    { 23, "LEX908", "Lexus", "Mondeo" },
                    { 24, "MAZ720", "Mazda", "Up" },
                    { 25, "FOR126", "Ford", "V90" },
                    { 26, "LEX793", "Lexus", "Rio" },
                    { 27, "LEX656", "Lexus", "Mondeo" },
                    { 28, "LEX869", "Lexus", "M5" },
                    { 30, "SAA675", "Saab", "Touareg" },
                    { 61, "LEX815", "Lexus", "Focus" },
                    { 62, "BMW237", "BMW", "Egde" },
                    { 63, "MAZ811", "Mazda", "Kadett" },
                    { 96, "FOR695", "Ford", "Ceed" },
                    { 97, "LEX912", "Lexus", "Egde" },
                    { 98, "VOL312", "Volkswagen", "V90" },
                    { 99, "MAZ157", "Mazda", "900" },
                    { 100, "FOR535", "Ford", "Golf" },
                    { 101, "BMW396", "BMW", "Focus" },
                    { 102, "OPE493", "Opel", "Focus" },
                    { 103, "SAA770", "Saab", "C30" },
                    { 104, "OPE985", "Opel", "M5" },
                    { 105, "SAA387", "Saab", "Ceed" },
                    { 106, "MAZ482", "Mazda", "Egde" },
                    { 107, "OPE549", "Opel", "Golf" },
                    { 108, "BMW710", "BMW", "Passat" },
                    { 109, "LEX885", "Lexus", "Polo" },
                    { 110, "SAA165", "Saab", "V90" },
                    { 111, "KIA865", "Kia", "Rio" },
                    { 112, "SAA167", "Saab", "Egde" },
                    { 113, "OPE162", "Opel", "900" },
                    { 114, "MAZ458", "Mazda", "M5" },
                    { 115, "LEX128", "Lexus", "9000" },
                    { 116, "LEX100", "Lexus", "XC60" },
                    { 117, "LEX968", "Lexus", "M3" },
                    { 118, "VOL774", "Volkswagen", "Kadett" },
                    { 119, "LEX232", "Lexus", "M3" },
                    { 120, "MAZ190", "Mazda", "Ascona" },
                    { 121, "VOL834", "Volkswagen", "M5" },
                    { 122, "MAZ593", "Mazda", "XC60" },
                    { 95, "LEX246", "Lexus", "900" },
                    { 94, "KIA854", "Kia", "900" },
                    { 93, "FOR863", "Ford", "Touareg" },
                    { 92, "LEX262", "Lexus", "Up" },
                    { 64, "BMW981", "BMW", "Fiesta" },
                    { 65, "SAA662", "Saab", "i8" },
                    { 66, "LEX562", "Lexus", "Kadett" },
                    { 67, "SAA339", "Saab", "Touareg" },
                    { 68, "MAZ507", "Mazda", "Focus" },
                    { 69, "FOR539", "Ford", "Golf" },
                    { 70, "FOR185", "Ford", "9000" },
                    { 71, "FOR302", "Ford", "Ascona" },
                    { 72, "VOL204", "Volkswagen", "C30" },
                    { 73, "BMW262", "BMW", "900" },
                    { 74, "OPE178", "Opel", "i8" },
                    { 75, "VOL464", "Volkswagen", "Passat" },
                    { 76, "FOR362", "Ford", "M5" },
                    { 124, "FOR553", "Ford", "Egde" },
                    { 77, "LEX231", "Lexus", "Ascona" },
                    { 79, "OPE767", "Opel", "V90" },
                    { 80, "SAA300", "Saab", "9-3" },
                    { 81, "MAZ844", "Mazda", "9000" },
                    { 82, "MAZ437", "Mazda", "Ascona" },
                    { 83, "MAZ391", "Mazda", "Polo" },
                    { 84, "OPE927", "Opel", "Mondeo" },
                    { 85, "SAA668", "Saab", "Up" },
                    { 86, "FOR216", "Ford", "Focus" },
                    { 87, "KIA594", "Kia", "Ceed" },
                    { 88, "FOR697", "Ford", "Mondeo" },
                    { 89, "LEX591", "Lexus", "Up" },
                    { 90, "VOL823", "Volkswagen", "Mondeo" },
                    { 91, "SAA653", "Saab", "740" },
                    { 78, "SAA623", "Saab", "Polo" },
                    { 499, "MAZ328", "Mazda", "Focus" },
                    { 249, "SAA162", "Saab", "XC60" },
                    { 251, "OPE717", "Opel", "Touareg" },
                    { 408, "BMW895", "BMW", "Focus" },
                    { 409, "OPE759", "Opel", "V90" },
                    { 410, "KIA565", "Kia", "Golf" },
                    { 411, "OPE447", "Opel", "Passat" },
                    { 412, "SAA906", "Saab", "740" },
                    { 413, "KIA196", "Kia", "Egde" },
                    { 414, "BMW454", "BMW", "Rio" },
                    { 415, "MAZ751", "Mazda", "V90" },
                    { 416, "FOR853", "Ford", "Egde" },
                    { 417, "LEX337", "Lexus", "Kadett" },
                    { 418, "MAZ169", "Mazda", "Mondeo" },
                    { 419, "LEX174", "Lexus", "XC60" },
                    { 420, "MAZ551", "Mazda", "Egde" },
                    { 421, "BMW398", "BMW", "Golf" },
                    { 422, "VOL820", "Volkswagen", "C30" },
                    { 423, "MAZ216", "Mazda", "M5" },
                    { 424, "LEX845", "Lexus", "M3" },
                    { 425, "KIA672", "Kia", "Fiesta" },
                    { 426, "LEX617", "Lexus", "Egde" },
                    { 427, "FOR828", "Ford", "Mondeo" },
                    { 428, "BMW838", "BMW", "Egde" },
                    { 429, "FOR338", "Ford", "Polo" },
                    { 430, "SAA836", "Saab", "C30" },
                    { 431, "BMW765", "BMW", "C30" },
                    { 432, "VOL183", "Volkswagen", "i8" },
                    { 433, "KIA672", "Kia", "Focus" },
                    { 434, "LEX153", "Lexus", "9000" },
                    { 407, "KIA384", "Kia", "i8" },
                    { 435, "MAZ455", "Mazda", "i8" },
                    { 406, "LEX273", "Lexus", "XC60" },
                    { 404, "BMW206", "BMW", "Polo" },
                    { 377, "SAA713", "Saab", "XC60" },
                    { 378, "MAZ427", "Mazda", "i8" },
                    { 379, "OPE391", "Opel", "Ceed" },
                    { 380, "SAA276", "Saab", "Up" },
                    { 381, "KIA586", "Kia", "Rio" },
                    { 382, "SAA801", "Saab", "Focus" },
                    { 383, "BMW449", "BMW", "Polo" },
                    { 384, "BMW759", "BMW", "Golf" },
                    { 385, "MAZ292", "Mazda", "i8" },
                    { 386, "MAZ874", "Mazda", "740" },
                    { 387, "OPE619", "Opel", "Polo" },
                    { 388, "FOR411", "Ford", "M3" },
                    { 389, "LEX625", "Lexus", "Ascona" },
                    { 390, "SAA792", "Saab", "M3" },
                    { 391, "MAZ893", "Mazda", "M3" },
                    { 392, "SAA420", "Saab", "Kadett" },
                    { 393, "LEX658", "Lexus", "Ceed" },
                    { 394, "VOL625", "Volkswagen", "Passat" },
                    { 395, "BMW386", "BMW", "900" },
                    { 396, "LEX741", "Lexus", "i8" },
                    { 397, "FOR430", "Ford", "Polo" },
                    { 398, "OPE784", "Opel", "M3" },
                    { 399, "VOL893", "Volkswagen", "Touareg" },
                    { 400, "FOR342", "Ford", "XC60" },
                    { 401, "FOR590", "Ford", "9000" },
                    { 402, "VOL573", "Volkswagen", "Rio" },
                    { 403, "BMW151", "BMW", "XC60" },
                    { 405, "FOR851", "Ford", "Up" },
                    { 436, "OPE691", "Opel", "Ascona" },
                    { 437, "OPE851", "Opel", "Ceed" },
                    { 438, "OPE807", "Opel", "9000" },
                    { 471, "VOL816", "Volkswagen", "Golf" },
                    { 472, "KIA941", "Kia", "C30" },
                    { 473, "VOL917", "Volkswagen", "9-3" },
                    { 474, "BMW700", "BMW", "Golf" },
                    { 475, "OPE783", "Opel", "Touareg" },
                    { 476, "LEX530", "Lexus", "i8" },
                    { 477, "LEX767", "Lexus", "XC60" },
                    { 478, "VOL173", "Volkswagen", "M3" },
                    { 479, "KIA396", "Kia", "Rio" },
                    { 480, "VOL938", "Volkswagen", "Golf" },
                    { 481, "BMW508", "BMW", "M5" },
                    { 482, "SAA924", "Saab", "i8" },
                    { 483, "MAZ693", "Mazda", "V90" },
                    { 484, "FOR173", "Ford", "9000" },
                    { 485, "BMW955", "BMW", "XC60" },
                    { 486, "BMW444", "BMW", "Egde" },
                    { 487, "LEX329", "Lexus", "900" },
                    { 488, "MAZ339", "Mazda", "C30" },
                    { 489, "OPE560", "Opel", "M3" },
                    { 490, "MAZ139", "Mazda", "i8" },
                    { 491, "VOL580", "Volkswagen", "M3" },
                    { 492, "LEX613", "Lexus", "Ceed" },
                    { 493, "FOR631", "Ford", "Ceed" },
                    { 494, "BMW462", "BMW", "Egde" },
                    { 495, "BMW620", "BMW", "Golf" },
                    { 496, "MAZ395", "Mazda", "Polo" },
                    { 497, "KIA640", "Kia", "V90" },
                    { 470, "SAA264", "Saab", "M5" },
                    { 469, "SAA275", "Saab", "9000" },
                    { 468, "VOL727", "Volkswagen", "9000" },
                    { 467, "FOR519", "Ford", "i8" },
                    { 439, "MAZ334", "Mazda", "M5" },
                    { 440, "OPE391", "Opel", "V90" },
                    { 441, "VOL295", "Volkswagen", "740" },
                    { 442, "SAA371", "Saab", "Focus" },
                    { 443, "KIA965", "Kia", "900" },
                    { 444, "VOL840", "Volkswagen", "Touareg" },
                    { 445, "LEX428", "Lexus", "Fiesta" },
                    { 446, "MAZ941", "Mazda", "Mondeo" },
                    { 447, "OPE916", "Opel", "Up" },
                    { 448, "VOL183", "Volkswagen", "Touareg" },
                    { 449, "LEX644", "Lexus", "V90" },
                    { 450, "LEX842", "Lexus", "M5" },
                    { 451, "BMW601", "BMW", "9-3" },
                    { 376, "OPE312", "Opel", "Ascona" },
                    { 452, "SAA835", "Saab", "C30" },
                    { 454, "KIA863", "Kia", "XC60" },
                    { 455, "MAZ907", "Mazda", "M5" },
                    { 456, "LEX988", "Lexus", "9-3" },
                    { 457, "OPE494", "Opel", "M3" },
                    { 458, "SAA272", "Saab", "Rio" },
                    { 459, "OPE353", "Opel", "M3" },
                    { 460, "KIA587", "Kia", "XC60" },
                    { 461, "MAZ364", "Mazda", "Focus" },
                    { 462, "KIA129", "Kia", "Golf" },
                    { 463, "FOR619", "Ford", "Kadett" },
                    { 464, "VOL562", "Volkswagen", "M5" },
                    { 465, "SAA279", "Saab", "XC60" },
                    { 466, "KIA727", "Kia", "M5" },
                    { 453, "BMW629", "BMW", "C30" },
                    { 250, "FOR490", "Ford", "XC60" },
                    { 375, "SAA453", "Saab", "Ceed" },
                    { 373, "SAA579", "Saab", "i8" },
                    { 283, "FOR721", "Ford", "Fiesta" },
                    { 284, "VOL578", "Volkswagen", "Passat" },
                    { 285, "MAZ284", "Mazda", "C30" },
                    { 286, "MAZ677", "Mazda", "Up" },
                    { 287, "KIA451", "Kia", "M5" },
                    { 288, "OPE518", "Opel", "XC60" },
                    { 289, "MAZ833", "Mazda", "M5" },
                    { 290, "BMW613", "BMW", "Ascona" },
                    { 291, "MAZ436", "Mazda", "M5" },
                    { 292, "SAA894", "Saab", "Kadett" },
                    { 293, "VOL579", "Volkswagen", "Golf" },
                    { 294, "SAA872", "Saab", "i8" },
                    { 295, "SAA710", "Saab", "Fiesta" },
                    { 296, "KIA791", "Kia", "Touareg" },
                    { 297, "BMW985", "BMW", "740" },
                    { 298, "VOL812", "Volkswagen", "Mondeo" },
                    { 299, "VOL542", "Volkswagen", "9000" },
                    { 300, "LEX573", "Lexus", "Rio" },
                    { 301, "LEX453", "Lexus", "XC60" },
                    { 302, "KIA555", "Kia", "M5" },
                    { 303, "FOR534", "Ford", "XC60" },
                    { 304, "SAA839", "Saab", "Mondeo" },
                    { 305, "KIA646", "Kia", "Up" },
                    { 306, "VOL844", "Volkswagen", "Focus" },
                    { 307, "BMW822", "BMW", "Ascona" },
                    { 308, "KIA890", "Kia", "Focus" },
                    { 309, "VOL509", "Volkswagen", "Egde" },
                    { 282, "BMW799", "BMW", "Golf" },
                    { 310, "VOL864", "Volkswagen", "Golf" },
                    { 281, "LEX452", "Lexus", "Focus" },
                    { 279, "FOR273", "Ford", "Rio" },
                    { 252, "LEX206", "Lexus", "Ceed" },
                    { 253, "BMW792", "BMW", "Mondeo" },
                    { 254, "SAA699", "Saab", "Focus" },
                    { 255, "MAZ932", "Mazda", "M3" },
                    { 256, "VOL762", "Volkswagen", "XC60" },
                    { 257, "MAZ388", "Mazda", "M5" },
                    { 258, "OPE510", "Opel", "Mondeo" },
                    { 259, "VOL671", "Volkswagen", "C30" },
                    { 260, "SAA970", "Saab", "Ceed" },
                    { 261, "OPE513", "Opel", "M5" },
                    { 262, "KIA431", "Kia", "XC60" },
                    { 263, "SAA292", "Saab", "Ceed" },
                    { 264, "FOR188", "Ford", "9-3" },
                    { 265, "KIA614", "Kia", "Touareg" },
                    { 266, "LEX167", "Lexus", "740" },
                    { 267, "LEX784", "Lexus", "Golf" },
                    { 268, "SAA251", "Saab", "740" },
                    { 269, "KIA490", "Kia", "Rio" },
                    { 270, "FOR464", "Ford", "C30" },
                    { 271, "OPE894", "Opel", "9000" },
                    { 272, "BMW937", "BMW", "M5" },
                    { 273, "FOR424", "Ford", "Ascona" },
                    { 274, "VOL995", "Volkswagen", "Fiesta" },
                    { 275, "OPE156", "Opel", "9000" },
                    { 276, "FOR995", "Ford", "C30" },
                    { 277, "BMW711", "BMW", "Kadett" },
                    { 278, "VOL992", "Volkswagen", "740" },
                    { 280, "SAA100", "Saab", "M3" },
                    { 311, "SAA422", "Saab", "Passat" },
                    { 312, "LEX469", "Lexus", "XC60" },
                    { 313, "OPE162", "Opel", "Mondeo" },
                    { 346, "OPE221", "Opel", "9000" },
                    { 347, "MAZ593", "Mazda", "XC60" },
                    { 348, "LEX881", "Lexus", "Egde" },
                    { 349, "FOR134", "Ford", "Touareg" },
                    { 350, "VOL243", "Volkswagen", "Kadett" },
                    { 351, "FOR553", "Ford", "M3" },
                    { 352, "SAA179", "Saab", "Touareg" },
                    { 353, "OPE981", "Opel", "Polo" },
                    { 354, "LEX551", "Lexus", "Focus" },
                    { 355, "KIA252", "Kia", "Golf" },
                    { 356, "KIA360", "Kia", "900" },
                    { 357, "SAA922", "Saab", "9-3" },
                    { 358, "MAZ333", "Mazda", "Fiesta" },
                    { 359, "SAA864", "Saab", "M3" },
                    { 360, "MAZ623", "Mazda", "Touareg" },
                    { 361, "BMW275", "BMW", "Polo" },
                    { 362, "KIA515", "Kia", "M3" },
                    { 363, "SAA958", "Saab", "Polo" },
                    { 364, "SAA505", "Saab", "M5" },
                    { 365, "FOR949", "Ford", "Polo" },
                    { 366, "KIA275", "Kia", "i8" },
                    { 367, "MAZ209", "Mazda", "Egde" },
                    { 368, "MAZ844", "Mazda", "Mondeo" },
                    { 369, "FOR472", "Ford", "900" },
                    { 370, "FOR674", "Ford", "M3" },
                    { 371, "FOR691", "Ford", "Up" },
                    { 372, "SAA184", "Saab", "Rio" },
                    { 345, "KIA506", "Kia", "Rio" },
                    { 344, "FOR850", "Ford", "Passat" },
                    { 343, "SAA297", "Saab", "Focus" },
                    { 342, "KIA854", "Kia", "Golf" },
                    { 314, "FOR296", "Ford", "i8" },
                    { 315, "SAA105", "Saab", "900" },
                    { 316, "FOR181", "Ford", "740" },
                    { 317, "FOR182", "Ford", "Rio" },
                    { 318, "MAZ306", "Mazda", "Focus" },
                    { 319, "MAZ952", "Mazda", "M5" },
                    { 320, "OPE495", "Opel", "9000" },
                    { 321, "KIA395", "Kia", "9-3" },
                    { 322, "VOL289", "Volkswagen", "M3" },
                    { 323, "OPE302", "Opel", "Focus" },
                    { 324, "FOR705", "Ford", "Rio" },
                    { 325, "MAZ382", "Mazda", "Ascona" },
                    { 326, "VOL426", "Volkswagen", "Polo" },
                    { 374, "MAZ496", "Mazda", "Golf" },
                    { 327, "BMW524", "BMW", "740" },
                    { 329, "MAZ336", "Mazda", "Golf" },
                    { 330, "KIA219", "Kia", "V90" },
                    { 331, "OPE439", "Opel", "M3" },
                    { 332, "VOL227", "Volkswagen", "Focus" },
                    { 333, "BMW335", "BMW", "Kadett" },
                    { 334, "BMW157", "BMW", "Passat" },
                    { 335, "BMW764", "BMW", "i8" },
                    { 336, "OPE326", "Opel", "M5" },
                    { 337, "LEX892", "Lexus", "Focus" },
                    { 338, "VOL852", "Volkswagen", "Kadett" },
                    { 339, "LEX913", "Lexus", "Passat" },
                    { 340, "LEX934", "Lexus", "Touareg" },
                    { 341, "LEX592", "Lexus", "XC60" },
                    { 328, "SAA458", "Saab", "C30" },
                    { 999, "MAZ572", "Mazda", "C30" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 999);
        }
    }
}
