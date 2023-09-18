﻿using System;
using Algorithms;
using static Algorithms.SortingAlgorithms;

public class Program
{
    private static List<int> complexList = new() { 6747, -3729, 3232, -9082, 3760, -1262, -215, 3559, 2603, -5290, -8325, 1815, 9879, 9532, -9668, 7142, 2809, -7892, -2761, -1675, -4024, -6871, 974, 166, -5306, 6850, -8429, 7061, -545, 295, 1188, 4188, -8960, 8429, 218, 1853, -15, -2469, 8645, 4241, 9730, 8791, 5837, -7307, 5608, 6733, 6649, -6182, 9020, 7738, 6149, -5647, -4167, -6534, -4947, 8149, 3032, 5143, -6044, 5118, 7855, 5781, -1017, -5364, -3077, -2681, -7262, -9260, 821, -3844, 1594, 4080, -808, -8571, -7938, 1593, -792, -1705, -3443, 1251, 6742, -1948, 7965, 801, -5743, 3135, 470, -6919, 7685, -2477, 6216, 9221, 6707, -7543, -54, -6396, 9500, 72, 2037, -5174, 1591, -2763, 4802, 4077, -5913, -5449, 9892, 2441, 9347, 7695, -4344, -4692, -7564, 3534, 5824, 8072, -868, 5530, -2347, -4387, -1449, -4115, 3268, 6346, -9707, 8347, 9749, 5425, -1986, -2942, -1669, -8397, -8174, 1886, -4688, 1937, -6134, -9048, 6781, 8958, -7594, -5103, -7665, -8439, 3331, -9054, 134, 4295, -5439, -9139, -3273, -6111, -7440, 2051, 3468, -2870, 7459, 7909, -7977, 4808, 6359, -7560, 9362, 3970, 5173, -6206, -221, -7929, 9483, 9064, 3342, -1346, -9198, 1051, -3044, -475, 6963, 9683, -3554, -2615, 235, -6609, 684, -8466, -9796, -5401, -2359, -7944, 5521, -2530, -2189, 9032, -278, 8052, -6351, -8327, 3485, -3609, -4623, 7453, -7963, -4685, -948, 6575, 3581, -4565, -1800, -9241, -1743, 8177, 208, -3335, -4391, -3869, 7392, -8078, -1410, -2834, -6787, -6455, -6630, -7679, -833, 5622, 4542, -4576, 6883, -4590, -7720, 7411, -1526, -5671, 9258, -396, -6959, 1683, 4316, 2430, 948, -1751, -7341, -2661, -3513, -3547, 4801, -6677, -8569, -2809, -7927, -8130, -1843, -9294, -2456, 7781, -2979, -5061, -3073, -7277, 8459, -9568, -1221, -7276, -7818, -8080, -1814, 7407, 4185, -2881, -7544, -9710, -6751, -9675, 7832, -9639, -3132, -3038, 4535, 591, 1071, -5072, 6096, -1414, 2667, -1017, -3049, -4856, 209, 607, -4808, 7832, 314, -3150, -1964, 9163, -4128, -5870, 8863, -8259, -5574, 2527, 8656, 884, -4899, -925, 8527, 5727, 3680, 7381, -6897, -2660, -8853, -3342, 4476, 6976, -7818, -1112, -9848, -1255, 4793, 216, 5376, -7199, -4401, 4562, -4027, -8421, 3182, 7251, 1051, 9770, -9861, -1751, 7882, -7101, 399, -2679, -4481, 3960, 11, 4302, 6838, -6740, -140, -5637, -4655, 7036, -7785, 6675, 3169, -9184, -1173, 8979, 5311, -839, 3682, 2338, 5956, 831, -9983, 2386, -6812, -7620, 3409, 4466, -5148, -2505, -3541, 2959, 1672, 1323, 9054, -7958, -2209, -2406, -6855, -2295, -4211, -1763, -2981, 6686, 1942, -3479, -7667, 3222, 5581, -5181, 7055, 1586, -1620, -8891, -7883, -2451, 8563, -8989, 9226, -219, -5518, -2251, 5542, 9126, -404, 9746, 4967, 2876, -8151, 9200, -299, 3684, -6523, -3963, 2135, -3410, 9635, 4125, 7794, -9361, 1162, 5717, -6294, 117, 7362, 2145, -631, 8426, 2606, -4738, 6504, -6384, -8863, -8985, -2797, -1299, -3754, 2020, -371, 523, 8904, -2982, -5150, 554, 8486, -5166, -4417, -4159, 6777, -5319, -7576, -1837, -756, 4946, -854, 3434, 5736, 490, -4520, -7732, -1720, -5932, -7527, -452, -8138, 4606, 2808, 6666, -9557, -6764, 6077, -8772, 4269, 7098, 2853, -2673, 966, -6013, 1490, 4625, 1187, -6823, -9133, -4870, -3449, -2388, 2956, 4232, -5515, 8266, -5544, -3228, 7061, 5109, 1184, 4312, 2435, -7102, 7167, -5464, -3051, -4086, 1256, -6959, -463, 4598, -403, 5016, -5556, 9977, -4886, 5390, -4045, 6701, 7914, -2622, -7434, 2014, 2491, 2690, -7123, -5245, 2415, -49, 6286, -1416, 8367, 6803, -4822, -5377, 8305, 4660, 8487, -646, -5374, 4565, -7978, -8172, -637, -8749, 2187, -9153, 6967, 9984, -3395, -9526, -2019, -7318, -7425, 4831, -1282, 6221, -9974, 2418, -3447, 7746, -4721, -7005, -26, 5170, 7869, -3059, -3352, -6005, 1213, 7548, -5591, 6988, 4648, -7705, -7989, 7919, -4117, 2517, -3066, -3775, 8460, 8059, -1561, 7312, 797, 2205, 9424, -2524, 9979, 4424, 1063, 6771, 8356, -1667, 9444, -9073, -4782, -4794, 8613, 3490, -3529, -9833, 3224, 4019, 5390, -2536, 9679, 7470, 6255, -2875, -9589, -8890, -7334, -4113, -2789, 7308, -2732, -9295, -1255, -5079, 6689, 472, -8721, -366, -4914, -7919, 2856, -7499, 6890, 5094, -3124, -9099, 4330, 5526, 2030, 6252, 5486, 1868, -7215, -313, 1170, -929, -9983, -2802, -8714, -1311, 5606, 7921, 4573, -5221, -3496, -2683, -7220, 7160, -3360, 2441, -6744, 1333, -3211, -5050, -1041, 9784, -566, -2891, 3896, 189, 1872, 3279, 1871, 1283, 9362, -7496, 4372, 7461, -6861, 6011, 8617, -601, 7909, 3436, 3552, -3053, -6185, -4795, 8884, -4122, 4430, 6437, -2034, -1655, -4915, 9802, -7309, 187, -4901, 8104, -5379, -754, 6109, 2452, 5136, -818, 34, -3887, -6941, 8275, 9948, 2853, -1322, 8856, -247, 810, 7503, -8798, -7747, 7531, -301, -4003, -3256, 1090, -8205, 1762, 2436, 6326, 3980, -8485, 1620, -8041, -4476, 1572, 3959, -7680, 4613, 8492, 9424, 387, 6537, 6004, 3029, -1150, 2238, -2756, 7514, 9928, 721, -4009, -7767, -3584, 1483, 2996, -4284, 9329, 1503, -3873, 4688, -2171, 4618, 6258, 3297, 1325, -6630, 2244, -4680, 3536, -3006, -3268, -5086, 5915, 9330, 4879, 2971, -8903, 6942, -9700, 5343, 8247, 3506, 8482, -1877, -4711, -1983, 4569, 6397, -6463, 1309, 3875, -2731, -2468, -6802, -5225, 1708, 858, 9922, -1900, 497, -7043, 6095, 2368, -5291, 6420, -3774, 8609, 3068, 1777, 7726, -9275, -8142, 7644, -8130, 5855, 3345, -6281, -2186, -2758, -6440, -8493, 9069, -2816, 832, -5588, 8452, -1236, 3541, -1482, -8552, 2784, 8645, -3408, -3244, -5142, -5113, -3359, 6975, 6295, 3572, 6427, -553, 897, -7369, 9859, -6993, 7885, 461, 1985, -8837, 2309, 1473, -1752, -3124, -9721, 6952, 8142, -9209, -1498, 3147, 5960, -3165, -4511, 3964, 8121, 7728, -463, 6824, -6834, -4006, -3109, -7597, -2005, 5592, -7141, -2703, -3509, 9613, 1896, 3044, 3131, -9013, 539, -5160, 3461, 9808, -2834, -9757, -2828, 5347, 8083, -1924, -3243, -7265, -3584, -6070, -643, -1734, -2148, -6908, -8544, 8621, 7597, 5203, -1567, -6894, 8711, -5470, -7620, -4181, 1110, 5011, -1897, 4548, -9369, -1050, 6997, 8798, -8738, -4625, 4981, 5555, 3567, 4876, 3285, -6090, 9043, -2187, -1057, 5171, -6745, 406, -8260, 6006, -8999, 5536, -8462, 6661, 3223, 4346, -4732, 1030, -4670, -488, 4343, 4554, -9186, 3195, -5370, 8691, -4438, -203, 3154, 7461, -774, -8215, -4454, -3691, -2837, -6428, -2307, 436, 5907, -60, 2227, 1753, -9769, 9918, 6879, -7777, 5218, -6710, -1217, -4021, 3069, -5378, 0, 6334, -7463, -4764, 2896, 8362, -5147, -57, -3634, -4801, -6101, 946, -7338, -3919, -4781, 1071, -8350, -7372, -7143, 2784, -3244, 6416, -920, 6, 5764, 1226, 9779, -6355, -4347, -8746, 2648, 4601, -4153, 8215, 5466, 8484, 1451 };
    private static List<int> simpleList  = new() { 5, 4, 3, 2, 1 };

