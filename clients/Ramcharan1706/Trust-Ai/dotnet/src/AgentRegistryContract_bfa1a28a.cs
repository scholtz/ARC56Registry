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

namespace Arc56.Generated.Ramcharan1706.Trust_Ai.AgentRegistryContract_bfa1a28a
{


    //
    // Registry for trusted AI agents.
    //
    public class AgentRegistryContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentRegistryContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentRecord : AVMObjectType
            {
                public Algorand.Address Wallet { get; set; }

                public string MetadataHash { get; set; }

                public string Capabilities { get; set; }

                public ulong RegisteredAt { get; set; }

                public bool Verified { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadataHash.From(MetadataHash);
                    stringRef[ret.Count] = vMetadataHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCapabilities = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCapabilities.From(Capabilities);
                    stringRef[ret.Count] = vCapabilities.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegisteredAt.From(RegisteredAt);
                    ret.AddRange(vRegisteredAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vVerified.From(Verified);
                    ret.AddRange(vVerified.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AgentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is Algorand.Address vWalletValue) { ret.Wallet = vWalletValue; }
                    var indexMetadataHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadataHash.Decode(bytes.Skip(indexMetadataHash + prefixOffset).ToArray());
                    var valueMetadataHash = vMetadataHash.ToValue();
                    if (valueMetadataHash is string vMetadataHashValue) { ret.MetadataHash = vMetadataHashValue; }
                    var indexCapabilities = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCapabilities = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCapabilities.Decode(bytes.Skip(indexCapabilities + prefixOffset).ToArray());
                    var valueCapabilities = vCapabilities.ToValue();
                    if (valueCapabilities is string vCapabilitiesValue) { ret.Capabilities = vCapabilitiesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegisteredAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegisteredAt = vRegisteredAt.ToValue();
                    if (valueRegisteredAt is ulong vRegisteredAtValue) { ret.RegisteredAt = vRegisteredAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vVerified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerified = vVerified.ToValue();
                    if (valueVerified is bool vVerifiedValue) { ret.Verified = vVerifiedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentRecord);
                }
                public bool Equals(AgentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentRecord left, AgentRecord right)
                {
                    return EqualityComparer<AgentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentRecord left, AgentRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Register a new agent for the provided wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="metadata_hash"> </param>
        /// <param name="capabilities"> </param>
        public async Task RegisterAgent(Algorand.Address wallet, string metadata_hash, string capabilities, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 240, 87, 27 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_hashAbi.From(metadata_hash);
            var capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilitiesAbi.From(capabilities);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, metadata_hashAbi, capabilitiesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(Algorand.Address wallet, string metadata_hash, string capabilities, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 240, 87, 27 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_hashAbi.From(metadata_hash);
            var capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilitiesAbi.From(capabilities);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, metadata_hashAbi, capabilitiesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update metadata for an existing agent.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="metadata_hash"> </param>
        /// <param name="capabilities"> </param>
        public async Task UpdateAgent(Algorand.Address wallet, string metadata_hash, string capabilities, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 75, 206, 176 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_hashAbi.From(metadata_hash);
            var capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilitiesAbi.From(capabilities);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, metadata_hashAbi, capabilitiesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAgent_Transactions(Algorand.Address wallet, string metadata_hash, string capabilities, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 75, 206, 176 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_hashAbi.From(metadata_hash);
            var capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilitiesAbi.From(capabilities);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, metadata_hashAbi, capabilitiesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify a registered agent.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task VerifyAgent(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 110, 67, 173 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifyAgent_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 110, 67, 173 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the agent metadata for the provided wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.AgentRecord> GetAgent(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 61, 57, 188 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgent_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 61, 57, 188 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZWdpc3RyeUNvbnRyYWN0IiwiZGVzYyI6IlJlZ2lzdHJ5IGZvciB0cnVzdGVkIEFJIGFnZW50cy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWdlbnRSZWNvcmQiOlt7Im5hbWUiOiJ3YWxsZXQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im1ldGFkYXRhX2hhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY2FwYWJpbGl0aWVzIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InJlZ2lzdGVyZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidmVyaWZpZWQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWdpc3Rlcl9hZ2VudCIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyBhZ2VudCBmb3IgdGhlIHByb3ZpZGVkIHdhbGxldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0YWRhdGFfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FwYWJpbGl0aWVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9hZ2VudCIsImRlc2MiOiJVcGRhdGUgbWV0YWRhdGEgZm9yIGFuIGV4aXN0aW5nIGFnZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhZGF0YV9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXBhYmlsaXRpZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2FnZW50IiwiZGVzYyI6IlZlcmlmeSBhIHJlZ2lzdGVyZWQgYWdlbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FnZW50IiwiZGVzYyI6IlJldHVybiB0aGUgYWdlbnQgbWV0YWRhdGEgZm9yIHRoZSBwcm92aWRlZCB3YWxsZXQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3Msc3RyaW5nLHN0cmluZyx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJBZ2VudFJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTRdLCJlcnJvck1lc3NhZ2UiOiJhZ2VudCBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDQsMjUzXSwiZXJyb3JNZXNzYWdlIjoiY2FwYWJpbGl0aWVzIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMywxMTksMjA1LDIyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMywxMjYsMjE1LDIyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NywxOTksMzMwLDM2NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzIsMjM0LDMzNSwzNzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHdhbGxldCBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM5LDI0OF0sImVycm9yTWVzc2FnZSI6Im1ldGFkYXRhIGhhc2ggcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDMsMzQzLDM3OF0sImVycm9yTWVzc2FnZSI6InVua25vd24gYWdlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREF3TURBZ0ltRm5aVzUwY3lJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTQTlJRUZrWkhKbGMzTW9LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhaRzFwYmlJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMUNpQWdJQ0F2THlCamJHRnpjeUJCWjJWdWRGSmxaMmx6ZEhKNVEyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVE1LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREkzWmpBMU56RmlJREI0WkdRMFltTmxZakFnTUhneFpUWmxORE5oWkNBd2VEWmlNMlF6T1dKaklDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZZV2RsYm5Rb1lXUmtjbVZ6Y3l4emRISnBibWNzYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlY5aFoyVnVkQ2hoWkdSeVpYTnpMSE4wY21sdVp5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYMkZuWlc1MEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyRm5aVzUwS0dGa1pISmxjM01wS0dGa1pISmxjM01zYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc1ltOXZiQ2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCeVpXZHBjM1JsY2w5aFoyVnVkQ0IxY0dSaGRHVmZZV2RsYm5RZ2RtVnlhV1o1WDJGblpXNTBJR2RsZEY5aFoyVnVkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFek9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdkbGJuUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV2RsYm5SU1pXZHBjM1J5ZVVOdmJuUnlZV04wTG5KbFoybHpkR1Z5WDJGblpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEpmWVdkbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnWVhOelpYSjBJSGRoYkd4bGRDQWhQU0JCWkdSeVpYTnpLQ2tzSUNKcGJuWmhiR2xrSUhkaGJHeGxkQ0JoWkdSeVpYTnpJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSGRoYkd4bGRDQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUdGemMyVnlkQ0J0WlhSaFpHRjBZVjlvWVhOb0lDRTlJRk4wY21sdVp5Z2lJaWtzSUNKdFpYUmhaR0YwWVNCb1lYTm9JSEpsY1hWcGNtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnRaWFJoWkdGMFlTQm9ZWE5vSUhKbGNYVnBjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpZWEJoWW1sc2FYUnBaWE1nSVQwZ1UzUnlhVzVuS0NJaUtTd2dJbU5oY0dGaWFXeHBkR2xsY3lCeVpYRjFhWEpsWkNJS0lDQWdJR1JwWnlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUdGemMyVnlkQ0J0WlhSaFpHRjBZVjlvWVhOb0lDRTlJRk4wY21sdVp5Z2lJaWtzSUNKdFpYUmhaR0YwWVNCb1lYTm9JSEpsY1hWcGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnWVhOelpYSjBJR05oY0dGaWFXeHBkR2xsY3lBaFBTQlRkSEpwYm1jb0lpSXBMQ0FpWTJGd1lXSnBiR2wwYVdWeklISmxjWFZwY21Wa0lnb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVhCaFltbHNhWFJwWlhNZ2NtVnhkV2x5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnY21WMGRYSnVJSGRoYkd4bGRDQnBiaUJ6Wld4bUxtRm5aVzUwY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdkbGJuUnpJZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTGw5b1lYTmZZV2RsYm5Rb2QyRnNiR1YwS1N3Z0ltRm5aVzUwSUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkNJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhaMlZ1ZENCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96TVMwek53b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ1FXZGxiblJTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnZDJGc2JHVjBQWGRoYkd4bGRDd0tJQ0FnSUM4dklDQWdJQ0J0WlhSaFpHRjBZVjlvWVhOb1BXMWxkR0ZrWVhSaFgyaGhjMmdzQ2lBZ0lDQXZMeUFnSUNBZ1kyRndZV0pwYkdsMGFXVnpQV05oY0dGaWFXeHBkR2xsY3l3S0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSbGNtVmtYMkYwUFVGeVl6UlZTVzUwTmpRb1ZVbHVkRFkwS0RBcEtTd0tJQ0FnSUM4dklDQWdJQ0IyWlhKcFptbGxaRDFDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF5WkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb2FXNTBJRFExQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNellLSUNBZ0lDOHZJSFpsY21sbWFXVmtQVUp2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96TVMwek53b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ1FXZGxiblJTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnZDJGc2JHVjBQWGRoYkd4bGRDd0tJQ0FnSUM4dklDQWdJQ0J0WlhSaFpHRjBZVjlvWVhOb1BXMWxkR0ZrWVhSaFgyaGhjMmdzQ2lBZ0lDQXZMeUFnSUNBZ1kyRndZV0pwYkdsMGFXVnpQV05oY0dGaWFXeHBkR2xsY3l3S0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSbGNtVmtYMkYwUFVGeVl6UlZTVzUwTmpRb1ZVbHVkRFkwS0RBcEtTd0tJQ0FnSUM4dklDQWdJQ0IyWlhKcFptbGxaRDFDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzNkaGJHeGxkRjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV2RsYm5SZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXZGxiblJTWldkcGMzUnllVU52Ym5SeVlXTjBMblZ3WkdGMFpWOWhaMlZ1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlY5aFoyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCaGMzTmxjblFnZDJGc2JHVjBJQ0U5SUVGa1pISmxjM01vS1N3Z0ltbHVkbUZzYVdRZ2QyRnNiR1YwSUdGa1pISmxjM01pQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZDJGc2JHVjBJR0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhkaGJHeGxkQ0JwYmlCelpXeG1MbUZuWlc1MGN3b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXZGxiblJ6SWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxsOW9ZWE5mWVdkbGJuUW9kMkZzYkdWMEtTd2dJblZ1YTI1dmQyNGdZV2RsYm5RaUNpQWdJQ0JoYzNObGNuUWdMeThnZFc1cmJtOTNiaUJoWjJWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCaGMzTmxjblFnYldWMFlXUmhkR0ZmYUdGemFDQWhQU0JUZEhKcGJtY29JaUlwTENBaWJXVjBZV1JoZEdFZ2FHRnphQ0J5WlhGMWFYSmxaQ0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01Bb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ0WlhSaFpHRjBZU0JvWVhOb0lISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUdGemMyVnlkQ0JqWVhCaFltbHNhWFJwWlhNZ0lUMGdVM1J5YVc1bktDSWlLU3dnSW1OaGNHRmlhV3hwZEdsbGN5QnlaWEYxYVhKbFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCdFpYUmhaR0YwWVY5b1lYTm9JQ0U5SUZOMGNtbHVaeWdpSWlrc0lDSnRaWFJoWkdGMFlTQm9ZWE5vSUhKbGNYVnBjbVZrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdOaGNHRmlhV3hwZEdsbGN5QWhQU0JUZEhKcGJtY29JaUlwTENBaVkyRndZV0pwYkdsMGFXVnpJSEpsY1hWcGNtVmtJZ29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCallYQmhZbWxzYVhScFpYTWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVoWjJWdWRITmJkMkZzYkdWMFhTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRrS0lDQWdJQzh2SUhKbFkyOXlaQzV0WlhSaFpHRjBZVjlvWVhOb0lEMGdiV1YwWVdSaGRHRmZhR0Z6YUFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRE0wQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnTFFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUF6TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalV3Q2lBZ0lDQXZMeUJ5WldOdmNtUXVZMkZ3WVdKcGJHbDBhV1Z6SUQwZ1kyRndZV0pwYkdsMGFXVnpDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUhObGJHWXVZV2RsYm5SelczZGhiR3hsZEYwZ1BTQnlaV052Y21RdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdkbGJuUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV2RsYm5SU1pXZHBjM1J5ZVVOdmJuUnlZV04wTG5abGNtbG1lVjloWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWOWhaMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQjNZV3hzWlhRZ0lUMGdRV1JrY21WemN5Z3BMQ0FpYVc1MllXeHBaQ0IzWVd4c1pYUWdZV1JrY21WemN5SUtJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2QyRnNiR1YwSUdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIZGhiR3hsZENCcGJpQnpaV3htTG1GblpXNTBjd29nSUNBZ1lubDBaV05mTVNBdkx5QWlZV2RsYm5Seklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1ZmFHRnpYMkZuWlc1MEtIZGhiR3hsZENrc0lDSjFibXR1YjNkdUlHRm5aVzUwSWdvZ0lDQWdZWE56WlhKMElDOHZJSFZ1YTI1dmQyNGdZV2RsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yTUMwMk1Rb2dJQ0FnTHk4Z2NtVmpiM0prTG5abGNtbG1hV1ZrSUQwZ1FtOXZiQ2hVY25WbEtRb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdWRITmJkMkZzYkdWMFhTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBOQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJ5WldOdmNtUXVkbVZ5YVdacFpXUWdQU0JDYjI5c0tGUnlkV1VwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWXdMVFl4Q2lBZ0lDQXZMeUJ5WldOdmNtUXVkbVZ5YVdacFpXUWdQU0JDYjI5c0tGUnlkV1VwQ2lBZ0lDQXZMeUJ6Wld4bUxtRm5aVzUwYzF0M1lXeHNaWFJkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vYVc1MElEUTBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRm5aVzUwWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtGblpXNTBVbVZuYVhOMGNubERiMjUwY21GamRDNW5aWFJmWVdkbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZllXZGxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFnZDJGc2JHVjBJQ0U5SUVGa1pISmxjM01vS1N3Z0ltbHVkbUZzYVdRZ2QyRnNiR1YwSUdGa1pISmxjM01pQ2lBZ0lDQmtkWEFLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSGRoYkd4bGRDQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUhKbGRIVnliaUIzWVd4c1pYUWdhVzRnYzJWc1ppNWhaMlZ1ZEhNS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GblpXNTBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVYMmhoYzE5aFoyVnVkQ2gzWVd4c1pYUXBMQ0FpZFc1cmJtOTNiaUJoWjJWdWRDSUtJQ0FnSUdGemMyVnlkQ0F2THlCMWJtdHViM2R1SUdGblpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUZuWlc1MGMxdDNZV3hzWlhSZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdBaVlDQWdBQUJtRm5aVzUwY3pFWVFBQUtnQVZoWkcxcGJqSURaekViUVFBck1Sa1VSREVZUklJRUJDZndWeHNFM1V2T3NBUWVia090QkdzOU9idzJHZ0NPQkFBSkFHOEE4Z0VWQURFWkZERVlGQkJETmhvQlNSVWtFa1EyR2dKSklsa2xDRXNCRlVsUEFoSkVOaG9EU1NKWkpRaExBUlVTUkVzRE1nTVRSQ0lXU3dNb0UwUkxBU2dUUkNsTEJWQkp2VVVCRkVSUEJZQUNBQzFRZ1MxUEJRZ1dWd1lDVUU4Q1VJQUJBRkJQQTFCUEFsQkxBYnhJdnlORE5ob0JTUlVrRWtRMkdnSkpJbGtsQ0VzQkZVbFBBaEpFTmhvRFNTSlpKUWhMQVJVU1JFc0RNZ01UUkNsUEJGQkp2VVVCUkVzREtCTkVTd0VvRTBSSnZraEpKRmxMQVNKTEFsaFBCbEJMQW9FaVdVc0RGVThFU3dKUEFsSlBBa3hRU3dGUEF3bFBBazhGQ0V3SkZsY0dBbHdpU1lFaVdTSk1XRThDVUVzQnZFaS9JME0yR2dGSkZTUVNSRWt5QXhORUtVeFFTYjFGQVVSSmdTd2p1aUlqVklFc1RMc2pRellhQVVrVkpCSkVTVElERTBRcFRGQkp2VVVCUkw1SWdBUVZIM3gxVEZDd0kwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
