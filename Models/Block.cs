namespace SPL.Models
{
    public class Block
    {
        public Guid? Id { get; set; }
        public int? BlockId { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Z { get; set; }
        public string? Type { get; set; }
        public string? Function { get; set; }
        public string? Another1 { get; set; }
        public string? Another2 { get; set; }
        public string? Another3 { get; set; }
        public string? Another4 { get; set; }
        public string? Another5 { get; set; }

        public List<Block> GetBlockListByCoordinate(string CoordinateA, int BlockIdA, string CoordinateB = null, int BlockIdB = 99999, List<int> WharfSplitBlockIds = null, List<int> WharfInBlockIds = null, List<int> WharfOutBlockIds = null, List<int> StationBlockIds = null)
        {
            List<Block> blocks = new List<Block>();
            if (CoordinateB == null)
            {
                // 只有单坐标
                string[] coordinateAParts = CoordinateA.Split(',');
                int x = int.Parse(coordinateAParts[0].Trim());
                int y = int.Parse(coordinateAParts[1].Trim());
                int z = int.Parse(coordinateAParts[2].Trim());
                blocks.Add(new Block { Id = Guid.NewGuid(), BlockId = BlockIdA, X = x, Y = y, Z = z, Type = "Conveyer", Function = "Convey" });
            }
            else if (CoordinateA != null && CoordinateB != null)
            {
                // 双坐标
                string[] AParts = CoordinateA.Split(',');
                int aX = int.Parse(AParts[0].Trim());
                int aY = int.Parse(AParts[1].Trim());
                int aZ = int.Parse(AParts[2].Trim());

                string[] BParts = CoordinateB.Split(',');
                int bX = int.Parse(BParts[0].Trim());
                int bY = int.Parse(BParts[1].Trim());
                int bZ = int.Parse(BParts[2].Trim());

                bool isTurn = false;
                int StartBlockId = BlockIdA;
                int EndBlockId = BlockIdB;
                if (aX > bX)
                {
                    int a = aX;
                    aX = bX;
                    bX = a;
                    isTurn = true;
                }
                if (aY > bY)
                {
                    int a = aY;
                    aY = bY;
                    bY = a;
                    isTurn = true;
                }
                if (aZ > bZ)
                {
                    int a = aZ;
                    aZ = bZ;
                    bZ = a;
                    isTurn = true;
                }
                if (isTurn == true)
                {
                    StartBlockId = BlockIdB;
                    EndBlockId = BlockIdA;
                }

                if (aX != bX)
                {
                    for (int i = aX; i <= bX; i++)
                    {
                        blocks.Add(new Block { Id = Guid.NewGuid(), BlockId = StartBlockId, X = i, Y = aY, Z = aZ, Type = "Conveyer", Function = "Convey" });
                        if (isTurn == true) StartBlockId--;
                        else StartBlockId++;
                    }
                }

                if (aY != bY)
                {
                    for (int i = aY; i <= bY; i++)
                    {
                        blocks.Add(new Block { Id = Guid.NewGuid(), BlockId = StartBlockId, X = aX, Y = i, Z = aZ, Type = "Conveyer", Function = "Convey" });
                        if (isTurn == true) StartBlockId--;
                        else StartBlockId++;
                    }
                }
                if (aZ != bZ)
                {
                    for (int i = aZ; i <= bZ; i++)
                    {
                        blocks.Add(new Block { Id = Guid.NewGuid(), BlockId = StartBlockId, X = aX, Y = aY, Z = i, Type = "Conveyer", Function = "Convey" });
                        if (isTurn == true) StartBlockId--;
                        else StartBlockId++;
                    }
                }

            }
            else
            {
                // 其他情况

            }

            // 添加其他类型区块
            if (WharfSplitBlockIds != null)
            {
                foreach (int toModifyBlockId in WharfSplitBlockIds)
                {
                    var blockToModify = blocks.FirstOrDefault(block => block.BlockId == toModifyBlockId);
                    if (blockToModify != null)
                    {
                        blockToModify.Type = "Wharf-Split";
                    }
                }
            }

            if (WharfInBlockIds != null)
            {
                foreach (int toModifyBlockId in WharfInBlockIds)
                {
                    var blockToModify = blocks.FirstOrDefault(block => block.BlockId == toModifyBlockId);
                    if (blockToModify != null)
                    {
                        blockToModify.Type = "Wharf-In";
                    }
                }
            }

            if (WharfOutBlockIds != null)
            {
                foreach (int toModifyBlockId in WharfOutBlockIds)
                {
                    var blockToModify = blocks.FirstOrDefault(block => block.BlockId == toModifyBlockId);
                    if (blockToModify != null)
                    {
                        blockToModify.Type = "Wharf-Out";
                    }
                }
            }

            if (StationBlockIds != null)
            {
                foreach (int toModifyBlockId in StationBlockIds)
                {
                    var blockToModify = blocks.FirstOrDefault(block => block.BlockId == toModifyBlockId);
                    if (blockToModify != null)
                    {
                        blockToModify.Type = "Station";
                    }
                }
            }

            var result = blocks.Distinct().ToList();
            return result;
        }

        public List<Block> GetSeedBlockMap()
        {
            List<Block> blocks = new List<Block>();
            blocks.AddRange(GetBlockListByCoordinate("-6, -58, 4", 10001, "-6, -58, -8", 10013, new List<int> { 10004 }));
            blocks.AddRange(GetBlockListByCoordinate("-7, -58, -2", 10014, "-17, -58, -2", 10024, null, new List<int> { 10018 }, new List<int> { 10020 }, new List<int> { 10019 }));
            blocks.AddRange(GetBlockListByCoordinate("-7, -58, -8", 10025, "-17, -58, -8", 10035, null, new List<int> { 10029 }, new List<int> { 10031 }, new List<int> { 10030 }));
            blocks.AddRange(GetBlockListByCoordinate("-18, -58, -2", 10036, "-18, -58, -13", 10047));
            blocks.AddRange(GetBlockListByCoordinate("-18, -58, -14", 10048, "-18, -54, -14", 10052));
            blocks.AddRange(GetBlockListByCoordinate("-17, -54, -14", 20001, "-6, -54, -14", 20012, new List<int> { 20003 }));
            blocks.AddRange(GetBlockListByCoordinate("-12, -54, -15", 20013, "-12, -54, -25", 20023, null, new List<int> { 20017 }, new List<int> { 20019 }, new List<int> { 20018 }));
            blocks.AddRange(GetBlockListByCoordinate("-6, -54, -15", 20024, "-6, -54, -25", 20034, null, new List<int> { 20028 }, new List<int> { 20030 }, new List<int> { 20029 }));
            blocks.AddRange(GetBlockListByCoordinate("-12, -54, -26", 20035, "6, -54, -26", 20053, new List<int> { 20044 }));
            blocks.AddRange(GetBlockListByCoordinate("0, -54, -27", 20054, "0, -54, -31", 20058, null, new List<int> { 20058 }));
            blocks.AddRange(GetBlockListByCoordinate("6, -54, -27", 20059, "6, -54, -31", 20063, null, new List<int> { 20063 }));
            blocks.AddRange(GetBlockListByCoordinate("0, -54, -39", 30001, "0, -54, -43", 30005, null, null, new List<int> { 30001 }));
            blocks.AddRange(GetBlockListByCoordinate("6, -54, -39", 30006, "6, -54, -43", 30010, null, null, new List<int> { 30006 }));
            blocks.AddRange(GetBlockListByCoordinate("0, -54, -44", 30011, "6, -54, -44", 30017));
            blocks.AddRange(GetBlockListByCoordinate("3, -54, -45", 30018, "3, -54, -53", 30026, new List<int> { 30026 }));
            blocks.AddRange(GetBlockListByCoordinate("-2, -54, -54", 30027, "8, -54, -54", 30037));
            blocks.AddRange(GetBlockListByCoordinate("-2, -54, -55", 30038, "-2, -54, -65", 30048, null, new List<int> { 30042 }, new List<int> { 30044 }, new List<int> { 30043 }));
            blocks.AddRange(GetBlockListByCoordinate("1, -54, -55", 30049, "1, -54, -71", 30065, null, new List<int> { 30053 }, new List<int> { 30055 }, new List<int> { 30054 }));
            blocks.AddRange(GetBlockListByCoordinate("5, -54, -55", 30066, "5, -54, -71", 30082, null, new List<int> { 30070 }, new List<int> { 30072 }, new List<int> { 30071 }));
            blocks.AddRange(GetBlockListByCoordinate("8, -54, -55", 30083, "8, -54, -66", 30094, null, new List<int> { 30087 }, new List<int> { 30089 }, new List<int> { 30088 }));
            blocks.AddRange(GetBlockListByCoordinate("-2, -54, -66", 31001, "0, -54, -66", 31003));
            blocks.AddRange(GetBlockListByCoordinate("2, -54, -66", 30097, "4, -54, -66", 30099));
            blocks.AddRange(GetBlockListByCoordinate("6, -54, -66", 30100, "7, -54, -66", 30101));
            blocks.AddRange(GetBlockListByCoordinate("5, -54, -72", 30102, "-4, -54, -72", 30111));
            blocks.AddRange(GetBlockListByCoordinate("-4, -54, -71", 30112, "-4, -54, -67 ", 30116, new List<int> { 30116 }));
            blocks.AddRange(GetBlockListByCoordinate("-5, -54, -67", 30117));
            blocks.AddRange(GetBlockListByCoordinate("-6, -54, -62", 30118, "-6, -54, -72", 30128));
            blocks.AddRange(GetBlockListByCoordinate("-7, -54, -72", 30175, "-18, -54, -72", 30186, null, new List<int> { 30175, 30179 }, new List<int> { 30177, 30181 }, new List<int> { 30176, 30180 }));
            blocks.AddRange(GetBlockListByCoordinate("-7, -54, -70", 30158, "-23, -54, -70", 30174, null, new List<int> { 30158, 30162 }, new List<int> { 30160, 30164 }, new List<int> { 30159, 30163 }));
            blocks.AddRange(GetBlockListByCoordinate("-7, -54, -64", 30141, "-23, -54, -64", 30157, null, new List<int> { 30141, 30145 }, new List<int> { 30143, 30147 }, new List<int> { 30142, 30146 }));
            blocks.AddRange(GetBlockListByCoordinate("-7, -54, -62", 30129, "-18, -54, -62", 30140, null, new List<int> { 30129, 30133 }, new List<int> { 30131, 30135 }, new List<int> { 30130, 30134 }));
            blocks.AddRange(GetBlockListByCoordinate("-18, -54, -63", 30194));
            blocks.AddRange(GetBlockListByCoordinate("-18, -54, -71", 30195));
            blocks.AddRange(GetBlockListByCoordinate("-10, -54, -63", 30187));
            blocks.AddRange(GetBlockListByCoordinate("-10, -54, -65", 30189, "-10, -54, -69", 30193));
            blocks.AddRange(GetBlockListByCoordinate("-10, -54, -71", 30188));
            blocks.AddRange(GetBlockListByCoordinate("-29, -58, -64", 40001, "-29, -58, -53", 40012, new List<int> { 40003 }, new List<int> { 40001 }));
            blocks.AddRange(GetBlockListByCoordinate("-28, -58, -59", 40013, "-18, -58, -59", 40023, null, new List<int> { 40017, 40023 }, new List<int> { 40019 }, new List<int> { 40018 }));
            blocks.AddRange(GetBlockListByCoordinate("-28, -58, -53", 40024, "-18, -58, -53", 40034, null, new List<int> { 40028, 40034 }, new List<int> { 40030 }, new List<int> { 40029 }));


            var result = blocks.Distinct().ToList();
            return result;
        }

        public List<Block> GetCorrectPosition()
        {
            var blocks = new Block();
            var seed = blocks.GetSeedBlockMap();

            if (seed == null || !seed.Any())
            {
                return new List<Block>();
            }

            var baseData = seed[0];

            //var transformedCoordinates = seed.Select(item =>
            //    new Block(item.X - baseData.X,
            //                   item.Y - baseData.Y,
            //                   item.Z - baseData.Z,
            //                   )).ToList();

            var transformedBase = seed.Select(item =>
                new Block { Id = item.Id, BlockId = item.BlockId, X = item.X - baseData.X, Y = item.Y - baseData.Y, Z = item.Z - baseData.Z, Type = item.Type, Function = item.Function }
            ).ToList();

            return transformedBase;
        }

        public static List<Block> GetCorrectPosition2(List<Block> blocks)
        {
            //var blocks = new Block();
            //var seed = blocks.GetSeedBlockMap();

            //if (seed == null || !seed.Any())
            //{
            //    return new List<Block>();
            //}

            var baseData = blocks[0];

            //var transformedCoordinates = seed.Select(item =>
            //    new Block(item.X - baseData.X,
            //                   item.Y - baseData.Y,
            //                   item.Z - baseData.Z,
            //                   )).ToList();

            var transformedBase = blocks.Select(item =>
                new Block { Id = item.Id, BlockId = item.BlockId, X = item.X - baseData.X, Y = item.Y - baseData.Y, Z = item.Z - baseData.Z, Type = item.Type, Function = item.Function }
            ).ToList();

            return transformedBase;
        }
    }
}