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

namespace Arc56.Generated.joe_p.snarkjs_algorand.Groth16Bls12381Verifier_6ba23b50
{


    public class Groth16Bls12381VerifierProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Groth16Bls12381VerifierProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Groth16Bls12381Proof : AVMObjectType
            {
                public byte[] PiA { get; set; }

                public byte[] PiB { get; set; }

                public byte[] PiC { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vPiA.From(PiA);
                    ret.AddRange(vPiA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    vPiB.From(PiB);
                    ret.AddRange(vPiB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vPiC.From(PiC);
                    ret.AddRange(vPiC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Groth16Bls12381Proof Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Groth16Bls12381Proof();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vPiA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiA = vPiA.ToValue();
                    if (valuePiA is byte[] vPiAValue) { ret.PiA = vPiAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    count = vPiB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiB = vPiB.ToValue();
                    if (valuePiB is byte[] vPiBValue) { ret.PiB = vPiBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vPiC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiC = vPiC.ToValue();
                    if (valuePiC is byte[] vPiCValue) { ret.PiC = vPiCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Groth16Bls12381Proof);
                }
                public bool Equals(Groth16Bls12381Proof? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Groth16Bls12381Proof left, Groth16Bls12381Proof right)
                {
                    return EqualityComparer<Groth16Bls12381Proof>.Default.Equals(left, right);
                }
                public static bool operator !=(Groth16Bls12381Proof left, Groth16Bls12381Proof right)
                {
                    return !(left == right);
                }

            }

            public class Groth16Bls12381VerificationKey : AVMObjectType
            {
                public byte[] VkAlpha1 { get; set; }

                public byte[] VkBeta2 { get; set; }

                public byte[] VkGamma2 { get; set; }

                public byte[] VkDelta2 { get; set; }

                public ulong NPublic { get; set; }

                public byte[][] Ic { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkAlpha1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vVkAlpha1.From(VkAlpha1);
                    ret.AddRange(vVkAlpha1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkBeta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    vVkBeta2.From(VkBeta2);
                    ret.AddRange(vVkBeta2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkGamma2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    vVkGamma2.From(VkGamma2);
                    ret.AddRange(vVkGamma2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkDelta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    vVkDelta2.From(VkDelta2);
                    ret.AddRange(vVkDelta2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNPublic = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNPublic.From(NPublic);
                    ret.AddRange(vNPublic.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96][]");
                    vIc.From(Ic);
                    ret.AddRange(vIc.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Groth16Bls12381VerificationKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Groth16Bls12381VerificationKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkAlpha1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vVkAlpha1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkAlpha1 = vVkAlpha1.ToValue();
                    if (valueVkAlpha1 is byte[] vVkAlpha1Value) { ret.VkAlpha1 = vVkAlpha1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkBeta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    count = vVkBeta2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkBeta2 = vVkBeta2.ToValue();
                    if (valueVkBeta2 is byte[] vVkBeta2Value) { ret.VkBeta2 = vVkBeta2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkGamma2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    count = vVkGamma2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkGamma2 = vVkGamma2.ToValue();
                    if (valueVkGamma2 is byte[] vVkGamma2Value) { ret.VkGamma2 = vVkGamma2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkDelta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[192]");
                    count = vVkDelta2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkDelta2 = vVkDelta2.ToValue();
                    if (valueVkDelta2 is byte[] vVkDelta2Value) { ret.VkDelta2 = vVkDelta2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNPublic = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNPublic.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNPublic = vNPublic.ToValue();
                    if (valueNPublic is ulong vNPublicValue) { ret.NPublic = vNPublicValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96][]");
                    count = vIc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIc = vIc.ToValue();
                    if (valueIc is byte[][] vIcValue) { ret.Ic = vIcValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Groth16Bls12381VerificationKey);
                }
                public bool Equals(Groth16Bls12381VerificationKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Groth16Bls12381VerificationKey left, Groth16Bls12381VerificationKey right)
                {
                    return EqualityComparer<Groth16Bls12381VerificationKey>.Default.Equals(left, right);
                }
                public static bool operator !=(Groth16Bls12381VerificationKey left, Groth16Bls12381VerificationKey right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Dummy function that only exists so we can have the VerificationKey type in the generated client
        ///</summary>
        /// <param name="_vk"> Groth16Bls12381VerificationKey</param>
        public async Task Dummy(Structs.Groth16Bls12381VerificationKey _vk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 88, 159, 160 };

            var result = await base.CallApp(new List<object> { abiHandle, _vk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Dummy_Transactions(Structs.Groth16Bls12381VerificationKey _vk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 88, 159, 160 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _vk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="signals"> </param>
        /// <param name="proof"> Groth16Bls12381Proof</param>
        public async Task Verify(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bls12381Proof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 84, 225, 209 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            var result = await base.CallApp(new List<object> { abiHandle, signalsAbi, proof }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bls12381Proof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 84, 225, 209 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            return await base.MakeTransactionList(new List<object> { abiHandle, signalsAbi, proof }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JvdGgxNkJsczEyMzgxVmVyaWZpZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR3JvdGgxNkJsczEyMzgxUHJvb2YiOlt7Im5hbWUiOiJwaV9hIiwidHlwZSI6ImJ5dGVbOTZdIn0seyJuYW1lIjoicGlfYiIsInR5cGUiOiJieXRlWzE5Ml0ifSx7Im5hbWUiOiJwaV9jIiwidHlwZSI6ImJ5dGVbOTZdIn1dLCJHcm90aDE2QmxzMTIzODFWZXJpZmljYXRpb25LZXkiOlt7Im5hbWUiOiJ2a19hbHBoYV8xIiwidHlwZSI6ImJ5dGVbOTZdIn0seyJuYW1lIjoidmtfYmV0YV8yIiwidHlwZSI6ImJ5dGVbMTkyXSJ9LHsibmFtZSI6InZrX2dhbW1hXzIiLCJ0eXBlIjoiYnl0ZVsxOTJdIn0seyJuYW1lIjoidmtfZGVsdGFfMiIsInR5cGUiOiJieXRlWzE5Ml0ifSx7Im5hbWUiOiJuUHVibGljIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IklDIiwidHlwZSI6ImJ5dGVbOTZdW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiX2R1bW15IiwiZGVzYyI6IkR1bW15IGZ1bmN0aW9uIHRoYXQgb25seSBleGlzdHMgc28gd2UgY2FuIGhhdmUgdGhlIFZlcmlmaWNhdGlvbktleSB0eXBlIGluIHRoZSBnZW5lcmF0ZWQgY2xpZW50IiwiYXJncyI6W3sidHlwZSI6IihieXRlWzk2XSxieXRlWzE5Ml0sYnl0ZVsxOTJdLGJ5dGVbMTkyXSx1aW50NjQsYnl0ZVs5Nl1bXSkiLCJzdHJ1Y3QiOiJHcm90aDE2QmxzMTIzODFWZXJpZmljYXRpb25LZXkiLCJuYW1lIjoiX3ZrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiQ2xvc2VPdXQiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NltdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGJ5dGVbOTZdLGJ5dGVbMTkyXSxieXRlWzk2XSkiLCJzdHJ1Y3QiOiJHcm90aDE2QmxzMTIzODFQcm9vZiIsIm5hbWUiOiJwcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6IkludmFsaWQgbnVtYmVyIG9mIHB1YmxpYyBpbnB1dHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTldLCJlcnJvck1lc3NhZ2UiOiJMZW5ndGggbXVzdCBiZSAzMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MCw0MjMsNDQzXSwiZXJyb3JNZXNzYWdlIjoiTGVuZ3RoIG11c3QgYmUgOTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDZdLCJlcnJvck1lc3NhZ2UiOiJWZXJpZmljYXRpb24gZmFpbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg5LDM0NCwzODRdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwLDEwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50MjU2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBjb250cmFjdHMvZ3JvdGgxNl9ibHMxMjM4MS5hbGdvLnRzOjpHcm90aDE2QmxzMTIzODFQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGNvbnRyYWN0cy9ncm90aDE2X2JsczEyMzgxLmFsZ28udHM6Okdyb3RoMTZCbHMxMjM4MVZlcmlmaWNhdGlvbktleSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNSBvZiAodWludDhbOTZdLHVpbnQ4WzE5Ml0sdWludDhbMTkyXSx1aW50OFsxOTJdLHVpbnQ2NCwobGVuK3VpbnQ4Wzk2XVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTFdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MF0sImVycm9yTWVzc2FnZSI6InBpX2Egbm90IGluIEcxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwXSwiZXJyb3JNZXNzYWdlIjoicGlfYiBub3QgaW4gRzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjFdLCJlcnJvck1lc3NhZ2UiOiJwaV9jIG5vdCBpbiBHMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Ml0sImVycm9yTWVzc2FnZSI6InB1YmxpYyBzaWduYWwgbm90IGluIEZyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNeklnT1RZZ01TQXdJRFk0TUFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZUNBd2VEY3paV1JoTnpVek1qazVaRGRrTkRnek16TTVaRGd3T0RBNVlURmtPREExTlROaVpHRTBNREptWm1abE5XSm1aV1ptWm1abVptWm1NREF3TURBd01ERWdWRTFRVEY5V1JWSkpSa2xEUVZSSlQwNWZTMFZaQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNVjkyWlhKcFptbGxjaTVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1IzSnZkR2d4TmtKc2N6RXlNemd4Vm1WeWFXWnBaWElnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5nb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEYzBOVGc1Wm1Fd0lEQjRaVE0xTkdVeFpERWdMeThnYldWMGFHOWtJQ0pmWkhWdGJYa29LR0o1ZEdWYk9UWmRMR0o1ZEdWYk1Ua3lYU3hpZVhSbFd6RTVNbDBzWW5sMFpWc3hPVEpkTEhWcGJuUTJOQ3hpZVhSbFd6azJYVnRkS1NsMmIybGtJaXdnYldWMGFHOWtJQ0oyWlhKcFpua29kV2x1ZERJMU5sdGRMQ2hpZVhSbFd6azJYU3hpZVhSbFd6RTVNbDBzWW5sMFpWczVObDBwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgxOWtkVzF0ZVY5eWIzVjBaVUF6SUcxaGFXNWZkbVZ5YVdaNVgzSnZkWFJsUURRS0lDQWdJR1Z5Y2dvS2JXRnBibDkyWlhKcFpubGZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneFgzWmxjbWxtYVdWeUxtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklIWmxjbWxtZVNoemFXZHVZV3h6T2lCUWRXSnNhV05UYVdkdVlXeHpMQ0J3Y205dlpqb2dSM0p2ZEdneE5rSnNjekV5TXpneFVISnZiMllwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JpSUhabGNtbG1lUW9LYldGcGJsOWZaSFZ0YlhsZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4WDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNKRGJHOXpaVTkxZENJZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUJEYkc5elpVOTFkQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJRjlrZFcxdGVRb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4WDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkhjbTkwYURFMlFteHpNVEl6T0RGV1pYSnBabWxsY2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREZmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem82UjNKdmRHZ3hOa0pzY3pFeU16Z3hWbVZ5YVdacFpYSXVYMlIxYlcxNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYMlIxYlcxNU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZllteHpNVEl6T0RGZmRtVnlhV1pwWlhJdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrTnNiM05sVDNWMElpQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05qZ3dDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZNE1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBMUlHOW1JQ2gxYVc1ME9GczVObDBzZFdsdWREaGJNVGt5WFN4MWFXNTBPRnN4T1RKZExIVnBiblE0V3pFNU1sMHNkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJPVFpkVzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUE1TmdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBMk9EUUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPa2R5YjNSb01UWkNiSE14TWpNNE1WWmxjbWxtYVdOaGRHbHZia3RsZVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hYM1psY21sbWFXVnlMbUZzWjI4dWRITTZPa2R5YjNSb01UWkNiSE14TWpNNE1WWmxjbWxtYVdWeUxuWmxjbWxtZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVRvS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hYM1psY21sbWFXVnlMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSFpsY21sbWVTaHphV2R1WVd4ek9pQlFkV0pzYVdOVGFXZHVZV3h6TENCd2NtOXZaam9nUjNKdmRHZ3hOa0pzY3pFeU16Z3hVSEp2YjJZcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblF5TlRZK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpPRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk9rZHliM1JvTVRaQ2JITXhNak00TVZCeWIyOW1DaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qSTFNd29nSUNBZ0x5OGdaR1ZqYjJSbFFYSmpORHhIY205MGFERTJRbXh6TVRJek9ERldaWEpwWm1sallYUnBiMjVMWlhrK0tIWnJRbmwwWlhNcExBb2dJQ0FnWW5sMFpXTmZNaUF2THlCVVRWQk1YMVpGVWtsR1NVTkJWRWxQVGw5TFJWa0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem80TkFvZ0lDQWdMeThnWVhOelpYSjBLR2N4UjNKdmRYQkRhR1ZqYXlod2NtOXZaaTV3YVY5aEtTd2dJbkJwWDJFZ2JtOTBJR2x1SUVjeElpazdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBNU5nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVSV3hzYVhCMGFXTkRkWEoyWlM1emRXSm5jbTkxY0VOb1pXTnJLRzl3TGtWakxrSk1VekV5WHpNNE1XY3hMQ0J3S1RzS0lDQWdJR1ZqWDNOMVltZHliM1Z3WDJOb1pXTnJJRUpNVXpFeVh6TTRNV2N4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJoYzNObGNuUW9aekZIY205MWNFTm9aV05yS0hCeWIyOW1MbkJwWDJFcExDQWljR2xmWVNCdWIzUWdhVzRnUnpFaUtUc0tJQ0FnSUdGemMyVnlkQ0F2THlCd2FWOWhJRzV2ZENCcGJpQkhNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdZWE56WlhKMEtHY3lSM0p2ZFhCRGFHVmpheWh3Y205dlppNXdhVjlpS1N3Z0luQnBYMklnYm05MElHbHVJRWN5SWlrN0NpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTVRreUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OMVltZHliM1Z3UTJobFkyc29iM0F1UldNdVFreFRNVEpmTXpneFp6SXNJSEFwT3dvZ0lDQWdaV05mYzNWaVozSnZkWEJmWTJobFkyc2dRa3hUTVRKZk16Z3haeklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5Na2R5YjNWd1EyaGxZMnNvY0hKdmIyWXVjR2xmWWlrc0lDSndhVjlpSUc1dmRDQnBiaUJITWlJcE93b2dJQ0FnWVhOelpYSjBJQzh2SUhCcFgySWdibTkwSUdsdUlFY3lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QmhjM05sY25Rb1p6RkhjbTkxY0VOb1pXTnJLSEJ5YjI5bUxuQnBYMk1wTENBaWNHbGZZeUJ1YjNRZ2FXNGdSekVpS1RzS0lDQWdJSEIxYzJocGJuUWdNamc0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OMVltZHliM1Z3UTJobFkyc29iM0F1UldNdVFreFRNVEpmTXpneFp6RXNJSEFwT3dvZ0lDQWdaV05mYzNWaVozSnZkWEJmWTJobFkyc2dRa3hUTVRKZk16Z3haekVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5NVWR5YjNWd1EyaGxZMnNvY0hKdmIyWXVjR2xmWXlrc0lDSndhVjlqSUc1dmRDQnBiaUJITVNJcE93b2dJQ0FnWVhOelpYSjBJQzh2SUhCcFgyTWdibTkwSUdsdUlFY3hDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qazJDaUFnSUNBdkx5QmhjM05sY25Rb2MybG5ibUZzY3k1c1pXNW5kR2dnUFQwOUlIWnJMbTVRZFdKc2FXTXNJQ0pKYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJ3ZFdKc2FXTWdhVzV3ZFhSeklpazdDaUFnSUNCd2RYTm9hVzUwSURZM01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0J1ZFcxaVpYSWdiMllnY0hWaWJHbGpJR2x1Y0hWMGN3b2dJQ0FnYVc1MFkxOHpJQzh2SURBS0NuWmxjbWxtZVY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJSE5wWjI1aGJDQnZaaUJ6YVdkdVlXeHpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQThDaUFnSUNCaWVpQjJaWEpwWm5sZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdScFp5QTJDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnNjekV5TXpneFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCeVpYUjFjbTRnZG1Gc2RXVXVZWE5DYVdkVmFXNTBLQ2tnUENCQ1RGTXhNbDh6T0RGZlUwTkJURUZTWDAxUFJGVk1WVk03Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TnpObFpHRTNOVE15T1Rsa04yUTBPRE16TXpsa09EQTRNRGxoTVdRNE1EVTFNMkprWVRRd01tWm1abVUxWW1abFptWm1abVptWm1Zd01EQXdNREF3TVFvZ0lDQWdZandLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHBia1pwWld4a0tITnBaMjVoYkNrc0lDSndkV0pzYVdNZ2MybG5ibUZzSUc1dmRDQnBiaUJHY2lJcE93b2dJQ0FnWVhOelpYSjBJQzh2SUhCMVlteHBZeUJ6YVdkdVlXd2dibTkwSUdsdUlFWnlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUhabGNtbG1lVjltYjNKZmFHVmhaR1Z5UURJS0NuWmxjbWxtZVY5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QnBaaUFvYzJsbmJtRnNjeTVzWlc1bmRHZ2dQVDA5SURBcElIc0tJQ0FnSUdScFp5QTFDaUFnSUNCaWJub2dkbVZ5YVdaNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem94TXpBS0lDQWdJQzh2SUhKbGRIVnliaUIyYXk1SlExc3dYU0JoY3lCaWVYUmxjenc1Tmo0N0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTmpnd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJRGsyQ2dwMlpYSnBabmxmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qcGpiMjF3ZFhSbFEzQjFZa0F4TXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWJITXhNak00TVY5amIyMXRiMjR1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnY21WMGRYSnVJRzl3TGtWc2JHbHdkR2xqUTNWeWRtVXVjMk5oYkdGeVRYVnNLRzl3TGtWakxrSk1VekV5WHpNNE1XY3hMQ0J3TENCQ2VYUmxjeWh6S1NrdWRHOUdhWGhsWkNoN0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnNjekV5TXpneFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCeVpYUjFjbTRnWnpGVWFXMWxjMFp5S0hBc0lGSmZUVWxPVlZOZk1TazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNNMlZrWVRjMU16STVPV1EzWkRRNE16TXpPV1E0TURnd09XRXhaRGd3TlRVelltUmhOREF5Wm1abVpUVmlabVZtWm1abVptWm1aakF3TURBd01EQXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbXh6TVRJek9ERmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OallXeGhjazExYkNodmNDNUZZeTVDVEZNeE1sOHpPREZuTVN3Z2NDd2dRbmwwWlhNb2N5a3BMblJ2Um1sNFpXUW9ld29nSUNBZ1pXTmZjMk5oYkdGeVgyMTFiQ0JDVEZNeE1sOHpPREZuTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKc2N6RXlNemd4WDJOdmJXMXZiaTVoYkdkdkxuUnpPall5TFRZMENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVJXeHNhWEIwYVdORGRYSjJaUzV6WTJGc1lYSk5kV3dvYjNBdVJXTXVRa3hUTVRKZk16Z3haekVzSUhBc0lFSjVkR1Z6S0hNcEtTNTBiMFpwZUdWa0tIc0tJQ0FnSUM4dklDQWdiR1Z1WjNSb09pQTVOaXdLSUNBZ0lDOHZJSDBwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTVOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTVpXNW5kR2dnYlhWemRDQmlaU0E1TmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem94T0RFS0lDQWdJQzh2SUdOdmJuTjBJR2N4VUc5cGJuUnpJRDBnYm1WblVHbEJMbU52Ym1OaGRDaGpjSFZpS1M1amIyNWpZWFFvY0hKdmIyWXVjR2xmWXlrdVkyOXVZMkYwS0hackxuWnJYMkZzY0doaFh6RXBPd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURBZ09UWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6b3hPRFVLSUNBZ0lDOHZJQzVqYjI1allYUW9kbXN1ZG10ZloyRnRiV0ZmTWlrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBjeUF5T0RnZ01Ua3lDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem94T0RRdE1UZzFDaUFnSUNBdkx5QmpiMjV6ZENCbk1sQnZhVzUwY3lBOUlIQnliMjltTG5CcFgySUtJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaDJheTUyYTE5bllXMXRZVjh5S1FvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZllteHpNVEl6T0RFdVlXeG5ieTUwY3pveE9EWUtJQ0FnSUM4dklDNWpiMjVqWVhRb2Rtc3VkbXRmWkdWc2RHRmZNaWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MGN5QTBPREFnTVRreUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6b3hPRFF0TVRnMkNpQWdJQ0F2THlCamIyNXpkQ0JuTWxCdmFXNTBjeUE5SUhCeWIyOW1MbkJwWDJJS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoMmF5NTJhMTluWVcxdFlWOHlLUW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyUmxiSFJoWHpJcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk1UZzNDaUFnSUNBdkx5QXVZMjl1WTJGMEtIWnJMblpyWDJKbGRHRmZNaWs3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnT1RZZ01Ua3lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qRTROQzB4T0RjS0lDQWdJQzh2SUdOdmJuTjBJR2N5VUc5cGJuUnpJRDBnY0hKdmIyWXVjR2xmWWdvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0hackxuWnJYMmRoYlcxaFh6SXBDaUFnSUNBdkx5QWdJQzVqYjI1allYUW9kbXN1ZG10ZlpHVnNkR0ZmTWlrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoMmF5NTJhMTlpWlhSaFh6SXBPd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPakU1TUMweE9UUUtJQ0FnSUM4dklHTnZibk4wSUhKbGN5QTlJRzl3TGtWc2JHbHdkR2xqUTNWeWRtVXVjR0ZwY21sdVowTm9aV05yS0FvZ0lDQWdMeThnSUNCdmNDNUZZeTVDVEZNeE1sOHpPREZuTVN3S0lDQWdJQzh2SUNBZ1p6RlFiMmx1ZEhNc0NpQWdJQ0F2THlBZ0lHY3lVRzlwYm5SekxBb2dJQ0FnTHk4Z0tUc0tJQ0FnSUdWalgzQmhhWEpwYm1kZlkyaGxZMnNnUWt4VE1USmZNemd4WnpFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4WDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUdGemMyVnlkQ2gyWlhKcFpubEdjbTl0VkdWdGNHeGhkR1VvYzJsbmJtRnNjeXdnY0hKdmIyWXBMQ0FpVm1WeWFXWnBZMkYwYVc5dUlHWmhhV3hsWkNJcE93b2dJQ0FnWVhOelpYSjBJQzh2SUZabGNtbG1hV05oZEdsdmJpQm1ZV2xzWldRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4WDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUhabGNtbG1lU2h6YVdkdVlXeHpPaUJRZFdKc2FXTlRhV2R1WVd4ekxDQndjbTl2WmpvZ1IzSnZkR2d4TmtKc2N6RXlNemd4VUhKdmIyWXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDblpsY21sbWVWOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJITXhNak00TVM1aGJHZHZMblJ6T2pFek5Bb2dJQ0FnTHk4Z2JHVjBJR2xqVUc5cGJuUnpJRDBnUW5sMFpYTW9LVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4TG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXhPeUJwSUR3OUlITnBaMjVoYkhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaWRYSjVJRGdLQ25abGNtbG1lVjkzYUdsc1pWOTBiM0JBTnpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4TG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXhPeUJwSUR3OUlITnBaMjVoYkhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmthV2NnTmdvZ0lDQWdQRDBLSUNBZ0lHSjZJSFpsY21sbWVWOWhablJsY2w5M2FHbHNaVUE1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPakV6TmdvZ0lDQWdMeThnYVdOUWIybHVkSE1nUFNCcFkxQnZhVzUwY3k1amIyNWpZWFFvZG1zdVNVTXVZWFFvYVNraEtUc0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBMk9EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURnS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURrMkNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdPVFlLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURFeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBeE95QnBJRHc5SUhOcFoyNWhiSE11YkdWdVozUm9PeUJwS3lzcElIc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURnS0lDQWdJR0lnZG1WeWFXWjVYM2RvYVd4bFgzUnZjRUEzQ2dwMlpYSnBabmxmWVdaMFpYSmZkMmhwYkdWQU9Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5QnNaWFFnYzJOaGJHRnljeUE5SUVKNWRHVnpLQ2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmlkWEo1SURFS0NuWmxjbWxtZVY5bWIzSmZhR1ZoWkdWeVFERXdPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6b3hOREVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYzJsbmJtRnNJRzltSUhOcFoyNWhiSE1wSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURZS0lDQWdJRHdLSUNBZ0lHSjZJSFpsY21sbWVWOWhablJsY2w5bWIzSkFNVElLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpzY3pFeU16Z3hYMk52YlcxdmJpNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QnlaWFIxY200Z1lTQWxJRUpNVXpFeVh6TTRNVjlUUTBGTVFWSmZUVTlFVlV4VlV6c0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzNNMlZrWVRjMU16STVPV1EzWkRRNE16TXpPV1E0TURnd09XRXhaRGd3TlRVelltUmhOREF5Wm1abVpUVmlabVZtWm1abVptWm1aakF3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnNjekV5TXpneFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lGVnBiblF5TlRZb1lTa3VZbmwwWlhNdWRHOUdhWGhsWkNoN0lHeGxibWQwYURvZ016SWdmU2s3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlc1bmRHZ2diWFZ6ZENCaVpTQXpNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6b3hORElLSUNBZ0lDOHZJSE5qWVd4aGNuTWdQU0J6WTJGc1lYSnpMbU52Ym1OaGRDaGlNeklvWm5KVFkyRnNZWElvYzJsbmJtRnNMbUZ6UW1sblZXbHVkQ2dwS1NrcE93b2dJQ0FnWkdsbklERXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdkbVZ5YVdaNVgyWnZjbDlvWldGa1pYSkFNVEFLQ25abGNtbG1lVjloWm5SbGNsOW1iM0pBTVRJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJITXhNak00TVM1aGJHZHZMblJ6T2pFME5pMHhOVEFLSUNBZ0lDOHZJR3hsZENCamNIVmlJRDBnYjNBdVJXeHNhWEIwYVdORGRYSjJaUzV6WTJGc1lYSk5kV3hOZFd4MGFTZ0tJQ0FnSUM4dklDQWdiM0F1UldNdVFreFRNVEpmTXpneFp6RXNDaUFnSUNBdkx5QWdJR2xqVUc5cGJuUnpMQW9nSUNBZ0x5OGdJQ0J6WTJGc1lYSnpMQW9nSUNBZ0x5OGdLUzUwYjBacGVHVmtLSHNnYkdWdVozUm9PaUE1TmlCOUtUc0tJQ0FnSUdScFp5QTVDaUFnSUNCa2FXY2dPUW9nSUNBZ1pXTmZiWFZzZEdsZmMyTmhiR0Z5WDIxMWJDQkNURk14TWw4ek9ERm5NUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNU5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlc1bmRHZ2diWFZ6ZENCaVpTQTVOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6b3hOVE1LSUNBZ0lDOHZJR053ZFdJZ1BTQm5NVUZrWkNoamNIVmlMQ0IyYXk1SlExc3dYU0JoY3lCaWVYUmxjenc1Tmo0cE93b2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTBJQzh2SURZNE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUE1TmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKc2N6RXlNemd4WDJOdmJXMXZiaTVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1Uld4c2FYQjBhV05EZFhKMlpTNWhaR1FvYjNBdVJXTXVRa3hUTVRKZk16Z3haekVzSUhBeExDQndNaWt1ZEc5R2FYaGxaQ2g3Q2lBZ0lDQmxZMTloWkdRZ1FreFRNVEpmTXpneFp6RUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnNjekV5TXpneFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pjekxUYzFDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVSV3hzYVhCMGFXTkRkWEoyWlM1aFpHUW9iM0F1UldNdVFreFRNVEpmTXpneFp6RXNJSEF4TENCd01pa3VkRzlHYVhobFpDaDdDaUFnSUNBdkx5QWdJR3hsYm1kMGFEb2dPVFlzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGsyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFeGxibWQwYUNCdGRYTjBJR0psSURrMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJITXhNak00TVM1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTNCMVlpQTlJR052YlhCMWRHVkRjSFZpS0hackxDQnphV2R1WVd4ektUc0tJQ0FnSUdJZ2RtVnlhV1o1WDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6bzZZMjl0Y0hWMFpVTndkV0pBTVRNSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZJR0FCQUtnRkpnTUFJSFB0cDFNcG5YMUlNem5ZQ0FtaDJBVlR2YVFDLy81Yi92Ly8vLzhBQUFBQkFERWJRUUFzZ2dJRWRGaWZvQVRqVk9IUk5ob0FqZ0lBQ3dBQkFERVpGREVZRUVSQ0FEWXhHWUVDRWpFWUVFUkNBQWd4R1JReEdCUVFRellhQVVrVlN3RWhCRmxKZ2FvRkVrUlBBa3hMQWxJbFdTTUxnYXdGQ0JKRUpFTWxTU2cyR2dGSEFpVlpTVTRDU1NJTGdRSUlUd0lWRWtRMkdnSkpGWUdBQXhKRUtrbE9BazREU1ZjQVlFbE9CT1FDUkVsWFlNQkpUZ1RrQTBTQm9BSWpXRWxPQStRQ1JJR2dCVnNTUkNWSlN3WU1RUUFZU3daWEFnQkxBVWxPQWlJTElsZ3BwRVFrQ0VVQlF2L2hTd1ZBQUdoTEJFa2hCRmxMQVJWU1Z3SmdTd1NBSUhQdHAxTXBuWDFJTXpuWUNBbWgyQVZUdmFRQy8vNWIvdi8vLy84QUFBQUE0UUpKRlNNU1JFeFFTd0pRU3dWSlRnSlhBR0JRU3dHREFxQUN3QUZZU3dWTVVFc0Nnd0xnQThBQldGQlBBbGRnd0ZEaUFrUWtReWhGQ2lSRkNFc0hTd1lPUVFBalN3UkpJUVJaU3dFVlVsY0NBRXNJU1U0Q0l3c2pXRXNMVEZCRkN5UUlSUWhDLzlVb1JRa2xSUUZKU3dZTVFRQXFTd1pYQWdCTEFVbE9BaUlMSWxncHFra1ZJZzVFSXErclNSVWlFa1JMQ2t4UVJRb2tDRVVCUXYvUFN3bExDZU1DU1JVakVrUkxCVWtoQkZsTEFSVlNWd0pnNEFKSkZTTVNSRUwvR3c9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlZFUklGSUNBVElPTl9LRVkiOnsidHlwZSI6IkFWTUJ5dGVzIiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