    private const string lstPrompt  = "Please select the list you would like to sort: \n 0. Simple \n 1. Complex"; 
    private const string funcPrompt = "Please select the sorting method: \n 0. Bubble \n 1. Merge"; 

    /// <summary>
    ///     Main program
    /// </summary>
    /// <param name="args">Program arguments</param>
    public static void Main(string[] args)
    {
        var lstToUse = 0;
        var funcToUse = 0;

        Console.WriteLine(lstPrompt + "\n");
        var lstInput = Console.ReadLine();

        Console.WriteLine("\n" + funcPrompt + "\n");
        var funcInput = Console.ReadLine();

        try
        {
            lstToUse  = lstInput == null ? 0: int.Parse(lstInput);
            funcToUse = funcInput == null ? 0: int.Parse(funcInput);
        }
        catch
        {
            Console.Error.WriteLine("Please enter a valid number");
            return;
        }

        SortList(lstToUse, funcToUse);
    }

    /// <summary>
    ///     Take input data and call the given sorting method with the given list
    /// </summary>
    /// <param name="lstToUse">list to use</param>
    /// <param name="funcToUse">list to use</param>
    private static void SortList(int lstToUse, int funcToUse)
    {
        var lst = new List<int>();

        switch (lstToUse)
        {
            case 0:
                lst = simpleList;
                break;
            case 1:
                lst = complexList;
                break;
        }

        // Show the list prior to being sorting
        PrintIntArray(lst);

        switch (funcToUse)
        {
            case 0:
                BubbleSort(lst);
                break;
            case 1:
                lst = MergeSort(lst);
                break;
        }

        // Show the sorted list
        PrintIntArray(lst);
    }

    /// <summary>
    ///     Method made to print a list in a readable way
    /// </summary>
    /// <param name="lst">List to print</param>
    private static void PrintIntArray(List<int> lst)
    {
        Console.WriteLine();
        Console.Write("[");

        for (int x = 0; x < lst.Count; x++)
        {
            if (x == lst.Count - 1)
            {
                Console.Write(lst[x] + "]");
            }
            else
            {
                Console.Write(lst[x] + ", ");
            }
        }

        Console.WriteLine();

    }
}