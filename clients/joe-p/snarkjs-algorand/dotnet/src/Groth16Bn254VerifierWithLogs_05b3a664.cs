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

namespace Arc56.Generated.joe_p.snarkjs_algorand.Groth16Bn254VerifierWithLogs_05b3a664
{


    public class Groth16Bn254VerifierWithLogsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Groth16Bn254VerifierWithLogsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JvdGgxNkJuMjU0VmVyaWZpZXJXaXRoTG9ncyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHcm90aDE2Qm4yNTRQcm9vZiI6W3sibmFtZSI6InBpX2EiLCJ0eXBlIjoiYnl0ZVs2NF0ifSx7Im5hbWUiOiJwaV9iIiwidHlwZSI6ImJ5dGVbMTI4XSJ9LHsibmFtZSI6InBpX2MiLCJ0eXBlIjoiYnl0ZVs2NF0ifV0sIkdyb3RoMTZCbjI1NFZlcmlmaWNhdGlvbktleSI6W3sibmFtZSI6InZrX2FscGhhXzEiLCJ0eXBlIjoiYnl0ZVs2NF0ifSx7Im5hbWUiOiJ2a19iZXRhXzIiLCJ0eXBlIjoiYnl0ZVsxMjhdIn0seyJuYW1lIjoidmtfZ2FtbWFfMiIsInR5cGUiOiJieXRlWzEyOF0ifSx7Im5hbWUiOiJ2a19kZWx0YV8yIiwidHlwZSI6ImJ5dGVbMTI4XSJ9LHsibmFtZSI6Im5QdWJsaWMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiSUMiLCJ0eXBlIjoiYnl0ZVs2NF1bXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJfZHVtbXkiLCJkZXNjIjoiRHVtbXkgZnVuY3Rpb24gdGhhdCBvbmx5IGV4aXN0cyBzbyB3ZSBjYW4gaGF2ZSB0aGUgVmVyaWZpY2F0aW9uS2V5IHR5cGUgaW4gdGhlIGdlbmVyYXRlZCBjbGllbnQiLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbNjRdLGJ5dGVbMTI4XSxieXRlWzEyOF0sYnl0ZVsxMjhdLHVpbnQ2NCxieXRlWzY0XVtdKSIsInN0cnVjdCI6Ikdyb3RoMTZCbjI1NFZlcmlmaWNhdGlvbktleSIsIm5hbWUiOiJfdmsiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJDbG9zZU91dCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYnl0ZVs2NF0sYnl0ZVsxMjhdLGJ5dGVbNjRdKSIsInN0cnVjdCI6Ikdyb3RoMTZCbjI1NFByb29mIiwibmFtZSI6InByb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY1XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBudW1iZXIgb2YgcHVibGljIGlucHV0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2NF0sImVycm9yTWVzc2FnZSI6Ikxlbmd0aCBtdXN0IGJlIDMyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAyLDQ4OCw1MDhdLCJlcnJvck1lc3NhZ2UiOiJMZW5ndGggbXVzdCBiZSA2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3MV0sImVycm9yTWVzc2FnZSI6IlZlcmlmaWNhdGlvbiBmYWlsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODcsNDA5LDQ0OV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAsMTAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQyNTY+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGNvbnRyYWN0cy9ncm90aDE2X2JuMjU0LmFsZ28udHM6Okdyb3RoMTZCbjI1NFByb29mIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgY29udHJhY3RzL2dyb3RoMTZfYm4yNTQuYWxnby50czo6R3JvdGgxNkJuMjU0VmVyaWZpY2F0aW9uS2V5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA1IG9mICh1aW50OFs2NF0sdWludDhbMTI4XSx1aW50OFsxMjhdLHVpbnQ4WzEyOF0sdWludDY0LChsZW4rdWludDhbNjRdW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Nl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjoicGlfYSBub3QgaW4gRzEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTBdLCJlcnJvck1lc3NhZ2UiOiJwaV9iIG5vdCBpbiBHMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1OV0sImVycm9yTWVzc2FnZSI6InBpX2Mgbm90IGluIEcxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkwXSwiZXJyb3JNZXNzYWdlIjoicHVibGljIHNpZ25hbCBub3QgaW4gRnIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJjYmxvY2tzIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdOalFnTVNBd0lEUTFOZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlQ0F3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFZ1ZFMVFURjlXUlZKSlJrbERRVlJKVDA1ZlMwVlpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkY5MlpYSnBabWxsY2k1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSM0p2ZEdneE5rSnVNalUwVm1WeWFXWnBaWEpYYVhSb1RHOW5jeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMkNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1UWXhNR1ZpWkdFZ01IZzFOV0UzWW1JM01TQXZMeUJ0WlhSb2IyUWdJbDlrZFcxdGVTZ29ZbmwwWlZzMk5GMHNZbmwwWlZzeE1qaGRMR0o1ZEdWYk1USTRYU3hpZVhSbFd6RXlPRjBzZFdsdWREWTBMR0o1ZEdWYk5qUmRXMTBwS1hadmFXUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVTaDFhVzUwTWpVMlcxMHNLR0o1ZEdWYk5qUmRMR0o1ZEdWYk1USTRYU3hpZVhSbFd6WTBYU2twZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlgyUjFiVzE1WDNKdmRYUmxRRE1nYldGcGJsOTJaWEpwWm5sZmNtOTFkR1ZBTkFvZ0lDQWdaWEp5Q2dwdFlXbHVYM1psY21sbWVWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFJmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnZG1WeWFXWjVLSE5wWjI1aGJITTZJRkIxWW14cFkxTnBaMjVoYkhNc0lIQnliMjltT2lCSGNtOTBhREUyUW00eU5UUlFjbTl2WmlrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ2RtVnlhV1o1Q2dwdFlXbHVYMTlrZFcxdGVWOXliM1YwWlVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFJmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSWtOc2IzTmxUM1YwSWlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRU5zYjNObFQzVjBDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdYMlIxYlcxNUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUEyT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUmZkbVZ5YVdacFpYSXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVkeWIzUm9NVFpDYmpJMU5GWmxjbWxtYVdWeVYybDBhRXh2WjNNZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBYM1psY21sbWFXVnlMbUZzWjI4dWRITTZPa2R5YjNSb01UWkNiakkxTkZabGNtbG1hV1Z5VjJsMGFFeHZaM011WDJSMWJXMTVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWDJSMWJXMTVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRSZmRtVnlhV1pwWlhJdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrTnNiM05sVDNWMElpQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05EVTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRMU9Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBMUlHOW1JQ2gxYVc1ME9GczJORjBzZFdsdWREaGJNVEk0WFN4MWFXNTBPRnN4TWpoZExIVnBiblE0V3pFeU9GMHNkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJOalJkVzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBME5qQUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk9rZHliM1JvTVRaQ2JqSTFORlpsY21sbWFXTmhkR2x2Ymt0bGVRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBYM1psY21sbWFXVnlMbUZzWjI4dWRITTZPa2R5YjNSb01UWkNiakkxTkZabGNtbG1hV1Z5VjJsMGFFeHZaM011ZG1WeWFXWjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVPZ29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFJmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnZG1WeWFXWjVLSE5wWjI1aGJITTZJRkIxWW14cFkxTnBaMjVoYkhNc0lIQnliMjltT2lCSGNtOTBhREUyUW00eU5UUlFjbTl2WmlrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkREkxTmo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTFOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem82UjNKdmRHZ3hOa0p1TWpVMFVISnZiMllLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1qWXhDaUFnSUNBdkx5QmtaV052WkdWQmNtTTBQRWR5YjNSb01UWkNiakkxTkZabGNtbG1hV05oZEdsdmJrdGxlVDRvZG10Q2VYUmxjeWtzQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRlJOVUV4ZlZrVlNTVVpKUTBGVVNVOU9YMHRGV1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCaGMzTmxjblFvWnpGSGNtOTFjRU5vWldOcktIQnliMjltTG5CcFgyRXBMQ0FpY0dsZllTQnViM1FnYVc0Z1J6RWlLVHNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OMVltZHliM1Z3UTJobFkyc29iM0F1UldNdVFrNHlOVFJuTVN3Z2NDazdDaUFnSUNCbFkxOXpkV0puY205MWNGOWphR1ZqYXlCQ1RqSTFOR2N4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qZzBDaUFnSUNBdkx5QmhjM05sY25Rb1p6RkhjbTkxY0VOb1pXTnJLSEJ5YjI5bUxuQnBYMkVwTENBaWNHbGZZU0J1YjNRZ2FXNGdSekVpS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3YVY5aElHNXZkQ0JwYmlCSE1Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnWVhOelpYSjBLR2N5UjNKdmRYQkRhR1ZqYXlod2NtOXZaaTV3YVY5aUtTd2dJbkJwWDJJZ2JtOTBJR2x1SUVjeUlpazdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTmpRZ01USTRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OMVltZHliM1Z3UTJobFkyc29iM0F1UldNdVFrNHlOVFJuTWl3Z2NDazdDaUFnSUNCbFkxOXpkV0puY205MWNGOWphR1ZqYXlCQ1RqSTFOR2N5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QmhjM05sY25Rb1p6SkhjbTkxY0VOb1pXTnJLSEJ5YjI5bUxuQnBYMklwTENBaWNHbGZZaUJ1YjNRZ2FXNGdSeklpS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3YVY5aUlHNXZkQ0JwYmlCSE1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWVhOelpYSjBLR2N4UjNKdmRYQkRhR1ZqYXlod2NtOXZaaTV3YVY5aktTd2dJbkJwWDJNZ2JtOTBJR2x1SUVjeElpazdDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVSV3hzYVhCMGFXTkRkWEoyWlM1emRXSm5jbTkxY0VOb1pXTnJLRzl3TGtWakxrSk9NalUwWnpFc0lIQXBPd29nSUNBZ1pXTmZjM1ZpWjNKdmRYQmZZMmhsWTJzZ1FrNHlOVFJuTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdZWE56WlhKMEtHY3hSM0p2ZFhCRGFHVmpheWh3Y205dlppNXdhVjlqS1N3Z0luQnBYMk1nYm05MElHbHVJRWN4SWlrN0NpQWdJQ0JoYzNObGNuUWdMeThnY0dsZll5QnViM1FnYVc0Z1J6RUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUdGemMyVnlkQ2h6YVdkdVlXeHpMbXhsYm1kMGFDQTlQVDBnZG1zdWJsQjFZbXhwWXl3Z0lrbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlIQjFZbXhwWXlCcGJuQjFkSE1pS1RzS0lDQWdJSEIxYzJocGJuUWdORFE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHNTFiV0psY2lCdlppQndkV0pzYVdNZ2FXNXdkWFJ6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9LZG1WeWFXWjVYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYzJsbmJtRnNJRzltSUhOcFoyNWhiSE1wSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURZS0lDQWdJRHdLSUNBZ0lHSjZJSFpsY21sbWVWOWhablJsY2w5bWIzSkFOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbTR5TlRSZlkyOXRiVzl1TG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUhKbGRIVnliaUIyWVd4MVpTNWhjMEpwWjFWcGJuUW9LU0E4SUVKT01qVTBYMU5EUVV4QlVsOU5UMFJWVEZWVE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJOENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJqSTFOQzVoYkdkdkxuUnpPams1Q2lBZ0lDQXZMeUJoYzNObGNuUW9hVzVHYVdWc1pDaHphV2R1WVd3cExDQWljSFZpYkdsaklITnBaMjVoYkNCdWIzUWdhVzRnUm5JaUtUc0tJQ0FnSUdGemMyVnlkQ0F2THlCd2RXSnNhV01nYzJsbmJtRnNJRzV2ZENCcGJpQkdjZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCMlpYSnBabmxmWm05eVgyaGxZV1JsY2tBeUNncDJaWEpwWm5sZllXWjBaWEpmWm05eVFEUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z2FXWWdLSE5wWjI1aGJITXViR1Z1WjNSb0lEMDlQU0F3S1NCN0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWW01NklIWmxjbWxtZVY5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UTXdDaUFnSUNBdkx5QnlaWFIxY200Z2Rtc3VTVU5iTUYwZ1lYTWdZbmwwWlhNOE5qUStPd29nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklEUTFOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBMk5Bb0tkbVZ5YVdaNVgyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6bzZZMjl0Y0hWMFpVTndkV0pBTVRNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJqSTFOQzVoYkdkdkxuUnpPakl3T0FvZ0lDQWdMeThnWkdWaWRXZE1iMmNvSW1Od2RXSWlMQ0JqY0hWaUtUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaVkzQjFZaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYmpJMU5GOWpiMjF0YjI0dVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2JHOW5LRzVoYldVcE93b2dJQ0FnYkc5bkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltNHlOVFJmWTI5dGJXOXVMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR3h2WnloMllXeDFaU2s3Q2lBZ0lDQmtkWEFLSUNBZ0lHeHZad29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pveU1URUtJQ0FnSUM4dklHUmxZblZuVEc5bktDSndhVjloSWl3Z2NISnZiMll1Y0dsZllTazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luQnBYMkVpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW00eU5UUmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHeHZaeWh1WVcxbEtUc0tJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnVNalUwWDJOdmJXMXZiaTVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJzYjJjb2RtRnNkV1VwT3dvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qSXhNZ29nSUNBZ0x5OGdaR1ZpZFdkTWIyY29JbkJwWDJJaUxDQndjbTl2Wmk1d2FWOWlLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWljR2xmWWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWJqSTFORjlqYjIxdGIyNHVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdiRzluS0c1aGJXVXBPd29nSUNBZ2JHOW5DaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbTR5TlRSZlkyOXRiVzl1TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUd4dlp5aDJZV3gxWlNrN0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCc2IyY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02TWpFekNpQWdJQ0F2THlCa1pXSjFaMHh2WnlnaWNHbGZZeUlzSUhCeWIyOW1MbkJwWDJNcE93b2dJQ0FnY0hWemFHSjVkR1Z6SUNKd2FWOWpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkp1TWpVMFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCc2IyY29ibUZ0WlNrN0NpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWJqSTFORjlqYjIxdGIyNHVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdiRzluS0haaGJIVmxLVHNLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3h2WndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKdU1qVTBYMk52YlcxdmJpNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QnlaWFIxY200Z1p6RlVhVzFsYzBaeUtIQXNJRkpmVFVsT1ZWTmZNU2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW00eU5UUmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OallXeGhjazExYkNodmNDNUZZeTVDVGpJMU5HY3hMQ0J3TENCQ2VYUmxjeWh6S1NrdWRHOUdhWGhsWkNoN0NpQWdJQ0JsWTE5elkyRnNZWEpmYlhWc0lFSk9NalUwWnpFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWJqSTFORjlqYjIxdGIyNHVZV3huYnk1MGN6bzJNaTAyTkFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TGtWc2JHbHdkR2xqUTNWeWRtVXVjMk5oYkdGeVRYVnNLRzl3TGtWakxrSk9NalUwWnpFc0lIQXNJRUo1ZEdWektITXBLUzUwYjBacGVHVmtLSHNLSUNBZ0lDOHZJQ0FnYkdWdVozUm9PaUEyTkN3S0lDQWdJQzh2SUgwcE93b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aVzVuZEdnZ2JYVnpkQ0JpWlNBMk5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem95TVRrS0lDQWdJQzh2SUdOdmJuTjBJR2N4VUc5cGJuUnpJRDBnYm1WblVHbEJMbU52Ym1OaGRDaGpjSFZpS1M1amIyNWpZWFFvY0hKdmIyWXVjR2xmWXlrdVkyOXVZMkYwS0hackxuWnJYMkZzY0doaFh6RXBPd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFkwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZNakl6Q2lBZ0lDQXZMeUF1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ01USTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pJeU1pMHlNak1LSUNBZ0lDOHZJR052Ym5OMElHY3lVRzlwYm5SeklEMGdjSEp2YjJZdWNHbGZZZ29nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6b3lNalFLSUNBZ0lDOHZJQzVqYjI1allYUW9kbXN1ZG10ZlpHVnNkR0ZmTWlrS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBjeUF6TWpBZ01USTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6b3lNakl0TWpJMENpQWdJQ0F2THlCamIyNXpkQ0JuTWxCdmFXNTBjeUE5SUhCeWIyOW1MbkJwWDJJS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoMmF5NTJhMTluWVcxdFlWOHlLUW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyUmxiSFJoWHpJcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02TWpJMUNpQWdJQ0F2THlBdVkyOXVZMkYwS0hackxuWnJYMkpsZEdGZk1pazdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTVRJNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJqSTFOQzVoYkdkdkxuUnpPakl5TWkweU1qVUtJQ0FnSUM4dklHTnZibk4wSUdjeVVHOXBiblJ6SUQwZ2NISnZiMll1Y0dsZllnb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtIWnJMblpyWDJkaGJXMWhYeklwQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvZG1zdWRtdGZaR1ZzZEdGZk1pa0tJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaDJheTUyYTE5aVpYUmhYeklwT3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlozSnZkR2d4Tmw5aWJqSTFOQzVoYkdkdkxuUnpPakl5T0FvZ0lDQWdMeThnWTI5dWMzUWdjbVZ6SUQwZ2IzQXVSV3hzYVhCMGFXTkRkWEoyWlM1d1lXbHlhVzVuUTJobFkyc29iM0F1UldNdVFrNHlOVFJuTVN3Z1p6RlFiMmx1ZEhNc0lHY3lVRzlwYm5SektUc0tJQ0FnSUdWalgzQmhhWEpwYm1kZlkyaGxZMnNnUWs0eU5UUm5NUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pveU16QUtJQ0FnSUM4dklHUmxZblZuVEc5bktDSndZV2x5YVc1bklISmxjM1ZzZENJc0lISmxjeUEvSUVKNWRHVnpMbVp5YjIxSVpYZ29JakF4SWlrZ09pQkNlWFJsY3k1bWNtOXRTR1Y0S0NJd01DSXBLVHNLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd3TUNBd2VEQXhDaUFnSUNCa2FXY2dNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbkJoYVhKcGJtY2djbVZ6ZFd4MElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnVNalUwWDJOdmJXMXZiaTVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJzYjJjb2JtRnRaU2s3Q2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYmpJMU5GOWpiMjF0YjI0dVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2JHOW5LSFpoYkhWbEtUc0tJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFJmZG1WeWFXWnBaWEl1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWVhOelpYSjBLSFpsY21sbWVVWnliMjFVWlcxd2JHRjBaVmRwZEdoTWIyZHpLSE5wWjI1aGJITXNJSEJ5YjI5bUtTd2dJbFpsY21sbWFXTmhkR2x2YmlCbVlXbHNaV1FpS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJXWlhKcFptbGpZWFJwYjI0Z1ptRnBiR1ZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5GOTJaWEpwWm1sbGNpNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjJaWEpwWm5rb2MybG5ibUZzY3pvZ1VIVmliR2xqVTJsbmJtRnNjeXdnY0hKdmIyWTZJRWR5YjNSb01UWkNiakkxTkZCeWIyOW1LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AyWlhKcFpubGZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUd4bGRDQnBZMUJ2YVc1MGN5QTlJRUo1ZEdWektDazdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qRXpOUW9nSUNBZ0x5OGdabTl5SUNoc1pYUWdhVG9nZFdsdWREWTBJRDBnTVRzZ2FTQThQU0J6YVdkdVlXeHpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZblZ5ZVNBNENncDJaWEpwWm5sZmQyaHBiR1ZmZEc5d1FEYzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNVHNnYVNBOFBTQnphV2R1WVd4ekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQmthV2NnTndvZ0lDQWdaR2xuSURZS0lDQWdJRHc5Q2lBZ0lDQmllaUIyWlhKcFpubGZZV1owWlhKZmQyaHBiR1ZBT1FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6b3hNellLSUNBZ0lDOHZJR2xqVUc5cGJuUnpJRDBnYVdOUWIybHVkSE11WTI5dVkyRjBLSFpyTGtsRExtRjBLR2twSVNrN0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTkRVMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlERXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNVHNnYVNBOFBTQnphV2R1WVd4ekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTRDaUFnSUNCaUlIWmxjbWxtZVY5M2FHbHNaVjkwYjNCQU53b0tkbVZ5YVdaNVgyRm1kR1Z5WDNkb2FXeGxRRGs2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qRTBNQW9nSUNBZ0x5OGdiR1YwSUhOallXeGhjbk1nUFNCQ2VYUmxjeWdwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdZblZ5ZVNBeENncDJaWEpwWm5sZlptOXlYMmhsWVdSbGNrQXhNRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJSE5wWjI1aGJDQnZaaUJ6YVdkdVlXeHpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQThDaUFnSUNCaWVpQjJaWEpwWm5sZllXWjBaWEpmWm05eVFERXlDaUFnSUNCa2FXY2dOZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWliakkxTkY5amIyMXRiMjR1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnY21WMGRYSnVJR0VnSlNCQ1RqSTFORjlUUTBGTVFWSmZUVTlFVlV4VlV6c0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnVNalUwWDJOdmJXMXZiaTVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUZWcGJuUXlOVFlvWVNrdVlubDBaWE11ZEc5R2FYaGxaQ2g3SUd4bGJtZDBhRG9nTXpJZ2ZTazdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aVzVuZEdnZ2JYVnpkQ0JpWlNBek1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUhOallXeGhjbk1nUFNCelkyRnNZWEp6TG1OdmJtTmhkQ2hpTXpJb1puSlRZMkZzWVhJb2MybG5ibUZzTG1GelFtbG5WV2x1ZENncEtTa3BPd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnZG1WeWFXWjVYMlp2Y2w5b1pXRmtaWEpBTVRBS0NuWmxjbWxtZVY5aFpuUmxjbDltYjNKQU1USTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFME5pMHhOVEFLSUNBZ0lDOHZJR3hsZENCamNIVmlJRDBnYjNBdVJXeHNhWEIwYVdORGRYSjJaUzV6WTJGc1lYSk5kV3hOZFd4MGFTZ0tJQ0FnSUM4dklDQWdiM0F1UldNdVFrNHlOVFJuTVN3S0lDQWdJQzh2SUNBZ2FXTlFiMmx1ZEhNc0NpQWdJQ0F2THlBZ0lITmpZV3hoY25Nc0NpQWdJQ0F2THlBcExuUnZSbWw0WldRb2V5QnNaVzVuZEdnNklEWTBJSDBwT3dvZ0lDQWdaR2xuSURrS0lDQWdJR1JwWnlBNUNpQWdJQ0JsWTE5dGRXeDBhVjl6WTJGc1lYSmZiWFZzSUVKT01qVTBaekVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UVXpDaUFnSUNBdkx5QmpjSFZpSUQwZ1p6RkJaR1FvWTNCMVlpd2dkbXN1U1VOYk1GMGdZWE1nWW5sMFpYTThOalErS1RzS0lDQWdJR1JwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTlRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYmpJMU5GOWpiMjF0YjI0dVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xrVnNiR2x3ZEdsalEzVnlkbVV1WVdSa0tHOXdMa1ZqTGtKT01qVTBaekVzSUhBeExDQndNaWt1ZEc5R2FYaGxaQ2g3SUd4bGJtZDBhRG9nTmpRZ2ZTazdDaUFnSUNCbFkxOWhaR1FnUWs0eU5UUm5NUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlc1bmRHZ2diWFZ6ZENCaVpTQTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pveU1EY0tJQ0FnSUM4dklHTnZibk4wSUdOd2RXSWdQU0JqYjIxd2RYUmxRM0IxWWloMmF5d2djMmxuYm1Gc2N5azdDaUFnSUNCaUlIWmxjbWxtZVY5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBjeTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk9tTnZiWEIxZEdWRGNIVmlRREV6Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZJRUFCQU1nREpnTUFJREJrVG5MaE1hQXB1RkJGdG9HQldGMG9NK2hJZWJsd2tVUGg5WlB3QUFBQkFERWJRUUFzZ2dJRUZoRHIyZ1JWcDd0eE5ob0FqZ0lBQ3dBQkFERVpGREVZRUVSQ0FEWXhHWUVDRWpFWUVFUkNBQWd4R1JReEdCUVFRellhQVVrVlN3RWhCRmxKZ2NvREVrUlBBa3hMQWxJbFdTTUxnY3dEQ0JKRUpFTWxTU2cyR2dGSEFpVlpTVTRDU1NJTGdRSUlUd0lWRWtRMkdnSkpGWUdBQWhKRUtrbE9BazREU1ZjQVFFbE9CT1FBUkVsWFFJQkpUZ1RrQVVSWHdFQkpUZ1BrQUVTQndBTmJFa1FsU1VzR0RFRUFHRXNHVndJQVN3RkpUZ0lpQ3lKWUthUkVKQWhGQVVMLzRVc0ZRQUNyU3dSSklRUlpTd0VWVWxjQ1FJQUVZM0IxWXJCSnNJQUVjR2xmWWJCTEJFbXdnQVJ3YVY5aXNFc0VTVTREc0lBRWNHbGZZN0JMQkVsT0FyQ0FJREJrVG5MaE1hQXB1RkJGdG9HQldGMG9NK2hJZWJsd2tVUGg5WlB3QUFBQTRRQkpGU01TUkU4Q1VFeFFTd1pKVGdKWEFFQlFTd0ZYd0lCUEEweFFTd0tEQXNBQ2dBRllVRThDVjBDQVVPSUFnZ0lCQUFFQlN3Sk5nQTV3WVdseWFXNW5JSEpsYzNWc2RMQ3dSQ1JES0VVS0pFVUlTd2RMQmc1QkFDTkxCRWtoQkZsTEFSVlNWd0lBU3doSlRnSWpDeU5ZU3d0TVVFVUxKQWhGQ0VMLzFTaEZDU1ZGQVVsTEJneEJBQ3BMQmxjQ0FFc0JTVTRDSWdzaVdDbXFTUlVpRGtRaXI2dEpGU0lTUkVzS1RGQkZDaVFJUlFGQy84OUxDVXNKNHdCSkZTTVNSRXNGU1NFRVdVc0JGVkpYQWtEZ0FFa1ZJeEpFUXY3WSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlZFUklGSUNBVElPTl9LRVkiOnsidHlwZSI6IkFWTUJ5dGVzIiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
