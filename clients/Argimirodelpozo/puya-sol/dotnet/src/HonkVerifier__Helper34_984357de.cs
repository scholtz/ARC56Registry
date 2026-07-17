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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.HonkVerifier__Helper34_984357de
{


    //
    // Helper contract 34 for HonkVerifier
    //
    public class HonkVerifier__Helper34Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HonkVerifier__Helper34Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field4 { get; set; }

                public Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5 Field5 { get; set; } = new Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field6 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field7 { get; set; }

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
                    ret.AddRange(Field5.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return();
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
                    ret.Field5 = Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5.Parse(queue.ToArray());
                    { var consumedField5 = ret.Field5.ToByteArray().Length; for (int i = 0; i < consumedField5 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var vField6 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field6 = vField6;
                    var vField7 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field7 = vField7;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return right)
                {
                    return !(left == right);
                }

            }

            public class RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5 : AVMObjectType
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

                public static RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5();
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
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5 left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5 right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5 left, RelationsLibAccumulateRelationEvaluationsChunk1Chunk12ReturnField5 right)
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
        public async Task<Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return> RelationsLibAccumulateRelationEvaluationsChunk1Chunk12(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] alphas, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] evaluations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 241, 228, 105 };
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(40, "uint256"); purportedEvaluationsAbi.From(purportedEvaluations);
            var alphasAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(25, "uint256"); alphasAbi.From(alphas);
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>(26, "uint256"); evaluationsAbi.From(evaluations);

            var result = await base.SimApp(new List<object> { abiHandle, purportedEvaluationsAbi, alphasAbi, evaluationsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RelationsLibAccumulateRelationEvaluationsChunk1Chunk12Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RelationsLibAccumulateRelationEvaluationsChunk1Chunk12_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] alphas, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] evaluations, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 241, 228, 105 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSG9ua1ZlcmlmaWVyX19IZWxwZXIzNCIsImRlc2MiOiJIZWxwZXIgY29udHJhY3QgMzQgZm9yIEhvbmtWZXJpZmllciIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc0NodW5rMUNodW5rMTJSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6IlJlbGF0aW9uc0xpYkFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zQ2h1bmsxQ2h1bmsxMlJldHVybkZpZWxkNSJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6InVpbnQyNTYifV0sIlJlbGF0aW9uc0xpYkFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zQ2h1bmsxQ2h1bmsxMlJldHVybkZpZWxkNSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkOSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxMCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxMiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxMyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxNCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxNSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxNiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxNyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxOCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxOSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyMCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyMSIsInR5cGUiOiJ1aW50MjU2In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6IlJlbGF0aW9uc0xpYi5hY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc19fY2h1bmtfMV9fY2h1bmtfMTIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1Nls0MF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXJwb3J0ZWRFdmFsdWF0aW9ucyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NlsyNV0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbHBoYXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTZbMjZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZhbHVhdGlvbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NiwodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NiksdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlJlbGF0aW9uc0xpYkFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zQ2h1bmsxQ2h1bmsxMlJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMyMDVdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IGFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTZdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IG11c3QgYmUgY2FsbGVkIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMwXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjNdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHVuYXV0aG9yaXplZCBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDZdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgY2h1bmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjBdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE5OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50MjU2LCAyNT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50MjU2LCAyNj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50MjU2LCA0MD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTcyLDMxODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTAsNzIzLDg1NCwxMDQ2LDEyNDUsMTQ0OSwxNzAyLDE5MDksMjExNiwyMzE1LDI1MTEsMjc0NywyOTEyLDMwNzQsMzA4NSwzMDk3LDMxMDksMzEyMSwzMTM1LDMxNDddLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pNMExsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklETXlJRFUzTmlBMk56SWdOakE0SURVME5DQTFNVElnTkRnd0lEUXhOaUF6TlRJZ016ZzBJRFkwTUNBeU5UWWdORFE0SURJNE9DQXpNakFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbThpSURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01TQWljQ0lnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBd0NpQWdJQ0JpSUY5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZkNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VVbVZzWVhScGIyNXpUR2xpTG5kcGNtVW9jRG9nZFdsdWREWTBMQ0JmZDJseVpUb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tVbVZzWVhScGIyNXpUR2xpTG5kcGNtVTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNiMkZrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzSjFjM1F0YUc5dWF5OWpiMjUwY21GamRITXZlbXRXWlhKcFptbGxjaTV6YjJ3dVlXUmtLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21Ga1pEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5eWRYTjBMV2h2Ym1zdlkyOXVkSEpoWTNSekwzcHJWbVZ5YVdacFpYSXVjMjlzTG0xMWJDaGhPaUJpZVhSbGN5d2dZam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3B0ZFd3NkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzV6ZFdJb1lUb2dZbmwwWlhNc0lHSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjM1ZpT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNVE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpMEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEl6TkM1ZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh5Z3BJQzArSUhWcGJuUTJORG9LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4NkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZYMTlpWVhKbFgyTnlaV0YwWlY5ZlFEZ0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHUXhaakZsTkRZNUlEQjRZVGsyWldZNU9Ea2dMeThnYldWMGFHOWtJQ0pTWld4aGRHbHZibk5NYVdJdVlXTmpkVzExYkdGMFpWSmxiR0YwYVc5dVJYWmhiSFZoZEdsdmJuTmZYMk5vZFc1clh6RmZYMk5vZFc1clh6RXlLSFZwYm5ReU5UWmJOREJkTEhWcGJuUXlOVFpiTWpWZExIVnBiblF5TlRaYk1qWmRLU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc0tIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwTEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpTENCdFpYUm9iMlFnSWw5ZmFXNXBkRjlmS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCU1pXeGhkR2x2Ym5OTWFXSXVZV05qZFcxMWJHRjBaVkpsYkdGMGFXOXVSWFpoYkhWaGRHbHZibk5mWDJOb2RXNXJYekZmWDJOb2RXNXJYekV5SUY5ZmFXNXBkRjlmQ2lBZ0lDQmxjbklLQ2w5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlgxOWZZbUZ5WlY5amNtVmhkR1ZmWDBBNE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pNMExsSmxiR0YwYVc5dWMweHBZaTVoWTJOMWJYVnNZWFJsVW1Wc1lYUnBiMjVGZG1Gc2RXRjBhVzl1YzE5ZlkyaDFibXRmTVY5ZlkyaDFibXRmTVRKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncFNaV3hoZEdsdmJuTk1hV0l1WVdOamRXMTFiR0YwWlZKbGJHRjBhVzl1UlhaaGJIVmhkR2x2Ym5OZlgyTm9kVzVyWHpGZlgyTm9kVzVyWHpFeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREV5T0RBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkREkxTml3Z05EQStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0RBd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblF5TlRZc0lESTFQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwTWpVMkxDQXlOajRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHhYMTlqYUhWdWExOHhNbDloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJRzExYzNRZ1ltVWdZMkZzYkdWa0lHbHVJR2R5YjNWd0NpQWdJQ0JuZEhodUlEQWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkVzVoZFhSb2IzSnBlbVZrSUdOaGJHeGxjZ29nSUNBZ1ozUjRiaUF3SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQlNaV3hoZEdsdmJuTk1hV0l1WVdOamRXMTFiR0YwWlZKbGJHRjBhVzl1UlhaaGJIVmhkR2x2Ym5OZlgyTm9kVzVyWHpGZlgyTm9kVzVyWHpFeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0NncFNaV3hoZEdsdmJuTk1hV0l1WVdOamRXMTFiR0YwWlZKbGJHRjBhVzl1UlhaaGJIVmhkR2x2Ym5OZlgyTm9kVzVyWHpGZlgyTm9kVzVyWHpFeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR2RzYjJGa0lERWdNQW9nSUNBZ1oyeHZZV1FnTWlBeENpQWdJQ0JuYkc5aFpDQXpJREFLSUNBZ0lHZHNiMkZrSURNZ01Rb2dJQ0FnWjJ4dllXUWdOQ0F3Q2lBZ0lDQm5iRzloWkNBMElERUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdaMnh2WVdRZ05TQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdkc2IyRmtJRFVnTVFvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdNZ05TQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBMklDOHZJRFE0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURnZ0x5OGdNelV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOamN5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnY0hWemFHbHVkQ0F6TlFvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWkdsbklEa0tJQ0FnSUhCMWMyaHBiblFnTWpjS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdOaGJHeHpkV0lnYzNWaUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeE13b2dJQ0FnYVc1MFl5QXhNQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TkFvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHbHVkR05mTXlBdkx5QTJNRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ016SUtJQ0FnSUdScFp5QXhPUW9nSUNBZ2FXNTBZeUF4TVNBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnYVc1MFl5QXhNaUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5TVFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURJeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01qTUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXlOQW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lHUnBaeUF5TlFvZ0lDQWdhVzUwWXlBeE15QXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpZS0lDQWdJR2x1ZEdNZ05DQXZMeUExTkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUExSUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpJRFlnTHk4Z05EZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWXlBM0lDOHZJRFF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTWdPQ0F2THlBek5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqSURrZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFkxOHlJQzh2SURZM01nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGNLSUNBZ0lHbHVkR01nTVRRZ0x5OGdNekl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QXhNQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZMTh6SUM4dklEWXdPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JsZUhSeVlXTjBJREU1TWlBek1nb2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpJREV4SUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERXlJQzh2SURRME9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUyQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklERTVDaUFnSUNCbGVIUnlZV04wSURJeU5DQXpNZ29nSUNBZ1pHbG5JREl6Q2lBZ0lDQndkWE5vYVc1MElETTRDaUFnSUNCallXeHNjM1ZpSUZKbGJHRjBhVzl1YzB4cFlpNTNhWEpsQ2lBZ0lDQmthV2NnTWpRS0lDQWdJSEIxYzJocGJuUWdNekFLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR05oYkd4emRXSWdjM1ZpQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWpJS0lDQWdJR0o4Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05UUTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFVnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTWdOaUF2THlBME9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqSURjZ0x5OGdOREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QTRJQzh2SURNMU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nT1NBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5Salh6SWdMeThnTmpjeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUF4TkNBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdiWFZzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQnpkV0lLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdZbndLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZMTh6SUM4dklEWXdPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JsZUhSeVlXTjBJREU1TWlBek1nb2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpJREV4SUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERXlJQzh2SURRME9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUyQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklERTVDaUFnSUNCbGVIUnlZV04wSURJeU5DQXpNZ29nSUNBZ1pHbG5JREl3Q2lBZ0lDQnBiblJqSURFeklDOHZJREk0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5TVFvZ0lDQWdhVzUwWXlBMElDOHZJRFUwTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMUlDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqSURZZ0x5OGdORGd3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFl5QTNJQzh2SURReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR01nTVRRZ0x5OGdNekl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQnRkV3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHRmtaQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHbHVkR01nTVRNZ0x5OGdNamc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBNUNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURnS0lDQWdJR2x1ZEdNZ09TQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpYeklnTHk4Z05qY3lDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ01UQWdMeThnTmpRd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRE15Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR1Y0ZEhKaFkzUWdNVFl3SURNeUNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYek1nTHk4Z05qQTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURNeUNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR2x1ZEdNZ01USWdMeThnTkRRNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ01qRUtJQ0FnSUdWNGRISmhZM1FnTWpJMElETXlDaUFnSUNCMWJtTnZkbVZ5SURJeUNpQWdJQ0JwYm5SaklEUWdMeThnTlRRMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ09DQXZMeUF6TlRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpJREV3SUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdNZ05TQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQXhPVElnTXpJS0lDQWdJR1JwWnlBNUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdiWFZzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZbndLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURjZ0x5OGdOREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbHVkR05mTWlBdkx5QTJOeklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwYm5SaklERTBJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdaR2xuSURFeENpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERXlDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhNd29nSUNBZ2FXNTBZMTh6SUM4dklEWXdPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMENpQWdJQ0JwYm5SaklERXhJQzh2SURJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUxQ2lBZ0lDQnBiblJqSURFeUlDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTJDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURFNUNpQWdJQ0JsZUhSeVlXTjBJREl5TkNBek1nb2dJQ0FnWkdsbklESXdDaUFnSUNCcGJuUmpJREV6SUM4dklESTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlNUW9nSUNBZ2FXNTBZeUEwSUM4dklEVTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURNd0NpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlITjFZZ29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTlNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6RWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZeUEySUM4dklEUTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBMENpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUhOMVlnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklEY0tJQ0FnSUdKOENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTRJQzh2SURNMU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nT1NBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5Salh6SWdMeThnTmpjeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPQW9nSUNBZ2FXNTBZeUF4TkNBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwYm5SaklERXdJQzh2SURZME1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdaR2xuSURFeENpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERXlDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhNd29nSUNBZ2FXNTBZMTh6SUM4dklEWXdPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMENpQWdJQ0JsZUhSeVlXTjBJREU1TWlBek1nb2dJQ0FnWkdsbklERTFDaUFnSUNCcGJuUmpJREV4SUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JwYm5SaklERXlJQzh2SURRME9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQmthV2NnTVRnS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBek1nb2dJQ0FnWkdsbklESXdDaUFnSUNCcGJuUmpJREV6SUM4dklESTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlNUW9nSUNBZ2FXNTBZeUEwSUM4dklEVTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUxQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUExSUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpJRFlnTHk4Z05EZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWXlBM0lDOHZJRFF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTWdPQ0F2THlBek5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqSURrZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFkxOHlJQzh2SURZM01nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGNLSUNBZ0lHbHVkR01nTVRRZ0x5OGdNekl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QXhNQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JsZUhSeVlXTjBJREUyTUNBek1nb2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZMTh6SUM4dklEWXdPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JsZUhSeVlXTjBJREU1TWlBek1nb2dJQ0FnWkdsbklERTRDaUFnSUNCd2RYTm9hVzUwSURNM0NpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCa2FXY2dNallLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHTmhiR3h6ZFdJZ2JYVnNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nTVRJZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhOd29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTVRrS0lDQWdJR1Y0ZEhKaFkzUWdNakkwSURNeUNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z01qZzRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05UUTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFVnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTWdOaUF2THlBME9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqSURjZ0x5OGdOREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QTRJQzh2SURNMU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nT1NBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5Salh6SWdMeThnTmpjeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUF4TkNBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5SaklERXdJQzh2SURZME1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRE15Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1Y0ZEhKaFkzUWdNVFl3SURNeUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpYek1nTHk4Z05qQTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURNeUNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRrS0lDQWdJSEIxYzJocGJuUWdNellLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeU53b2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR05oYkd4emRXSWdZV1JrQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVRjS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnTkRRNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdWNGRISmhZM1FnTWpJMElETXlDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdNamc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOVFEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTmlBdkx5QTBPREFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklEY2dMeThnTkRFMkNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZeUE0SUM4dklETTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdNZ09TQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpYeklnTHk4Z05qY3lDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBeE5DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREV3SUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOakE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdWNGRISmhZM1FnTVRreUlETXlDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR01nTVRFZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUhCMWMyaHBiblFnTXpVS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUhWdVkyOTJaWElnTWpjS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZMkZzYkhOMVlpQnRkV3dLSUNBZ0lHTmhiR3h6ZFdJZ1lXUmtDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nTVRJZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhOd29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmthV2NnTVRrS0lDQWdJR1Y0ZEhKaFkzUWdNakkwSURNeUNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z01qZzRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05UUTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFVnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTWdOaUF2THlBME9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqSURjZ0x5OGdOREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QTRJQzh2SURNMU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nT1NBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5Salh6SWdMeThnTmpjeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUF4TkNBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5SaklERXdJQzh2SURZME1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRE15Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1Y0ZEhKaFkzUWdNVFl3SURNeUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpYek1nTHk4Z05qQTRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURNeUNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUhCMWMyaHBiblFnTXpnS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUF4TVNBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR05oYkd4emRXSWdjM1ZpQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVRjS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnTkRRNENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdWNGRISmhZM1FnTWpJMElETXlDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdNamc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOVFEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdNemNLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJREk1Q2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JqWVd4c2MzVmlJSE4xWWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdNZ05TQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWXlBMklDOHZJRFE0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqSURnZ0x5OGdNelV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFl5QXhOQ0F2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREFLSUNBZ0lHTmhiR3h6ZFdJZ2JYVnNDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyRnNiSE4xWWlCaFpHUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMkZzYkhOMVlpQnRkV3dLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURFeElDOHZJREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHTmhiR3h6ZFdJZ1lXUmtDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdiWFZzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnT1FvZ0lDQWdZbndLSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOamN5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnYVc1MFl5QXhNQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaWGgwY21GamRDQXhNamdnTXpJS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0F4TmpBZ016SUtJQ0FnSUdScFp5QXhNZ29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHbHVkR05mTXlBdkx5QTJNRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ016SUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUF4TWlBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5nb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklERTNDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdaWGgwY21GamRDQXlNalFnTXpJS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnYVc1MFl5QXhNeUF2THlBeU9EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01qRUtJQ0FnSUdsdWRHTWdOQ0F2THlBMU5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTFJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5SaklEWWdMeThnTkRnd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZeUEzSUM4dklEUXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdNZ09DQXZMeUF6TlRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpJRGtnTHk4Z016ZzBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWTE4eUlDOHZJRFkzTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdNVFFnTHk4Z016SXdDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWXlBeE1DQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdaR2xuSURFeENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFkxOHpJQzh2SURZd09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV6Q2lBZ0lDQmxlSFJ5WVdOMElERTVNaUF6TWdvZ0lDQWdaR2xuSURFMENpQWdJQ0JwYm5SaklERXhJQzh2SURJMU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCdGRXd0tJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUhOMVlnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklERTNDaUFnSUNCaWZBb2dJQ0FnWkdsbklERTJDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURFNUNpQWdJQ0JsZUhSeVlXTjBJREl5TkNBek1nb2dJQ0FnWkdsbklESXdDaUFnSUNCcGJuUmpJREV6SUM4dklESTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlNUW9nSUNBZ2FXNTBZeUEwSUM4dklEVTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUE1SUM4dklETTROQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdNZ01UQWdMeThnTmpRd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUF4TWlBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRzExYkFvZ0lDQWdaR2xuSURjS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHTmhiR3h6ZFdJZ2JYVnNDaUFnSUNCallXeHNjM1ZpSUcxMWJBb2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTWdOeUF2THlBME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJ0ZFd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBM0NpQWdJQ0JpZkFvZ0lDQWdaR2xuSURZS0lDQWdJR2x1ZEdOZk1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpJRFlnTHk4Z05EZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWXlBNElDOHZJRE0xTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTmZNaUF2THlBMk56SUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWXlBeE5DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaWGgwY21GamRDQXhOakFnTXpJS0lDQWdJR1JwWnlBeE13b2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdsdWRHTmZNeUF2THlBMk1EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TlFvZ0lDQWdaWGgwY21GamRDQXhPVElnTXpJS0lDQWdJR1JwWnlBeE5nb2dJQ0FnYVc1MFl5QXhNU0F2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXlNQW9nSUNBZ1pYaDBjbUZqZENBeU1qUWdNeklLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdhVzUwWXlBeE15QXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpJS0lDQWdJR2x1ZEdNZ05DQXZMeUExTkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCa2FXY2dNd29nSUNBZ1lud0tJQ0FnSUdScFp5QTRDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEY0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR1JwWnlBMENpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdaR2xuSURRS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl5ZFhOMExXaHZibXN2WTI5dWRISmhZM1J6TDNwclZtVnlhV1pwWlhJdWMyOXNMa2h2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TXpRdVgxOXBibWwwWDE5YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZYMmx1YVhSZlh6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCaGJISmxZV1I1SUdsdWFYUnBZV3hwZW1Wa0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0NJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjblZ6ZEMxb2IyNXJMMk52Ym5SeVlXTjBjeTk2YTFabGNtbG1hV1Z5TG5OdmJDNUliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjak0wTG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQVBJTUFFb0FYZ0JLQUVnQVRnQTZBRDRBS0FBNEFGZ0FMQUE2QUN3QUltQkFGdklEQmtUbkxoTWFBcHVGQkZ0b0dCV0Ywb00raEllYmx3a1VQaDlaUHdBQUFCQVhBZ01HUk9jdUV4b0NtNFVFVzJnWUZZWFNnejZFaDV1WENSUStIMWsvQUFBQUJDQUlLS0FnR0JDSytML3haUVNSV0JDQWxiaS80K1RDSUxJbGlKaWdJQmkvNkwvNkFwcW9tS0FnR0wvb3Yvb3ltcWlZb0NBWUFoQVRCa1RuTGhNYUFwdUZCRnRvR0JXRjBvTStoSWVibHdrVVBoOVpQd0FBQUJpLytoZ0NFQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNxaS82Z0thcUpNUnRCQUIweEdSUkVNUmhFZ2dJRTBmSGthUVNwYnZtSk5ob0FqZ0lBQ1F0T0FERVpGREVZRkJCRE5ob0JGWUdBQ2hKRU5ob0NGWUdnQmhKRU5ob0RGWUhBQmhKRUtHUkJBREl5QklFQ0QwUXpBQmdvWkJKRU13QUFNUUFTUkNwa1FRQVpNUmFCQVFrNEdDcGtFa1F4Rm9FQkNUa2FBSUFCYzJRU1JEb0JBRG9DQVRvREFEb0RBVG9FQURvRUFZRUFPZ1VBZ0FBNkJRRkxCQ0VGSWxoTEJTTWlXRXNHSVFZaVdFc0hJUWNpV0VzSUlRZ2lXRXNKSVFraVdFc0tKQ0pZU3dpQkk0ait0MHNKZ1J1SS9yQ0kvdHhKRlNJT1JDS3ZURXNCcTBzTklRb2lXRXNPVjRBZ1N3OVhvQ0JMRUZjQUlFc1JKU0pZU3hKWHdDQkxFeUVMSWxoTEZDRU1JbGhMRlZjZ0lFc1dWMEFnU3hkWFlDQkxHRmZnSUVzWklRMGlXRThhSVFRaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdoUVR3ZFFUd2RRVHdKUVR3WlFUd2RRVEZCUEJWQk1VRXhRVHdKUVNTRUZJbGhMQVNNaVdFc0NJUVlpV0VzRElRY2lXRXNFSVFnaVdFc0ZJUWtpV0VzR0pDSllTd2NoRGlKWVN3Z2hDaUpZU3dsWGdDQkxDbGVnSUVzTFZ3QWdTd3dsSWxoTERWZkFJRXNPSVFzaVdFc1BJUXdpV0VzUVZ5QWdTeEZYUUNCTEVsZGdJRXNUVitBZ1N4ZUJKb2o5cGtzWWdSNkkvWitJL2N0SkZTSU9SRXNXcTA4VklRUWlXRThLVHdaUVR3VlFUd1JRVHdsUVR3aFFUd1pRVHdOUVR3UlFUd0pRVHdWUVR3ZFFUd1pRVHdaUVR3SlFUd1ZRVHdaUVRGQlBCRkJNVUV4UVRGQkpJUVVpV0VzQkl5SllTd0loQmlKWVN3TWhCeUpZU3dRaENDSllTd1VoQ1NKWVN3WWtJbGhMQnlFT0lsaEpTd0dJL1VKTEFZajlTRWtWSWc1RVN3cXJTd2xYZ0NCTENsZWdJRXNMVndBZ1N3d2xJbGhMRFZmQUlFc09JUXNpV0VzUElRd2lXRXNRVnlBZ1N4RlhRQ0JMRWxkZ0lFc1RWK0FnU3hRaERTSllUeFVoQkNKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraEJTSllTd0VqSWxoTEFpRUdJbGhMQXlFSElsaExCQ0VPSWxpQkFSWkxBU3VJL0k1TEFZajhma3NISVEwaVdFeExBWWo4ZlVrVklnNUVTd21yU3dnaENTSllTd2trSWxoTENpRUtJbGhMQzFlQUlFc01WNkFnU3cxWEFDQkxEaVVpV0VzUFY4QWdTeEFoQ3lKWVN4RWhEQ0pZU3hKWElDQkxFMWRBSUVzVVYyQWdTeFZYNENCUEZpRUVJbGhQQ1U4RlVFOEVVRThEVUU4SVVFOEhVRThGVUU4Q1VFOERVRThJVUU4SlVFOEhVRThHVUU4SFVFOENVRThHVUU4SFVFeFFUd1ZRVEZCTVVFeFFTU0VJSWxoTEFTRUtJbGhMQWlFRklsaExBeU1pV0VzRVY4QWdTd21CQW9qN29rc0tnUU9JKzV1SSs3eExBVXlJKzdaSkZTSU9SRXNJcTBzR0lRY2lXRXNISVFraVdFc0lKQ0pZU3draERpSllTd3BYZ0NCTEMxZWdJRXNNVndBZ1N3MGxJbGhMRGlFTElsaExEeUVNSWxoTEVGY2dJRXNSVjBBZ1N4SlhZQ0JMRTFmZ0lFc1VJUTBpV0U4VklRUWlXRThKVHdaUVR3VlFUd1JRVHdoUVR3ZFFUd3hRVHdOUVR3UlFUd0pRVHdSUVR3dFFUd1ZRVHdWUVR3SlFUd1JRVHdWUVRGQlBBMUJNVUU4Q1VFeFFTd1NCSG9qNjdrc0JWK0FnVEVzQmlQc1NTd0loQlNKWVN3TWpJbGhMQkNFR0lsaExBMHNFaVBydlR3U0krdlZKRlNJT1JFc0hxMHNGSVFnaVdFc0dJUWtpV0VzSEpDSllTd2doRGlKWVN3a2hDaUpZU3dwWGdDQkxDMWVnSUVzTVZ3QWdTdzBsSWxoTERsZkFJRXNQSVFzaVdFc1FJUXdpV0VzUlZ5QWdTeEpYUUNCTEUxZGdJRXNVSVEwaVdFOFZJUVFpV0U4SlR3VlFUd1JRVHdOUVR3aFFUd2RRVHdWUVR3OVFUd1JRVHdKUVR3VlFUd2RRVHdaUVR3WlFUd0pRVHdWUVR3WlFURkJQQkZCTVVFeFFURkJKSVFVaVdFc0JJeUpZU3dJaEJpSllTd01oQnlKWVN3UWhDQ0pZU3dVaENTSllTd1lrSWxoTEJ5RU9JbGhMQ0NFS0lsaExDVmVBSUVzS1Y2QWdTd3RYQUNCTERDVWlXRXNOVjhBZ1N4S0JKWWo1MFVzYVYwQWdpUG50U1JVaURrUkxFYXRMRHlFTUlsaExFRmNnSUVzUlYwQWdTeEpYWUNCTEUxZmdJRXNVSVEwaVdFOFZJUVFpV0U4S1R3WlFUd1ZRVHdSUVR3bFFUd2hRVHdaUVR3TlFUd1JRVHdKUVR3VlFUd2RRVHdaUVR3WlFUd0pRVHdWUVR3WlFURkJQQkZCTVVFeFFURkJKSVFVaVdFc0JJeUpZU3dJaEJpSllTd01oQnlKWVN3UWhDQ0pZU3dVaENTSllTd1lrSWxoTEJ5RU9JbGhMQ0NFS0lsaExDVmVBSUVzS1Y2QWdTd3RYQUNCTERDVWlXRXNOVjhBZ1N3NGhDeUpZU3hPQkpJajVCVXNiVnlBZ2lQa2hpUGtUU1JVaURrUkxFYXRMRHlFTUlsaExFRmNnSUVzUlYwQWdTeEpYWUNCTEUxZmdJRXNVSVEwaVdFOFZJUVFpV0U4S1R3WlFUd1ZRVHdSUVR3bFFUd2hRVHdaUVR3TlFUd1JRVHdKUVR3VlFUd2RRVHdaUVR3WlFUd0pRVHdWUVR3WlFURkJQQkZCTVVFeFFURkJKSVFVaVdFc0JJeUpZU3dJaEJpSllTd01oQnlKWVN3UWhDQ0pZU3dVaENTSllTd1lrSWxoTEJ5RU9JbGhMQ0NFS0lsaExDVmVBSUVzS1Y2QWdTd3RYQUNCTERDVWlXRXNOVjhBZ1N3NGhDeUpZU3hPQkk0ajROazhiVndBZ2lQaFNpUGhFU1JVaURrUkxFYXRMRHlFTUlsaExFRmNnSUVzUlYwQWdTeEpYWUNCTEUxZmdJRXNVSVEwaVdFOFZJUVFpV0U4S1R3WlFUd1ZRVHdSUVR3bFFUd2hRVHdaUVR3TlFUd1JRVHdKUVR3VlFUd2RRVHdaUVR3WlFUd0pRVHdWUVR3WlFURkJQQkZCTVVFeFFURkJKSVFVaVdFc0JJeUpZU3dJaEJpSllTd01oQnlKWVN3UWhDQ0pZU3dVaENTSllTd1lrSWxoTEJ5RU9JbGhMQ0NFS0lsaExDVmVBSUVzS1Y2QWdTd3RYQUNCTERDVWlXRXNOVjhBZ1N4S0JKb2ozYlVzUElRc2lXSWozazBrVklnNUVTeEdyU3c4aERDSllTeEJYSUNCTEVWZEFJRXNTVjJBZ1N4Tlg0Q0JMRkNFTklsaFBGU0VFSWxoUENrOEdVRThGVUU4RVVFOEpVRThJVUU4R1VFOERVRThFVUU4Q1VFOEZVRThIVUU4R1VFOEdVRThDVUU4RlVFOEdVRXhRVHdSUVRGQk1VRXhRU3dTQkpZajI4a3NGZ1IySTl1dUk5eGRMQVNFRklsaExBaU1pV0VzRElRWWlXRXNFSVFjaVdFc0ZJUWdpV0VzR0lRNGlXRWtyaVBia1N3bUk5dFJQQjRqMjJrc0hJUXNpV0VrcmlQYlBUd3FJOXI5UEFreUk5c1JKRlNJT1JFc0pxMHNJSkNKWVN3a2hDaUpZU3dwWGdDQkxDMWVnSUVzTVZ3QWdTdzBsSWxoTERsZkFJRXNQSVF3aVdFc1FWeUFnU3hGWFFDQkxFbGRnSUVzVFYrQWdTeFFoRFNKWVR4VWhCQ0pZVHdsUEJsQlBCVkJQQkZCUENGQlBCMUJQQlZCUEExQlBDRkJQQWxCUEIxQlBCMUJQQmxCUEJsQlBBbEJQQlZCUEJsQk1VRThFVUV4UVRGQk1VRWtoQlNKWVN3RWpJbGhMQWlFR0lsaExBeUVISWxoTEJDRUlJbGhMQlNFSklsaExCaVFpV0VzSElRNGlXRXNJSVFvaVdFc0pWNEFnU3dwWG9DQkxDMWNBSUVzTUpTSllTdzFYd0NCTERpRUxJbGhKU3dHSTlkMUxBWWoxNDBrVklnNUVTeEdyU3hCWElDQkxFVmRBSUVzU1YyQWdTeE5YNENCTEZDRU5JbGhQRlNFRUlsaFBDazhHVUU4RlVFOEVVRThKVUU4SVVFOEdVRThEVUU4RVVFOENVRThGVUU4SFVFOEdVRThHVUU4Q1VFOEZVRThHVUV4UVR3UlFURkJNVUV4UVNTRUpJbGhMQVNFS0lsaExBaUVNSWxoTEJvRUhpUFUzU3dGTWlQVlZTd2VCQ29qMUtrOEtpUFZKaVBWR1N3UWhCeUpZVHdpQkI0ajFGVXNCVElqMU0wa1ZJZzVFU3dlclN3WWpJbGhMQnlFR0lsaExDQ0VJSWxoTENTUWlXRXNLSVE0aVdFc0xWNEFnU3d4WG9DQkxEVmNBSUVzT0pTSllTdzlYd0NCTEVDRUxJbGhMRVZjZ0lFc1NWMEFnU3hOWFlDQkxGRmZnSUVzVklRMGlXRThXSVFRaVdFOEpUd1pRVHdWUVR3UlFUd2hRVHdkUVR3VlFUd05RVHdOUVR3SlFUd05RVHdSUVR3dFFUd2RRVHdoUVR3UlFUd1ZRVEZCUEExQk1VRThEVUV4UVN3Z1ZJZzVFVHdoTEE2dExDQlVpRGtSUENFc0VxMUJMQnhVaURrUlBCMHNFcTFCTEJoVWlEa1JQQmtzRXExQkxBaFVpRGtSUEFrc0RxMUJNVUVzREZTSU9SRThEU3dLclVFc0NGU0lPUkU0Q3ExQ0FCQlVmZkhWTVVMQ0JBVU0yR2dGSkZZRUlFa1FYTmhvQ1NSV0JDQkpFRnpZYUEwbUJBRm1CQWdoTEFSVVNSRmNDQUNoa0ZFUW9Ud05uS2s4Q1o0QUJjMHhuZ1FGRCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
