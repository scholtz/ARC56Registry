using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.Argimirodelpozo.puya_sol.HonkVerifier__Helper41_148f9599
{


    //
    // Helper contract 41 for HonkVerifier
    //
    public class HonkVerifier__Helper41Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HonkVerifier__Helper41Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return : AVMObjectType
            {
                public Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0 Field0 { get; set; } = new Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return();
                    uint count = 0;
                    ret.Field0 = Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return right)
                {
                    return !(left == right);
                }

            }

            public class RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0 : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field5 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field6 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field7 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field8 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field9 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field10 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field11 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field12 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field13 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field14 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field15 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field16 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field17 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field18 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field19 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field20 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field21 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField9.From(Field9);
                    ret.AddRange(vField9.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField10.From(Field10);
                    ret.AddRange(vField10.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField11 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField11.From(Field11);
                    ret.AddRange(vField11.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField12 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField12.From(Field12);
                    ret.AddRange(vField12.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField13 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField13.From(Field13);
                    ret.AddRange(vField13.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField14 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField14.From(Field14);
                    ret.AddRange(vField14.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField15 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField15.From(Field15);
                    ret.AddRange(vField15.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField16 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField16.From(Field16);
                    ret.AddRange(vField16.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField17 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField17.From(Field17);
                    ret.AddRange(vField17.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField18 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField18.From(Field18);
                    ret.AddRange(vField18.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField19 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField19.From(Field19);
                    ret.AddRange(vField19.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField20 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField20.From(Field20);
                    ret.AddRange(vField20.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField21 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField21.From(Field21);
                    ret.AddRange(vField21.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    var vField4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field4 = vField4;
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    var vField6 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field6 = vField6;
                    var vField7 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field7 = vField7;
                    var vField8 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field8 = vField8;
                    var vField9 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField9.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field9 = vField9;
                    var vField10 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField10.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field10 = vField10;
                    var vField11 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField11.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field11 = vField11;
                    var vField12 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField12.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field12 = vField12;
                    var vField13 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField13.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field13 = vField13;
                    var vField14 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField14.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field14 = vField14;
                    var vField15 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField15.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field15 = vField15;
                    var vField16 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField16.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field16 = vField16;
                    var vField17 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField17.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field17 = vField17;
                    var vField18 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField18.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field18 = vField18;
                    var vField19 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField19.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field19 = vField19;
                    var vField20 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField20.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field20 = vField20;
                    var vField21 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField21.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field21 = vField21;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0 left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0 right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0 left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk6ReturnField0 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="purportedEvaluations"> </param>
        /// <param name="alphas"> </param>
        /// <param name="evaluations"> </param>
        public async Task<Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return> RelationsLibAccumulateRelationEvaluationsChunk1Chunk6(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] alphas, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] evaluations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 196, 203, 20 };
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(40, "uint256"); purportedEvaluationsAbi.From(purportedEvaluations);
            var alphasAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(25, "uint256"); alphasAbi.From(alphas);
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(26, "uint256"); evaluationsAbi.From(evaluations);

            var result = await base.SimApp(new List<object> { abiHandle, purportedEvaluationsAbi, alphasAbi, evaluationsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk6Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RelationsLibAccumulateRelationEvaluationsChunk1Chunk6_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] alphas, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] evaluations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 196, 203, 20 };
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(40, "uint256"); purportedEvaluationsAbi.From(purportedEvaluations);
            var alphasAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(25, "uint256"); alphasAbi.From(alphas);
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(26, "uint256"); evaluationsAbi.From(evaluations);

            return await base.MakeTransactionList(new List<object> { abiHandle, purportedEvaluationsAbi, alphasAbi, evaluationsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="o"> </param>
        /// <param name="p"> </param>
        /// <param name="s"> </param>
        public async Task Init(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSG9ua1ZlcmlmaWVyX19IZWxwZXI0MSIsImRlc2MiOiJIZWxwZXIgY29udHJhY3QgNDEgZm9yIEhvbmtWZXJpZmllciIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc0NodW5rMUNodW5rNlJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc0NodW5rMUNodW5rNlJldHVybkZpZWxkMCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQyNTYifV0sIlJlbGF0aW9uc0xpYkFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zQ2h1bmsxQ2h1bms2UmV0dXJuRmllbGQwIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDciLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkOCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ5IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDExIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDE0IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDE1IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDE2IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDE3IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDE4IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDE5IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDIwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDIxIiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiUmVsYXRpb25zTGliLmFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zX19jaHVua18xX19jaHVua182IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTZbNDBdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVycG9ydGVkRXZhbHVhdGlvbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTZbMjVdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWxwaGFzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2WzI2XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2YWx1YXRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IigodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NiksdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlJlbGF0aW9uc0xpYkFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zQ2h1bmsxQ2h1bms2UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2luaXRfXyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzEwMl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzBdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyM10sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Nl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQyNTYsIDI1PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQyNTYsIDI2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQyNTYsIDQwPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNjksMzA3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNiw3MDksODQwLDEwMzIsMTIzMSwxNDM1LDE2ODgsMTg5NSwyMTAyLDIzMDEsMjQ5NywyNzMzLDI4NzAsMzAzMiwzMDQ0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqUXhMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRE15SURVM05pQTJOeklnTmpBNElEVTBOQ0ExTVRJZ05EZ3dJRFF4TmlBek5USWdNemcwSURZME1DQXlOVFlnTkRRNElESTRPQ0F6TWpBS0lDQWdJR0o1ZEdWallteHZZMnNnSW04aUlEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNU0FpY0NJZ01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXdDaUFnSUNCaUlGOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNKMWMzUXRhRzl1YXk5amIyNTBjbUZqZEhNdmVtdFdaWEpwWm1sbGNpNXpiMnd1VW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVvY0RvZ2RXbHVkRFkwTENCZmQybHlaVG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVU2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzYjJGa2N3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VZV1JrS0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtRmtaRG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXlkWE4wTFdodmJtc3ZZMjl1ZEhKaFkzUnpMM3ByVm1WeWFXWnBaWEl1YzI5c0xtMTFiQ2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwdGRXdzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1emRXSW9ZVG9nWW5sMFpYTXNJR0k2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYzNWaU9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVRNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZaTBLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNKMWMzUXRhRzl1YXk5amIyNTBjbUZqZEhNdmVtdFdaWEpwWm1sbGNpNXpiMnd1U0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJME1TNWZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYeWdwSUMwK0lIVnBiblEyTkRvS1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxODZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2dYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmWDE5aVlYSmxYMk55WldGMFpWOWZRRGdLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFkwWXpSallqRTBJREI0WVRrMlpXWTVPRGtnTHk4Z2JXVjBhRzlrSUNKU1pXeGhkR2x2Ym5OTWFXSXVZV05qZFcxMWJHRjBaVkpsYkdGMGFXOXVSWFpoYkhWaGRHbHZibk5mWDJOb2RXNXJYekZmWDJOb2RXNXJYellvZFdsdWRESTFObHMwTUYwc2RXbHVkREkxTmxzeU5WMHNkV2x1ZERJMU5sc3lObDBwS0NoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLU3gxYVc1ME1qVTJMSFZwYm5ReU5UWXBJaXdnYldWMGFHOWtJQ0pmWDJsdWFYUmZYeWgxYVc1ME5qUXNkV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHhYMTlqYUhWdWExODJJRjlmYVc1cGRGOWZDaUFnSUNCbGNuSUtDbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmWDE5ZlltRnlaVjlqY21WaGRHVmZYMEE0T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjblZ6ZEMxb2IyNXJMMk52Ym5SeVlXTjBjeTk2YTFabGNtbG1hV1Z5TG5OdmJDNUliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjalF4TGxKbGJHRjBhVzl1YzB4cFlpNWhZMk4xYlhWc1lYUmxVbVZzWVhScGIyNUZkbUZzZFdGMGFXOXVjMTlmWTJoMWJtdGZNVjlmWTJoMWJtdGZObHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2xKbGJHRjBhVzl1YzB4cFlpNWhZMk4xYlhWc1lYUmxVbVZzWVhScGIyNUZkbUZzZFdGMGFXOXVjMTlmWTJoMWJtdGZNVjlmWTJoMWJtdGZOam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE1qZ3dDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5ReU5UWXNJRFF3UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ3dNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME1qVTJMQ0F5TlQ0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWRESTFOaXdnTWpZK0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklGSmxiR0YwYVc5dWMweHBZaTVoWTJOMWJYVnNZWFJsVW1Wc1lYUnBiMjVGZG1Gc2RXRjBhVzl1YzE5ZlkyaDFibXRmTVY5ZlkyaDFibXRmTmw5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUcxMWMzUWdZbVVnWTJGc2JHVmtJR2x1SUdkeWIzVndDaUFnSUNCbmRIaHVJREFnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZFc1aGRYUm9iM0pwZW1Wa0lHTmhiR3hsY2dvZ0lDQWdaM1I0YmlBd0lGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhObGJtUmxjaUJ0YVhOdFlYUmphQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUJTWld4aGRHbHZibk5NYVdJdVlXTmpkVzExYkdGMFpWSmxiR0YwYVc5dVJYWmhiSFZoZEdsdmJuTmZYMk5vZFc1clh6RmZYMk5vZFc1clh6WmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJSEIxYzJoaWVYUmxjeUFpY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJ0WlhSb2IyUUtDbEpsYkdGMGFXOXVjMHhwWWk1aFkyTjFiWFZzWVhSbFVtVnNZWFJwYjI1RmRtRnNkV0YwYVc5dWMxOWZZMmgxYm10Zk1WOWZZMmgxYm10Zk5sOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JuYkc5aFpDQXhJREFLSUNBZ0lHZHNiMkZrSURJZ01Rb2dJQ0FnWjJ4dllXUWdNeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHZHNiMkZrSURNZ01Rb2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTWdOU0F2THlBMU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTJJQzh2SURRNE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTnlBdkx5QTBNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklEZ2dMeThnTXpVeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPQW9nSUNBZ2FXNTBZeUE1SUM4dklETTROQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTnpJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCd2RYTm9hVzUwSURNMUNpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCa2FXY2dPUW9nSUNBZ2NIVnphR2x1ZENBeU53b2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1kyRnNiSE4xWWlCemRXSUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpJREV3SUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JsZUhSeVlXTjBJREV5T0NBek1nb2dJQ0FnWkdsbklERTBDaUFnSUNCbGVIUnlZV04wSURFMk1DQXpNZ29nSUNBZ1pHbG5JREUxQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdhVzUwWTE4eklDOHZJRFl3T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTNDaUFnSUNCbGVIUnlZV04wSURFNU1pQXpNZ29nSUNBZ1pHbG5JREU0Q2lBZ0lDQnBiblJqSURFeElDOHZJREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTVDaUFnSUNCcGJuUmpJREV5SUM4dklEUTBPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JrYVdjZ01qRUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdScFp5QXlNZ29nSUNBZ1pYaDBjbUZqZENBNU5pQXpNZ29nSUNBZ1pHbG5JREl6Q2lBZ0lDQmxlSFJ5WVdOMElESXlOQ0F6TWdvZ0lDQWdaR2xuSURJMENpQWdJQ0JwYm5SaklERXpJQzh2SURJNE9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeU5Rb2dJQ0FnYVc1MFl5QTBJQzh2SURVME5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTmlBdkx5QTBPREFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklEY2dMeThnTkRFMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZeUE0SUM4dklETTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdNZ09TQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpYeklnTHk4Z05qY3lDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBeE5DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREV3SUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdWNGRISmhZM1FnTVRreUlETXlDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR01nTVRFZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdNVElnTHk4Z05EUTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkdsbklERTRDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHVjRkSEpoWTNRZ01qSTBJRE15Q2lBZ0lDQmthV2NnTWpNS0lDQWdJSEIxYzJocGJuUWdNemdLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeU5Bb2dJQ0FnY0hWemFHbHVkQ0F6TUFvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWTJGc2JITjFZaUJ6ZFdJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeU1nb2dJQ0FnWW53S0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nTkNBdkx5QTFORFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTlNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUEySUM4dklEUTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdNZ055QXZMeUEwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTBDaUFnSUNCcGJuUmpJRGdnTHk4Z016VXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWXlBNUlDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURFMElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJSE4xWWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JpZkFvZ0lDQWdaR2xuSURrS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdWNGRISmhZM1FnTVRreUlETXlDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR01nTVRFZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdNVElnTHk4Z05EUTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkdsbklERTRDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHVjRkSEpoWTNRZ01qSTBJRE15Q2lBZ0lDQmthV2NnTWpBS0lDQWdJR2x1ZEdNZ01UTWdMeThnTWpnNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURJeENpQWdJQ0JwYm5SaklEUWdMeThnTlRRMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEVWdMeThnTlRFeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEVTNOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdNZ05pQXZMeUEwT0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpJRGNnTHk4Z05ERTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWXlBeE5DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURFS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBd0NpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdZV1JrQ2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBeE15QXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUcxMWJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklEa0tJQ0FnSUdKOENpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR05mTWlBdkx5QTJOeklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYVc1MFl5QXhNQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QXhNd29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR05mTXlBdkx5QTJNRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ016SUtJQ0FnSUdScFp5QXhOZ29nSUNBZ2FXNTBZeUF4TVNBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE53b2dJQ0FnYVc1MFl5QXhNaUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURFNUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXlNUW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lIVnVZMjkyWlhJZ01qSUtJQ0FnSUdsdWRHTWdOQ0F2THlBMU5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTRJQzh2SURNMU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR01nTVRBZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFl5QTFJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTVNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMENpQWdJQ0JsZUhSeVlXTjBJREU1TWlBek1nb2dJQ0FnWkdsbklEa0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWkdsbklERXdDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdOaGJHeHpkV0lnYlhWc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBNENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURZS0lDQWdJR2x1ZEdNZ055QXZMeUEwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpJRGtnTHk4Z016ZzBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWTE4eUlDOHZJRFkzTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdNVFFnTHk4Z016SXdDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVElLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREV6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnTkRRNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdWNGRISmhZM1FnTWpJMElETXlDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdNamc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOVFEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ016QUtJQ0FnSUdOaGJHeHpkV0lnVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESXlOQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdjM1ZpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBMUlDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNU0F2THlBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURZZ0x5OGdORGd3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklEUUtJQ0FnSUdOaGJHeHpkV0lnYlhWc0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTmhiR3h6ZFdJZ2MzVmlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dOd29nSUNBZ1lud0tJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpJRGdnTHk4Z016VXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBNUlDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURFMElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdNVEFnTHk4Z05qUXdDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVElLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREV6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdWNGRISmhZM1FnTVRreUlETXlDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nTVRFZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdsdWRHTWdNVElnTHk4Z05EUTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkdsbklERTVDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdNamc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOVFEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTmlBdkx5QTBPREFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklEY2dMeThnTkRFMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZeUE0SUM4dklETTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdNZ09TQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpYeklnTHk4Z05qY3lDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBeE5DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREV3SUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdWNGRISmhZM1FnTVRreUlETXlDaUFnSUNCa2FXY2dNVGdLSUNBZ0lIQjFjMmhwYm5RZ016Y0tJQ0FnSUdOaGJHeHpkV0lnVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdZMkZzYkhOMVlpQnRkV3dLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF4TndvZ0lDQWdZbndLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdhVzUwWXlBeE1pQXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmthV2NnTVRnS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnWlhoMGNtRmpkQ0F5TWpRZ016SUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZeUF4TXlBdkx5QXlPRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nTkNBdkx5QTFORFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTlNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUEySUM4dklEUTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdNZ055QXZMeUEwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTBDaUFnSUNCcGJuUmpJRGdnTHk4Z016VXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWXlBNUlDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURFMElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTWdNVEFnTHk4Z05qUXdDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT1FvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR05mTXlBdkx5QTJNRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE13b2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ016SUtJQ0FnSUdScFp5QXhOQW9nSUNBZ2FXNTBZeUF4TVNBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnY0hWemFHbHVkQ0F6TmdvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWkdsbklESXlDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCallXeHNjM1ZpSUcxMWJBb2dJQ0FnWTJGc2JITjFZaUJoWkdRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE53b2dJQ0FnWW53S0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYVc1MFl5QXhNaUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURFM0NpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdhVzUwWXlBeE15QXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR2x1ZEdNZ05DQXZMeUExTkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05TQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBMklDOHZJRFE0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURnZ0x5OGdNelV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR05mTWlBdkx5QTJOeklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklERTBJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbHVkR01nTVRBZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1pYaDBjbUZqZENBeE5qQWdNeklLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR2x1ZEdOZk15QXZMeUEyTURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNd29nSUNBZ1pYaDBjbUZqZENBeE9USWdNeklLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdhVzUwWXlBeE1TQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhPUW9nSUNBZ2NIVnphR2x1ZENBek5Rb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ2RXNWpiM1psY2lBeU1nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdZMkZzYkhOMVlpQmhaR1FLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF4TndvZ0lDQWdZbndLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdhVzUwWXlBeE1pQXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmthV2NnTVRnS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnWlhoMGNtRmpkQ0F5TWpRZ016SUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZeUF4TXlBdkx5QXlPRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nTkNBdkx5QTFORFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTlNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUEySUM4dklEUTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdNZ055QXZMeUEwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTBDaUFnSUNCcGJuUmpJRGdnTHk4Z016VXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWXlBNUlDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURFMElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTWdNVEFnTHk4Z05qUXdDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT1FvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR05mTXlBdkx5QTJNRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE13b2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ016SUtJQ0FnSUdScFp5QXhPQW9nSUNBZ2NIVnphR2x1ZENBek9Bb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQnBiblJqSURFeElDOHZJREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTJGc2JITjFZaUJ6ZFdJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE53b2dJQ0FnWW53S0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYVc1MFl5QXhNaUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURFM0NpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdhVzUwWXlBeE15QXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR2x1ZEdNZ05DQXZMeUExTkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkQ0F6TndvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWkdsbklEVUtJQ0FnSUhCMWMyaHBiblFnTWprS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdOaGJHeHpkV0lnYzNWaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QTFJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklEWWdMeThnTkRnd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZeUEzSUM4dklEUXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdNZ09DQXZMeUF6TlRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpJREUwSUM4dklETXlNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQnRkV3dLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmpZV3hzYzNWaUlHRmtaQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdaR2xuSURjS0lDQWdJR2x1ZEdNZ01URWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXdDaUFnSUNCallXeHNjM1ZpSUcxMWJBb2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdZMkZzYkhOMVlpQmhaR1FLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBNUNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURnS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTnpJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJREV3SUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JsZUhSeVlXTjBJREV5T0NBek1nb2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURFMk1DQXpNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWTE4eklDOHZJRFl3T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCbGVIUnlZV04wSURFNU1pQXpNZ29nSUNBZ1pHbG5JREUxQ2lBZ0lDQnBiblJqSURFeUlDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTJDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURFNUNpQWdJQ0JsZUhSeVlXTjBJREl5TkNBek1nb2dJQ0FnWkdsbklESXdDaUFnSUNCcGJuUmpJREV6SUM4dklESTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlNUW9nSUNBZ2FXNTBZeUEwSUM4dklEVTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFVnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTWdOaUF2THlBME9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqSURjZ0x5OGdOREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QTRJQzh2SURNMU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nT1NBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5Salh6SWdMeThnTmpjeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUF4TkNBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5SaklERXdJQzh2SURZME1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRE15Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1Y0ZEhKaFkzUWdNVFl3SURNeUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpYek1nTHk4Z05qQTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURNeUNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHMTFiQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ2MzVmlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdWNGRISmhZM1FnTWpJMElETXlDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdNamc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOVFEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURrZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QXhNQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqSURFeUlDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdOZk1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpJRFlnTHk4Z05EZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBNElDOHZJRE0xTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBiblJqSURFMElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBeE13b2dJQ0FnYVc1MFkxOHpJQzh2SURZd09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQmxlSFJ5WVdOMElERTVNaUF6TWdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERXhJQzh2SURJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUyQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklERTVDaUFnSUNCbGVIUnlZV04wSURJeU5DQXpNZ29nSUNBZ1pHbG5JREl3Q2lBZ0lDQnBiblJqSURFeklDOHZJREk0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5TVFvZ0lDQWdhVzUwWXlBMElDOHZJRFUwTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QXlDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqUXhMbDlmYVc1cGRGOWZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWDE5cGJtbDBYMTg2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dZV3h5WldGa2VTQnBibWwwYVdGc2FYcGxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pReExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFQSU1BRW9BWGdCS0FFZ0FUZ0E2QUQ0QUtBQTRBRmdBTEFBNkFDd0FJbUJBRnZJREJrVG5MaE1hQXB1RkJGdG9HQldGMG9NK2hJZWJsd2tVUGg5WlB3QUFBQkFYQWdNR1JPY3VFeG9DbTRVRVcyZ1lGWVhTZ3o2RWg1dVhDUlErSDFrL0FBQUFCQ0FJS0tBZ0dCQ0srTC94WlFTUldCQ0FsYmkvNCtUQ0lMSWxpSmlnSUJpLzZMLzZBcHFvbUtBZ0dML292L295bXFpWW9DQVlBaEFUQmtUbkxoTWFBcHVGQkZ0b0dCV0Ywb00raEllYmx3a1VQaDlaUHdBQUFCaS8raGdDRUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDcWkvNmdLYXFKTVJ0QkFCMHhHUlJFTVJoRWdnSUVaTVRMRkFTcGJ2bUpOaG9BamdJQUNRcm5BREVaRkRFWUZCQkROaG9CRllHQUNoSkVOaG9DRllHZ0JoSkVOaG9ERllIQUJoSkVLR1JCQURJeUJJRUNEMFF6QUJnb1pCSkVNd0FBTVFBU1JDcGtRUUFaTVJhQkFRazRHQ3BrRWtReEZvRUJDVGthQUlBQmMyUVNSRG9CQURvQ0FUb0RBSUFBT2dNQlN3TWhCU0pZU3dRaklsaExCU0VHSWxoTEJpRUhJbGhMQnlFSUlsaExDQ0VKSWxoTENTUWlXRXNJZ1NPSS9zVkxDWUViaVA2K2lQN3FTUlVpRGtRaXIweExBYXRMRENFS0lsaExEVmVBSUVzT1Y2QWdTdzlYQUNCTEVDVWlXRXNSVjhBZ1N4SWhDeUpZU3hNaERDSllTeFJYSUNCTEZWZEFJRXNXVjJBZ1N4ZFg0Q0JMR0NFTklsaFBHU0VFSWxoUENrOEdVRThGVUU4RVVFOEpVRThJVUU4R1VFOERVRThFVUU4Q1VFOEZVRThJVUU4SFVFOEhVRThDVUU4R1VFOEhVRXhRVHdWUVRGQk1VRThDVUVraEJTSllTd0VqSWxoTEFpRUdJbGhMQXlFSElsaExCQ0VJSWxoTEJTRUpJbGhMQmlRaVdFc0hJUTRpV0VzSUlRb2lXRXNKVjRBZ1N3cFhvQ0JMQzFjQUlFc01KU0pZU3cxWHdDQkxEaUVMSWxoTER5RU1JbGhMRUZjZ0lFc1JWMEFnU3hKWFlDQkxFMWZnSUVzWGdTYUkvYlJMR0lFZWlQMnRpUDNaU1JVaURrUkxGcXRQRlNFRUlsaFBDazhHVUU4RlVFOEVVRThKVUU4SVVFOEdVRThEVUU4RVVFOENVRThGVUU4SFVFOEdVRThHVUU4Q1VFOEZVRThHVUV4UVR3UlFURkJNVUV4UVNTRUZJbGhMQVNNaVdFc0NJUVlpV0VzRElRY2lXRXNFSVFnaVdFc0ZJUWtpV0VzR0pDSllTd2NoRGlKWVNVc0JpUDFRU3dHSS9WWkpGU0lPUkVzS3Ewc0pWNEFnU3dwWG9DQkxDMWNBSUVzTUpTSllTdzFYd0NCTERpRUxJbGhMRHlFTUlsaExFRmNnSUVzUlYwQWdTeEpYWUNCTEUxZmdJRXNVSVEwaVdFOFZJUVFpV0U4S1R3WlFUd1ZRVHdSUVR3bFFUd2hRVHdaUVR3TlFUd1JRVHdKUVR3VlFUd2RRVHdaUVR3WlFUd0pRVHdWUVR3WlFURkJQQkZCTVVFeFFURkJKSVFVaVdFc0JJeUpZU3dJaEJpSllTd01oQnlKWVN3UWhEaUpZZ1FFV1N3RXJpUHljU3dHSS9JeExCeUVOSWxoTVN3R0kvSXRKRlNJT1JFc0pxMHNJSVFraVdFc0pKQ0pZU3dvaENpSllTd3RYZ0NCTERGZWdJRXNOVndBZ1N3NGxJbGhMRDFmQUlFc1FJUXNpV0VzUklRd2lXRXNTVnlBZ1N4TlhRQ0JMRkZkZ0lFc1ZWK0FnVHhZaEJDSllUd2xQQlZCUEJGQlBBMUJQQ0ZCUEIxQlBCVkJQQWxCUEExQlBDRkJQQ1ZCUEIxQlBCbEJQQjFCUEFsQlBCbEJQQjFCTVVFOEZVRXhRVEZCTVVFa2hDQ0pZU3dFaENpSllTd0loQlNKWVN3TWpJbGhMQkZmQUlFc0pnUUtJKzdCTENvRURpUHVwaVB2S1N3Rk1pUHZFU1JVaURrUkxDS3RMQmlFSElsaExCeUVKSWxoTENDUWlXRXNKSVE0aVdFc0tWNEFnU3d0WG9DQkxERmNBSUVzTkpTSllTdzRoQ3lKWVN3OGhEQ0pZU3hCWElDQkxFVmRBSUVzU1YyQWdTeE5YNENCTEZDRU5JbGhQRlNFRUlsaFBDVThHVUU4RlVFOEVVRThJVUU4SFVFOE1VRThEVUU4RVVFOENVRThFVUU4TFVFOEZVRThGVUU4Q1VFOEVVRThGVUV4UVR3TlFURkJQQWxCTVVFc0VnUjZJK3Z4TEFWZmdJRXhMQVlqN0lFc0NJUVVpV0VzREl5SllTd1FoQmlKWVN3TkxCSWo2L1U4RWlQc0RTUlVpRGtSTEI2dExCU0VJSWxoTEJpRUpJbGhMQnlRaVdFc0lJUTRpV0VzSklRb2lXRXNLVjRBZ1N3dFhvQ0JMREZjQUlFc05KU0pZU3c1WHdDQkxEeUVMSWxoTEVDRU1JbGhMRVZjZ0lFc1NWMEFnU3hOWFlDQkxGQ0VOSWxoUEZTRUVJbGhQQ1U4RlVFOEVVRThEVUU4SVVFOEhVRThGVUU4UFVFOEVVRThDVUU4RlVFOEhVRThHVUU4R1VFOENVRThGVUU4R1VFeFFUd1JRVEZCTVVFeFFTU0VGSWxoTEFTTWlXRXNDSVFZaVdFc0RJUWNpV0VzRUlRZ2lXRXNGSVFraVdFc0dKQ0pZU3djaERpSllTd2doQ2lKWVN3bFhnQ0JMQ2xlZ0lFc0xWd0FnU3d3bElsaExEVmZBSUVzU2dTV0krZDlMRlZkQUlJajUrMGtWSWc1RVN4R3JTdzhoRENKWVN4QlhJQ0JMRVZkQUlFc1NWMkFnU3hOWDRDQkxGQ0VOSWxoUEZTRUVJbGhQQ2s4R1VFOEZVRThFVUU4SlVFOElVRThHVUU4RFVFOEVVRThDVUU4RlVFOEhVRThHVUU4R1VFOENVRThGVUU4R1VFeFFUd1JRVEZCTVVFeFFTU0VGSWxoTEFTTWlXRXNDSVFZaVdFc0RJUWNpV0VzRUlRZ2lXRXNGSVFraVdFc0dKQ0pZU3djaERpSllTd2doQ2lKWVN3bFhnQ0JMQ2xlZ0lFc0xWd0FnU3d3bElsaExEVmZBSUVzT0lRc2lXRXNUZ1NTSStSTkxGbGNnSUlqNUw0ajVJVWtWSWc1RVN4R3JTdzhoRENKWVN4QlhJQ0JMRVZkQUlFc1NWMkFnU3hOWDRDQkxGQ0VOSWxoUEZTRUVJbGhQQ2s4R1VFOEZVRThFVUU4SlVFOElVRThHVUU4RFVFOEVVRThDVUU4RlVFOEhVRThHVUU4R1VFOENVRThGVUU4R1VFeFFUd1JRVEZCTVVFeFFTU0VGSWxoTEFTTWlXRXNDSVFZaVdFc0RJUWNpV0VzRUlRZ2lXRXNGSVFraVdFc0dKQ0pZU3djaERpSllTd2doQ2lKWVN3bFhnQ0JMQ2xlZ0lFc0xWd0FnU3d3bElsaExEVmZBSUVzT0lRc2lXRXNUZ1NPSStFUlBGbGNBSUlqNFlJajRVa2tWSWc1RVN4R3JTdzhoRENKWVN4QlhJQ0JMRVZkQUlFc1NWMkFnU3hOWDRDQkxGQ0VOSWxoUEZTRUVJbGhQQ2s4R1VFOEZVRThFVUU4SlVFOElVRThHVUU4RFVFOEVVRThDVUU4RlVFOEhVRThHVUU4R1VFOENVRThGVUU4R1VFeFFUd1JRVEZCTVVFeFFTU0VGSWxoTEFTTWlXRXNDSVFZaVdFc0RJUWNpV0VzRUlRZ2lXRXNGSVFraVdFc0dKQ0pZU3djaERpSllTd2doQ2lKWVN3bFhnQ0JMQ2xlZ0lFc0xWd0FnU3d3bElsaExEVmZBSUVzU2dTYUk5M3RMRHlFTElsaUk5NkZKRlNJT1JFc1JxMHNQSVF3aVdFc1FWeUFnU3hGWFFDQkxFbGRnSUVzVFYrQWdTeFFoRFNKWVR4VWhCQ0pZVHdwUEJsQlBCVkJQQkZCUENWQlBDRkJQQmxCUEExQlBCRkJQQWxCUEJWQlBCMUJQQmxCUEJsQlBBbEJQQlZCUEJsQk1VRThFVUV4UVRGQk1VRXNFZ1NXSTl3QkxCWUVkaVBiNWlQY2xTd0VoQlNKWVN3SWpJbGhMQXlFR0lsaExCQ0VISWxoTEJTRUlJbGhMQmlFT0lsaEpLNGoyOGtzSmlQYmlUd2VJOXVoTEJ5RUxJbGhKSzRqMjNVOEtpUGJOVHdKTWlQYlNTUlVpRGtSTENhdExDQ1FpV0VzSklRb2lXRXNLVjRBZ1N3dFhvQ0JMREZjQUlFc05KU0pZU3c1WHdDQkxEeUVNSWxoTEVGY2dJRXNSVjBBZ1N4SlhZQ0JMRTFmZ0lFc1VJUTBpV0U4VklRUWlXRThKVHdaUVR3VlFUd1JRVHdoUVR3ZFFUd1ZRVHdOUVR3aFFUd0pRVHdkUVR3ZFFUd1pRVHdaUVR3SlFUd1ZRVHdaUVRGQlBCRkJNVUV4UVRGQkpJUVVpV0VzQkl5SllTd0loQmlKWVN3TWhCeUpZU3dRaENDSllTd1VoQ1NKWVN3WWtJbGhMQnlFT0lsaExDQ0VLSWxoTENWZUFJRXNLVjZBZ1N3dFhBQ0JMRENVaVdFc05WOEFnU3c0aEN5SllTVXNCaVBYclN3R0k5ZkZKRlNJT1JFc1JxMHNRVnlBZ1N4RlhRQ0JMRWxkZ0lFc1RWK0FnU3hRaERTSllUeFVoQkNKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraENTSllTd0VoQ2lKWVN3SWhEQ0pZU3dNaEJ5SllUd2VCQjRqMVAwc0JUSWoxWFVrVklnNUVTd2FyU3dVaklsaExCaUVHSWxoTEJ5RUlJbGhMQ0NRaVdFc0pJUTRpV0VzS1Y0QWdTd3RYb0NCTERGY0FJRXNOSlNKWVN3NVh3Q0JMRHlFTElsaExFRmNnSUVzUlYwQWdTeEpYWUNCTEUxZmdJRXNVSVEwaVdFOFZJUVFpV0U4SlR3WlFUd1ZRVHdSUVR3aFFUd2RRVHdWUVR3TlFUd05RVHdKUVR3TlFUd1JRVHdwUVR3ZFFUd2RRVHdSUVR3VlFURkJQQTFCTVVFOENVRXhRU3dNVklnNUVUd05MQXF0UVN3SVZJZzVFVGdLclVJQUVGUjk4ZFV4UXNJRUJRellhQVVrVmdRZ1NSQmMyR2dKSkZZRUlFa1FYTmhvRFNZRUFXWUVDQ0VzQkZSSkVWd0lBS0dRVVJDaFBBMmNxVHdKbmdBRnpUR2VCQVVNPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
