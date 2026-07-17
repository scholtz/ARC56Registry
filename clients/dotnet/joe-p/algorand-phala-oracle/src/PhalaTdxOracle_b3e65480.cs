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

namespace Arc56.Generated.joe_p.algorand_phala_oracle.PhalaTdxOracle_b3e65480
{


    public class PhalaTdxOracleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PhalaTdxOracleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CommittedInputs : AVMObjectType
            {
                public byte[] Rtmr0 { get; set; }

                public byte[] Rtmr1 { get; set; }

                public byte[] Rtmr2 { get; set; }

                public byte[] Rtmr3 { get; set; }

                public byte[] Pubkey { get; set; }

                public byte[] ComposeHash { get; set; }

                public byte[] AppId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    vRtmr0.From(Rtmr0);
                    ret.AddRange(vRtmr0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    vRtmr1.From(Rtmr1);
                    ret.AddRange(vRtmr1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    vRtmr2.From(Rtmr2);
                    ret.AddRange(vRtmr2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    vRtmr3.From(Rtmr3);
                    ret.AddRange(vRtmr3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPubkey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vPubkey.From(Pubkey);
                    ret.AddRange(vPubkey.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vComposeHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vComposeHash.From(ComposeHash);
                    ret.AddRange(vComposeHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[20]");
                    vAppId.From(AppId);
                    ret.AddRange(vAppId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CommittedInputs Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CommittedInputs();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    count = vRtmr0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRtmr0 = vRtmr0.ToValue();
                    if (valueRtmr0 is byte[] vRtmr0Value) { ret.Rtmr0 = vRtmr0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    count = vRtmr1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRtmr1 = vRtmr1.ToValue();
                    if (valueRtmr1 is byte[] vRtmr1Value) { ret.Rtmr1 = vRtmr1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    count = vRtmr2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRtmr2 = vRtmr2.ToValue();
                    if (valueRtmr2 is byte[] vRtmr2Value) { ret.Rtmr2 = vRtmr2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRtmr3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[48]");
                    count = vRtmr3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRtmr3 = vRtmr3.ToValue();
                    if (valueRtmr3 is byte[] vRtmr3Value) { ret.Rtmr3 = vRtmr3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPubkey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vPubkey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePubkey = vPubkey.ToValue();
                    if (valuePubkey is byte[] vPubkeyValue) { ret.Pubkey = vPubkeyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vComposeHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vComposeHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueComposeHash = vComposeHash.ToValue();
                    if (valueComposeHash is byte[] vComposeHashValue) { ret.ComposeHash = vComposeHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[20]");
                    count = vAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppId = vAppId.ToValue();
                    if (valueAppId is byte[] vAppIdValue) { ret.AppId = vAppIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CommittedInputs);
                }
                public bool Equals(CommittedInputs? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CommittedInputs left, CommittedInputs right)
                {
                    return EqualityComparer<CommittedInputs>.Default.Equals(left, right);
                }
                public static bool operator !=(CommittedInputs left, CommittedInputs right)
                {
                    return !(left == right);
                }

            }

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

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="verifierAddress"> </param>
        public async Task CreateApplication(Algorand.Address verifierAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var verifierAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAddressAbi.From(verifierAddress);

            var result = await base.CallApp(new List<object> { abiHandle, verifierAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address verifierAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var verifierAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAddressAbi.From(verifierAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, verifierAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="verifier"> </param>
        /// <param name="signals"> </param>
        /// <param name="proof"> Groth16Bn254Proof</param>
        /// <param name="committedInputs"> CommittedInputs</param>
        public async Task Bootstrap(PaymentTransaction verifier, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, Structs.CommittedInputs committedInputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { verifier });
            byte[] abiHandle = { 50, 153, 60, 53 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            var result = await base.CallApp(new List<object> { abiHandle, verifier, signalsAbi, proof, committedInputs }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(PaymentTransaction verifier, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] signals, Structs.Groth16Bn254Proof proof, Structs.CommittedInputs committedInputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { verifier });
            byte[] abiHandle = { 50, 153, 60, 53 };
            var signalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); signalsAbi.From(signals);

            return await base.MakeTransactionList(new List<object> { abiHandle, verifier, signalsAbi, proof, committedInputs }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGhhbGFUZHhPcmFjbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ29tbWl0dGVkSW5wdXRzIjpbeyJuYW1lIjoicnRtcjAiLCJ0eXBlIjoiYnl0ZVs0OF0ifSx7Im5hbWUiOiJydG1yMSIsInR5cGUiOiJieXRlWzQ4XSJ9LHsibmFtZSI6InJ0bXIyIiwidHlwZSI6ImJ5dGVbNDhdIn0seyJuYW1lIjoicnRtcjMiLCJ0eXBlIjoiYnl0ZVs0OF0ifSx7Im5hbWUiOiJwdWJrZXkiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJjb21wb3NlSGFzaCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImFwcElEIiwidHlwZSI6ImJ5dGVbMjBdIn1dLCJHcm90aDE2Qm4yNTRQcm9vZiI6W3sibmFtZSI6InBpX2EiLCJ0eXBlIjoiYnl0ZVs2NF0ifSx7Im5hbWUiOiJwaV9iIiwidHlwZSI6ImJ5dGVbMTI4XSJ9LHsibmFtZSI6InBpX2MiLCJ0eXBlIjoiYnl0ZVs2NF0ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTZbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hbHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihieXRlWzY0XSxieXRlWzEyOF0sYnl0ZVs2NF0pIiwic3RydWN0IjoiR3JvdGgxNkJuMjU0UHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihieXRlWzQ4XSxieXRlWzQ4XSxieXRlWzQ4XSxieXRlWzQ4XSxieXRlWzMyXSxieXRlWzMyXSxieXRlWzIwXSkiLCJzdHJ1Y3QiOiJDb21taXR0ZWRJbnB1dHMiLCJuYW1lIjoiY29tbWl0dGVkSW5wdXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6OX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjc3XSwiZXJyb3JNZXNzYWdlIjoiQ29tcG9zZSBoYXNoIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4XSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgYWxyZWFkeSBib290c3RyYXBwZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjldLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIHNpZ25hbHMgbGVuZ3RoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY0XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCB2ZXJpZmllciBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ5XSwiZXJyb3JNZXNzYWdlIjoiTGVuZ3RoIG11c3QgYmUgMzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODVdLCJlcnJvck1lc3NhZ2UiOiJQaGFsYSBBcHAgSUQgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTNdLCJlcnJvck1lc3NhZ2UiOiJSVE1SMCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwM10sImVycm9yTWVzc2FnZSI6IlJUTVIxIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEzXSwiZXJyb3JNZXNzYWdlIjoiUlRNUjIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjNdLCJlcnJvck1lc3NhZ2UiOiJSVE1SMyBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MV0sImVycm9yTWVzc2FnZSI6IlNpZ25hbCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1N10sImVycm9yTWVzc2FnZSI6IlRoZSBmZWUgcGF5bWVudCB0cmFuc2FjdGlvbiBtdXN0IGJlIGEgMCBBTEdPIHBheSB0aGF0IGNsb3NlcyB0byB0aGUgYXBwIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjIsMjczLDI4MSwyODksMjk5LDMwOSwzMTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQyNTY+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGNvbnRyYWN0cy9vcmFjbGUuYWxnby50czo6Q29tbWl0dGVkSW5wdXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGNvbnRyYWN0cy9vcmFjbGUuYWxnby50czo6R3JvdGgxNkJuMjU0UHJvb2YiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NiwxMjhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUVpSUNKMklpQWlZeUlnSWpBaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFhR0ZzWVZSa2VFOXlZV05zWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUExQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TWprNU0yTXpOU0F2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0Nod1lYa3NkV2x1ZERJMU5sdGRMQ2hpZVhSbFd6WTBYU3hpZVhSbFd6RXlPRjBzWW5sMFpWczJORjBwTENoaWVYUmxXelE0WFN4aWVYUmxXelE0WFN4aWVYUmxXelE0WFN4aWVYUmxXelE0WFN4aWVYUmxXek15WFN4aWVYUmxXek15WFN4aWVYUmxXekl3WFNrcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdKdmIzUnpkSEpoY0FvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFhR0ZzWVZSa2VFOXlZV05zWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdRek1qUmlaV0UwSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHVnljZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvNlVHaGhiR0ZVWkhoUGNtRmpiR1V1WTNKbFlYUmxRWEJ3YkdsallYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvZG1WeWFXWnBaWEpCWkdSeVpYTnpPaUJCWTJOdmRXNTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdkbVZ5YVdacFpYSkJaR1J5WlhOeklEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ0oySWlCOUtUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luWWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklIUm9hWE11ZG1WeWFXWnBaWEpCWkdSeVpYTnpMblpoYkhWbElEMGdkbVZ5YVdacFpYSkJaR1J5WlhOek93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvNE9Rb2dJQ0FnTHk4Z1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b2RtVnlhV1pwWlhKQlpHUnlaWE56T2lCQlkyTnZkVzUwS1NCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPanBRYUdGc1lWUmtlRTl5WVdOc1pTNWliMjkwYzNSeVlYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjI5MGMzUnlZWEE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVFExTFRFMU1Bb2dJQ0FnTHk4Z1ltOXZkSE4wY21Gd0tBb2dJQ0FnTHk4Z0lDQjJaWEpwWm1sbGNqb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxBb2dJQ0FnTHk4Z0lDQnphV2R1WVd4ek9pQlRhV2R1WVd4ekxBb2dJQ0FnTHk4Z0lDQndjbTl2WmpvZ1IzSnZkR2d4TmtKdU1qVTBVSEp2YjJZc0NpQWdJQ0F2THlBZ0lHTnZiVzFwZEhSbFpFbHVjSFYwY3pvZ1EyOXRiV2wwZEdWa1NXNXdkWFJ6TEFvZ0lDQWdMeThnS1NCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkREkxTmo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOVFlnTHk4Z01qVTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02T2tkeWIzUm9NVFpDYmpJMU5GQnliMjltQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU56WWdMeThnTWpjMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZPa052YlcxcGRIUmxaRWx1Y0hWMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbkJvWVd4aFFYQndTV1F1YUdGelZtRnNkV1VzSUNKRGIyNTBjbUZqZENCaGJISmxZV1I1SUdKdmIzUnpkSEpoY0hCbFpDSXBPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2NHaGhiR0ZCY0hCSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEZCb1lXeGhRWEJ3U1VRK0tIc2dhMlY1T2lBaVlTSWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakUxTVFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxuQm9ZV3hoUVhCd1NXUXVhR0Z6Vm1Gc2RXVXNJQ0pEYjI1MGNtRmpkQ0JoYkhKbFlXUjVJR0p2YjNSemRISmhjSEJsWkNJcE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiblJ5WVdOMElHRnNjbVZoWkhrZ1ltOXZkSE4wY21Gd2NHVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UWTJDaUFnSUNBdkx5QmpiMjV6ZENCbVpXVlFZWGx0Wlc1MElEMGdaM1I0Ymk1UVlYbHRaVzUwVkhodUtGUjRiaTVuY205MWNFbHVaR1Y0SUNzZ01TazdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TmpndE1UYzNDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2dLSUNBZ0lDOHZJQ0FnWm1WbFVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjlMQW9nSUNBZ0x5OGdJQ0FpVkdobElHWmxaU0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1SUcxMWMzUWdZbVVnWVNBd0lFRk1SMDhnY0dGNUlIUm9ZWFFnWTJ4dmMyVnpJSFJ2SUhSb1pTQmhjSEFnWVdSa2NtVnpjeUlzQ2lBZ0lDQXZMeUFwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOekVLSUNBZ0lDOHZJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5qZ3RNVGMzQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNnS0lDQWdJQzh2SUNBZ1ptVmxVR0Y1YldWdWRDd0tJQ0FnSUM4dklDQWdld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0I5TEFvZ0lDQWdMeThnSUNBaVZHaGxJR1psWlNCd1lYbHRaVzUwSUhSeVlXNXpZV04wYVc5dUlHMTFjM1FnWW1VZ1lTQXdJRUZNUjA4Z2NHRjVJSFJvWVhRZ1kyeHZjMlZ6SUhSdklIUm9aU0JoY0hBZ1lXUmtjbVZ6Y3lJc0NpQWdJQ0F2THlBcE93b2dJQ0FnUFQwS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFM01nb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TmpndE1UYzNDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2dLSUNBZ0lDOHZJQ0FnWm1WbFVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjlMQW9nSUNBZ0x5OGdJQ0FpVkdobElHWmxaU0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1SUcxMWMzUWdZbVVnWVNBd0lFRk1SMDhnY0dGNUlIUm9ZWFFnWTJ4dmMyVnpJSFJ2SUhSb1pTQmhjSEFnWVdSa2NtVnpjeUlzQ2lBZ0lDQXZMeUFwT3dvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklFTnNiM05sVW1WdFlXbHVaR1Z5Vkc4S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOamd0TVRjM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDZ0tJQ0FnSUM4dklDQWdabVZsVUdGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCOUxBb2dJQ0FnTHk4Z0lDQWlWR2hsSUdabFpTQndZWGx0Wlc1MElIUnlZVzV6WVdOMGFXOXVJRzExYzNRZ1ltVWdZU0F3SUVGTVIwOGdjR0Y1SUhSb1lYUWdZMnh2YzJWeklIUnZJSFJvWlNCaGNIQWdZV1JrY21WemN5SXNDaUFnSUNBdkx5QXBPd29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVkdobElHWmxaU0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1SUcxMWMzUWdZbVVnWVNBd0lFRk1SMDhnY0dGNUlIUm9ZWFFnWTJ4dmMyVnpJSFJ2SUhSb1pTQmhjSEFnWVdSa2NtVnpjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRTNPUzB4T0RRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dabVZsVUdGNWJXVnVkQzVtWldVZ0t5QkhiRzlpWVd3dWJXbHVRbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRTRNUW9nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UZ3lDaUFnSUNBdkx5QmhiVzkxYm5RNklHWmxaVkJoZVcxbGJuUXVabVZsSUNzZ1IyeHZZbUZzTG0xcGJrSmhiR0Z1WTJVc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkdaV1VLSUNBZ0lHZHNiMkpoYkNCTmFXNUNZV3hoYm1ObENpQWdJQ0FyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakUzT1MweE9ETUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWm1WbFVHRjViV1Z1ZEM1bVpXVWdLeUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE56a3RNVGcwQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHWmxaVkJoZVcxbGJuUXVabVZsSUNzZ1IyeHZZbUZzTG0xcGJrSmhiR0Z1WTJVc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UVTBDaUFnSUNBdkx5QjBhR2x6TG5Cb1lXeGhRWEJ3U1dRdWRtRnNkV1VnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11WVhCd1NVUTdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblJ6SURJMU5pQXlNQ0F2THlBeU5UWXNJREl3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCd2FHRnNZVUZ3Y0Vsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4VUdoaGJHRkJjSEJKUkQ0b2V5QnJaWGs2SUNKaElpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUVpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVFUwQ2lBZ0lDQXZMeUIwYUdsekxuQm9ZV3hoUVhCd1NXUXVkbUZzZFdVZ1BTQmpiMjF0YVhSMFpXUkpibkIxZEhNdVlYQndTVVE3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TlRVS0lDQWdJQzh2SUhSb2FYTXVZMjl0Y0c5elpVaGhjMmd1ZG1Gc2RXVWdQU0JqYjIxdGFYUjBaV1JKYm5CMWRITXVZMjl0Y0c5elpVaGhjMmc3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXlNalFnTXpJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWTI5dGNHOXpaVWhoYzJnZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6TXlQaWg3SUd0bGVUb2dJbU1pSUgwcE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVl5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklIUm9hWE11WTI5dGNHOXpaVWhoYzJndWRtRnNkV1VnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11WTI5dGNHOXpaVWhoYzJnN0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5UWUtJQ0FnSUM4dklIUm9hWE11Y25SdGNqQXVkbUZzZFdVZ1BTQmpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakE3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFE0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSEowYlhJd0lEMGdSMnh2WW1Gc1UzUmhkR1U4VTJoaE16ZzBSR2xuWlhOMFBpaDdJR3RsZVRvZ0lqQWlJSDBwT3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpTUNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TlRZS0lDQWdJQzh2SUhSb2FYTXVjblJ0Y2pBdWRtRnNkV1VnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqQTdDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOVGNLSUNBZ0lDOHZJSFJvYVhNdWNuUnRjakV1ZG1Gc2RXVWdQU0JqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pFN0NpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0EwT0NBME9Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCeWRHMXlNU0E5SUVkc2IySmhiRk4wWVhSbFBGTm9ZVE00TkVScFoyVnpkRDRvZXlCclpYazZJQ0l4SWlCOUtUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaU1TSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5UY0tJQ0FnSUM4dklIUm9hWE11Y25SdGNqRXVkbUZzZFdVZ1BTQmpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakU3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TlRnS0lDQWdJQzh2SUhSb2FYTXVjblJ0Y2pJdWRtRnNkV1VnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqSTdDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBNU5pQTBPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnlkRzF5TWlBOUlFZHNiMkpoYkZOMFlYUmxQRk5vWVRNNE5FUnBaMlZ6ZEQ0b2V5QnJaWGs2SUNJeUlpQjlLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlNaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOVGdLSUNBZ0lDOHZJSFJvYVhNdWNuUnRjakl1ZG1Gc2RXVWdQU0JqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pJN0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5Ua0tJQ0FnSUM4dklIUm9hWE11Y25SdGNqTXVkbUZzZFdVZ1BTQmpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjak03Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaWGgwY21GamRDQXhORFFnTkRnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnY25SdGNqTWdQU0JIYkc5aVlXeFRkR0YwWlR4VGFHRXpPRFJFYVdkbGMzUStLSHNnYTJWNU9pQWlNeUlnZlNrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWpNaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRVNUNpQWdJQ0F2THlCMGFHbHpMbkowYlhJekxuWmhiSFZsSUQwZ1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG5KMGJYSXpPd29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVFl3Q2lBZ0lDQXZMeUIwYUdsekxuWnJTR0Z6YUM1MllXeDFaU0E5SUhOcFoyNWhiSE11WVhRb01Da2hMbUo1ZEdWekxuUnZSbWw0WldRb2V5QnNaVzVuZEdnNklETXlJSDBwT3dvZ0lDQWdaR2xuSURnS0lDQWdJR1Y0ZEhKaFkzUWdNaUF6TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTVpXNW5kR2dnYlhWemRDQmlaU0F6TWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUIyYTBoaGMyZ2dQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjek15UGloN0lHdGxlVG9nSW1zaUlIMHBPd29nSUNBZ2NIVnphR0o1ZEdWeklDSnJJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdkR2hwY3k1MmEwaGhjMmd1ZG1Gc2RXVWdQU0J6YVdkdVlXeHpMbUYwS0RBcElTNWllWFJsY3k1MGIwWnBlR1ZrS0hzZ2JHVnVaM1JvT2lBek1pQjlLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJSFpsY21sbWFXVnlMbk5sYm1SbGNpQTlQVDBnZEdocGN5NTJaWEpwWm1sbGNrRmtaSEpsYzNNdWRtRnNkV1VzQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnZG1WeWFXWnBaWEpCWkdSeVpYTnpJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUNKMklpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbllpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJSFpsY21sbWFXVnlMbk5sYm1SbGNpQTlQVDBnZEdocGN5NTJaWEpwWm1sbGNrRmtaSEpsYzNNdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvNU9DMHhNREVLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdkbVZ5YVdacFpYSXVjMlZ1WkdWeUlEMDlQU0IwYUdsekxuWmxjbWxtYVdWeVFXUmtjbVZ6Y3k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSWtsdWRtRnNhV1FnZG1WeWFXWnBaWElnWVdSa2NtVnpjeUlzQ2lBZ0lDQXZMeUFwT3dvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdkbVZ5YVdacFpYSWdZV1JrY21WemN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFd013b2dJQ0FnTHk4Z1lYTnpaWEowS0hOcFoyNWhiSE11YkdWdVozUm9JRDA5UFNBeUxDQWlTVzUyWVd4cFpDQnphV2R1WVd4eklHeGxibWQwYUNJcE93b2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhOcFoyNWhiSE1nYkdWdVozUm9DaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmpiMjF0YVhSMFpXUkpibkIxZEhNdVkyOXRjRzl6WlVoaGMyZ2dQVDA5SUhSb2FYTXVZMjl0Y0c5elpVaGhjMmd1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCamIyMXdiM05sU0dGemFDQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpNekkrS0hzZ2EyVjVPaUFpWXlJZ2ZTazdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdZMjl0YldsMGRHVmtTVzV3ZFhSekxtTnZiWEJ2YzJWSVlYTm9JRDA5UFNCMGFHbHpMbU52YlhCdmMyVklZWE5vTG5aaGJIVmxMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdScFp5QTFDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFd05TMHhNRGdLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdZMjl0YldsMGRHVmtTVzV3ZFhSekxtTnZiWEJ2YzJWSVlYTm9JRDA5UFNCMGFHbHpMbU52YlhCdmMyVklZWE5vTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FpUTI5dGNHOXpaU0JvWVhOb0lHMXBjMjFoZEdOb0lpd0tJQ0FnSUM4dklDazdDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXRjRzl6WlNCb1lYTm9JRzFwYzIxaGRHTm9DaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1URXhDaUFnSUNBdkx5QmpiMjF0YVhSMFpXUkpibkIxZEhNdVlYQndTVVFnUFQwOUlIUm9hWE11Y0doaGJHRkJjSEJKWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIQm9ZV3hoUVhCd1NXUWdQU0JIYkc5aVlXeFRkR0YwWlR4UWFHRnNZVUZ3Y0VsRVBpaDdJR3RsZVRvZ0ltRWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUdOdmJXMXBkSFJsWkVsdWNIVjBjeTVoY0hCSlJDQTlQVDBnZEdocGN5NXdhR0ZzWVVGd2NFbGtMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBMkNpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakV4TUMweE1UTUtJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG1Gd2NFbEVJRDA5UFNCMGFHbHpMbkJvWVd4aFFYQndTV1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0pRYUdGc1lTQkJjSEFnU1VRZ2JXbHpiV0YwWTJnaUxBb2dJQ0FnTHk4Z0tUc0tJQ0FnSUdGemMyVnlkQ0F2THlCUWFHRnNZU0JCY0hBZ1NVUWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqQWdQVDA5SUhSb2FYTXVjblJ0Y2pBdWRtRnNkV1VzSUNKU1ZFMVNNQ0J0YVhOdFlYUmphQ0lwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdjblJ0Y2pBZ1BTQkhiRzlpWVd4VGRHRjBaVHhUYUdFek9EUkVhV2RsYzNRK0tIc2dhMlY1T2lBaU1DSWdmU2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0l3SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakV4TlFvZ0lDQWdMeThnWVhOelpYSjBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NXlkRzF5TUNBOVBUMGdkR2hwY3k1eWRHMXlNQzUyWVd4MVpTd2dJbEpVVFZJd0lHMXBjMjFoZEdOb0lpazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkdsbklEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVWxSTlVqQWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE1UWUtJQ0FnSUM4dklHRnpjMlZ5ZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqRWdQVDA5SUhSb2FYTXVjblJ0Y2pFdWRtRnNkV1VzSUNKU1ZFMVNNU0J0YVhOdFlYUmphQ0lwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdjblJ0Y2pFZ1BTQkhiRzlpWVd4VGRHRjBaVHhUYUdFek9EUkVhV2RsYzNRK0tIc2dhMlY1T2lBaU1TSWdmU2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJakVpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVEUyQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZMjl0YldsMGRHVmtTVzV3ZFhSekxuSjBiWEl4SUQwOVBTQjBhR2x6TG5KMGJYSXhMblpoYkhWbExDQWlVbFJOVWpFZ2JXbHpiV0YwWTJnaUtUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJTVkUxU01TQnRhWE50WVhSamFBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z1lYTnpaWEowS0dOdmJXMXBkSFJsWkVsdWNIVjBjeTV5ZEcxeU1pQTlQVDBnZEdocGN5NXlkRzF5TWk1MllXeDFaU3dnSWxKVVRWSXlJRzFwYzIxaGRHTm9JaWs3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnlkRzF5TWlBOUlFZHNiMkpoYkZOMFlYUmxQRk5vWVRNNE5FUnBaMlZ6ZEQ0b2V5QnJaWGs2SUNJeUlpQjlLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlNaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjaklnUFQwOUlIUm9hWE11Y25SdGNqSXVkbUZzZFdVc0lDSlNWRTFTTWlCdGFYTnRZWFJqYUNJcE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkpVVFZJeUlHMXBjMjFoZEdOb0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRFNENpQWdJQ0F2THlCaGMzTmxjblFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJeklEMDlQU0IwYUdsekxuSjBiWEl6TG5aaGJIVmxMQ0FpVWxSTlVqTWdiV2x6YldGMFkyZ2lLVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklISjBiWEl6SUQwZ1IyeHZZbUZzVTNSaGRHVThVMmhoTXpnMFJHbG5aWE4wUGloN0lHdGxlVG9nSWpNaUlIMHBPd29nSUNBZ2NIVnphR0o1ZEdWeklDSXpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdZWE56WlhKMEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1eWRHMXlNeUE5UFQwZ2RHaHBjeTV5ZEcxeU15NTJZV3gxWlN3Z0lsSlVUVkl6SUcxcGMyMWhkR05vSWlrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbFJOVWpNZ2JXbHpiV0YwWTJnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TWpFdE1USXlDaUFnSUNBdkx5QmpiMjV6ZENCMGIwSmxTR0Z6YUdWa0lEMGdZMjl0YldsMGRHVmtTVzV3ZFhSekxuSjBiWEl3Q2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJeEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXlNUzB4TWpNS0lDQWdJQzh2SUdOdmJuTjBJSFJ2UW1WSVlYTm9aV1FnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqQUtJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaGpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakVwQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJeUtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TWpFdE1USTBDaUFnSUNBdkx5QmpiMjV6ZENCMGIwSmxTR0Z6YUdWa0lEMGdZMjl0YldsMGRHVmtTVzV3ZFhSekxuSjBiWEl3Q2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJeEtRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1eWRHMXlNaWtLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2hqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pNcENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE1qVUtJQ0FnSUM4dklDNWpiMjVqWVhRb1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG5CMVltdGxlU2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ016SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE1qRXRNVEkxQ2lBZ0lDQXZMeUJqYjI1emRDQjBiMEpsU0dGemFHVmtJRDBnWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJd0NpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG5KMGJYSXhLUW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NXlkRzF5TWlrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqTXBDaUFnSUNBdkx5QWdJQzVqYjI1allYUW9ZMjl0YldsMGRHVmtTVzV3ZFhSekxuQjFZbXRsZVNrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE1qRXRNVEkyQ2lBZ0lDQXZMeUJqYjI1emRDQjBiMEpsU0dGemFHVmtJRDBnWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJd0NpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG5KMGJYSXhLUW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NXlkRzF5TWlrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqTXBDaUFnSUNBdkx5QWdJQzVqYjI1allYUW9ZMjl0YldsMGRHVmtTVzV3ZFhSekxuQjFZbXRsZVNrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamIyMXRhWFIwWldSSmJuQjFkSE11WTI5dGNHOXpaVWhoYzJncENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakV5TVMweE1qY0tJQ0FnSUM4dklHTnZibk4wSUhSdlFtVklZWE5vWldRZ1BTQmpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakFLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2hqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pFcENpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG5KMGJYSXlLUW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NXlkRzF5TXlrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y0hWaWEyVjVLUW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NWpiMjF3YjNObFNHRnphQ2tLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2hqYjIxdGFYUjBaV1JKYm5CMWRITXVZWEJ3U1VRcE93b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TWpnS0lDQWdJQzh2SUdOdmJuTjBJR052YlhCMWRHVmtVMmxuYm1Gc0lEMGdjMmhoTWpVMktIUnZRbVZJWVhOb1pXUXBMbUpwZEhkcGMyVkJibVFvQ2lBZ0lDQnphR0V5TlRZS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TWprdE1UTXhDaUFnSUNBdkx5QkNlWFJsY3k1bWNtOXRTR1Y0S0FvZ0lDQWdMeThnSUNBaU1XWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVppSXNDaUFnSUNBdkx5QXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNV1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXlPQzB4TXpJS0lDQWdJQzh2SUdOdmJuTjBJR052YlhCMWRHVmtVMmxuYm1Gc0lEMGdjMmhoTWpVMktIUnZRbVZJWVhOb1pXUXBMbUpwZEhkcGMyVkJibVFvQ2lBZ0lDQXZMeUFnSUVKNWRHVnpMbVp5YjIxSVpYZ29DaUFnSUNBdkx5QWdJQ0FnSWpGbVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZaUxBb2dJQ0FnTHk4Z0lDQXBMQW9nSUNBZ0x5OGdLVHNLSUNBZ0lHSW1DaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UTXpDaUFnSUNBdkx5QmhjM05sY25Rb2MybG5ibUZzY3k1aGRDZ3hLU0V1WW5sMFpYTWdQVDA5SUdOdmJYQjFkR1ZrVTJsbmJtRnNMQ0FpVTJsbmJtRnNJRzFwYzIxaGRHTm9JaWs3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTXpRZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVTJsbmJtRnNJRzFwYzIxaGRHTm9DaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklHOXlZV05zWlZObGNuWnBZMlZCWkdSeVpYTnpJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUNKdklpQjlLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlieUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hNelVLSUNBZ0lDOHZJSFJvYVhNdWIzSmhZMnhsVTJWeWRtbGpaVUZrWkhKbGMzTXVkbUZzZFdVZ1BTQkJZMk52ZFc1MEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1d2RXSnJaWGtwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TkRVdE1UVXdDaUFnSUNBdkx5QmliMjkwYzNSeVlYQW9DaUFnSUNBdkx5QWdJSFpsY21sbWFXVnlPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNDaUFnSUNBdkx5QWdJSE5wWjI1aGJITTZJRk5wWjI1aGJITXNDaUFnSUNBdkx5QWdJSEJ5YjI5bU9pQkhjbTkwYURFMlFtNHlOVFJRY205dlppd0tJQ0FnSUM4dklDQWdZMjl0YldsMGRHVmtTVzV3ZFhSek9pQkRiMjF0YVhSMFpXUkpibkIxZEhNc0NpQWdJQ0F2THlBcElIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQWlZRUFXRUJkZ0ZqQVRBeEdSUkVNUmhCQUE2QUJES1pQRFUyR2dDT0FRQWNBSUFFMHlTK3BEWWFBSTRCQUFFQU5ob0JTUlVrRWtRcFRHY2pRekVXSXdsSk9CQWpFa1EyR2dGSklsbEpKQXNsQ0VzQ0ZSSkVOaG9DRllHQUFoSkVOaG9EU1JXQmxBSVNSQ0lvWlVVQkZFUXhGaU1JU1RnUUl4SkVTVGdBTVFBU1N3RTRCeklLRWhCTEFUZ0lGQkJMQVRnSk1nb1NFRVN4TVFCTU9BRXlBUWl5Q0xJSEk3SVFJcklCczBtREFvQUNGRmdvU3dGblN3Rlg0Q0FxU3dGblN3SlhBREFyU3dGblN3TlhNRENBQVRGTEFXZExCRmRnTUlBQk1rc0JaMHNGVjVBd2dBRXpTd0ZuU3doWEFpQkpGU1FTUklBQmEweG5Ud2s0QUNJcFpVUVNSRThISlJKRUlpcGxSRXNGRWtRaUtHVkVTd1lTUkNJclpVUkxCQkpFSW9BQk1XVkVTd01TUkNLQUFUSmxSRXNDRWtRaWdBRXpaVVJMQVJKRVR3TlBBMUJQQWxCTVVFOERWOEFnVEVzQlVFOENVRThDVUFHQUlCLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vckU4Q1Z5SWdFa1NBQVc5TVp5TkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
