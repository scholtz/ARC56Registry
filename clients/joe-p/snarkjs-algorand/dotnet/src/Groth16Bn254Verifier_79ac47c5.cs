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

namespace Arc56.Generated.joe_p.snarkjs_algorand.Groth16Bn254Verifier_79ac47c5
{


    public class Groth16Bn254VerifierProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Groth16Bn254VerifierProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Groth16Bn254Proof : AVMObjectType
            {
                public byte[] PiA { get; set; }

                public byte[] PiB { get; set; }

                public byte[] PiC { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vPiA.From(PiA);
                    ret.AddRange(vPiA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    vPiB.From(PiB);
                    ret.AddRange(vPiB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
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

                public static Groth16Bn254Proof Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Groth16Bn254Proof();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vPiA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiA = vPiA.ToValue();
                    if (valuePiA is byte[] vPiAValue) { ret.PiA = vPiAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    count = vPiB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePiB = vPiB.ToValue();
                    if (valuePiB is byte[] vPiBValue) { ret.PiB = vPiBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPiC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
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
                    return Equals(obj as Groth16Bn254Proof);
                }
                public bool Equals(Groth16Bn254Proof? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Groth16Bn254Proof left, Groth16Bn254Proof right)
                {
                    return EqualityComparer<Groth16Bn254Proof>.Default.Equals(left, right);
                }
                public static bool operator !=(Groth16Bn254Proof left, Groth16Bn254Proof right)
                {
                    return !(left == right);
                }

            }

            public class Groth16Bn254VerificationKey : AVMObjectType
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkAlpha1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vVkAlpha1.From(VkAlpha1);
                    ret.AddRange(vVkAlpha1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkBeta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    vVkBeta2.From(VkBeta2);
                    ret.AddRange(vVkBeta2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkGamma2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    vVkGamma2.From(VkGamma2);
                    ret.AddRange(vVkGamma2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkDelta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    vVkDelta2.From(VkDelta2);
                    ret.AddRange(vVkDelta2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNPublic = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNPublic.From(NPublic);
                    ret.AddRange(vNPublic.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64][]");
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

                public static Groth16Bn254VerificationKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Groth16Bn254VerificationKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkAlpha1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vVkAlpha1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkAlpha1 = vVkAlpha1.ToValue();
                    if (valueVkAlpha1 is byte[] vVkAlpha1Value) { ret.VkAlpha1 = vVkAlpha1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkBeta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    count = vVkBeta2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkBeta2 = vVkBeta2.ToValue();
                    if (valueVkBeta2 is byte[] vVkBeta2Value) { ret.VkBeta2 = vVkBeta2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkGamma2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    count = vVkGamma2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkGamma2 = vVkGamma2.ToValue();
                    if (valueVkGamma2 is byte[] vVkGamma2Value) { ret.VkGamma2 = vVkGamma2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVkDelta2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[128]");
                    count = vVkDelta2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVkDelta2 = vVkDelta2.ToValue();
                    if (valueVkDelta2 is byte[] vVkDelta2Value) { ret.VkDelta2 = vVkDelta2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNPublic = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNPublic.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNPublic = vNPublic.ToValue();
                    if (valueNPublic is ulong vNPublicValue) { ret.NPublic = vNPublicValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64][]");
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
                    return Equals(obj as Groth16Bn254VerificationKey);
                }
                public bool Equals(Groth16Bn254VerificationKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Groth16Bn254VerificationKey left, Groth16Bn254VerificationKey right)
                {
                    return EqualityComparer<Groth16Bn254VerificationKey>.Default.Equals(left, right);
                }
                public static bool operator !=(Groth16Bn254VerificationKey left, Groth16Bn254VerificationKey right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Dummy function that only exists so we can have the VerificationKey type in the generated client
        ///</summary>
        /// <param name="_vk"> Groth16Bn254VerificationKey</param>
        public async Task Dummy(Structs.Groth16Bn254VerificationKey _vk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 16, 235, 218 };

            var result = await base.CallApp(new List<object> { abiHandle, _vk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Dummy_Transactions(Structs.Groth16Bn254VerificationKey _vk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 16, 235, 218 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _vk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="signals"> </param>
        /// <param name="proof"> Groth16Bn254Proof</param>
        public async Task Verify(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 167, 187, 113 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            var result = await base.CallApp(new List<object> { abiHandle, signalsAbi, proof }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 167, 187, 113 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JvdGgxNkJuMjU0VmVyaWZpZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR3JvdGgxNkJuMjU0UHJvb2YiOlt7Im5hbWUiOiJwaV9hIiwidHlwZSI6ImJ5dGVbNjRdIn0seyJuYW1lIjoicGlfYiIsInR5cGUiOiJieXRlWzEyOF0ifSx7Im5hbWUiOiJwaV9jIiwidHlwZSI6ImJ5dGVbNjRdIn1dLCJHcm90aDE2Qm4yNTRWZXJpZmljYXRpb25LZXkiOlt7Im5hbWUiOiJ2a19hbHBoYV8xIiwidHlwZSI6ImJ5dGVbNjRdIn0seyJuYW1lIjoidmtfYmV0YV8yIiwidHlwZSI6ImJ5dGVbMTI4XSJ9LHsibmFtZSI6InZrX2dhbW1hXzIiLCJ0eXBlIjoiYnl0ZVsxMjhdIn0seyJuYW1lIjoidmtfZGVsdGFfMiIsInR5cGUiOiJieXRlWzEyOF0ifSx7Im5hbWUiOiJuUHVibGljIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IklDIiwidHlwZSI6ImJ5dGVbNjRdW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiX2R1bW15IiwiZGVzYyI6IkR1bW15IGZ1bmN0aW9uIHRoYXQgb25seSBleGlzdHMgc28gd2UgY2FuIGhhdmUgdGhlIFZlcmlmaWNhdGlvbktleSB0eXBlIGluIHRoZSBnZW5lcmF0ZWQgY2xpZW50IiwiYXJncyI6W3sidHlwZSI6IihieXRlWzY0XSxieXRlWzEyOF0sYnl0ZVsxMjhdLGJ5dGVbMTI4XSx1aW50NjQsYnl0ZVs2NF1bXSkiLCJzdHJ1Y3QiOiJHcm90aDE2Qm4yNTRWZXJpZmljYXRpb25LZXkiLCJuYW1lIjoiX3ZrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiQ2xvc2VPdXQiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NltdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGJ5dGVbNjRdLGJ5dGVbMTI4XSxieXRlWzY0XSkiLCJzdHJ1Y3QiOiJHcm90aDE2Qm4yNTRQcm9vZiIsIm5hbWUiOiJwcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2NV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgbnVtYmVyIG9mIHB1YmxpYyBpbnB1dHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTNdLCJlcnJvck1lc3NhZ2UiOiJMZW5ndGggbXVzdCBiZSAzMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OCw0MTcsNDM3XSwiZXJyb3JNZXNzYWdlIjoiTGVuZ3RoIG11c3QgYmUgNjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDBdLCJlcnJvck1lc3NhZ2UiOiJWZXJpZmljYXRpb24gZmFpbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3LDMzOCwzNzhdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwLDEwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50MjU2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBjb250cmFjdHMvZ3JvdGgxNl9ibjI1NC5hbGdvLnRzOjpHcm90aDE2Qm4yNTRQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGNvbnRyYWN0cy9ncm90aDE2X2JuMjU0LmFsZ28udHM6Okdyb3RoMTZCbjI1NFZlcmlmaWNhdGlvbktleSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNSBvZiAodWludDhbNjRdLHVpbnQ4WzEyOF0sdWludDhbMTI4XSx1aW50OFsxMjhdLHVpbnQ2NCwobGVuK3VpbnQ4WzY0XVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODVdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MF0sImVycm9yTWVzc2FnZSI6InBpX2Egbm90IGluIEcxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwXSwiZXJyb3JNZXNzYWdlIjoicGlfYiBub3QgaW4gRzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTldLCJlcnJvck1lc3NhZ2UiOiJwaV9jIG5vdCBpbiBHMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MF0sImVycm9yTWVzc2FnZSI6InB1YmxpYyBzaWduYWwgbm90IGluIEZyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNeklnTmpRZ01TQXdJRFExTmdvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZUNBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERWdWRTFRVEY5V1JWSkpSa2xEUVZSSlQwNWZTMFZaQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5GOTJaWEpwWm1sbGNpNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUjNKdmRHZ3hOa0p1TWpVMFZtVnlhV1pwWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFOZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREUyTVRCbFltUmhJREI0TlRWaE4ySmlOekVnTHk4Z2JXVjBhRzlrSUNKZlpIVnRiWGtvS0dKNWRHVmJOalJkTEdKNWRHVmJNVEk0WFN4aWVYUmxXekV5T0Ywc1lubDBaVnN4TWpoZExIVnBiblEyTkN4aWVYUmxXelkwWFZ0ZEtTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmtvZFdsdWRESTFObHRkTENoaWVYUmxXelkwWFN4aWVYUmxXekV5T0Ywc1lubDBaVnMyTkYwcEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMTlrZFcxdGVWOXliM1YwWlVBeklHMWhhVzVmZG1WeWFXWjVYM0p2ZFhSbFFEUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MlpYSnBabmxmY205MWRHVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMFgzWmxjbWxtYVdWeUxtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklIWmxjbWxtZVNoemFXZHVZV3h6T2lCUWRXSnNhV05UYVdkdVlXeHpMQ0J3Y205dlpqb2dSM0p2ZEdneE5rSnVNalUwVUhKdmIyWXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJSFpsY21sbWVRb0tiV0ZwYmw5ZlpIVnRiWGxmY205MWRHVkFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMFgzWmxjbWxtYVdWeUxtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSkRiRzl6WlU5MWRDSWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdNaUF2THlCRGJHOXpaVTkxZEFvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JpSUY5a2RXMXRlUW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnVNalUwWDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkhjbTkwYURFMlFtNHlOVFJXWlhKcFptbGxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRSZmRtVnlhV1pwWlhJdVlXeG5ieTUwY3pvNlIzSnZkR2d4TmtKdU1qVTBWbVZ5YVdacFpYSXVYMlIxYlcxNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYMlIxYlcxNU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFJmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSWtOc2IzTmxUM1YwSWlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5SaklEUWdMeThnTkRVMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFExT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0ExSUc5bUlDaDFhVzUwT0ZzMk5GMHNkV2x1ZERoYk1USTRYU3gxYVc1ME9Gc3hNamhkTEhWcGJuUTRXekV5T0Ywc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYk5qUmRXMTBwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0EwTmpBS0lDQWdJQ3NLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T2tkeWIzUm9NVFpDYmpJMU5GWmxjbWxtYVdOaGRHbHZia3RsZVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMFgzWmxjbWxtYVdWeUxtRnNaMjh1ZEhNNk9rZHliM1JvTVRaQ2JqSTFORlpsY21sbWFXVnlMblpsY21sbWVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVUb0tJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6QWdMeThnSWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBYM1psY21sbWFXVnlMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSFpsY21sbWVTaHphV2R1WVd4ek9pQlFkV0pzYVdOVGFXZHVZV3h6TENCd2NtOXZaam9nUjNKdmRHZ3hOa0p1TWpVMFVISnZiMllwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUXlOVFkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU5UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZPa2R5YjNSb01UWkNiakkxTkZCeWIyOW1DaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pJME5Rb2dJQ0FnTHk4Z1pHVmpiMlJsUVhKak5EeEhjbTkwYURFMlFtNHlOVFJXWlhKcFptbGpZWFJwYjI1TFpYaytLSFpyUW5sMFpYTXBMQW9nSUNBZ1lubDBaV05mTWlBdkx5QlVUVkJNWDFaRlVrbEdTVU5CVkVsUFRsOUxSVmtLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem80TkFvZ0lDQWdMeThnWVhOelpYSjBLR2N4UjNKdmRYQkRhR1ZqYXlod2NtOXZaaTV3YVY5aEtTd2dJbkJwWDJFZ2JtOTBJR2x1SUVjeElpazdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVJXeHNhWEIwYVdORGRYSjJaUzV6ZFdKbmNtOTFjRU5vWldOcktHOXdMa1ZqTGtKT01qVTBaekVzSUhBcE93b2dJQ0FnWldOZmMzVmlaM0p2ZFhCZlkyaGxZMnNnUWs0eU5UUm5NUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pvNE5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0djeFIzSnZkWEJEYUdWamF5aHdjbTl2Wmk1d2FWOWhLU3dnSW5CcFgyRWdibTkwSUdsdUlFY3hJaWs3Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR2xmWVNCdWIzUWdhVzRnUnpFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5Na2R5YjNWd1EyaGxZMnNvY0hKdmIyWXVjR2xmWWlrc0lDSndhVjlpSUc1dmRDQnBiaUJITWlJcE93b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFkwSURFeU9Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVJXeHNhWEIwYVdORGRYSjJaUzV6ZFdKbmNtOTFjRU5vWldOcktHOXdMa1ZqTGtKT01qVTBaeklzSUhBcE93b2dJQ0FnWldOZmMzVmlaM0p2ZFhCZlkyaGxZMnNnUWs0eU5UUm5NZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0djeVIzSnZkWEJEYUdWamF5aHdjbTl2Wmk1d2FWOWlLU3dnSW5CcFgySWdibTkwSUdsdUlFY3lJaWs3Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR2xmWWlCdWIzUWdhVzRnUnpJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5NVWR5YjNWd1EyaGxZMnNvY0hKdmIyWXVjR2xmWXlrc0lDSndhVjlqSUc1dmRDQnBiaUJITVNJcE93b2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ05qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xrVnNiR2x3ZEdsalEzVnlkbVV1YzNWaVozSnZkWEJEYUdWamF5aHZjQzVGWXk1Q1RqSTFOR2N4TENCd0tUc0tJQ0FnSUdWalgzTjFZbWR5YjNWd1gyTm9aV05ySUVKT01qVTBaekVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklHRnpjMlZ5ZENobk1VZHliM1Z3UTJobFkyc29jSEp2YjJZdWNHbGZZeWtzSUNKd2FWOWpJRzV2ZENCcGJpQkhNU0lwT3dvZ0lDQWdZWE56WlhKMElDOHZJSEJwWDJNZ2JtOTBJR2x1SUVjeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJqSTFOQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJoYzNObGNuUW9jMmxuYm1Gc2N5NXNaVzVuZEdnZ1BUMDlJSFpyTG01UWRXSnNhV01zSUNKSmJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCd2RXSnNhV01nYVc1d2RYUnpJaWs3Q2lBZ0lDQndkWE5vYVc1MElEUTBPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ2NIVmliR2xqSUdsdWNIVjBjd29nSUNBZ2FXNTBZMTh6SUM4dklEQUtDblpsY21sbWVWOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJSE5wWjI1aGJDQnZaaUJ6YVdkdVlXeHpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQThDaUFnSUNCaWVpQjJaWEpwWm5sZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdScFp5QTJDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnVNalUwWDJOdmJXMXZiaTVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkbUZzZFdVdVlYTkNhV2RWYVc1MEtDa2dQQ0JDVGpJMU5GOVRRMEZNUVZKZlRVOUVWVXhWVXpzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpUEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdZWE56WlhKMEtHbHVSbWxsYkdRb2MybG5ibUZzS1N3Z0luQjFZbXhwWXlCemFXZHVZV3dnYm05MElHbHVJRVp5SWlrN0NpQWdJQ0JoYzNObGNuUWdMeThnY0hWaWJHbGpJSE5wWjI1aGJDQnViM1FnYVc0Z1JuSUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnZG1WeWFXWjVYMlp2Y2w5b1pXRmtaWEpBTWdvS2RtVnlhV1o1WDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TWpnS0lDQWdJQzh2SUdsbUlDaHphV2R1WVd4ekxteGxibWQwYUNBOVBUMGdNQ2tnZXdvZ0lDQWdaR2xuSURVS0lDQWdJR0p1ZWlCMlpYSnBabmxmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFek1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhackxrbERXekJkSUdGeklHSjVkR1Z6UERZMFBqc0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBME5UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTmpRS0NuWmxjbWxtZVY5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk9tTnZiWEIxZEdWRGNIVmlRREV6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKdU1qVTBYMk52YlcxdmJpNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVSV3hzYVhCMGFXTkRkWEoyWlM1elkyRnNZWEpOZFd3b2IzQXVSV011UWs0eU5UUm5NU3dnY0N3Z1FubDBaWE1vY3lrcExuUnZSbWw0WldRb2V3b2dJQ0FnWkdsbklEUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWliakkxTkY5amIyMXRiMjR1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnY21WMGRYSnVJR2N4VkdsdFpYTkdjaWh3TENCU1gwMUpUbFZUWHpFcE93b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnVNalUwWDJOdmJXMXZiaTVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1Uld4c2FYQjBhV05EZFhKMlpTNXpZMkZzWVhKTmRXd29iM0F1UldNdVFrNHlOVFJuTVN3Z2NDd2dRbmwwWlhNb2N5a3BMblJ2Um1sNFpXUW9ld29nSUNBZ1pXTmZjMk5oYkdGeVgyMTFiQ0JDVGpJMU5HY3hDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbTR5TlRSZlkyOXRiVzl1TG1Gc1oyOHVkSE02TmpJdE5qUUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OallXeGhjazExYkNodmNDNUZZeTVDVGpJMU5HY3hMQ0J3TENCQ2VYUmxjeWh6S1NrdWRHOUdhWGhsWkNoN0NpQWdJQ0F2THlBZ0lHeGxibWQwYURvZ05qUXNDaUFnSUNBdkx5QjlLVHNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UZ3hDaUFnSUNBdkx5QmpiMjV6ZENCbk1WQnZhVzUwY3lBOUlHNWxaMUJwUVM1amIyNWpZWFFvWTNCMVlpa3VZMjl1WTJGMEtIQnliMjltTG5CcFgyTXBMbU52Ym1OaGRDaDJheTUyYTE5aGJIQm9ZVjh4S1RzS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFkwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUF1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ01USTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFNE5DMHhPRFVLSUNBZ0lDOHZJR052Ym5OMElHY3lVRzlwYm5SeklEMGdjSEp2YjJZdWNHbGZZZ29nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFNE5nb2dJQ0FnTHk4Z0xtTnZibU5oZENoMmF5NTJhMTlrWld4MFlWOHlLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5SeklETXlNQ0F4TWpnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFNE5DMHhPRFlLSUNBZ0lDOHZJR052Ym5OMElHY3lVRzlwYm5SeklEMGdjSEp2YjJZdWNHbGZZZ29nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb2Rtc3VkbXRmWkdWc2RHRmZNaWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6b3hPRGNLSUNBZ0lDOHZJQzVqYjI1allYUW9kbXN1ZG10ZlltVjBZVjh5S1RzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQXhNamdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UZzBMVEU0TndvZ0lDQWdMeThnWTI5dWMzUWdaekpRYjJsdWRITWdQU0J3Y205dlppNXdhVjlpQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvZG1zdWRtdGZaMkZ0YldGZk1pa0tJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaDJheTUyYTE5a1pXeDBZVjh5S1FvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0hackxuWnJYMkpsZEdGZk1pazdDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QmpiMjV6ZENCeVpYTWdQU0J2Y0M1RmJHeHBjSFJwWTBOMWNuWmxMbkJoYVhKcGJtZERhR1ZqYXlodmNDNUZZeTVDVGpJMU5HY3hMQ0JuTVZCdmFXNTBjeXdnWnpKUWIybHVkSE1wT3dvZ0lDQWdaV05mY0dGcGNtbHVaMTlqYUdWamF5QkNUakkxTkdjeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJqSTFORjkyWlhKcFptbGxjaTVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9kbVZ5YVdaNVJuSnZiVlJsYlhCc1lYUmxLSE5wWjI1aGJITXNJSEJ5YjI5bUtTd2dJbFpsY21sbWFXTmhkR2x2YmlCbVlXbHNaV1FpS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJXWlhKcFptbGpZWFJwYjI0Z1ptRnBiR1ZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5GOTJaWEpwWm1sbGNpNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QjJaWEpwWm5rb2MybG5ibUZzY3pvZ1VIVmliR2xqVTJsbmJtRnNjeXdnY0hKdmIyWTZJRWR5YjNSb01UWkNiakkxTkZCeWIyOW1LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AyWlhKcFpubGZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUd4bGRDQnBZMUJ2YVc1MGN5QTlJRUo1ZEdWektDazdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qRXpOUW9nSUNBZ0x5OGdabTl5SUNoc1pYUWdhVG9nZFdsdWREWTBJRDBnTVRzZ2FTQThQU0J6YVdkdVlXeHpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZblZ5ZVNBNENncDJaWEpwWm5sZmQyaHBiR1ZmZEc5d1FEYzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNVHNnYVNBOFBTQnphV2R1WVd4ekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQmthV2NnTndvZ0lDQWdaR2xuSURZS0lDQWdJRHc5Q2lBZ0lDQmllaUIyWlhKcFpubGZZV1owWlhKZmQyaHBiR1ZBT1FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6b3hNellLSUNBZ0lDOHZJR2xqVUc5cGJuUnpJRDBnYVdOUWIybHVkSE11WTI5dVkyRjBLSFpyTGtsRExtRjBLR2twSVNrN0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTkRVMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlERXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNVHNnYVNBOFBTQnphV2R1WVd4ekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTRDaUFnSUNCaUlIWmxjbWxtZVY5M2FHbHNaVjkwYjNCQU53b0tkbVZ5YVdaNVgyRm1kR1Z5WDNkb2FXeGxRRGs2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qRTBNQW9nSUNBZ0x5OGdiR1YwSUhOallXeGhjbk1nUFNCQ2VYUmxjeWdwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdZblZ5ZVNBeENncDJaWEpwWm5sZlptOXlYMmhsWVdSbGNrQXhNRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJSE5wWjI1aGJDQnZaaUJ6YVdkdVlXeHpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQThDaUFnSUNCaWVpQjJaWEpwWm5sZllXWjBaWEpmWm05eVFERXlDaUFnSUNCa2FXY2dOZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWliakkxTkY5amIyMXRiMjR1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnY21WMGRYSnVJR0VnSlNCQ1RqSTFORjlUUTBGTVFWSmZUVTlFVlV4VlV6c0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnVNalUwWDJOdmJXMXZiaTVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUZWcGJuUXlOVFlvWVNrdVlubDBaWE11ZEc5R2FYaGxaQ2g3SUd4bGJtZDBhRG9nTXpJZ2ZTazdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aVzVuZEdnZ2JYVnpkQ0JpWlNBek1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUhOallXeGhjbk1nUFNCelkyRnNZWEp6TG1OdmJtTmhkQ2hpTXpJb1puSlRZMkZzWVhJb2MybG5ibUZzTG1GelFtbG5WV2x1ZENncEtTa3BPd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnZG1WeWFXWjVYMlp2Y2w5b1pXRmtaWEpBTVRBS0NuWmxjbWxtZVY5aFpuUmxjbDltYjNKQU1USTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFME5pMHhOVEFLSUNBZ0lDOHZJR3hsZENCamNIVmlJRDBnYjNBdVJXeHNhWEIwYVdORGRYSjJaUzV6WTJGc1lYSk5kV3hOZFd4MGFTZ0tJQ0FnSUM4dklDQWdiM0F1UldNdVFrNHlOVFJuTVN3S0lDQWdJQzh2SUNBZ2FXTlFiMmx1ZEhNc0NpQWdJQ0F2THlBZ0lITmpZV3hoY25Nc0NpQWdJQ0F2THlBcExuUnZSbWw0WldRb2V5QnNaVzVuZEdnNklEWTBJSDBwT3dvZ0lDQWdaR2xuSURrS0lDQWdJR1JwWnlBNUNpQWdJQ0JsWTE5dGRXeDBhVjl6WTJGc1lYSmZiWFZzSUVKT01qVTBaekVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UVXpDaUFnSUNBdkx5QmpjSFZpSUQwZ1p6RkJaR1FvWTNCMVlpd2dkbXN1U1VOYk1GMGdZWE1nWW5sMFpYTThOalErS1RzS0lDQWdJR1JwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTlRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYmpJMU5GOWpiMjF0YjI0dVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xrVnNiR2x3ZEdsalEzVnlkbVV1WVdSa0tHOXdMa1ZqTGtKT01qVTBaekVzSUhBeExDQndNaWt1ZEc5R2FYaGxaQ2g3SUd4bGJtZDBhRG9nTmpRZ2ZTazdDaUFnSUNCbFkxOWhaR1FnUWs0eU5UUm5NUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlc1bmRHZ2diWFZ6ZENCaVpTQTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklHTnZibk4wSUdOd2RXSWdQU0JqYjIxd2RYUmxRM0IxWWloMmF5d2djMmxuYm1Gc2N5azdDaUFnSUNCaUlIWmxjbWxtZVY5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk9tTnZiWEIxZEdWRGNIVmlRREV6Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZJRUFCQU1nREpnTUFJREJrVG5MaE1hQXB1RkJGdG9HQldGMG9NK2hJZWJsd2tVUGg5WlB3QUFBQkFERWJRUUFzZ2dJRUZoRHIyZ1JWcDd0eE5ob0FqZ0lBQ3dBQkFERVpGREVZRUVSQ0FEWXhHWUVDRWpFWUVFUkNBQWd4R1JReEdCUVFRellhQVVrVlN3RWhCRmxKZ2NvREVrUlBBa3hMQWxJbFdTTUxnY3dEQ0JKRUpFTWxTU2cyR2dGSEFpVlpTVTRDU1NJTGdRSUlUd0lWRWtRMkdnSkpGWUdBQWhKRUtrbE9BazREU1ZjQVFFbE9CT1FBUkVsWFFJQkpUZ1RrQVVSWHdFQkpUZ1BrQUVTQndBTmJFa1FsU1VzR0RFRUFHRXNHVndJQVN3RkpUZ0lpQ3lKWUthUkVKQWhGQVVMLzRVc0ZRQUJrU3dSSklRUlpTd0VWVWxjQ1FFc0VnQ0F3WkU1eTRUR2dLYmhRUmJhQmdWaGRLRFBvU0htNWNKRkQ0ZldUOEFBQUFPRUFTUlVqRWtSTVVFc0NVRXNGU1U0Q1Z3QkFVRXNCVjhDQVN3Vk1VRXNDZ3dMQUFvQUJXRkJQQWxkQWdGRGlBRVFrUXloRkNpUkZDRXNIU3dZT1FRQWpTd1JKSVFSWlN3RVZVbGNDQUVzSVNVNENJd3NqV0VzTFRGQkZDeVFJUlFoQy85VW9SUWtsUlFGSlN3WU1RUUFxU3daWEFnQkxBVWxPQWlJTElsZ3Bxa2tWSWc1RUlxK3JTUlVpRWtSTENreFFSUW9rQ0VVQlF2L1BTd2xMQ2VNQVNSVWpFa1JMQlVraEJGbExBUlZTVndKQTRBQkpGU01TUkVML0h3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJWRVJJRklDQVRJT05fS0VZIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
