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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.HonkVerifier__Helper35_50daed80
{


    //
    // Helper contract 35 for HonkVerifier
    //
    public class HonkVerifier__Helper35Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HonkVerifier__Helper35Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4 Field4 { get; set; } = new Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field5 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field6 { get; set; }

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
                    ret.AddRange(Field4.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return();
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
                    ret.Field4 = Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4.Parse(queue.ToArray());
                    { var consumedField4 = ret.Field4.ToByteArray().Length; for (int i = 0; i < consumedField4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    var vField6 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field6 = vField6;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return right)
                {
                    return !(left == right);
                }

            }

            public class RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4 : AVMObjectType
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

                public static RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4();
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
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4 left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4 right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4 left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk11ReturnField4 right)
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
        public async Task<Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return> RelationsLibAccumulateRelationEvaluationsChunk1Chunk11(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] alphas, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] evaluations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 132, 214, 107 };
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(40, "uint256"); purportedEvaluationsAbi.From(purportedEvaluations);
            var alphasAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(25, "uint256"); alphasAbi.From(alphas);
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(26, "uint256"); evaluationsAbi.From(evaluations);

            var result = await base.SimApp(new List<object> { abiHandle, purportedEvaluationsAbi, alphasAbi, evaluationsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk11Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RelationsLibAccumulateRelationEvaluationsChunk1Chunk11_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] alphas, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] evaluations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 132, 214, 107 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSG9ua1ZlcmlmaWVyX19IZWxwZXIzNSIsImRlc2MiOiJIZWxwZXIgY29udHJhY3QgMzUgZm9yIEhvbmtWZXJpZmllciIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc0NodW5rMUNodW5rMTFSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc0NodW5rMUNodW5rMTFSZXR1cm5GaWVsZDQifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJ1aW50MjU2In1dLCJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc0NodW5rMUNodW5rMTFSZXR1cm5GaWVsZDQiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDkiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTIiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTYiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTciLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMTkiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMjAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMjEiLCJ0eXBlIjoidWludDI1NiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJSZWxhdGlvbnNMaWIuYWNjdW11bGF0ZVJlbGF0aW9uRXZhbHVhdGlvbnNfX2NodW5rXzFfX2NodW5rXzExIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTZbNDBdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVycG9ydGVkRXZhbHVhdGlvbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTZbMjVdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWxwaGFzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2WzI2XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2YWx1YXRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LCh1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2KSx1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiUmVsYXRpb25zTGliQWNjdW11bGF0ZVJlbGF0aW9uRXZhbHVhdGlvbnNDaHVuazFDaHVuazExUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2luaXRfXyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzE5MF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzBdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyM10sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Nl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQyNTYsIDI1PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQyNTYsIDI2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQyNTYsIDQwPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNTcsMzE2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Nyw3MjAsODUxLDEwNDMsMTI0MiwxNDQ2LDE2OTksMTkwNiwyMTEzLDIzMTIsMjUwOCwyNzQ0LDI5MDksMzA3MSwzMDgyLDMwOTQsMzEwNiwzMTIwLDMxMzJdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pNMUxsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklETXlJRFUzTmlBMk56SWdOakE0SURVME5DQTFNVElnTkRnd0lEUXhOaUF6TlRJZ016ZzBJRFkwTUNBeU5UWWdORFE0SURJNE9DQXpNakFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbThpSURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01TQWljQ0lnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBd0NpQWdJQ0JpSUY5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZkNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VVbVZzWVhScGIyNXpUR2xpTG5kcGNtVW9jRG9nZFdsdWREWTBMQ0JmZDJseVpUb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tVbVZzWVhScGIyNXpUR2xpTG5kcGNtVTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNiMkZrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzSjFjM1F0YUc5dWF5OWpiMjUwY21GamRITXZlbXRXWlhKcFptbGxjaTV6YjJ3dVlXUmtLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21Ga1pEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5eWRYTjBMV2h2Ym1zdlkyOXVkSEpoWTNSekwzcHJWbVZ5YVdacFpYSXVjMjlzTG0xMWJDaGhPaUJpZVhSbGN5d2dZam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3B0ZFd3NkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzV6ZFdJb1lUb2dZbmwwWlhNc0lHSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjM1ZpT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNVE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpMEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEl6TlM1ZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh5Z3BJQzArSUhWcGJuUTJORG9LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4NkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZYMTlpWVhKbFgyTnlaV0YwWlY5ZlFEZ0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VETXdPRFJrTmpaaUlEQjRZVGsyWldZNU9Ea2dMeThnYldWMGFHOWtJQ0pTWld4aGRHbHZibk5NYVdJdVlXTmpkVzExYkdGMFpWSmxiR0YwYVc5dVJYWmhiSFZoZEdsdmJuTmZYMk5vZFc1clh6RmZYMk5vZFc1clh6RXhLSFZwYm5ReU5UWmJOREJkTEhWcGJuUXlOVFpiTWpWZExIVnBiblF5TlRaYk1qWmRLU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxDaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyS1N4MWFXNTBNalUyTEhWcGJuUXlOVFlwSWl3Z2JXVjBhRzlrSUNKZlgybHVhWFJmWHloMWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1VtVnNZWFJwYjI1elRHbGlMbUZqWTNWdGRXeGhkR1ZTWld4aGRHbHZia1YyWVd4MVlYUnBiMjV6WDE5amFIVnVhMTh4WDE5amFIVnVhMTh4TVNCZlgybHVhWFJmWHdvZ0lDQWdaWEp5Q2dwZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOWZYMkpoY21WZlkzSmxZWFJsWDE5QU9Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNKMWMzUXRhRzl1YXk5amIyNTBjbUZqZEhNdmVtdFdaWEpwWm1sbGNpNXpiMnd1U0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJek5TNVNaV3hoZEdsdmJuTk1hV0l1WVdOamRXMTFiR0YwWlZKbGJHRjBhVzl1UlhaaGJIVmhkR2x2Ym5OZlgyTm9kVzVyWHpGZlgyTm9kVzVyWHpFeFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tVbVZzWVhScGIyNXpUR2xpTG1GalkzVnRkV3hoZEdWU1pXeGhkR2x2YmtWMllXeDFZWFJwYjI1elgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4eE1Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TWpnd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblF5TlRZc0lEUXdQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnd01Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwTWpVMkxDQXlOVDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNE16SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERJMU5pd2dNalkrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUZKbGJHRjBhVzl1YzB4cFlpNWhZMk4xYlhWc1lYUmxVbVZzWVhScGIyNUZkbUZzZFdGMGFXOXVjMTlmWTJoMWJtdGZNVjlmWTJoMWJtdGZNVEZmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dVbVZzWVhScGIyNXpUR2xpTG1GalkzVnRkV3hoZEdWU1pXeGhkR2x2YmtWMllXeDFZWFJwYjI1elgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4eE1WOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnWTJoMWJtc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tVbVZzWVhScGIyNXpUR2xpTG1GalkzVnRkV3hoZEdWU1pXeGhkR2x2YmtWMllXeDFZWFJwYjI1elgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4eE1WOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JuYkc5aFpDQXhJREFLSUNBZ0lHZHNiMkZrSURJZ01Rb2dJQ0FnWjJ4dllXUWdNeUF3Q2lBZ0lDQm5iRzloWkNBeklERUtJQ0FnSUdkc2IyRmtJRFFnTUFvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCbmJHOWhaQ0EwSURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaMnh2WVdRZ05TQXdDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZeUExSUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdOZk1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpJRFlnTHk4Z05EZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBM0lDOHZJRFF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTWdPQ0F2THlBek5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBiblJqSURrZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQndkWE5vYVc1MElETTFDaUFnSUNCallXeHNjM1ZpSUZKbGJHRjBhVzl1YzB4cFlpNTNhWEpsQ2lBZ0lDQmthV2NnT1FvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdZMkZzYkhOMVlpQnpkV0lLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JREV6Q2lBZ0lDQnBiblJqSURFd0lDOHZJRFkwTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1pHbG5JREUxQ2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBeE53b2dJQ0FnYVc1MFkxOHpJQzh2SURZd09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElERTVNaUF6TWdvZ0lDQWdaR2xuSURFNUNpQWdJQ0JwYm5SaklERXhJQzh2SURJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREl3Q2lBZ0lDQnBiblJqSURFeUlDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESXhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dNaklLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUnBaeUF5TXdvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURJMENpQWdJQ0JsZUhSeVlXTjBJREl5TkNBek1nb2dJQ0FnWkdsbklESTFDaUFnSUNCcGJuUmpJREV6SUM4dklESTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlOZ29nSUNBZ2FXNTBZeUEwSUM4dklEVTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEVWdMeThnTlRFeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEVTNOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdNZ05pQXZMeUEwT0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpJRGNnTHk4Z05ERTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWXlBNElDOHZJRE0xTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdPU0F2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdOamN5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhOQ0F2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURFd0lDOHZJRFkwTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5Salh6TWdMeThnTmpBNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRE15Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR2x1ZEdNZ01URWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nTVRJZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhOd29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTVRrS0lDQWdJR1Y0ZEhKaFkzUWdNakkwSURNeUNpQWdJQ0JrYVdjZ01qTUtJQ0FnSUhCMWMyaHBiblFnTXpnS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdScFp5QXlOQW9nSUNBZ2NIVnphR2x1ZENBek1Bb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1kyRnNiSE4xWWlCemRXSUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXlNZ29nSUNBZ1lud0tJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR2x1ZEdNZ05DQXZMeUExTkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05TQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBMklDOHZJRFE0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURnZ0x5OGdNelV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR05mTWlBdkx5QTJOeklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklERTBJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCdGRXd0tJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUhOMVlnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklERXdDaUFnSUNCaWZBb2dJQ0FnWkdsbklEa0tJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5Salh6TWdMeThnTmpBNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRE15Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR2x1ZEdNZ01URWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nTVRJZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhOd29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTVRrS0lDQWdJR1Y0ZEhKaFkzUWdNakkwSURNeUNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z01qZzRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05UUTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFVnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTWdOaUF2THlBME9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqSURjZ0x5OGdOREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QXhOQ0F2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklERUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXdDaUFnSUNCallXeHNjM1ZpSUcxMWJBb2dJQ0FnWkdsbklERUtJQ0FnSUdOaGJHeHpkV0lnWVdSa0NpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhNeUF2THlBeU9EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHMTFiQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JRGtLSUNBZ0lHSjhDaUFnSUNCa2FXY2dPQW9nSUNBZ2FXNTBZeUE1SUM4dklETTROQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTnpJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2FXNTBZeUF4TUNBdkx5QTJOREFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdScFp5QXhNZ29nSUNBZ1pYaDBjbUZqZENBeE5qQWdNeklLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR2x1ZEdOZk15QXZMeUEyTURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOUW9nSUNBZ1pYaDBjbUZqZENBeE9USWdNeklLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdhVzUwWXlBeE1TQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOd29nSUNBZ2FXNTBZeUF4TWlBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklERTVDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCa2FXY2dNakFLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdaWGgwY21GamRDQXlNalFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNaklLSUNBZ0lHbHVkR01nTkNBdkx5QTFORFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUE0SUM4dklETTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdNZ01UQWdMeThnTmpRd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUExSUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURFNU1pQXpNZ29nSUNBZ1pHbG5JRGtLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdOaGJHeHpkV0lnVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVLSUNBZ0lHTmhiR3h6ZFdJZ2JYVnNDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCdGRXd0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTRDaUFnSUNCaWZBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURrZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFkxOHlJQzh2SURZM01nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR01nTVRRZ0x5OGdNekl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURFekNpQWdJQ0JwYm5Salh6TWdMeThnTmpBNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR01nTVRFZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdNVElnTHk4Z05EUTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkdsbklERTRDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHVjRkSEpoWTNRZ01qSTBJRE15Q2lBZ0lDQmthV2NnTWpBS0lDQWdJR2x1ZEdNZ01UTWdMeThnTWpnNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURJeENpQWdJQ0JwYm5SaklEUWdMeThnTlRRMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdNekFLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREl5TkNBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOaGJHeHpkV0lnYzNWaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFl5QTFJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTVNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5SaklEWWdMeThnTkRnd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHTmhiR3h6ZFdJZ2JYVnNDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdjM1ZpQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTndvZ0lDQWdZbndLSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqSURnZ0x5OGdNelV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGNLSUNBZ0lHbHVkR05mTWlBdkx5QTJOeklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5SaklERTBJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR01nTVRBZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURFekNpQWdJQ0JwYm5Salh6TWdMeThnTmpBNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRE15Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01URWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHbHVkR01nTVRJZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JREU1Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTWpBS0lDQWdJR2x1ZEdNZ01UTWdMeThnTWpnNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURJeENpQWdJQ0JwYm5SaklEUWdMeThnTlRRMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01UVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEVWdMeThnTlRFeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEVTNOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdNZ05pQXZMeUEwT0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpJRGNnTHk4Z05ERTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWXlBNElDOHZJRE0xTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdPU0F2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdOamN5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhOQ0F2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURFd0lDOHZJRFkwTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdWNGRISmhZM1FnTVRJNElETXlDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHVjRkSEpoWTNRZ01UWXdJRE15Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5Salh6TWdMeThnTmpBNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRE15Q2lBZ0lDQmthV2NnTVRnS0lDQWdJSEIxYzJocGJuUWdNemNLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeU5Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE53b2dJQ0FnWW53S0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYVc1MFl5QXhNaUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURFM0NpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdhVzUwWXlBeE15QXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR2x1ZEdNZ05DQXZMeUExTkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05TQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBMklDOHZJRFE0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURnZ0x5OGdNelV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR05mTWlBdkx5QTJOeklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklERTBJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbHVkR01nTVRBZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1pYaDBjbUZqZENBeE5qQWdNeklLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR2x1ZEdOZk15QXZMeUEyTURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNd29nSUNBZ1pYaDBjbUZqZENBeE9USWdNeklLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdhVzUwWXlBeE1TQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhPUW9nSUNBZ2NIVnphR2x1ZENBek5nb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JREkyQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmpZV3hzYzNWaUlHMTFiQW9nSUNBZ1kyRnNiSE4xWWlCaFpHUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXhOd29nSUNBZ1lud0tJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUF4TWlBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5nb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklERTNDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdaWGgwY21GamRDQXlNalFnTXpJS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnYVc1MFl5QXhNeUF2THlBeU9EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01qRUtJQ0FnSUdsdWRHTWdOQ0F2THlBMU5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOU0F2THlBMU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFl5QTJJQzh2SURRNE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR01nTnlBdkx5QTBNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5SaklEZ2dMeThnTXpVeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOUW9nSUNBZ2FXNTBZeUE1SUM4dklETTROQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURZS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTnpJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpJREUwSUM4dklETXlNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURnS0lDQWdJR2x1ZEdNZ01UQWdMeThnTmpRd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaWGgwY21GamRDQXhOakFnTXpJS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrYVdjZ01USUtJQ0FnSUdsdWRHTmZNeUF2THlBMk1EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdaWGgwY21GamRDQXhPVElnTXpJS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVc1MFl5QXhNU0F2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4T1FvZ0lDQWdjSFZ6YUdsdWRDQXpOUW9nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdkVzVqYjNabGNpQXlOZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCallXeHNjM1ZpSUcxMWJBb2dJQ0FnWTJGc2JITjFZaUJoWkdRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE53b2dJQ0FnWW53S0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYVc1MFl5QXhNaUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURFM0NpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdhVzUwWXlBeE15QXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR2x1ZEdNZ05DQXZMeUExTkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05TQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBMklDOHZJRFE0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURnZ0x5OGdNelV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR05mTWlBdkx5QTJOeklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklERTBJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbHVkR01nTVRBZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1pYaDBjbUZqZENBeE5qQWdNeklLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR2x1ZEdOZk15QXZMeUEyTURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNd29nSUNBZ1pYaDBjbUZqZENBeE9USWdNeklLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdjSFZ6YUdsdWRDQXpPQW9nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERXhJQzh2SURJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyRnNiSE4xWWlCemRXSUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXhOd29nSUNBZ1lud0tJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUF4TWlBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5nb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklERTNDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdaWGgwY21GamRDQXlNalFnTXpJS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnYVc1MFl5QXhNeUF2THlBeU9EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01qRUtJQ0FnSUdsdWRHTWdOQ0F2THlBMU5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBek53b2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5RZ01qa0tJQ0FnSUdOaGJHeHpkV0lnVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVLSUNBZ0lHTmhiR3h6ZFdJZ2MzVmlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZeUExSUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpJRFlnTHk4Z05EZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWXlBM0lDOHZJRFF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdPQ0F2THlBek5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURFMElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1JwWnlBNUNpQWdJQ0JqWVd4c2MzVmlJR0ZrWkFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCallXeHNjM1ZpSUcxMWJBb2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdNVEVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF3Q2lBZ0lDQmpZV3hzYzNWaUlHMTFiQW9nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnWTJGc2JITjFZaUJoWkdRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCdGRXd0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTVDaUFnSUNCaWZBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBiblJqSURFd0lDOHZJRFkwTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBeE13b2dJQ0FnYVc1MFkxOHpJQzh2SURZd09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQmxlSFJ5WVdOMElERTVNaUF6TWdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERXlJQzh2SURRME9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUyQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklERTVDaUFnSUNCbGVIUnlZV04wSURJeU5DQXpNZ29nSUNBZ1pHbG5JREl3Q2lBZ0lDQnBiblJqSURFeklDOHZJREk0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5TVFvZ0lDQWdhVzUwWXlBMElDOHZJRFUwTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTmlBdkx5QTBPREFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklEY2dMeThnTkRFMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZeUE0SUM4dklETTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdNZ09TQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpYeklnTHk4Z05qY3lDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBeE5DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREV3SUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdWNGRISmhZM1FnTVRreUlETXlDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR01nTVRFZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdjM1ZpQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVRjS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkdsbklERTRDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHVjRkSEpoWTNRZ01qSTBJRE15Q2lBZ0lDQmthV2NnTWpBS0lDQWdJR2x1ZEdNZ01UTWdMeThnTWpnNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURJeENpQWdJQ0JwYm5SaklEUWdMeThnTlRRMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEa2dMeThnTXpnMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QTJOREFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyRnNiSE4xWWlCdGRXd0tJQ0FnSUdOaGJHeHpkV0lnYlhWc0NpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFl5QXhNaUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURjZ0x5OGdOREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ2JYVnNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dOd29nSUNBZ1lud0tJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBMklDOHZJRFE0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTWdPQ0F2THlBek5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOamN5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTWdNVFFnTHk4Z016SXdDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01USUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREUwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdWNGRISmhZM1FnTVRreUlETXlDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHbHVkR01nTVRFZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JREU1Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTWpBS0lDQWdJR1Y0ZEhKaFkzUWdNakkwSURNeUNpQWdJQ0JrYVdjZ01qRUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z01qZzRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXlDaUFnSUNCcGJuUmpJRFFnTHk4Z05UUTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ053b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdaR2xuSURNS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTndvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1pHbG5JRFFLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCa2FXY2dOQW9nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXpDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzSjFjM1F0YUc5dWF5OWpiMjUwY21GamRITXZlbXRXWlhKcFptbGxjaTV6YjJ3dVNHOXVhMVpsY21sbWFXVnlYMTlJWld4d1pYSXpOUzVmWDJsdWFYUmZYMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2w5ZmFXNXBkRjlmT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJR0ZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqTTFMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBUElNQUVvQVhnQktBRWdBVGdBNkFENEFLQUE0QUZnQUxBQTZBQ3dBSW1CQUZ2SURCa1RuTGhNYUFwdUZCRnRvR0JXRjBvTStoSWVibHdrVVBoOVpQd0FBQUJBWEFnTUdST2N1RXhvQ200VUVXMmdZRllYU2d6NkVoNXVYQ1JRK0gxay9BQUFBQkNBSUtLQWdHQkNLK0wveFpRU1JXQkNBbGJpLzQrVENJTElsaUppZ0lCaS82TC82QXBxb21LQWdHTC9vdi9veW1xaVlvQ0FZQWhBVEJrVG5MaE1hQXB1RkJGdG9HQldGMG9NK2hJZWJsd2tVUGg5WlB3QUFBQmkvK2hnQ0VCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ3FpLzZnS2FxSk1SdEJBQjB4R1JSRU1SaEVnZ0lFTUlUV2F3U3Bidm1KTmhvQWpnSUFDUXMvQURFWkZERVlGQkJETmhvQkZZR0FDaEpFTmhvQ0ZZR2dCaEpFTmhvREZZSEFCaEpFS0dSQkFESXlCSUVDRDBRekFCZ29aQkpFTXdBQU1RQVNSQ3BrUVFBWk1SYUJBUWs0R0Nwa0VrUXhGb0VCQ1RrYUFJQUJjMlFTUkRvQkFEb0NBVG9EQURvREFUb0VBSUVBT2dRQmdBQTZCUUJMQkNFRklsaExCU01pV0VzR0lRWWlXRXNISVFjaVdFc0lJUWdpV0VzSklRa2lXRXNLSkNKWVN3aUJJNGordWtzSmdSdUkvck9JL3Q5SkZTSU9SQ0t2VEVzQnEwc05JUW9pV0VzT1Y0QWdTdzlYb0NCTEVGY0FJRXNSSlNKWVN4Slh3Q0JMRXlFTElsaExGQ0VNSWxoTEZWY2dJRXNXVjBBZ1N4ZFhZQ0JMR0ZmZ0lFc1pJUTBpV0U4YUlRUWlXRThLVHdaUVR3VlFUd1JRVHdsUVR3aFFUd1pRVHdOUVR3UlFUd0pRVHdWUVR3aFFUd2RRVHdkUVR3SlFUd1pRVHdkUVRGQlBCVkJNVUV4UVR3SlFTU0VGSWxoTEFTTWlXRXNDSVFZaVdFc0RJUWNpV0VzRUlRZ2lXRXNGSVFraVdFc0dKQ0pZU3djaERpSllTd2doQ2lKWVN3bFhnQ0JMQ2xlZ0lFc0xWd0FnU3d3bElsaExEVmZBSUVzT0lRc2lXRXNQSVF3aVdFc1FWeUFnU3hGWFFDQkxFbGRnSUVzVFYrQWdTeGVCSm9qOXFVc1lnUjZJL2FLSS9jNUpGU0lPUkVzV3EwOFZJUVFpV0U4S1R3WlFUd1ZRVHdSUVR3bFFUd2hRVHdaUVR3TlFUd1JRVHdKUVR3VlFUd2RRVHdaUVR3WlFUd0pRVHdWUVR3WlFURkJQQkZCTVVFeFFURkJKSVFVaVdFc0JJeUpZU3dJaEJpSllTd01oQnlKWVN3UWhDQ0pZU3dVaENTSllTd1lrSWxoTEJ5RU9JbGhKU3dHSS9VVkxBWWo5UzBrVklnNUVTd3FyU3dsWGdDQkxDbGVnSUVzTFZ3QWdTd3dsSWxoTERWZkFJRXNPSVFzaVdFc1BJUXdpV0VzUVZ5QWdTeEZYUUNCTEVsZGdJRXNUVitBZ1N4UWhEU0pZVHhVaEJDSllUd3BQQmxCUEJWQlBCRkJQQ1ZCUENGQlBCbEJQQTFCUEJGQlBBbEJQQlZCUEIxQlBCbEJQQmxCUEFsQlBCVkJQQmxCTVVFOEVVRXhRVEZCTVVFa2hCU0pZU3dFaklsaExBaUVHSWxoTEF5RUhJbGhMQkNFT0lsaUJBUlpMQVN1SS9KRkxBWWo4Z1VzSElRMGlXRXhMQVlqOGdFa1ZJZzVFU3dtclN3Z2hDU0pZU3dra0lsaExDaUVLSWxoTEMxZUFJRXNNVjZBZ1N3MVhBQ0JMRGlVaVdFc1BWOEFnU3hBaEN5SllTeEVoRENKWVN4SlhJQ0JMRTFkQUlFc1VWMkFnU3hWWDRDQlBGaUVFSWxoUENVOEZVRThFVUU4RFVFOElVRThIVUU4RlVFOENVRThEVUU4SVVFOEpVRThIVUU4R1VFOEhVRThDVUU4R1VFOEhVRXhRVHdWUVRGQk1VRXhRU1NFSUlsaExBU0VLSWxoTEFpRUZJbGhMQXlNaVdFc0VWOEFnU3dtQkFvajdwVXNLZ1FPSSs1NkkrNzlMQVV5SSs3bEpGU0lPUkVzSXEwc0dJUWNpV0VzSElRa2lXRXNJSkNKWVN3a2hEaUpZU3dwWGdDQkxDMWVnSUVzTVZ3QWdTdzBsSWxoTERpRUxJbGhMRHlFTUlsaExFRmNnSUVzUlYwQWdTeEpYWUNCTEUxZmdJRXNVSVEwaVdFOFZJUVFpV0U4SlR3WlFUd1ZRVHdSUVR3aFFUd2RRVHd4UVR3TlFUd1JRVHdKUVR3UlFUd3RRVHdWUVR3VlFUd0pRVHdSUVR3VlFURkJQQTFCTVVFOENVRXhRU3dTQkhvajY4VXNCVitBZ1RFc0JpUHNWU3dJaEJTSllTd01qSWxoTEJDRUdJbGhMQTBzRWlQcnlUd1NJK3ZoSkZTSU9SRXNIcTBzRklRZ2lXRXNHSVFraVdFc0hKQ0pZU3dnaERpSllTd2toQ2lKWVN3cFhnQ0JMQzFlZ0lFc01Wd0FnU3cwbElsaExEbGZBSUVzUElRc2lXRXNRSVF3aVdFc1JWeUFnU3hKWFFDQkxFMWRnSUVzVUlRMGlXRThWSVFRaVdFOEpUd1ZRVHdSUVR3TlFUd2hRVHdkUVR3VlFUdzlRVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSklRVWlXRXNCSXlKWVN3SWhCaUpZU3dNaEJ5SllTd1FoQ0NKWVN3VWhDU0pZU3dZa0lsaExCeUVPSWxoTENDRUtJbGhMQ1ZlQUlFc0tWNkFnU3d0WEFDQkxEQ1VpV0VzTlY4QWdTeEtCSllqNTFFc1pWMEFnaVBud1NSVWlEa1JMRWF0TER5RU1JbGhMRUZjZ0lFc1JWMEFnU3hKWFlDQkxFMWZnSUVzVUlRMGlXRThWSVFRaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSklRVWlXRXNCSXlKWVN3SWhCaUpZU3dNaEJ5SllTd1FoQ0NKWVN3VWhDU0pZU3dZa0lsaExCeUVPSWxoTENDRUtJbGhMQ1ZlQUlFc0tWNkFnU3d0WEFDQkxEQ1VpV0VzTlY4QWdTdzRoQ3lKWVN4T0JKSWo1Q0VzYVZ5QWdpUGtraVBrV1NSVWlEa1JMRWF0TER5RU1JbGhMRUZjZ0lFc1JWMEFnU3hKWFlDQkxFMWZnSUVzVUlRMGlXRThWSVFRaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSklRVWlXRXNCSXlKWVN3SWhCaUpZU3dNaEJ5SllTd1FoQ0NKWVN3VWhDU0pZU3dZa0lsaExCeUVPSWxoTENDRUtJbGhMQ1ZlQUlFc0tWNkFnU3d0WEFDQkxEQ1VpV0VzTlY4QWdTdzRoQ3lKWVN4T0JJNGo0T1U4YVZ3QWdpUGhWaVBoSFNSVWlEa1JMRWF0TER5RU1JbGhMRUZjZ0lFc1JWMEFnU3hKWFlDQkxFMWZnSUVzVUlRMGlXRThWSVFRaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSklRVWlXRXNCSXlKWVN3SWhCaUpZU3dNaEJ5SllTd1FoQ0NKWVN3VWhDU0pZU3dZa0lsaExCeUVPSWxoTENDRUtJbGhMQ1ZlQUlFc0tWNkFnU3d0WEFDQkxEQ1VpV0VzTlY4QWdTeEtCSm9qM2NFc1BJUXNpV0lqM2xra1ZJZzVFU3hHclN3OGhEQ0pZU3hCWElDQkxFVmRBSUVzU1YyQWdTeE5YNENCTEZDRU5JbGhQRlNFRUlsaFBDazhHVUU4RlVFOEVVRThKVUU4SVVFOEdVRThEVUU4RVVFOENVRThGVUU4SFVFOEdVRThHVUU4Q1VFOEZVRThHVUV4UVR3UlFURkJNVUV4UVN3U0JKWWoyOVVzRmdSMkk5dTZJOXhwTEFTRUZJbGhMQWlNaVdFc0RJUVlpV0VzRUlRY2lXRXNGSVFnaVdFc0dJUTRpV0VrcmlQYm5Td21JOXRkUEI0ajIzVXNISVFzaVdFa3JpUGJTVHdxSTlzSlBBa3lJOXNkSkZTSU9SRXNKcTBzSUpDSllTd2toQ2lKWVN3cFhnQ0JMQzFlZ0lFc01Wd0FnU3cwbElsaExEbGZBSUVzUElRd2lXRXNRVnlBZ1N4RlhRQ0JMRWxkZ0lFc1RWK0FnU3hRaERTSllUeFVoQkNKWVR3bFBCbEJQQlZCUEJGQlBDRkJQQjFCUEJWQlBBMUJQQ0ZCUEFsQlBCMUJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraEJTSllTd0VqSWxoTEFpRUdJbGhMQXlFSElsaExCQ0VJSWxoTEJTRUpJbGhMQmlRaVdFc0hJUTRpV0VzSUlRb2lXRXNKVjRBZ1N3cFhvQ0JMQzFjQUlFc01KU0pZU3cxWHdDQkxEaUVMSWxoSlN3R0k5ZUJMQVlqMTVra1ZJZzVFU3hHclN4QlhJQ0JMRVZkQUlFc1NWMkFnU3hOWDRDQkxGQ0VOSWxoUEZTRUVJbGhQQ2s4R1VFOEZVRThFVUU4SlVFOElVRThHVUU4RFVFOEVVRThDVUU4RlVFOEhVRThHVUU4R1VFOENVRThGVUU4R1VFeFFUd1JRVEZCTVVFeFFTU0VKSWxoTEFTRUtJbGhMQllFSGlQVkFTd0ZNaVBWZVN3YUJDb2oxTTA4SmlQVlNpUFZQU3dNaERDSllTd1FoQnlKWVR3aUJCNGoxR0VzQlRJajFOa2tWSWc1RVN3ZXJTd1lqSWxoTEJ5RUdJbGhMQ0NFSUlsaExDU1FpV0VzS0lRNGlXRXNMVjRBZ1N3eFhvQ0JMRFZjQUlFc09KU0pZU3c5WHdDQkxFQ0VMSWxoTEVWY2dJRXNTVjBBZ1N4TlhZQ0JMRkZmZ0lFc1ZJUTBpV0U4V0lRUWlXRThKVHdaUVR3VlFUd1JRVHdoUVR3ZFFUd1ZRVHdOUVR3TlFUd0pRVHdOUVR3UlFUd3RRVHdkUVR3ZFFUd1JRVHdWUVRGQlBBMUJNVUU4RFVFeFFTd2NWSWc1RVR3ZExBNnRMQnhVaURrUlBCMHNFcTFCTEJoVWlEa1JQQmtzRXExQkxBaFVpRGtSUEFrc0RxMUJNVUVzREZTSU9SRThEU3dLclVFc0NGU0lPUkU0Q3ExQ0FCQlVmZkhWTVVMQ0JBVU0yR2dGSkZZRUlFa1FYTmhvQ1NSV0JDQkpFRnpZYUEwbUJBRm1CQWdoTEFSVVNSRmNDQUNoa0ZFUW9Ud05uS2s4Q1o0QUJjMHhuZ1FGRCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
