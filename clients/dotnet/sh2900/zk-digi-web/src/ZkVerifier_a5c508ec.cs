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

namespace Arc56.Generated.sh2900.zk_digi_web.ZkVerifier_a5c508ec
{


    //
    // ZK-Verifier Smart Contract
    //
    //Handles zero-knowledge proof verification using native Algorand AVM opcodes.
    //Integrates with snarkjs-algorand patterns for Groth16 BN254.
    //
    public class ZkVerifierProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ZkVerifierProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        ///Initialize the verifier
        ///</summary>
        /// <param name="circuit"> </param>
        public async Task Initialize(byte[] circuit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 234, 10, 207 };
            var circuitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); circuitAbi.From(circuit);

            var result = await base.CallApp(new List<object> { abiHandle, circuitAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(byte[] circuit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 234, 10, 207 };
            var circuitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); circuitAbi.From(circuit);

            return await base.MakeTransactionList(new List<object> { abiHandle, circuitAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Internal helper to increase opcode budget.
        ///We now make this public so the client can call it multiple times in a group
        ///to "pool" a massive budget.
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify a ZK proof (Groth16 BN254) using the hardcoded template VK.
        ///</summary>
        /// <param name="proof">- The Groth16 proof points (pi_a, pi_b, pi_c) Groth16Bn254Proof</param>
        /// <param name="publicSignals">- Public signals array </param>
        public async Task<bool> VerifyProof(Structs.Groth16Bn254Proof proof, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] publicSignals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 22, 255, 145 };
            var publicSignalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); publicSignalsAbi.From(publicSignals);

            var result = await base.CallApp(new List<object> { abiHandle, proof, publicSignalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyProof_Transactions(Structs.Groth16Bn254Proof proof, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] publicSignals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 22, 255, 145 };
            var publicSignalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>("uint256"); publicSignalsAbi.From(publicSignals);

            return await base.MakeTransactionList(new List<object> { abiHandle, proof, publicSignalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Dummy function to include VerificationKey type in ARC-56
        ///</summary>
        /// <param name="vk"> Groth16Bn254VerificationKey</param>
        public async Task Dummy(Structs.Groth16Bn254VerificationKey vk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 16, 235, 218 };

            var result = await base.CallApp(new List<object> { abiHandle, vk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Dummy_Transactions(Structs.Groth16Bn254VerificationKey vk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 16, 235, 218 };

            return await base.MakeTransactionList(new List<object> { abiHandle, vk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin: Enable or disable verification
        ///</summary>
        /// <param name="enabled"> </param>
        public async Task SetVerificationEnabled(ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 164, 170, 126 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            var result = await base.CallApp(new List<object> { abiHandle, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVerificationEnabled_Transactions(ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 164, 170, 126 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWmtWZXJpZmllciIsImRlc2MiOiJaSy1WZXJpZmllciBTbWFydCBDb250cmFjdFxuXG5IYW5kbGVzIHplcm8ta25vd2xlZGdlIHByb29mIHZlcmlmaWNhdGlvbiB1c2luZyBuYXRpdmUgQWxnb3JhbmQgQVZNIG9wY29kZXMuXG5JbnRlZ3JhdGVzIHdpdGggc25hcmtqcy1hbGdvcmFuZCBwYXR0ZXJucyBmb3IgR3JvdGgxNiBCTjI1NC4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR3JvdGgxNkJuMjU0UHJvb2YiOlt7Im5hbWUiOiJwaV9hIiwidHlwZSI6ImJ5dGVbNjRdIn0seyJuYW1lIjoicGlfYiIsInR5cGUiOiJieXRlWzEyOF0ifSx7Im5hbWUiOiJwaV9jIiwidHlwZSI6ImJ5dGVbNjRdIn1dLCJHcm90aDE2Qm4yNTRWZXJpZmljYXRpb25LZXkiOlt7Im5hbWUiOiJ2a19hbHBoYV8xIiwidHlwZSI6ImJ5dGVbNjRdIn0seyJuYW1lIjoidmtfYmV0YV8yIiwidHlwZSI6ImJ5dGVbMTI4XSJ9LHsibmFtZSI6InZrX2dhbW1hXzIiLCJ0eXBlIjoiYnl0ZVsxMjhdIn0seyJuYW1lIjoidmtfZGVsdGFfMiIsInR5cGUiOiJieXRlWzEyOF0ifSx7Im5hbWUiOiJuUHVibGljIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IklDIiwidHlwZSI6ImJ5dGVbNjRdW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSB2ZXJpZmllciIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaXJjdWl0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjoiSW50ZXJuYWwgaGVscGVyIHRvIGluY3JlYXNlIG9wY29kZSBidWRnZXQuXG5XZSBub3cgbWFrZSB0aGlzIHB1YmxpYyBzbyB0aGUgY2xpZW50IGNhbiBjYWxsIGl0IG11bHRpcGxlIHRpbWVzIGluIGEgZ3JvdXBcbnRvIFwicG9vbFwiIGEgbWFzc2l2ZSBidWRnZXQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeVByb29mIiwiZGVzYyI6IlZlcmlmeSBhIFpLIHByb29mIChHcm90aDE2IEJOMjU0KSB1c2luZyB0aGUgaGFyZGNvZGVkIHRlbXBsYXRlIFZLLiIsImFyZ3MiOlt7InR5cGUiOiIoYnl0ZVs2NF0sYnl0ZVsxMjhdLGJ5dGVbNjRdKSIsInN0cnVjdCI6Ikdyb3RoMTZCbjI1NFByb29mIiwibmFtZSI6InByb29mIiwiZGVzYyI6Ii0gVGhlIEdyb3RoMTYgcHJvb2YgcG9pbnRzIChwaV9hLCBwaV9iLCBwaV9jKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NltdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVibGljU2lnbmFscyIsImRlc2MiOiItIFB1YmxpYyBzaWduYWxzIGFycmF5IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJib29sZWFuIC0gcHJvb2YgdmFsaWRpdHkifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfZHVtbXkiLCJkZXNjIjoiRHVtbXkgZnVuY3Rpb24gdG8gaW5jbHVkZSBWZXJpZmljYXRpb25LZXkgdHlwZSBpbiBBUkMtNTYiLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbNjRdLGJ5dGVbMTI4XSxieXRlWzEyOF0sYnl0ZVsxMjhdLHVpbnQ2NCxieXRlWzY0XVtdKSIsInN0cnVjdCI6Ikdyb3RoMTZCbjI1NFZlcmlmaWNhdGlvbktleSIsIm5hbWUiOiJ2ayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkNsb3NlT3V0Il19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VmVyaWZpY2F0aW9uRW5hYmxlZCIsImRlc2MiOiJBZG1pbjogRW5hYmxlIG9yIGRpc2FibGUgdmVyaWZpY2F0aW9uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVuYWJsZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMTldLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIG51bWJlciBvZiBwdWJsaWMgaW5wdXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc3XSwiZXJyb3JNZXNzYWdlIjoiTGVuZ3RoIG11c3QgYmUgMzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTgsNTAxLDUyMV0sImVycm9yTWVzc2FnZSI6Ikxlbmd0aCBtdXN0IGJlIDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBDbG9zZU91dCAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NCwzNzVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDQsNDIxLDQ2Ml0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODgsMTY4LDU0OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50MjU2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvemtfdmVyaWZpZXIvZ3JvdGgxNl9ibjI1NC5hbGdvLnRzOjpHcm90aDE2Qm4yNTRQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvemtfdmVyaWZpZXIvZ3JvdGgxNl9ibjI1NC5hbGdvLnRzOjpHcm90aDE2Qm4yNTRWZXJpZmljYXRpb25LZXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA1IG9mICh1aW50OFs2NF0sdWludDhbMTI4XSx1aW50OFsxMjhdLHVpbnQ4WzEyOF0sdWludDY0LChsZW4rdWludDhbNjRdW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjldLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0N10sImVycm9yTWVzc2FnZSI6InB1YmxpYyBzaWduYWwgbm90IGluIEZyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUlEWTBJRFExTmdvZ0lDQWdZbmwwWldOaWJHOWpheUFpZGlJZ0ltTWlJREI0SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01TQlVUVkJNWDFaRlVrbEdTVU5CVkVsUFRsOUxSVmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1dtdFdaWEpwWm1sbGNpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRZeE1HVmlaR0VnTHk4Z2JXVjBhRzlrSUNKZlpIVnRiWGtvS0dKNWRHVmJOalJkTEdKNWRHVmJNVEk0WFN4aWVYUmxXekV5T0Ywc1lubDBaVnN4TWpoZExIVnBiblEyTkN4aWVYUmxXelkwWFZ0ZEtTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlmWkhWdGJYbGZjbTkxZEdWQU13b0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRnByVm1WeWFXWnBaWElnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdWalpXRXdZV05tSURCNE9EVTBaR1ZrWlRBZ01IaGhNREUyWm1ZNU1TQXdlRGN3WVRSaFlUZGxJQzh2SUcxbGRHaHZaQ0FpYVc1cGRHbGhiR2w2WlNoaWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWliM0JWY0NncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVVSEp2YjJZb0tHSjVkR1ZiTmpSZExHSjVkR1ZiTVRJNFhTeGllWFJsV3pZMFhTa3NkV2x1ZERJMU5sdGRLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luTmxkRlpsY21sbWFXTmhkR2x2YmtWdVlXSnNaV1FvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnBibWwwYVdGc2FYcGxJRzl3VlhBZ2RtVnlhV1o1VUhKdmIyWWdjMlYwVm1WeWFXWnBZMkYwYVc5dVJXNWhZbXhsWkFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlrZFcxdGVWOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZERiRzl6WlU5MWRDY2dmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdNaUF2THlCRGJHOXpaVTkxZEFvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUVOc2IzTmxUM1YwSUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSWdYMlIxYlcxNUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdXbXRXWlhKcFptbGxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9scHJWbVZ5YVdacFpYSXVhVzVwZEdsaGJHbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUnBZV3hwZW1VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklIQjFZbXhwWXlCMlpYSnBabWxqWVhScGIyNUZibUZpYkdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1luSUgwcElDQWdJQzh2SURFZ1BTQmxibUZpYkdWa0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklIUm9hWE11ZG1WeWFXWnBZMkYwYVc5dVJXNWhZbXhsWkM1MllXeDFaU0E5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUhCMVlteHBZeUJ3Y205dlprTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyTW5JSDBwSUNBZ0lDQWdJQ0FnSUNBZ0x5OGdkRzkwWVd3Z2NISnZiMlp6SUhabGNtbG1hV1ZrQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUhSb2FYTXVjSEp2YjJaRGIzVnVkQzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJSEIxWW14cFl5QmphWEpqZFdsMFZIbHdaU0E5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGloN0lHdGxlVG9nSjNRbklIMHBJQ0FnSUNBZ0lDQWdJQ0F2THlCdFpYUmhaR0YwWVRvZ1pTNW5MaUFpYlhWc2RHbHdiR2xsY2lJS0lDQWdJSEIxYzJoaWVYUmxjeUFpZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCMGFHbHpMbU5wY21OMWFYUlVlWEJsTG5aaGJIVmxJRDBnWTJseVkzVnBkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82V210V1pYSnBabWxsY2k1dmNGVndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCVmNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dNVFU3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh4SUM4dklEQUtDbTl3VlhCZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdabTl5SUNoc1pYUWdhVG9nZFdsdWREWTBJRDBnTURzZ2FTQThJREUxT3lCcEt5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE5TQXZMeUF4TlFvZ0lDQWdQQW9nSUNBZ1lub2diM0JWY0Y5aFpuUmxjbDkzYUdsc1pVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOeTAwTUFvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3Q2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdZVzF2ZFc1ME9pQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNMVFF3Q2lBZ0lDQXZMeUJwZEhodUxuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJREFLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENBeE5Uc2dhU3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdiM0JWY0Y5M2FHbHNaVjkwYjNCQU1nb0tiM0JWY0Y5aFpuUmxjbDkzYUdsc1pVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBhYTFabGNtbG1hV1Z5TG5abGNtbG1lVkJ5YjI5bVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNVVISnZiMlk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREkxTmlBdkx5QXlOVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T2tkeWIzUm9NVFpDYmpJMU5GQnliMjltQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkREkxTmo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCcFppQW9kR2hwY3k1MlpYSnBabWxqWVhScGIyNUZibUZpYkdWa0xuWmhiSFZsSUQwOVBTQXdLU0J5WlhSMWNtNGdabUZzYzJVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnY0hWaWJHbGpJSFpsY21sbWFXTmhkR2x2YmtWdVlXSnNaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmRpY2dmU2tnSUNBZ0x5OGdNU0E5SUdWdVlXSnNaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbllpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnYVdZZ0tIUm9hWE11ZG1WeWFXWnBZMkYwYVc5dVJXNWhZbXhsWkM1MllXeDFaU0E5UFQwZ01Da2djbVYwZFhKdUlHWmhiSE5sQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1ltNTZJSFpsY21sbWVWQnliMjltWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtDblpsY21sbWVWQnliMjltWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbHByVm1WeWFXWnBaWEl1ZG1WeWFXWjVVSEp2YjJaQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkbVZ5YVdaNVVISnZiMlpmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQmtaV052WkdWQmNtTTBQRWR5YjNSb01UWkNiakkxTkZabGNtbG1hV05oZEdsdmJrdGxlVDRvZG10Q2VYUmxjeWtLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdWRTFRVEY5V1JWSkpSa2xEUVZSSlQwNWZTMFZaQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdZWE56WlhKMEtITnBaMjVoYkhNdWJHVnVaM1JvSUQwOVBTQjJheTV1VUhWaWJHbGpMQ0FpU1c1MllXeHBaQ0J1ZFcxaVpYSWdiMllnY0hWaWJHbGpJR2x1Y0hWMGN5SXBPd29nSUNBZ2NIVnphR2x1ZENBME5EZ2dMeThnTkRRNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0J1ZFcxaVpYSWdiMllnY0hWaWJHbGpJR2x1Y0hWMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0oxY25rZ05Rb0tkbVZ5YVdaNVVISnZiMlpmWm05eVgyaGxZV1JsY2tBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2MybG5ibUZzSUc5bUlITnBaMjVoYkhNcElIc0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1BBb2dJQ0FnWW5vZ2RtVnlhV1o1VUhKdmIyWmZZV1owWlhKZlptOXlRREV5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlpYmpJMU5GOWpiMjF0YjI0dVlXeG5ieTUwY3pvNE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhaaGJIVmxMbUZ6UW1sblZXbHVkQ2dwSUR3Z1FrNHlOVFJmVTBOQlRFRlNYMDFQUkZWTVZWTTdDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lqd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T1RBS0lDQWdJQzh2SUdGemMyVnlkQ2hwYmtacFpXeGtLSE5wWjI1aGJDa3NJQ0p3ZFdKc2FXTWdjMmxuYm1Gc0lHNXZkQ0JwYmlCR2NpSXBPd29nSUNBZ1lYTnpaWEowSUM4dklIQjFZbXhwWXlCemFXZHVZV3dnYm05MElHbHVJRVp5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTFDaUFnSUNCaUlIWmxjbWxtZVZCeWIyOW1YMlp2Y2w5b1pXRmtaWEpBTVRBS0NuWmxjbWxtZVZCeWIyOW1YMkZtZEdWeVgyWnZja0F4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZNVEU1Q2lBZ0lDQXZMeUJwWmlBb2MybG5ibUZzY3k1c1pXNW5kR2dnUFQwOUlEQXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ1ltNTZJSFpsY21sbWVWQnliMjltWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1USXhDaUFnSUNBdkx5QnlaWFIxY200Z2Rtc3VTVU5iTUYwZ1lYTWdZbmwwWlhNOE5qUStPd29nSUNBZ1pHbG5JRFlLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklEUTFOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBMk5Bb0tkbVZ5YVdaNVVISnZiMlpmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pwamIyMXdkWFJsUTNCMVlrQXlNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UY3hDaUFnSUNBdkx5QmpiMjV6ZENCdVpXZFFhVUVnUFNCbk1VNWxaeWh3Y205dlppNXdhVjloS1RzS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJKdU1qVTBYMk52YlcxdmJpNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QnlaWFIxY200Z1p6RlVhVzFsYzBaeUtIQXNJRkpmVFVsT1ZWTmZNU2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WW00eU5UUmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG5OallXeGhjazExYkNodmNDNUZZeTVDVGpJMU5HY3hMQ0J3TENCQ2VYUmxjeWh6S1NrdWRHOUdhWGhsWkNoN0NpQWdJQ0JsWTE5elkyRnNZWEpmYlhWc0lFSk9NalUwWnpFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5aWJqSTFORjlqYjIxdGIyNHVZV3huYnk1MGN6bzJNaTAyTkFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TGtWc2JHbHdkR2xqUTNWeWRtVXVjMk5oYkdGeVRYVnNLRzl3TGtWakxrSk9NalUwWnpFc0lIQXNJRUo1ZEdWektITXBLUzUwYjBacGVHVmtLSHNLSUNBZ0lDOHZJQ0FnYkdWdVozUm9PaUEyTkN3S0lDQWdJQzh2SUgwcE93b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aVzVuZEdnZ2JYVnpkQ0JpWlNBMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TnpJS0lDQWdJQzh2SUdOdmJuTjBJR2N4VUc5cGJuUnpJRDBnYm1WblVHbEJMbU52Ym1OaGRDaGpjSFZpS1M1amIyNWpZWFFvY0hKdmIyWXVjR2xmWXlrdVkyOXVZMkYwS0hackxuWnJYMkZzY0doaFh6RXBPd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnT0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TnpVS0lDQWdJQzh2SUdOdmJuTjBJR2N5VUc5cGJuUnpJRDBnY0hKdmIyWXVjR2xmWWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURZMElERXlPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pveE56WUtJQ0FnSUM4dklDNWpiMjVqWVhRb2Rtc3VkbXRmWjJGdGJXRmZNaWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElERTVNaUF4TWpnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZNVGMxTFRFM05nb2dJQ0FnTHk4Z1kyOXVjM1FnWnpKUWIybHVkSE1nUFNCd2NtOXZaaTV3YVY5aUNpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb2Rtc3VkbXRmWjJGdGJXRmZNaWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJkeWIzUm9NVFpmWW00eU5UUXVZV3huYnk1MGN6b3hOemNLSUNBZ0lDOHZJQzVqYjI1allYUW9kbXN1ZG10ZlpHVnNkR0ZmTWlrS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBjeUF6TWpBZ01USTRJQzh2SURNeU1Dd2dNVEk0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyZHliM1JvTVRaZlltNHlOVFF1WVd4bmJ5NTBjem94TnpVdE1UYzNDaUFnSUNBdkx5QmpiMjV6ZENCbk1sQnZhVzUwY3lBOUlIQnliMjltTG5CcFgySUtJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaDJheTUyYTE5bllXMXRZVjh5S1FvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0hackxuWnJYMlJsYkhSaFh6SXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UYzRDaUFnSUNBdkx5QXVZMjl1WTJGMEtIWnJMblpyWDJKbGRHRmZNaWs3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ01USTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFM05TMHhOemdLSUNBZ0lDOHZJR052Ym5OMElHY3lVRzlwYm5SeklEMGdjSEp2YjJZdWNHbGZZZ29nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLSFpyTG5aclgyZGhiVzFoWHpJcENpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb2Rtc3VkbXRmWkdWc2RHRmZNaWtLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2gyYXk1MmExOWlaWFJoWHpJcE93b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFNE1Rb2dJQ0FnTHk4Z1kyOXVjM1FnY21WeklEMGdiM0F1Uld4c2FYQjBhV05EZFhKMlpTNXdZV2x5YVc1blEyaGxZMnNvYjNBdVJXTXVRazR5TlRSbk1Td2daekZRYjJsdWRITXNJR2N5VUc5cGJuUnpLVHNLSUNBZ0lHVmpYM0JoYVhKcGJtZGZZMmhsWTJzZ1FrNHlOVFJuTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCcFppQW9hWE5XWVd4cFpDa2dld29nSUNBZ1lub2dkbVZ5YVdaNVVISnZiMlpmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdkR2hwY3k1d2NtOXZaa052ZFc1MExuWmhiSFZsSUQwZ2RHaHBjeTV3Y205dlprTnZkVzUwTG5aaGJIVmxJQ3NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjSEp2YjJaRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkakp5QjlLU0FnSUNBZ0lDQWdJQ0FnSUM4dklIUnZkR0ZzSUhCeWIyOW1jeUIyWlhKcFptbGxaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUIwYUdsekxuQnliMjltUTI5MWJuUXVkbUZzZFdVZ1BTQjBhR2x6TG5CeWIyOW1RMjkxYm5RdWRtRnNkV1VnS3lBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QndkV0pzYVdNZ2NISnZiMlpEYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqSnlCOUtTQWdJQ0FnSUNBZ0lDQWdJQzh2SUhSdmRHRnNJSEJ5YjI5bWN5QjJaWEpwWm1sbFpBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVl5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QjBhR2x6TG5CeWIyOW1RMjkxYm5RdWRtRnNkV1VnUFNCMGFHbHpMbkJ5YjI5bVEyOTFiblF1ZG1Gc2RXVWdLeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2RtVnlhV1o1VUhKdmIyWmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWkdsbklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSWdkbVZ5YVdaNVVISnZiMlpmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZXbXRXWlhKcFptbGxjaTUyWlhKcFpubFFjbTl2WmtBMkNncDJaWEpwWm5sUWNtOXZabDloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pveE1qVUtJQ0FnSUM4dklHeGxkQ0JwWTFCdmFXNTBjeUE5SUVKNWRHVnpLQ2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Q2lBZ0lDQmlkWEo1SURrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZNVEkyQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBeE95QnBJRHc5SUhOcFoyNWhiSE11YkdWdVozUm9PeUJwS3lzcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JpZFhKNUlEWUtDblpsY21sbWVWQnliMjltWDNkb2FXeGxYM1J2Y0VBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXhPeUJwSUR3OUlITnBaMjVoYkhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHUnBaeUExQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQRDBLSUNBZ0lHSjZJSFpsY21sbWVWQnliMjltWDJGbWRHVnlYM2RvYVd4bFFERTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFeU53b2dJQ0FnTHk4Z2FXTlFiMmx1ZEhNZ1BTQnBZMUJ2YVc1MGN5NWpiMjVqWVhRb2Rtc3VTVU11WVhRb2FTa2hLVHNLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBOVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklEWTBDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklERXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5bmNtOTBhREUyWDJKdU1qVTBMbUZzWjI4dWRITTZNVEkyQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBeE95QnBJRHc5SUhOcFoyNWhiSE11YkdWdVozUm9PeUJwS3lzcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURZS0lDQWdJR0lnZG1WeWFXWjVVSEp2YjJaZmQyaHBiR1ZmZEc5d1FERTFDZ3AyWlhKcFpubFFjbTl2Wmw5aFpuUmxjbDkzYUdsc1pVQXhOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QnNaWFFnYzJOaGJHRnljeUE5SUVKNWRHVnpLQ2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Q2lBZ0lDQmlkWEo1SURnS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlkWEo1SURVS0NuWmxjbWxtZVZCeWIyOW1YMlp2Y2w5b1pXRmtaWEpBTVRnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlozSnZkR2d4Tmw5aWJqSTFOQzVoYkdkdkxuUnpPakV6TWdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCemFXZHVZV3dnYjJZZ2MybG5ibUZzY3lrZ2V3b2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXhDaUFnSUNBOENpQWdJQ0JpZWlCMlpYSnBabmxRY205dlpsOWhablJsY2w5bWIzSkFNakFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMkp1TWpVMFgyTnZiVzF2Ymk1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCeVpYUjFjbTRnWVNBbElFSk9NalUwWDFORFFVeEJVbDlOVDBSVlRGVlRPd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZbTR5TlRSZlkyOXRiVzl1TG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1ZXbHVkREkxTmloaEtTNWllWFJsY3k1MGIwWnBlR1ZrS0hzZ2JHVnVaM1JvT2lBek1pQjlLVHNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRXhsYm1kMGFDQnRkWE4wSUdKbElETXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZaM0p2ZEdneE5sOWliakkxTkM1aGJHZHZMblJ6T2pFek13b2dJQ0FnTHk4Z2MyTmhiR0Z5Y3lBOUlITmpZV3hoY25NdVkyOXVZMkYwS0dJek1paG1jbE5qWVd4aGNpaHphV2R1WVd3dVlYTkNhV2RWYVc1MEtDa3BLU2s3Q2lBZ0lDQmthV2NnT1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlEa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURVS0lDQWdJR0lnZG1WeWFXWjVVSEp2YjJaZlptOXlYMmhsWVdSbGNrQXhPQW9LZG1WeWFXWjVVSEp2YjJaZllXWjBaWEpmWm05eVFESXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMmR5YjNSb01UWmZZbTR5TlRRdVlXeG5ieTUwY3pveE16Y3RNVFF4Q2lBZ0lDQXZMeUJzWlhRZ1kzQjFZaUE5SUc5d0xrVnNiR2x3ZEdsalEzVnlkbVV1YzJOaGJHRnlUWFZzVFhWc2RHa29DaUFnSUNBdkx5QWdJRzl3TGtWakxrSk9NalUwWnpFc0NpQWdJQ0F2THlBZ0lHbGpVRzlwYm5SekxBb2dJQ0FnTHk4Z0lDQnpZMkZzWVhKekxBb2dJQ0FnTHk4Z0tTNTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQTJOQ0I5S1RzS0lDQWdJR1JwWnlBNENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWldOZmJYVnNkR2xmYzJOaGJHRnlYMjExYkNCQ1RqSTFOR2N4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUV4bGJtZDBhQ0J0ZFhOMElHSmxJRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WjNKdmRHZ3hObDlpYmpJMU5DNWhiR2R2TG5Sek9qRTBOQW9nSUNBZ0x5OGdZM0IxWWlBOUlHY3hRV1JrS0dOd2RXSXNJSFpyTGtsRFd6QmRJR0Z6SUdKNWRHVnpQRFkwUGlrN0NpQWdJQ0JrYVdjZ053b2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTkRVMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WW00eU5UUmZZMjl0Ylc5dUxtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNUZiR3hwY0hScFkwTjFjblpsTG1Ga1pDaHZjQzVGWXk1Q1RqSTFOR2N4TENCd01Td2djRElwTG5SdlJtbDRaV1FvZXlCc1pXNW5kR2c2SURZMElIMHBPd29nSUNBZ1pXTmZZV1JrSUVKT01qVTBaekVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTluY205MGFERTJYMkp1TWpVMExtRnNaMjh1ZEhNNk1UWTJDaUFnSUNBdkx5QmpiMjV6ZENCamNIVmlJRDBnWTI5dGNIVjBaVU53ZFdJb2Rtc3NJSE5wWjI1aGJITXBPd29nSUNBZ1lpQjJaWEpwWm5sUWNtOXZabDloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T21OdmJYQjFkR1ZEY0hWaVFESXhDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9scHJWbVZ5YVdacFpYSXVYMlIxYlcxNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYMlIxYlcxNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZERiRzl6WlU5MWRDY2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZeUEwSUM4dklEUTFOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME5UZ2dMeThnTkRVNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURVZ2IyWWdLSFZwYm5RNFd6WTBYU3gxYVc1ME9Gc3hNamhkTEhWcGJuUTRXekV5T0Ywc2RXbHVkRGhiTVRJNFhTeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GczJORjFiWFNrcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRFkwQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURRMk1DQXZMeUEwTmpBS0lDQWdJQ3NLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOW5jbTkwYURFMlgySnVNalUwTG1Gc1oyOHVkSE02T2tkeWIzUm9NVFpDYmpJMU5GWmxjbWxtYVdOaGRHbHZia3RsZVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBhYTFabGNtbG1hV1Z5TG5ObGRGWmxjbWxtYVdOaGRHbHZia1Z1WVdKc1pXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSV1pYSnBabWxqWVhScGIyNUZibUZpYkdWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0NBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklIQjFZbXhwWXlCMlpYSnBabWxqWVhScGIyNUZibUZpYkdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1luSUgwcElDQWdJQzh2SURFZ1BTQmxibUZpYkdWa0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklIUm9hWE11ZG1WeWFXWnBZMkYwYVc5dVJXNWhZbXhsWkM1MllXeDFaU0E5SUdWdVlXSnNaV1FLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBUUFnUU1nREpnVUJkZ0ZqQUNBd1pFNXk0VEdnS2JoUVJiYUJnVmhkS0RQb1NIbTVjSkZENGZXVDhBQUFBUUF4RzBFQVJJQUVGaERyMmpZYUFJNEJBQ3N4R1JSRU1SaEVnZ1FFN09vS3p3U0ZUZTNnQktBVy81RUVjS1NxZmpZYUFJNEVBQmNBTlFCV0FmTUFNUm1CQWhJeEdCQkVRZ0hFTVJrVU1SZ1VFRVFpUXpZYUFVa2pXWUVDQ0VzQkZSSkVWd0lBS0NKbktTTm5nQUYwVEdjaVF5TkpnUThNUVFBWHNUSUtJN0lJc2djaXNoQWpzZ0d6U1NJSVJRRkMvK0lpUXlOSEFpcEhBallhQVVrVmdZQUNFa1EyR2dKSEFpTlpTVTRDSkF1QkFnaE1GUkpFSXlobFJFQUFFeU9BQVFBalR3SlVnQVFWSDN4MVRGQ3dJa01uQkVsRkNJSEFBMXRMQVJKRUkwVUZTd1JMQVF4QkFCaExBVmNDQUVzRlNVNENKQXNrV0N1a1JDSUlSUVZDLytCSlFBQi9Td1pKSVFSWlN3RVZVbGNDUUVzRFNWY0FRSUFnTUdST2N1RXhvQ200VUVXMmdZRllYU2d6NkVoNXVYQ1JRK0gxay9BQUFBRGhBRWtWSlJKRVR3SlFTd0ZYd0VCUVN3aEpUZ0pYQUVCUVR3SlhRSUJMQWxmQWdGQkxBb01Dd0FLQUFWaFFUd0pYUUlCUTRnQkpSUVZCQUFraktXVkVJZ2dwVEdkTEEwTC9PeXBGQ1NKRkJrc0ZTd0VPUVFBalN3WkpJUVJaU3dFVlVsY0NBRXNHU1U0Q0pRc2xXRXNLVEZCRkNpSUlSUVpDLzlVcVJRZ2pSUVZMQkVzQkRFRUFLa3NCVndJQVN3VkpUZ0lrQ3lSWUs2cEpGU1FPUkNTdnEwa1ZKQkpFU3dsTVVFVUpJZ2hGQlVML3prc0lTd2pqQUVrVkpSSkVTd2RKSVFSWlN3RVZVbGNDUU9BQVNSVWxFa1JDL3dNMkdnRkpGVXNCSVFSWlNZSEtBeEpFVHdKTVN3SlNJMWtsQzRITUF3Z1NSQ0pETmhvQlNSV0JDQkpFRnloTVp5SkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJWRVJJRklDQVRJT05fS0VZIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
