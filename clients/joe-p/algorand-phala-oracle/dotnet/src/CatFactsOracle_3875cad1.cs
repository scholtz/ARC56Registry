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

namespace Arc56.Generated.joe_p.algorand_phala_oracle.CatFactsOracle_3875cad1
{


    public class CatFactsOracleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CatFactsOracleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="fact"> </param>
        public async Task AddFact(string fact, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 102, 203, 136 };
            var factAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); factAbi.From(fact);

            var result = await base.CallApp(new List<object> { abiHandle, factAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddFact_Transactions(string fact, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 102, 203, 136 };
            var factAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); factAbi.From(fact);

            return await base.MakeTransactionList(new List<object> { abiHandle, factAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2F0RmFjdHNPcmFjbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ29tbWl0dGVkSW5wdXRzIjpbeyJuYW1lIjoicnRtcjAiLCJ0eXBlIjoiYnl0ZVs0OF0ifSx7Im5hbWUiOiJydG1yMSIsInR5cGUiOiJieXRlWzQ4XSJ9LHsibmFtZSI6InJ0bXIyIiwidHlwZSI6ImJ5dGVbNDhdIn0seyJuYW1lIjoicnRtcjMiLCJ0eXBlIjoiYnl0ZVs0OF0ifSx7Im5hbWUiOiJwdWJrZXkiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJjb21wb3NlSGFzaCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImFwcElEIiwidHlwZSI6ImJ5dGVbMjBdIn1dLCJHcm90aDE2Qm4yNTRQcm9vZiI6W3sibmFtZSI6InBpX2EiLCJ0eXBlIjoiYnl0ZVs2NF0ifSx7Im5hbWUiOiJwaV9iIiwidHlwZSI6ImJ5dGVbMTI4XSJ9LHsibmFtZSI6InBpX2MiLCJ0eXBlIjoiYnl0ZVs2NF0ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYWRkRmFjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmYWN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJpZmllckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYnl0ZVs2NF0sYnl0ZVsxMjhdLGJ5dGVbNjRdKSIsInN0cnVjdCI6Ikdyb3RoMTZCbjI1NFByb29mIiwibmFtZSI6InByb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYnl0ZVs0OF0sYnl0ZVs0OF0sYnl0ZVs0OF0sYnl0ZVs0OF0sYnl0ZVszMl0sYnl0ZVszMl0sYnl0ZVsyMF0pIiwic3RydWN0IjoiQ29tbWl0dGVkSW5wdXRzIiwibmFtZSI6ImNvbW1pdHRlZElucHV0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjl9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI2OF0sImVycm9yTWVzc2FnZSI6IkNvbXBvc2UgaGFzaCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2M10sImVycm9yTWVzc2FnZSI6IkNvbnRyYWN0IGFscmVhZHkgYm9vdHN0cmFwcGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYwXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzaWduYWxzIGxlbmd0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgdmVyaWZpZXIgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MF0sImVycm9yTWVzc2FnZSI6Ikxlbmd0aCBtdXN0IGJlIDMyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc2XSwiZXJyb3JNZXNzYWdlIjoiUGhhbGEgQXBwIElEIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg2XSwiZXJyb3JNZXNzYWdlIjoiUlRNUjAgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTZdLCJlcnJvck1lc3NhZ2UiOiJSVE1SMSBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNl0sImVycm9yTWVzc2FnZSI6IlJUTVIyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE2XSwiZXJyb3JNZXNzYWdlIjoiUlRNUjMgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NV0sImVycm9yTWVzc2FnZSI6IlNlbmRlciBpcyBub3QgdGhlIHJlZ2lzdGVyZWQgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg0XSwiZXJyb3JNZXNzYWdlIjoiU2lnbmFsIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI4XSwiZXJyb3JNZXNzYWdlIjoiVGhlIGZlZSBwYXltZW50IHRyYW5zYWN0aW9uIG11c3QgYmUgYSAwIEFMR08gcGF5IHRoYXQgY2xvc2VzIHRvIHRoZSBhcHAgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzLDI1MywyNjQsMjcyLDI4MiwyOTIsMzAyLDMxMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3LDEyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50MjU2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgY29udHJhY3RzL29yYWNsZS5hbGdvLnRzOjpDb21taXR0ZWRJbnB1dHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgY29udHJhY3RzL29yYWNsZS5hbGdvLnRzOjpHcm90aDE2Qm4yNTRQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMSwzOTldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUVpSUNKdklpQWlkaUlnSW1NaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRnNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRMkYwUm1GamRITlBjbUZqYkdVZ1pYaDBaVzVrY3lCUWFHRnNZVlJrZUU5eVlXTnNaU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFOZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR00yTmpaallqZzRJREI0TXpJNU9UTmpNelVnTHk4Z2JXVjBhRzlrSUNKaFpHUkdZV04wS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSmliMjkwYzNSeVlYQW9jR0Y1TEhWcGJuUXlOVFpiWFN3b1lubDBaVnMyTkYwc1lubDBaVnN4TWpoZExHSjVkR1ZiTmpSZEtTd29ZbmwwWlZzME9GMHNZbmwwWlZzME9GMHNZbmwwWlZzME9GMHNZbmwwWlZzME9GMHNZbmwwWlZzek1sMHNZbmwwWlZzek1sMHNZbmwwWlZzeU1GMHBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmhaR1JHWVdOMElHSnZiM1J6ZEhKaGNBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEWTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UZzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUTJGMFJtRmpkSE5QY21GamJHVWdaWGgwWlc1a2N5QlFhR0ZzWVZSa2VFOXlZV05zWlNCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa016STBZbVZoTkNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtHRmtaSEpsYzNNcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQmxjbklLQ2dvdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk9rTmhkRVpoWTNSelQzSmhZMnhsTG1Ga1pFWmhZM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUkdZV04wT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakU1TVFvZ0lDQWdMeThnWVdSa1JtRmpkQ2htWVdOME9pQnpkSEpwYm1jcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG05eVlXTnNaVk5sY25acFkyVkJaR1J5WlhOekxuWmhiSFZsTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2IzSmhZMnhsVTJWeWRtbGpaVUZrWkhKbGMzTWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSW04aUlIMHBPd29nSUNBZ1lubDBaV05mTVNBdkx5QWlieUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YjNKaFkyeGxVMlZ5ZG1salpVRmtaSEpsYzNNdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE16a3RNVFF5Q2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YjNKaFkyeGxVMlZ5ZG1salpVRmtaSEpsYzNNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNKVFpXNWtaWElnYVhNZ2JtOTBJSFJvWlNCeVpXZHBjM1JsY21Wa0lHRndjQ0lzQ2lBZ0lDQXZMeUFwT3dvZ0lDQWdZWE56WlhKMElDOHZJRk5sYm1SbGNpQnBjeUJ1YjNRZ2RHaGxJSEpsWjJsemRHVnlaV1FnWVhCd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRrekNpQWdJQ0F2THlCMGFHbHpMbU52ZG1WeVJtVmxLQ2s3Q2lBZ0lDQmpZV3hzYzNWaUlHTnZkbVZ5Um1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRrMUNpQWdJQ0F2THlCMGFHbHpMbVpoWTNSektFZHNiMkpoYkM1eWIzVnVaQ2t1ZG1Gc2RXVWdQU0JtWVdOME93b2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRTVNUW9nSUNBZ0x5OGdZV1JrUm1GamRDaG1ZV04wT2lCemRISnBibWNwSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZPbEJvWVd4aFZHUjRUM0poWTJ4bExtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk9Ea0tJQ0FnSUM4dklHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtIWmxjbWxtYVdWeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02T0RjS0lDQWdJQzh2SUhabGNtbG1hV1Z5UVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lBaWRpSWdmU2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0oySWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUIwYUdsekxuWmxjbWxtYVdWeVFXUmtjbVZ6Y3k1MllXeDFaU0E5SUhabGNtbG1hV1Z5UVdSa2NtVnpjenNLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZPRGtLSUNBZ0lDOHZJR055WldGMFpVRndjR3hwWTJGMGFXOXVLSFpsY21sbWFXVnlRV1JrY21WemN6b2dRV05qYjNWdWRDa2dld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvNlVHaGhiR0ZVWkhoUGNtRmpiR1V1WW05dmRITjBjbUZ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOXZkSE4wY21Gd09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFME5TMHhOVEFLSUNBZ0lDOHZJR0p2YjNSemRISmhjQ2dLSUNBZ0lDOHZJQ0FnZG1WeWFXWnBaWEk2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ0FnYzJsbmJtRnNjem9nVTJsbmJtRnNjeXdLSUNBZ0lDOHZJQ0FnY0hKdmIyWTZJRWR5YjNSb01UWkNiakkxTkZCeWIyOW1MQW9nSUNBZ0x5OGdJQ0JqYjIxdGFYUjBaV1JKYm5CMWRITTZJRU52YlcxcGRIUmxaRWx1Y0hWMGN5d0tJQ0FnSUM4dklDa2dld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5ReU5UWStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpVMklDOHZJREkxTmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qcEhjbTkwYURFMlFtNHlOVFJRY205dlpnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNamMySUM4dklESTNOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pwRGIyMXRhWFIwWldSSmJuQjFkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1d2FHRnNZVUZ3Y0Vsa0xtaGhjMVpoYkhWbExDQWlRMjl1ZEhKaFkzUWdZV3h5WldGa2VTQmliMjkwYzNSeVlYQndaV1FpS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJSEJvWVd4aFFYQndTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeFFhR0ZzWVVGd2NFbEVQaWg3SUd0bGVUb2dJbUVpSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlTSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5URUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTV3YUdGc1lVRndjRWxrTG1oaGMxWmhiSFZsTENBaVEyOXVkSEpoWTNRZ1lXeHlaV0ZrZVNCaWIyOTBjM1J5WVhCd1pXUWlLVHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYjI1MGNtRmpkQ0JoYkhKbFlXUjVJR0p2YjNSemRISmhjSEJsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnZEdocGN5NWpiM1psY2tabFpTZ3BPd29nSUNBZ1kyRnNiSE4xWWlCamIzWmxja1psWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnZEdocGN5NXdhR0ZzWVVGd2NFbGtMblpoYkhWbElEMGdZMjl0YldsMGRHVmtTVzV3ZFhSekxtRndjRWxFT3dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MGN5QXlOVFlnTWpBZ0x5OGdNalUyTENBeU1Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdjR2hoYkdGQmNIQkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBGQm9ZV3hoUVhCd1NVUStLSHNnYTJWNU9pQWlZU0lnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFMU5Bb2dJQ0FnTHk4Z2RHaHBjeTV3YUdGc1lVRndjRWxrTG5aaGJIVmxJRDBnWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbUZ3Y0VsRU93b2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UVTFDaUFnSUNBdkx5QjBhR2x6TG1OdmJYQnZjMlZJWVhOb0xuWmhiSFZsSUQwZ1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG1OdmJYQnZjMlZJWVhOb093b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTWpJMElETXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklHTnZiWEJ2YzJWSVlYTm9JRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE16TWo0b2V5QnJaWGs2SUNKaklpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU1pQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVFUxQ2lBZ0lDQXZMeUIwYUdsekxtTnZiWEJ2YzJWSVlYTm9MblpoYkhWbElEMGdZMjl0YldsMGRHVmtTVzV3ZFhSekxtTnZiWEJ2YzJWSVlYTm9Pd29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVFUyQ2lBZ0lDQXZMeUIwYUdsekxuSjBiWEl3TG5aaGJIVmxJRDBnWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJd093b2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTUNBME9Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCeWRHMXlNQ0E5SUVkc2IySmhiRk4wWVhSbFBGTm9ZVE00TkVScFoyVnpkRDRvZXlCclpYazZJQ0l3SWlCOUtUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaU1DSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5UWUtJQ0FnSUM4dklIUm9hWE11Y25SdGNqQXVkbUZzZFdVZ1BTQmpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakE3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TlRjS0lDQWdJQzh2SUhSb2FYTXVjblJ0Y2pFdWRtRnNkV1VnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqRTdDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBME9DQTBPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QnlkRzF5TVNBOUlFZHNiMkpoYkZOMFlYUmxQRk5vWVRNNE5FUnBaMlZ6ZEQ0b2V5QnJaWGs2SUNJeElpQjlLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlNU0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOVGNLSUNBZ0lDOHZJSFJvYVhNdWNuUnRjakV1ZG1Gc2RXVWdQU0JqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pFN0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5UZ0tJQ0FnSUM4dklIUm9hWE11Y25SdGNqSXVkbUZzZFdVZ1BTQmpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakk3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQTVOaUEwT0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJ5ZEcxeU1pQTlJRWRzYjJKaGJGTjBZWFJsUEZOb1lUTTRORVJwWjJWemRENG9leUJyWlhrNklDSXlJaUI5S1RzS0lDQWdJSEIxYzJoaWVYUmxjeUFpTWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TlRnS0lDQWdJQzh2SUhSb2FYTXVjblJ0Y2pJdWRtRnNkV1VnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqSTdDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOVGtLSUNBZ0lDOHZJSFJvYVhNdWNuUnRjak11ZG1Gc2RXVWdQU0JqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pNN0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F4TkRRZ05EZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2NuUnRjak1nUFNCSGJHOWlZV3hUZEdGMFpUeFRhR0V6T0RSRWFXZGxjM1ErS0hzZ2EyVjVPaUFpTXlJZ2ZTazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqTWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1UVTVDaUFnSUNBdkx5QjBhR2x6TG5KMGJYSXpMblpoYkhWbElEMGdZMjl0YldsMGRHVmtTVzV3ZFhSekxuSjBiWEl6T3dvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRZd0NpQWdJQ0F2THlCMGFHbHpMblpyU0dGemFDNTJZV3gxWlNBOUlITnBaMjVoYkhNdVlYUW9NQ2toTG1KNWRHVnpMblJ2Um1sNFpXUW9leUJzWlc1bmRHZzZJRE15SUgwcE93b2dJQ0FnWkdsbklEZ0tJQ0FnSUdWNGRISmhZM1FnTWlBek1nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aVzVuZEdnZ2JYVnpkQ0JpWlNBek1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCMmEwaGhjMmdnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3pNeVBpaDdJR3RsZVRvZ0ltc2lJSDBwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pySWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakUyTUFvZ0lDQWdMeThnZEdocGN5NTJhMGhoYzJndWRtRnNkV1VnUFNCemFXZHVZV3h6TG1GMEtEQXBJUzVpZVhSbGN5NTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQXpNaUI5S1RzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUhabGNtbG1hV1Z5TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTUyWlhKcFptbGxja0ZrWkhKbGMzTXVkbUZzZFdVc0NpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2RtVnlhV1pwWlhKQlpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDSjJJaUI5S1RzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5ZaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUhabGNtbG1hV1Z5TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTUyWlhKcFptbGxja0ZrWkhKbGMzTXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6bzVPQzB4TURFS0lDQWdJQzh2SUdGemMyVnlkQ2dLSUNBZ0lDOHZJQ0FnZG1WeWFXWnBaWEl1YzJWdVpHVnlJRDA5UFNCMGFHbHpMblpsY21sbWFXVnlRV1JrY21WemN5NTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lrbHVkbUZzYVdRZ2RtVnlhV1pwWlhJZ1lXUmtjbVZ6Y3lJc0NpQWdJQ0F2THlBcE93b2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnZG1WeWFXWnBaWElnWVdSa2NtVnpjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdZWE56WlhKMEtITnBaMjVoYkhNdWJHVnVaM1JvSUQwOVBTQXlMQ0FpU1c1MllXeHBaQ0J6YVdkdVlXeHpJR3hsYm1kMGFDSXBPd29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lITnBaMjVoYkhNZ2JHVnVaM1JvQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUJqYjIxdGFYUjBaV1JKYm5CMWRITXVZMjl0Y0c5elpVaGhjMmdnUFQwOUlIUm9hWE11WTI5dGNHOXpaVWhoYzJndWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QmpiMjF3YjNObFNHRnphQ0E5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6TXpJK0tIc2dhMlY1T2lBaVl5SWdmU2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pqSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbU52YlhCdmMyVklZWE5vSUQwOVBTQjBhR2x6TG1OdmJYQnZjMlZJWVhOb0xuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXdOUzB4TURnS0lDQWdJQzh2SUdGemMyVnlkQ2dLSUNBZ0lDOHZJQ0FnWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbU52YlhCdmMyVklZWE5vSUQwOVBTQjBhR2x6TG1OdmJYQnZjMlZJWVhOb0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNBaVEyOXRjRzl6WlNCb1lYTm9JRzFwYzIxaGRHTm9JaXdLSUNBZ0lDOHZJQ2s3Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMjl0Y0c5elpTQm9ZWE5vSUcxcGMyMWhkR05vQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJqYjIxdGFYUjBaV1JKYm5CMWRITXVZWEJ3U1VRZ1BUMDlJSFJvYVhNdWNHaGhiR0ZCY0hCSlpDNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJSEJvWVd4aFFYQndTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeFFhR0ZzWVVGd2NFbEVQaWg3SUd0bGVUb2dJbUVpSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlTSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE1URUtJQ0FnSUM4dklHTnZiVzFwZEhSbFpFbHVjSFYwY3k1aGNIQkpSQ0E5UFQwZ2RHaHBjeTV3YUdGc1lVRndjRWxrTG5aaGJIVmxMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdScFp5QTJDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFeE1DMHhNVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdZMjl0YldsMGRHVmtTVzV3ZFhSekxtRndjRWxFSUQwOVBTQjBhR2x6TG5Cb1lXeGhRWEJ3U1dRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNKUWFHRnNZU0JCY0hBZ1NVUWdiV2x6YldGMFkyZ2lMQW9nSUNBZ0x5OGdLVHNLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFhR0ZzWVNCQmNIQWdTVVFnYldsemJXRjBZMmdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hNVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakFnUFQwOUlIUm9hWE11Y25SdGNqQXVkbUZzZFdVc0lDSlNWRTFTTUNCdGFYTnRZWFJqYUNJcE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnY25SdGNqQWdQU0JIYkc5aVlXeFRkR0YwWlR4VGFHRXpPRFJFYVdkbGMzUStLSHNnYTJWNU9pQWlNQ0lnZlNrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWpBaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCaGMzTmxjblFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJd0lEMDlQU0IwYUdsekxuSjBiWEl3TG5aaGJIVmxMQ0FpVWxSTlVqQWdiV2x6YldGMFkyZ2lLVHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCa2FXY2dOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCU1ZFMVNNQ0J0YVhOdFlYUmphQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdZWE56WlhKMEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1eWRHMXlNU0E5UFQwZ2RHaHBjeTV5ZEcxeU1TNTJZV3gxWlN3Z0lsSlVUVkl4SUcxcGMyMWhkR05vSWlrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJ5ZEcxeU1TQTlJRWRzYjJKaGJGTjBZWFJsUEZOb1lUTTRORVJwWjJWemRENG9leUJyWlhrNklDSXhJaUI5S1RzS0lDQWdJSEIxYzJoaWVYUmxjeUFpTVNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUdGemMyVnlkQ2hqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pFZ1BUMDlJSFJvYVhNdWNuUnRjakV1ZG1Gc2RXVXNJQ0pTVkUxU01TQnRhWE50WVhSamFDSXBPd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZKVVRWSXhJRzFwYzIxaGRHTm9DaUFnSUNBdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk1URTNDaUFnSUNBdkx5QmhjM05sY25Rb1kyOXRiV2wwZEdWa1NXNXdkWFJ6TG5KMGJYSXlJRDA5UFNCMGFHbHpMbkowYlhJeUxuWmhiSFZsTENBaVVsUk5VaklnYldsemJXRjBZMmdpS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJSEowYlhJeUlEMGdSMnh2WW1Gc1UzUmhkR1U4VTJoaE16ZzBSR2xuWlhOMFBpaDdJR3RsZVRvZ0lqSWlJSDBwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l5SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakV4TndvZ0lDQWdMeThnWVhOelpYSjBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NXlkRzF5TWlBOVBUMGdkR2hwY3k1eWRHMXlNaTUyWVd4MVpTd2dJbEpVVFZJeUlHMXBjMjFoZEdOb0lpazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVWxSTlVqSWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqTWdQVDA5SUhSb2FYTXVjblJ0Y2pNdWRtRnNkV1VzSUNKU1ZFMVNNeUJ0YVhOdFlYUmphQ0lwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdjblJ0Y2pNZ1BTQkhiRzlpWVd4VGRHRjBaVHhUYUdFek9EUkVhV2RsYzNRK0tIc2dhMlY1T2lBaU15SWdmU2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJak1pQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVEU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZMjl0YldsMGRHVmtTVzV3ZFhSekxuSjBiWEl6SUQwOVBTQjBhR2x6TG5KMGJYSXpMblpoYkhWbExDQWlVbFJOVWpNZ2JXbHpiV0YwWTJnaUtUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJTVkUxU015QnRhWE50WVhSamFBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFeU1TMHhNaklLSUNBZ0lDOHZJR052Ym5OMElIUnZRbVZJWVhOb1pXUWdQU0JqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pBS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqRXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVEl4TFRFeU13b2dJQ0FnTHk4Z1kyOXVjM1FnZEc5Q1pVaGhjMmhsWkNBOUlHTnZiVzFwZEhSbFpFbHVjSFYwY3k1eWRHMXlNQW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NXlkRzF5TVNrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqSXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFeU1TMHhNalFLSUNBZ0lDOHZJR052Ym5OMElIUnZRbVZJWVhOb1pXUWdQU0JqYjIxdGFYUjBaV1JKYm5CMWRITXVjblJ0Y2pBS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqRXBDaUFnSUNBdkx5QWdJQzVqYjI1allYUW9ZMjl0YldsMGRHVmtTVzV3ZFhSekxuSjBiWEl5S1FvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0dOdmJXMXBkSFJsWkVsdWNIVjBjeTV5ZEcxeU15a0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdMbU52Ym1OaGRDaGpiMjF0YVhSMFpXUkpibkIxZEhNdWNIVmlhMlY1S1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIUnlZV04wSURFNU1pQXpNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXlNUzB4TWpVS0lDQWdJQzh2SUdOdmJuTjBJSFJ2UW1WSVlYTm9aV1FnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqQUtJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaGpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakVwQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJeUtRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1eWRHMXlNeWtLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2hqYjIxdGFYUjBaV1JKYm5CMWRITXVjSFZpYTJWNUtRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRXlNUzB4TWpZS0lDQWdJQzh2SUdOdmJuTjBJSFJ2UW1WSVlYTm9aV1FnUFNCamIyMXRhWFIwWldSSmJuQjFkSE11Y25SdGNqQUtJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaGpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjakVwQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJeUtRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1eWRHMXlNeWtLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2hqYjIxdGFYUjBaV1JKYm5CMWRITXVjSFZpYTJWNUtRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1amIyMXdiM05sU0dGemFDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRJeExURXlOd29nSUNBZ0x5OGdZMjl1YzNRZ2RHOUNaVWhoYzJobFpDQTlJR052YlcxcGRIUmxaRWx1Y0hWMGN5NXlkRzF5TUFvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0dOdmJXMXBkSFJsWkVsdWNIVjBjeTV5ZEcxeU1Ta0tJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaGpiMjF0YVhSMFpXUkpibkIxZEhNdWNuUnRjaklwQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbkowYlhJektRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtHTnZiVzFwZEhSbFpFbHVjSFYwY3k1d2RXSnJaWGtwQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTI5dGJXbDBkR1ZrU1c1d2RYUnpMbU52YlhCdmMyVklZWE5vS1FvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0dOdmJXMXBkSFJsWkVsdWNIVjBjeTVoY0hCSlJDazdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z1kyOXVjM1FnWTI5dGNIVjBaV1JUYVdkdVlXd2dQU0J6YUdFeU5UWW9kRzlDWlVoaGMyaGxaQ2t1WW1sMGQybHpaVUZ1WkNnS0lDQWdJSE5vWVRJMU5nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFeU9TMHhNekVLSUNBZ0lDOHZJRUo1ZEdWekxtWnliMjFJWlhnb0NpQWdJQ0F2THlBZ0lDSXhabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1JaXdLSUNBZ0lDOHZJQ2tzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YjNKaFkyeGxMbUZzWjI4dWRITTZNVEk0TFRFek1nb2dJQ0FnTHk4Z1kyOXVjM1FnWTI5dGNIVjBaV1JUYVdkdVlXd2dQU0J6YUdFeU5UWW9kRzlDWlVoaGMyaGxaQ2t1WW1sMGQybHpaVUZ1WkNnS0lDQWdJQzh2SUNBZ1FubDBaWE11Wm5KdmJVaGxlQ2dLSUNBZ0lDOHZJQ0FnSUNBaU1XWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVppSXNDaUFnSUNBdkx5QWdJQ2tzQ2lBZ0lDQXZMeUFwT3dvZ0lDQWdZaVlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hNek1LSUNBZ0lDOHZJR0Z6YzJWeWRDaHphV2R1WVd4ekxtRjBLREVwSVM1aWVYUmxjeUE5UFQwZ1kyOXRjSFYwWldSVGFXZHVZV3dzSUNKVGFXZHVZV3dnYldsemJXRjBZMmdpS1RzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBek5DQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVGFXZHVZV3dnYldsemJXRjBZMmdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdiM0poWTJ4bFUyVnlkbWxqWlVGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ0ltOGlJSDBwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYnlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUhSb2FYTXViM0poWTJ4bFUyVnlkbWxqWlVGa1pISmxjM011ZG1Gc2RXVWdQU0JCWTJOdmRXNTBLR052YlcxcGRIUmxaRWx1Y0hWMGN5NXdkV0pyWlhrcE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5EVXRNVFV3Q2lBZ0lDQXZMeUJpYjI5MGMzUnlZWEFvQ2lBZ0lDQXZMeUFnSUhabGNtbG1hV1Z5T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzQ2lBZ0lDQXZMeUFnSUhOcFoyNWhiSE02SUZOcFoyNWhiSE1zQ2lBZ0lDQXZMeUFnSUhCeWIyOW1PaUJIY205MGFERTJRbTR5TlRSUWNtOXZaaXdLSUNBZ0lDOHZJQ0FnWTI5dGJXbDBkR1ZrU1c1d2RYUnpPaUJEYjIxdGFYUjBaV1JKYm5CMWRITXNDaUFnSUNBdkx5QXBJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZiM0poWTJ4bExtRnNaMjh1ZEhNNk9sQm9ZV3hoVkdSNFQzSmhZMnhsTG1OdmRtVnlSbVZsS0NrZ0xUNGdkbTlwWkRvS1kyOTJaWEpHWldVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRZMkNpQWdJQ0F2THlCamIyNXpkQ0JtWldWUVlYbHRaVzUwSUQwZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S0ZSNGJpNW5jbTkxY0VsdVpHVjRJQ3NnTVNrN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOamd0TVRjM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDZ0tJQ0FnSUM4dklDQWdabVZsVUdGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCOUxBb2dJQ0FnTHk4Z0lDQWlWR2hsSUdabFpTQndZWGx0Wlc1MElIUnlZVzV6WVdOMGFXOXVJRzExYzNRZ1ltVWdZU0F3SUVGTVIwOGdjR0Y1SUhSb1lYUWdZMnh2YzJWeklIUnZJSFJvWlNCaGNIQWdZV1JrY21WemN5SXNDaUFnSUNBdkx5QXBPd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE56RUtJQ0FnSUM4dklITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TmpndE1UYzNDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2dLSUNBZ0lDOHZJQ0FnWm1WbFVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjlMQW9nSUNBZ0x5OGdJQ0FpVkdobElHWmxaU0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1SUcxMWMzUWdZbVVnWVNBd0lFRk1SMDhnY0dGNUlIUm9ZWFFnWTJ4dmMyVnpJSFJ2SUhSb1pTQmhjSEFnWVdSa2NtVnpjeUlzQ2lBZ0lDQXZMeUFwT3dvZ0lDQWdQVDBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDI5eVlXTnNaUzVoYkdkdkxuUnpPakUzTWdvZ0lDQWdMeThnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOamd0TVRjM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDZ0tJQ0FnSUM4dklDQWdabVZsVUdGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCOUxBb2dJQ0FnTHk4Z0lDQWlWR2hsSUdabFpTQndZWGx0Wlc1MElIUnlZVzV6WVdOMGFXOXVJRzExYzNRZ1ltVWdZU0F3SUVGTVIwOGdjR0Y1SUhSb1lYUWdZMnh2YzJWeklIUnZJSFJvWlNCaGNIQWdZV1JrY21WemN5SXNDaUFnSUNBdkx5QXBPd29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lHZDBlRzV6SUVOc2IzTmxVbVZ0WVdsdVpHVnlWRzhLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl2Y21GamJHVXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXZjbUZqYkdVdVlXeG5ieTUwY3pveE5qZ3RNVGMzQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNnS0lDQWdJQzh2SUNBZ1ptVmxVR0Y1YldWdWRDd0tJQ0FnSUM4dklDQWdld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0I5TEFvZ0lDQWdMeThnSUNBaVZHaGxJR1psWlNCd1lYbHRaVzUwSUhSeVlXNXpZV04wYVc5dUlHMTFjM1FnWW1VZ1lTQXdJRUZNUjA4Z2NHRjVJSFJvWVhRZ1kyeHZjMlZ6SUhSdklIUm9aU0JoY0hBZ1lXUmtjbVZ6Y3lJc0NpQWdJQ0F2THlBcE93b2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdWR2hsSUdabFpTQndZWGx0Wlc1MElIUnlZVzV6WVdOMGFXOXVJRzExYzNRZ1ltVWdZU0F3SUVGTVIwOGdjR0Y1SUhSb1lYUWdZMnh2YzJWeklIUnZJSFJvWlNCaGNIQWdZV1JrY21WemN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFM09TMHhPRFFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1ptVmxVR0Y1YldWdWRDNW1aV1VnS3lCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyOXlZV05zWlM1aGJHZHZMblJ6T2pFNE1Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmIzSmhZMnhsTG1Gc1oyOHVkSE02TVRneUNpQWdJQ0F2THlCaGJXOTFiblE2SUdabFpWQmhlVzFsYm5RdVptVmxJQ3NnUjJ4dlltRnNMbTFwYmtKaGJHRnVZMlVzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCR1pXVUtJQ0FnSUdkc2IySmhiQ0JOYVc1Q1lXeGhibU5sQ2lBZ0lDQXJDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTNWhiR2R2TG5Sek9qRTNPUzB4T0RNS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dabVZsVUdGNWJXVnVkQzVtWldVZ0t5QkhiRzlpWVd3dWJXbHVRbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dmNtRmpiR1V1WVd4bmJ5NTBjem94TnprdE1UZzBDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdabFpWQmhlVzFsYm5RdVptVmxJQ3NnUjJ4dlltRnNMbTFwYmtKaGJHRnVZMlVzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tUc0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDSUNZRUFXRUJid0YyQVdNeEdSUkVNUmhCQUJhQ0FnVEdac3VJQkRLWlBEVTJHZ0NPQWdBUEFFRUFnQVRUSkw2a05ob0FqZ0VBSmdBMkdnRkpJbGtrQ0VzQkZSSkVWd0lBTVFBaUtXVkVFa1NJQVMweUJoWkp2RWhNdnlORE5ob0JTUlVsRWtRcVRHY2pRekVXSXdsSk9CQWpFa1EyR2dGSklsbEpKUXNrQ0VzQ0ZSSkVOaG9DRllHQUFoSkVOaG9EU1JXQmxBSVNSQ0lvWlVVQkZFU0lBTjlKZ3dLQUFoUllLRXNCWjBzQlYrQWdLMHNCWjBzQ1Z3QXdnQUV3U3dGblN3TlhNRENBQVRGTEFXZExCRmRnTUlBQk1rc0JaMHNGVjVBd2dBRXpTd0ZuU3doWEFpQkpGU1VTUklBQmEweG5Ud2s0QUNJcVpVUVNSRThISkJKRUlpdGxSRXNGRWtRaUtHVkVTd1lTUkNLQUFUQmxSRXNFRWtRaWdBRXhaVVJMQXhKRUlvQUJNbVZFU3dJU1JDS0FBVE5sUkVzQkVrUlBBMDhEVUU4Q1VFeFFUd05Yd0NCTVN3RlFUd0pRVHdKUUFZQWdILy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8rc1R3SlhJaUFTUkNsTVp5TkRNUllqQ0VrNEVDTVNSRWs0QURFQUVrc0JPQWN5Q2hJUVN3RTRDQlFRU3dFNENUSUtFaEJFc1RFQVREZ0JNZ0VJc2dpeUJ5T3lFQ0t5QWJPSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
