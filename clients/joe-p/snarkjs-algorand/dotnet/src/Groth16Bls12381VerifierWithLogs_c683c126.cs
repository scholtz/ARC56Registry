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

namespace Arc56.Generated.joe_p.snarkjs_algorand.Groth16Bls12381VerifierWithLogs_c683c126
{


    public class Groth16Bls12381VerifierWithLogsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Groth16Bls12381VerifierWithLogsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JvdGgxNkJsczEyMzgxVmVyaWZpZXJXaXRoTG9ncyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHcm90aDE2QmxzMTIzODFQcm9vZiI6W3sibmFtZSI6InBpX2EiLCJ0eXBlIjoiYnl0ZVs5Nl0ifSx7Im5hbWUiOiJwaV9iIiwidHlwZSI6ImJ5dGVbMTkyXSJ9LHsibmFtZSI6InBpX2MiLCJ0eXBlIjoiYnl0ZVs5Nl0ifV0sIkdyb3RoMTZCbHMxMjM4MVZlcmlmaWNhdGlvbktleSI6W3sibmFtZSI6InZrX2FscGhhXzEiLCJ0eXBlIjoiYnl0ZVs5Nl0ifSx7Im5hbWUiOiJ2a19iZXRhXzIiLCJ0eXBlIjoiYnl0ZVsxOTJdIn0seyJuYW1lIjoidmtfZ2FtbWFfMiIsInR5cGUiOiJieXRlWzE5Ml0ifSx7Im5hbWUiOiJ2a19kZWx0YV8yIiwidHlwZSI6ImJ5dGVbMTkyXSJ9LHsibmFtZSI6Im5QdWJsaWMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiSUMiLCJ0eXBlIjoiYnl0ZVs5Nl1bXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJfZHVtbXkiLCJkZXNjIjoiRHVtbXkgZnVuY3Rpb24gdGhhdCBvbmx5IGV4aXN0cyBzbyB3ZSBjYW4gaGF2ZSB0aGUgVmVyaWZpY2F0aW9uS2V5IHR5cGUgaW4gdGhlIGdlbmVyYXRlZCBjbGllbnQiLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbOTZdLGJ5dGVbMTkyXSxieXRlWzE5Ml0sYnl0ZVsxOTJdLHVpbnQ2NCxieXRlWzk2XVtdKSIsInN0cnVjdCI6Ikdyb3RoMTZCbHMxMjM4MVZlcmlmaWNhdGlvbktleSIsIm5hbWUiOiJfdmsiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJDbG9zZU91dCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYnl0ZVs5Nl0sYnl0ZVsxOTJdLGJ5dGVbOTZdKSIsInN0cnVjdCI6Ikdyb3RoMTZCbHMxMjM4MVByb29mIiwibmFtZSI6InByb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY3XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBudW1iZXIgb2YgcHVibGljIGlucHV0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MF0sImVycm9yTWVzc2FnZSI6Ikxlbmd0aCBtdXN0IGJlIDMyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA0LDQ5NCw1MTRdLCJlcnJvck1lc3NhZ2UiOiJMZW5ndGggbXVzdCBiZSA5NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3N10sImVycm9yTWVzc2FnZSI6IlZlcmlmaWNhdGlvbiBmYWlsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODksNDE1LDQ1NV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAsMTAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQyNTY+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGNvbnRyYWN0cy9ncm90aDE2X2JsczEyMzgxLmFsZ28udHM6Okdyb3RoMTZCbHMxMjM4MVByb29mIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgY29udHJhY3RzL2dyb3RoMTZfYmxzMTIzODEuYWxnby50czo6R3JvdGgxNkJsczEyMzgxVmVyaWZpY2F0aW9uS2V5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA1IG9mICh1aW50OFs5Nl0sdWludDhbMTkyXSx1aW50OFsxOTJdLHVpbnQ4WzE5Ml0sdWludDY0LChsZW4rdWludDhbOTZdW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2Ml0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjoicGlfYSBub3QgaW4gRzEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTBdLCJlcnJvck1lc3NhZ2UiOiJwaV9iIG5vdCBpbiBHMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MV0sImVycm9yTWVzc2FnZSI6InBpX2Mgbm90IGluIEcxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkyXSwiZXJyb3JNZXNzYWdlIjoicHVibGljIHNpZ25hbCBub3QgaW4gRnIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJjYmxvY2tzIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdPVFlnTVNBd0lEWTRNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlQ0F3ZURjelpXUmhOelV6TWprNVpEZGtORGd6TXpNNVpEZ3dPREE1WVRGa09EQTFOVE5pWkdFME1ESm1abVpsTldKbVpXWm1abVptWm1abU1EQXdNREF3TURFZ1ZFMVFURjlXUlZKSlJrbERRVlJKVDA1ZlMwVlpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1WOTJaWEpwWm1sbGNpNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUjNKdmRHZ3hOa0pzY3pFeU16Z3hWbVZ5YVdacFpYSlhhWFJvVEc5bmN5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUEyQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TnpRMU9EbG1ZVEFnTUhobE16VTBaVEZrTVNBdkx5QnRaWFJvYjJRZ0lsOWtkVzF0ZVNnb1lubDBaVnM1Tmwwc1lubDBaVnN4T1RKZExHSjVkR1ZiTVRreVhTeGllWFJsV3pFNU1sMHNkV2x1ZERZMExHSjVkR1ZiT1RaZFcxMHBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVNoMWFXNTBNalUyVzEwc0tHSjVkR1ZiT1RaZExHSjVkR1ZiTVRreVhTeGllWFJsV3prMlhTa3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWDJSMWJXMTVYM0p2ZFhSbFFETWdiV0ZwYmw5MlpYSnBabmxmY205MWRHVkFOQW9nSUNBZ1pYSnlDZ3B0WVdsdVgzWmxjbWxtZVY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREZmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnZG1WeWFXWjVLSE5wWjI1aGJITTZJRkIxWW14cFkxTnBaMjVoYkhNc0lIQnliMjltT2lCSGNtOTBhREUyUW14ek1USXpPREZRY205dlppazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdkbVZ5YVdaNUNncHRZV2x1WDE5a2RXMXRlVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERmZkbVZ5YVdacFpYSXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJa05zYjNObFQzVjBJaUI5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklFTnNiM05sVDNWMENpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ1gyUjFiVzE1Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERmZkbVZ5YVdacFpYSXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVkeWIzUm9NVFpDYkhNeE1qTTRNVlpsY21sbWFXVnlWMmwwYUV4dlozTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneFgzWmxjbWxtYVdWeUxtRnNaMjh1ZEhNNk9rZHliM1JvTVRaQ2JITXhNak00TVZabGNtbG1hV1Z5VjJsMGFFeHZaM011WDJSMWJXMTVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWDJSMWJXMTVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERmZkbVZ5YVdacFpYSXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJa05zYjNObFQzVjBJaUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOamd3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEWTRNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQTFJRzltSUNoMWFXNTBPRnM1Tmwwc2RXbHVkRGhiTVRreVhTeDFhVzUwT0ZzeE9USmRMSFZwYm5RNFd6RTVNbDBzZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiT1RaZFcxMHBLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBNU5nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTJPRFFLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4TG1Gc1oyOHVkSE02T2tkeWIzUm9NVFpDYkhNeE1qTTRNVlpsY21sbWFXTmhkR2x2Ymt0bGVRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4WDNabGNtbG1hV1Z5TG1Gc1oyOHVkSE02T2tkeWIzUm9NVFpDYkhNeE1qTTRNVlpsY21sbWFXVnlWMmwwYUV4dlozTXVkbVZ5YVdaNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNU9nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREZmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnZG1WeWFXWjVLSE5wWjI1aGJITTZJRkIxWW14cFkxTnBaMjVoYkhNc0lIQnliMjltT2lCSGNtOTBhREUyUW14ek1USXpPREZRY205dlppazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERJMU5qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE00TkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6bzZSM0p2ZEdneE5rSnNjekV5TXpneFVISnZiMllLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZNalk1Q2lBZ0lDQXZMeUJrWldOdlpHVkJjbU0wUEVkeWIzUm9NVFpDYkhNeE1qTTRNVlpsY21sbWFXTmhkR2x2Ymt0bGVUNG9kbXRDZVhSbGN5a3NDaUFnSUNCaWVYUmxZMTh5SUM4dklGUk5VRXhmVmtWU1NVWkpRMEZVU1U5T1gwdEZXUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJITXhNak00TVM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCaGMzTmxjblFvWnpGSGNtOTFjRU5vWldOcktIQnliMjltTG5CcFgyRXBMQ0FpY0dsZllTQnViM1FnYVc0Z1J6RWlLVHNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEazJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzVGYkd4cGNIUnBZME4xY25abExuTjFZbWR5YjNWd1EyaGxZMnNvYjNBdVJXTXVRa3hUTVRKZk16Z3haekVzSUhBcE93b2dJQ0FnWldOZmMzVmlaM0p2ZFhCZlkyaGxZMnNnUWt4VE1USmZNemd4WnpFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4TG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdGemMyVnlkQ2huTVVkeWIzVndRMmhsWTJzb2NISnZiMll1Y0dsZllTa3NJQ0p3YVY5aElHNXZkQ0JwYmlCSE1TSXBPd29nSUNBZ1lYTnpaWEowSUM4dklIQnBYMkVnYm05MElHbHVJRWN4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJoYzNObGNuUW9aekpIY205MWNFTm9aV05yS0hCeWIyOW1MbkJwWDJJcExDQWljR2xmWWlCdWIzUWdhVzRnUnpJaUtUc0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0E1TmlBeE9USUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdjbVYwZFhKdUlHOXdMa1ZzYkdsd2RHbGpRM1Z5ZG1VdWMzVmlaM0p2ZFhCRGFHVmpheWh2Y0M1Rll5NUNURk14TWw4ek9ERm5NaXdnY0NrN0NpQWdJQ0JsWTE5emRXSm5jbTkxY0Y5amFHVmpheUJDVEZNeE1sOHpPREZuTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnWVhOelpYSjBLR2N5UjNKdmRYQkRhR1ZqYXlod2NtOXZaaTV3YVY5aUtTd2dJbkJwWDJJZ2JtOTBJR2x1SUVjeUlpazdDaUFnSUNCaGMzTmxjblFnTHk4Z2NHbGZZaUJ1YjNRZ2FXNGdSeklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5NVWR5YjNWd1EyaGxZMnNvY0hKdmIyWXVjR2xmWXlrc0lDSndhVjlqSUc1dmRDQnBiaUJITVNJcE93b2dJQ0FnY0hWemFHbHVkQ0F5T0RnS0lDQWdJR2x1ZEdOZk1TQXZMeUE1TmdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHOXdMa1ZzYkdsd2RHbGpRM1Z5ZG1VdWMzVmlaM0p2ZFhCRGFHVmpheWh2Y0M1Rll5NUNURk14TWw4ek9ERm5NU3dnY0NrN0NpQWdJQ0JsWTE5emRXSm5jbTkxY0Y5amFHVmpheUJDVEZNeE1sOHpPREZuTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWVhOelpYSjBLR2N4UjNKdmRYQkRhR1ZqYXlod2NtOXZaaTV3YVY5aktTd2dJbkJwWDJNZ2JtOTBJR2x1SUVjeElpazdDaUFnSUNCaGMzTmxjblFnTHk4Z2NHbGZZeUJ1YjNRZ2FXNGdSekVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaHphV2R1WVd4ekxteGxibWQwYUNBOVBUMGdkbXN1YmxCMVlteHBZeXdnSWtsdWRtRnNhV1FnYm5WdFltVnlJRzltSUhCMVlteHBZeUJwYm5CMWRITWlLVHNLSUNBZ0lIQjFjMmhwYm5RZ05qY3lDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCd2RXSnNhV01nYVc1d2RYUnpDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb0tkbVZ5YVdaNVgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYzJsbmJtRnNJRzltSUhOcFoyNWhiSE1wSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURZS0lDQWdJRHdLSUNBZ0lHSjZJSFpsY21sbWVWOWhablJsY2w5bWIzSkFOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbXh6TVRJek9ERmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklISmxkSFZ5YmlCMllXeDFaUzVoYzBKcFoxVnBiblFvS1NBOElFSk1VekV5WHpNNE1WOVRRMEZNUVZKZlRVOUVWVXhWVXpzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnM00yVmtZVGMxTXpJNU9XUTNaRFE0TXpNek9XUTRNRGd3T1dFeFpEZ3dOVFV6WW1SaE5EQXlabVptWlRWaVptVm1abVptWm1abVpqQXdNREF3TURBeENpQWdJQ0JpUEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem81T1FvZ0lDQWdMeThnWVhOelpYSjBLR2x1Um1sbGJHUW9jMmxuYm1Gc0tTd2dJbkIxWW14cFl5QnphV2R1WVd3Z2JtOTBJR2x1SUVaeUlpazdDaUFnSUNCaGMzTmxjblFnTHk4Z2NIVmliR2xqSUhOcFoyNWhiQ0J1YjNRZ2FXNGdSbklLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2RtVnlhV1o1WDJadmNsOW9aV0ZrWlhKQU1nb0tkbVZ5YVdaNVgyRm1kR1Z5WDJadmNrQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6b3hNamdLSUNBZ0lDOHZJR2xtSUNoemFXZHVZV3h6TG14bGJtZDBhQ0E5UFQwZ01Da2dld29nSUNBZ1pHbG5JRFVLSUNBZ0lHSnVlaUIyWlhKcFpubGZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJITXhNak00TVM1aGJHZHZMblJ6T2pFek1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhackxrbERXekJkSUdGeklHSjVkR1Z6UERrMlBqc0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBMk9EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnT1RZS0NuWmxjbWxtZVY5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZPbU52YlhCMWRHVkRjSFZpUURFek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZllteHpNVEl6T0RFdVlXeG5ieTUwY3pveU1USUtJQ0FnSUM4dklHUmxZblZuVEc5bktDSmpjSFZpSWl3Z1kzQjFZaWs3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbU53ZFdJaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllteHpNVEl6T0RGZlkyOXRiVzl1TG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUd4dlp5aHVZVzFsS1RzS0lDQWdJR3h2WndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKc2N6RXlNemd4WDJOdmJXMXZiaTVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJzYjJjb2RtRnNkV1VwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZNakUxQ2lBZ0lDQXZMeUJrWldKMVoweHZaeWdpY0dsZllTSXNJSEJ5YjI5bUxuQnBYMkVwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p3YVY5aElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnNjekV5TXpneFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCc2IyY29ibUZ0WlNrN0NpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWJITXhNak00TVY5amIyMXRiMjR1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnYkc5bktIWmhiSFZsS1RzS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR3h2WndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem95TVRZS0lDQWdJQzh2SUdSbFluVm5URzluS0NKd2FWOWlJaXdnY0hKdmIyWXVjR2xmWWlrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW5CcFgySWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbXh6TVRJek9ERmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHeHZaeWh1WVcxbEtUc0tJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnNjekV5TXpneFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCc2IyY29kbUZzZFdVcE93b2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHOW5DaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qSXhOd29nSUNBZ0x5OGdaR1ZpZFdkTWIyY29JbkJwWDJNaUxDQndjbTl2Wmk1d2FWOWpLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWljR2xmWXlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWJITXhNak00TVY5amIyMXRiMjR1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnYkc5bktHNWhiV1VwT3dvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW14ek1USXpPREZmWTI5dGJXOXVMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR3h2WnloMllXeDFaU2s3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWJITXhNak00TVY5amIyMXRiMjR1WVd4bmJ5NTBjem80TkFvZ0lDQWdMeThnY21WMGRYSnVJR2N4VkdsdFpYTkdjaWh3TENCU1gwMUpUbFZUWHpFcE93b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE56TmxaR0UzTlRNeU9UbGtOMlEwT0RNek16bGtPREE0TURsaE1XUTRNRFUxTTJKa1lUUXdNbVptWm1VMVltWmxabVptWm1abVptWXdNREF3TURBd01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnNjekV5TXpneFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVJXeHNhWEIwYVdORGRYSjJaUzV6WTJGc1lYSk5kV3dvYjNBdVJXTXVRa3hUTVRKZk16Z3haekVzSUhBc0lFSjVkR1Z6S0hNcEtTNTBiMFpwZUdWa0tIc0tJQ0FnSUdWalgzTmpZV3hoY2w5dGRXd2dRa3hUTVRKZk16Z3haekVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYkhNeE1qTTRNVjlqYjIxdGIyNHVZV3huYnk1MGN6bzJNaTAyTkFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TGtWc2JHbHdkR2xqUTNWeWRtVXVjMk5oYkdGeVRYVnNLRzl3TGtWakxrSk1VekV5WHpNNE1XY3hMQ0J3TENCQ2VYUmxjeWh6S1NrdWRHOUdhWGhsWkNoN0NpQWdJQ0F2THlBZ0lHeGxibWQwYURvZ09UWXNDaUFnSUNBdkx5QjlLVHNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdPVFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZNakl6Q2lBZ0lDQXZMeUJqYjI1emRDQm5NVkJ2YVc1MGN5QTlJRzVsWjFCcFFTNWpiMjVqWVhRb1kzQjFZaWt1WTI5dVkyRjBLSEJ5YjI5bUxuQnBYMk1wTG1OdmJtTmhkQ2gyYXk1MmExOWhiSEJvWVY4eEtUc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01DQTVOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPakl5TndvZ0lDQWdMeThnTG1OdmJtTmhkQ2gyYXk1MmExOW5ZVzF0WVY4eUtRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblJ6SURJNE9DQXhPVElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJITXhNak00TVM1aGJHZHZMblJ6T2pJeU5pMHlNamNLSUNBZ0lDOHZJR052Ym5OMElHY3lVRzlwYm5SeklEMGdjSEp2YjJZdWNHbGZZZ29nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem95TWpnS0lDQWdJQzh2SUM1amIyNWpZWFFvZG1zdWRtdGZaR1ZzZEdGZk1pa0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwY3lBME9EQWdNVGt5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZllteHpNVEl6T0RFdVlXeG5ieTUwY3pveU1qWXRNakk0Q2lBZ0lDQXZMeUJqYjI1emRDQm5NbEJ2YVc1MGN5QTlJSEJ5YjI5bUxuQnBYMklLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2gyYXk1MmExOW5ZVzF0WVY4eUtRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtIWnJMblpyWDJSbGJIUmhYeklwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4TG1Gc1oyOHVkSE02TWpJNUNpQWdJQ0F2THlBdVkyOXVZMkYwS0hackxuWnJYMkpsZEdGZk1pazdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTVRreUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJITXhNak00TVM1aGJHZHZMblJ6T2pJeU5pMHlNamtLSUNBZ0lDOHZJR052Ym5OMElHY3lVRzlwYm5SeklEMGdjSEp2YjJZdWNHbGZZZ29nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb2Rtc3VkbXRmWkdWc2RHRmZNaWtLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2gyYXk1MmExOWlaWFJoWHpJcE93b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliSE14TWpNNE1TNWhiR2R2TG5Sek9qSXpNaTB5TXpZS0lDQWdJQzh2SUdOdmJuTjBJSEpsY3lBOUlHOXdMa1ZzYkdsd2RHbGpRM1Z5ZG1VdWNHRnBjbWx1WjBOb1pXTnJLQW9nSUNBZ0x5OGdJQ0J2Y0M1Rll5NUNURk14TWw4ek9ERm5NU3dLSUNBZ0lDOHZJQ0FnWnpGUWIybHVkSE1zQ2lBZ0lDQXZMeUFnSUdjeVVHOXBiblJ6TEFvZ0lDQWdMeThnS1RzS0lDQWdJR1ZqWDNCaGFYSnBibWRmWTJobFkyc2dRa3hUTVRKZk16Z3haekVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkpzY3pFeU16Z3hMbUZzWjI4dWRITTZNak00Q2lBZ0lDQXZMeUJrWldKMVoweHZaeWdpY0dGcGNtbHVaeUJ5WlhOMWJIUWlMQ0J5WlhNZ1B5QkNlWFJsY3k1bWNtOXRTR1Y0S0NJd01TSXBJRG9nUW5sMFpYTXVabkp2YlVobGVDZ2lNREFpS1NrN0NpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1EQWdNSGd3TVFvZ0lDQWdaR2xuSURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKd1lXbHlhVzVuSUhKbGMzVnNkQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYkhNeE1qTTRNVjlqYjIxdGIyNHVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdiRzluS0c1aGJXVXBPd29nSUNBZ2JHOW5DaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbXh6TVRJek9ERmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHeHZaeWgyWVd4MVpTazdDaUFnSUNCc2IyY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneFgzWmxjbWxtYVdWeUxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHRnpjMlZ5ZENoMlpYSnBabmxHY205dFZHVnRjR3hoZEdWWGFYUm9URzluY3loemFXZHVZV3h6TENCd2NtOXZaaWtzSUNKV1pYSnBabWxqWVhScGIyNGdabUZwYkdWa0lpazdDaUFnSUNCaGMzTmxjblFnTHk4Z1ZtVnlhV1pwWTJGMGFXOXVJR1poYVd4bFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZllteHpNVEl6T0RGZmRtVnlhV1pwWlhJdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2RtVnlhV1o1S0hOcFoyNWhiSE02SUZCMVlteHBZMU5wWjI1aGJITXNJSEJ5YjI5bU9pQkhjbTkwYURFMlFteHpNVEl6T0RGUWNtOXZaaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZG1WeWFXWjVYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk1UTTBDaUFnSUNBdkx5QnNaWFFnYVdOUWIybHVkSE1nUFNCQ2VYUmxjeWdwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZllteHpNVEl6T0RFdVlXeG5ieTUwY3pveE16VUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREU3SUdrZ1BEMGdjMmxuYm1Gc2N5NXNaVzVuZEdnN0lHa3JLeWtnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSjFjbmtnT0FvS2RtVnlhV1o1WDNkb2FXeGxYM1J2Y0VBM09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZllteHpNVEl6T0RFdVlXeG5ieTUwY3pveE16VUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREU3SUdrZ1BEMGdjMmxuYm1Gc2N5NXNaVzVuZEdnN0lHa3JLeWtnZXdvZ0lDQWdaR2xuSURjS0lDQWdJR1JwWnlBMkNpQWdJQ0E4UFFvZ0lDQWdZbm9nZG1WeWFXWjVYMkZtZEdWeVgzZG9hV3hsUURrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKc2N6RXlNemd4TG1Gc1oyOHVkSE02TVRNMkNpQWdJQ0F2THlCcFkxQnZhVzUwY3lBOUlHbGpVRzlwYm5SekxtTnZibU5oZENoMmF5NUpReTVoZENocEtTRXBPd29nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklEWTRNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z09UWUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUE1TmdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01URUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW14ek1USXpPREV1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlERTdJR2tnUEQwZ2MybG5ibUZzY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWWlCMlpYSnBabmxmZDJocGJHVmZkRzl3UURjS0NuWmxjbWxtZVY5aFpuUmxjbDkzYUdsc1pVQTVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbXh6TVRJek9ERXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJR3hsZENCelkyRnNZWEp6SUQwZ1FubDBaWE1vS1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0oxY25rZ09Rb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR0oxY25rZ01Rb0tkbVZ5YVdaNVgyWnZjbDlvWldGa1pYSkFNVEE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPakUwTVFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCemFXZHVZV3dnYjJZZ2MybG5ibUZzY3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnUEFvZ0lDQWdZbm9nZG1WeWFXWjVYMkZtZEdWeVgyWnZja0F4TWdvZ0lDQWdaR2xuSURZS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW14ek1USXpPREZmWTI5dGJXOXVMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSEpsZEhWeWJpQmhJQ1VnUWt4VE1USmZNemd4WDFORFFVeEJVbDlOVDBSVlRGVlRPd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRGN6WldSaE56VXpNams1WkRka05EZ3pNek01WkRnd09EQTVZVEZrT0RBMU5UTmlaR0UwTURKbVptWmxOV0ptWldabVptWm1abVptTURBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbXh6TVRJek9ERmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dWV2x1ZERJMU5paGhLUzVpZVhSbGN5NTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQXpNaUI5S1RzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUV4bGJtZDBhQ0J0ZFhOMElHSmxJRE15Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPakUwTWdvZ0lDQWdMeThnYzJOaGJHRnljeUE5SUhOallXeGhjbk11WTI5dVkyRjBLR0l6TWlobWNsTmpZV3hoY2loemFXZHVZV3d1WVhOQ2FXZFZhVzUwS0NrcEtTazdDaUFnSUNCa2FXY2dNVEFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUIyWlhKcFpubGZabTl5WDJobFlXUmxja0F4TUFvS2RtVnlhV1o1WDJGbWRHVnlYMlp2Y2tBeE1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk1UUTJMVEUxTUFvZ0lDQWdMeThnYkdWMElHTndkV0lnUFNCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OallXeGhjazExYkUxMWJIUnBLQW9nSUNBZ0x5OGdJQ0J2Y0M1Rll5NUNURk14TWw4ek9ERm5NU3dLSUNBZ0lDOHZJQ0FnYVdOUWIybHVkSE1zQ2lBZ0lDQXZMeUFnSUhOallXeGhjbk1zQ2lBZ0lDQXZMeUFwTG5SdlJtbDRaV1FvZXlCc1pXNW5kR2c2SURrMklIMHBPd29nSUNBZ1pHbG5JRGtLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmxZMTl0ZFd4MGFWOXpZMkZzWVhKZmJYVnNJRUpNVXpFeVh6TTRNV2N4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEazJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUV4bGJtZDBhQ0J0ZFhOMElHSmxJRGsyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPakUxTXdvZ0lDQWdMeThnWTNCMVlpQTlJR2N4UVdSa0tHTndkV0lzSUhackxrbERXekJkSUdGeklHSjVkR1Z6UERrMlBpazdDaUFnSUNCa2FXY2dOUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z05qZ3dDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURrMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllteHpNVEl6T0RGZlkyOXRiVzl1TG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1RmJHeHBjSFJwWTBOMWNuWmxMbUZrWkNodmNDNUZZeTVDVEZNeE1sOHpPREZuTVN3Z2NERXNJSEF5S1M1MGIwWnBlR1ZrS0hzS0lDQWdJR1ZqWDJGa1pDQkNURk14TWw4ek9ERm5NUW9nSUNBZ1pIVndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbXh6TVRJek9ERmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk56TXROelVLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzVGYkd4cGNIUnBZME4xY25abExtRmtaQ2h2Y0M1Rll5NUNURk14TWw4ek9ERm5NU3dnY0RFc0lIQXlLUzUwYjBacGVHVmtLSHNLSUNBZ0lDOHZJQ0FnYkdWdVozUm9PaUE1Tml3S0lDQWdJQzh2SUgwcE93b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT1RZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUR1Z1WjNSb0lHMTFjM1FnWW1VZ09UWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnNjekV5TXpneExtRnNaMjh1ZEhNNk1qRXhDaUFnSUNBdkx5QmpiMjV6ZENCamNIVmlJRDBnWTI5dGNIVjBaVU53ZFdJb2Rtc3NJSE5wWjI1aGJITXBPd29nSUNBZ1lpQjJaWEpwWm5sZllXWjBaWEpmYVc1c2FXNWxaRjlqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYkhNeE1qTTRNUzVoYkdkdkxuUnpPanBqYjIxd2RYUmxRM0IxWWtBeE13bz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGSUdBQkFLZ0ZKZ01BSUhQdHAxTXBuWDFJTXpuWUNBbWgyQVZUdmFRQy8vNWIvdi8vLy84QUFBQUJBREViUVFBc2dnSUVkRmlmb0FUalZPSFJOaG9BamdJQUN3QUJBREVaRkRFWUVFUkNBRFl4R1lFQ0VqRVlFRVJDQUFneEdSUXhHQlFRUXpZYUFVa1ZTd0VoQkZsSmdhb0ZFa1JQQWt4TEFsSWxXU01MZ2F3RkNCSkVKRU1sU1NnMkdnRkhBaVZaU1U0Q1NTSUxnUUlJVHdJVkVrUTJHZ0pKRllHQUF4SkVLa2xPQWs0RFNWY0FZRWxPQk9RQ1JFbFhZTUJKVGdUa0EwU0JvQUlqV0VsT0ErUUNSSUdnQlZzU1JDVkpTd1lNUVFBWVN3WlhBZ0JMQVVsT0FpSUxJbGdwcEVRa0NFVUJRdi9oU3dWQUFLOUxCRWtoQkZsTEFSVlNWd0pnZ0FSamNIVmlzRW13Z0FSd2FWOWhzRXNFU2JDQUJIQnBYMkt3U3dSSlRnT3dnQVJ3YVY5anNFc0VTVTRDc0lBZ2MrMm5VeW1kZlVnek9kZ0lDYUhZQlZPOXBBTC8vbHYrLy8vLy93QUFBQURoQWtrVkl4SkVUd0pRVEZCTEJrbE9BbGNBWUZCTEFZTUNvQUxBQVZoUEEweFFTd0tEQXVBRHdBRllVRThDVjJEQVVPSUNnZ0lCQUFFQlN3Sk5nQTV3WVdseWFXNW5JSEpsYzNWc2RMQ3dSQ1JES0VVS0pFVUlTd2RMQmc1QkFDTkxCRWtoQkZsTEFSVlNWd0lBU3doSlRnSWpDeU5ZU3d0TVVFVUxKQWhGQ0VMLzFTaEZDU1ZGQVVsTEJneEJBQ3BMQmxjQ0FFc0JTVTRDSWdzaVdDbXFTUlVpRGtRaXI2dEpGU0lTUkVzS1RGQkZDaVFJUlFGQy84OUxDVXNKNHdKSkZTTVNSRXNGU1NFRVdVc0JGVkpYQW1EZ0Fra1ZJeEpFUXY3VSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlZFUklGSUNBVElPTl9LRVkiOnsidHlwZSI6IkFWTUJ5dGVzIiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
