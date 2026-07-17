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

namespace Arc56.Generated.prasanna9701.EcoTrack.CarbonCreditToken_d3280b6d
{


    public class CarbonCreditTokenProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CarbonCreditTokenProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RetirementRecord : AVMObjectType
            {
                public ulong Amount { get; set; }

                public ulong Timestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RetirementRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RetirementRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RetirementRecord);
                }
                public bool Equals(RetirementRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RetirementRecord left, RetirementRecord right)
                {
                    return EqualityComparer<RetirementRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(RetirementRecord left, RetirementRecord right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class CreditsRetiredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 120, 104, 164, 56 };
                public const string Signature = "CreditsRetired(byte[],uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field0 { get; set; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static CreditsRetiredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CreditsRetiredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Called on application creation.
        ///Stores the creator address. ASA is created in bootstrap().
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Bootstrap: create the EcoTrack Carbon Credit ASA.
        ///Must be called after funding the app account.
        ///</summary>
        /// <param name="mbrPay">- Payment to fund app for ASA MBR </param>
        public async Task<ulong> Bootstrap(PaymentTransaction mbrPay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 187, 38, 219, 64 };

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(PaymentTransaction mbrPay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 187, 38, 219, 64 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mint carbon credits to a recipient.
        ///Only callable by the contract creator.
        ///</summary>
        /// <param name="recipient">- Address to receive credits </param>
        /// <param name="amount">- Number of credits to mint (1 = 1 MT CO2) </param>
        public async Task Mint(Algorand.Address recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 32, 180, 120 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Mint_Transactions(Algorand.Address recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 32, 180, 120 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retire (burn) carbon credits.
        ///Caller sends credits to the contract via axferTxn.
        ///Retirement is recorded immutably in box storage.
        ///</summary>
        /// <param name="amount">- Amount being retired </param>
        /// <param name="axferTxn">- The asset transfer of credits to contract </param>
        /// <param name="mbrPay">- Payment to cover box storage MBR </param>
        public async Task Retire(AssetTransferTransaction axferTxn, PaymentTransaction mbrPay, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axferTxn, mbrPay });
            byte[] abiHandle = { 168, 218, 115, 214 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, axferTxn, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Retire_Transactions(AssetTransferTransaction axferTxn, PaymentTransaction mbrPay, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axferTxn, mbrPay });
            byte[] abiHandle = { 168, 218, 115, 214 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, axferTxn, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the ASA ID of the carbon credit token.
        ///</summary>
        public async Task<ulong> GetAssetId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 176, 212, 136 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 176, 212, 136 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the retirement count for an address.
        ///</summary>
        /// <param name="addr"> </param>
        public async Task<ulong> GetRetirementCount(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 100, 220, 168 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            var result = await base.CallApp(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRetirementCount_Transactions(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 100, 220, 168 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            return await base.MakeTransactionList(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FyYm9uQ3JlZGl0VG9rZW4iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUmV0aXJlbWVudFJlY29yZCI6W3sibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkNhbGxlZCBvbiBhcHBsaWNhdGlvbiBjcmVhdGlvbi5cblN0b3JlcyB0aGUgY3JlYXRvciBhZGRyZXNzLiBBU0EgaXMgY3JlYXRlZCBpbiBib290c3RyYXAoKS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6IkJvb3RzdHJhcDogY3JlYXRlIHRoZSBFY29UcmFjayBDYXJib24gQ3JlZGl0IEFTQS5cbk11c3QgYmUgY2FsbGVkIGFmdGVyIGZ1bmRpbmcgdGhlIGFwcCBhY2NvdW50LiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXkiLCJkZXNjIjoiLSBQYXltZW50IHRvIGZ1bmQgYXBwIGZvciBBU0EgTUJSIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBjcmVhdGVkIGFzc2V0IElEIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludCIsImRlc2MiOiJNaW50IGNhcmJvbiBjcmVkaXRzIHRvIGEgcmVjaXBpZW50LlxuT25seSBjYWxsYWJsZSBieSB0aGUgY29udHJhY3QgY3JlYXRvci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOiItIEFkZHJlc3MgdG8gcmVjZWl2ZSBjcmVkaXRzIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiLSBOdW1iZXIgb2YgY3JlZGl0cyB0byBtaW50ICgxID0gMSBNVCBDTzIpIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldGlyZSIsImRlc2MiOiJSZXRpcmUgKGJ1cm4pIGNhcmJvbiBjcmVkaXRzLlxuQ2FsbGVyIHNlbmRzIGNyZWRpdHMgdG8gdGhlIGNvbnRyYWN0IHZpYSBheGZlclR4bi5cblJldGlyZW1lbnQgaXMgcmVjb3JkZWQgaW1tdXRhYmx5IGluIGJveCBzdG9yYWdlLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiLSBBbW91bnQgYmVpbmcgcmV0aXJlZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJheGZlclR4biIsImRlc2MiOiItIFRoZSBhc3NldCB0cmFuc2ZlciBvZiBjcmVkaXRzIHRvIGNvbnRyYWN0IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXkiLCJkZXNjIjoiLSBQYXltZW50IHRvIGNvdmVyIGJveCBzdG9yYWdlIE1CUiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ3JlZGl0c1JldGlyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QXNzZXRJZCIsImRlc2MiOiJHZXQgdGhlIEFTQSBJRCBvZiB0aGUgY2FyYm9uIGNyZWRpdCB0b2tlbi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZXRpcmVtZW50Q291bnQiLCJkZXNjIjoiR2V0IHRoZSByZXRpcmVtZW50IGNvdW50IGZvciBhbiBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTI5XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBib290c3RyYXBwZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDAsNDQzXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzOSwyOTMsNDE1XSwiZXJyb3JNZXNzYWdlIjoiTm90IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gYm9vdHN0cmFwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBtaW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1LDMxNSwzMjFdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIwLDIzM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOCw0MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI2LDI2NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQsMjg5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRE15SURnS0lDQWdJR0o1ZEdWallteHZZMnNnSW1GemMyVjBTV1FpSUNKamNtVmhkRzl5SWlBd2VERTFNV1kzWXpjMUlDSnlZeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkRZWEppYjI1RGNtVmthWFJVYjJ0bGJpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFltSXlObVJpTkRBZ01IZzBPREl3WWpRM09DQXdlR0U0WkdFM00yUTJJREI0TUdOaU1HUTBPRGdnTUhnME16WTBaR05oT0NBdkx5QnRaWFJvYjJRZ0ltSnZiM1J6ZEhKaGNDaHdZWGtwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p0YVc1MEtHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsZEdseVpTaDFhVzUwTmpRc1lYaG1aWElzY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRFRnpjMlYwU1dRb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBVbVYwYVhKbGJXVnVkRU52ZFc1MEtHRmtaSEpsYzNNcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1ltOXZkSE4wY21Gd0lHMXBiblFnY21WMGFYSmxJR2RsZEVGemMyVjBTV1FnWjJWMFVtVjBhWEpsYldWdWRFTnZkVzUwQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNWZZM0psWkdsMEwwTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJEWVhKaWIyNURjbVZrYVhSVWIydGxiaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6bzZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZM0psWVhSbFFYQndiR2xqWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUdOeVpXRjBiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b2V5QnJaWGs2SUNkamNtVmhkRzl5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkzSmxZWFJ2Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNWZZM0psWkdsMEwwTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklIUm9hWE11WTNKbFlYUnZjaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QndkV0pzYVdNZ1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pvNlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVltOXZkSE4wY21Gd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl2ZEhOMGNtRndPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnY0hWaWJHbGpJR0p2YjNSemRISmhjQ2h0WW5KUVlYazZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNWZZM0psWkdsMEwwTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMDlJSFJvYVhNdVkzSmxZWFJ2Y2k1MllXeDFaU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QmpjbVZoZEc5eUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLSHNnYTJWNU9pQW5ZM0psWVhSdmNpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbU55WldGMGIzSXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TmpJdE5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1amNtVmhkRzl5TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FuVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJpYjI5MGMzUnlZWEFuTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdZbTl2ZEhOMGNtRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdVlYTnpaWFJKWkM1b1lYTldZV3gxWlN3Z0owRnNjbVZoWkhrZ1ltOXZkSE4wY21Gd2NHVmtKeWtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJoYzNObGRFbGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJGemMyVjBTV1FuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGMzTmxkRWxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbUZ6YzJWMFNXUXVhR0Z6Vm1Gc2RXVXNJQ2RCYkhKbFlXUjVJR0p2YjNSemRISmhjSEJsWkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCaWIyOTBjM1J5WVhCd1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZOekV0TnpNS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHMWljbEJoZVN3Z2V3b2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZOeklLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPamN4TFRjekNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHRZbkpRWVhrc0lIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pvM05pMDROd29nSUNBZ0x5OGdZMjl1YzNRZ1kzSmxZWFJsVkhodUlEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJEYjI1bWFXY29ld29nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNPaUJWYVc1ME5qUW9NVEJmTURBd1h6QXdNQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFNWhiV1U2SUNkRlkyOVVjbUZqYXlCRFlYSmliMjRnUTNKbFpHbDBKeXdLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBUbUZ0WlRvZ0owVkRReWNzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlRvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhkMkpoWTJzNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QnRZVzVoWjJWeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qZ3pMVGcwQ2lBZ0lDQXZMeUJ5WlhObGNuWmxPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklHTnNZWGRpWVdOck9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFVtVnpaWEoyWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEUxaGJtRm5aWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUhWdWFYUk9ZVzFsT2lBblJVTkRKeXdLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVU5ESWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVgyTnlaV1JwZEM5RFlYSmliMjVEY21Wa2FYUlViMnRsYmk1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCaGMzTmxkRTVoYldVNklDZEZZMjlVY21GamF5QkRZWEppYjI0Z1EzSmxaR2wwSnl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpUldOdlZISmhZMnNnUTJGeVltOXVJRU55WldScGRDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVgyTnlaV1JwZEM5RFlYSmliMjVEY21Wa2FYUlViMnRsYmk1aGJHZHZMblJ6T2pjNUNpQWdJQ0F2THlCa1pXTnBiV0ZzY3pvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2RHOTBZV3c2SUZWcGJuUTJOQ2d4TUY4d01EQmZNREF3S1N3S0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd01EQWdMeThnTVRBd01EQXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJVYjNSaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6bzNOaTA0TmdvZ0lDQWdMeThnWTI5dWMzUWdZM0psWVhSbFZIaHVJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSRGIyNW1hV2NvZXdvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzT2lCVmFXNTBOalFvTVRCZk1EQXdYekF3TUNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRTVoYldVNklDZEZZMjlVY21GamF5QkRZWEppYjI0Z1EzSmxaR2wwSnl3S0lDQWdJQzh2SUNBZ0lDQjFibWwwVG1GdFpUb2dKMFZEUXljc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJtWldVNklEQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZOell0T0RjS0lDQWdJQzh2SUdOdmJuTjBJR055WldGMFpWUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkRvZ1ZXbHVkRFkwS0RFd1h6QXdNRjh3TURBcExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJPWVcxbE9pQW5SV052VkhKaFkyc2dRMkZ5WW05dUlFTnlaV1JwZENjc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEU1aGJXVTZJQ2RGUTBNbkxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ6YzJWMFNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR0Z6YzJWMFNXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWVhOelpYUkpaQ2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GemMyVjBTV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVgyTnlaV1JwZEM5RFlYSmliMjVEY21Wa2FYUlViMnRsYmk1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWMFNXUXVkbUZzZFdVZ1BTQmpjbVZoZEdWVWVHNHVZM0psWVhSbFpFRnpjMlYwTG1sa0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJSEIxWW14cFl5QmliMjkwYzNSeVlYQW9iV0p5VUdGNU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNWZZM0psWkdsMEwwTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtRnNaMjh1ZEhNNk9rTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtMXBiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdGFXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem94TURBdE1UQXpDaUFnSUNBdkx5QndkV0pzYVdNZ2JXbHVkQ2dLSUNBZ0lDOHZJQ0FnY21WamFYQnBaVzUwT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVgyTnlaV1JwZEM5RFlYSmliMjVEY21Wa2FYUlViMnRsYmk1aGJHZHZMblJ6T2pFd05nb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1amNtVmhkRzl5TG5aaGJIVmxMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNWZZM0psWkdsMEwwTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHTnlaV0YwYjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9leUJyWlhrNklDZGpjbVZoZEc5eUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbU55WldGMGIzSXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TVRBMUxURXdPQW9nSUNBZ0x5OGdZWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlQU0IwYUdsekxtTnlaV0YwYjNJdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNkUGJteDVJR055WldGMGIzSWdZMkZ1SUcxcGJuUW5MQW9nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2JXbHVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRnpjMlYwU1dRdWFHRnpWbUZzZFdVc0lDZE9iM1FnWW05dmRITjBjbUZ3Y0dWa0p5a0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmhjM05sZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMkZ6YzJWMFNXUW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYzNObGRFbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRnpjMlYwU1dRdWFHRnpWbUZzZFdVc0lDZE9iM1FnWW05dmRITjBjbUZ3Y0dWa0p5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdKdmIzUnpkSEpoY0hCbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6b3hNVE10TVRJd0NpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUVGemMyVjBLSFJvYVhNdVlYTnpaWFJKWkM1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nY21WamFYQnBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TVRFekxURXhPUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQkJjM05sZENoMGFHbHpMbUZ6YzJWMFNXUXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qRXhNeTB4TWpBS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9kR2hwY3k1aGMzTmxkRWxrTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJ5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TVRBd0xURXdNd29nSUNBZ0x5OGdjSFZpYkdsaklHMXBiblFvQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZERvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPanBEWVhKaWIyNURjbVZrYVhSVWIydGxiaTV5WlhScGNtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhScGNtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPakV6TWkweE16WUtJQ0FnSUM4dklIQjFZbXhwWXlCeVpYUnBjbVVvQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JoZUdabGNsUjRiam9nWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUxBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TVRNM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhjM05sZEVsa0xtaGhjMVpoYkhWbExDQW5UbTkwSUdKdmIzUnpkSEpoY0hCbFpDY3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdZWE56WlhSSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RoYzNObGRFbGtKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVhOelpYUkpaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TVRNM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhjM05sZEVsa0xtaGhjMVpoYkhWbExDQW5UbTkwSUdKdmIzUnpkSEpoY0hCbFpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCaWIyOTBjM1J5WVhCd1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZNVFF3TFRFME5Bb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29ZWGhtWlhKVWVHNHNJSHNLSUNBZ0lDOHZJQ0FnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2gwYUdsekxtRnpjMlYwU1dRdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZWE56WlhSQmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0E5UFFvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02TVRReUNpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPakUwTUMweE5EUUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LR0Y0Wm1WeVZIaHVMQ0I3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvZEdocGN5NWhjM05sZEVsa0xuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlZ5ZENCMFlYSm5aWFFnYVhNZ2JXRjBZMmdnWm05eUlHTnZibVJwZEdsdmJuTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZNVFEzTFRFME9Rb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29iV0p5VUdGNUxDQjdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklIMHBDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem94TkRnS0lDQWdJQzh2SUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVgyTnlaV1JwZEM5RFlYSmliMjVEY21Wa2FYUlViMnRsYmk1aGJHZHZMblJ6T2pFME55MHhORGtLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0cxaWNsQmhlU3dnZXdvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPakUxTVFvZ0lDQWdMeThnWTI5dWMzUWdjMlZ1WkdWeVFubDBaWE02SUdKNWRHVnpJRDBnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJR052Ym5OMElIUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMElEMGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklHeGxkQ0JqYjNWdWREb2dkV2x1ZERZMElEMGdWV2x1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdjbVYwYVhKbGJXVnVkRU52ZFc1MGN5QTlJRUp2ZUUxaGNEeGllWFJsY3l3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKM0pqSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPakUxTVFvZ0lDQWdMeThnWTI5dWMzUWdjMlZ1WkdWeVFubDBaWE02SUdKNWRHVnpJRDBnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdjbVYwYVhKbGJXVnVkRU52ZFc1MGN5QTlJRUp2ZUUxaGNEeGllWFJsY3l3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKM0pqSnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZNVFUyQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTV5WlhScGNtVnRaVzUwUTI5MWJuUnpLSE5sYm1SbGNrSjVkR1Z6S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2djbVYwYVhKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pveE5UY0tJQ0FnSUM4dklHTnZkVzUwSUQwZ2RHaHBjeTV5WlhScGNtVnRaVzUwUTI5MWJuUnpLSE5sYm1SbGNrSjVkR1Z6S1M1MllXeDFaUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0F5Q2dweVpYUnBjbVZmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem94TmpFS0lDQWdJQzh2SUdOdmJuTjBJSEpsWTI5eVpFdGxlVG9nWW5sMFpYTWdQU0J2Y0M1amIyNWpZWFFvYzJWdVpHVnlRbmwwWlhNc0lHOXdMbWwwYjJJb1kyOTFiblFwS1FvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPakUyTXkweE5qWUtJQ0FnSUM4dklHTnZibk4wSUhKbFkyOXlaRG9nVW1WMGFYSmxiV1Z1ZEZKbFkyOXlaQ0E5SUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUhScGJXVnpkR0Z0Y0RvZ2RHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z2ZRb2dJQ0FnWkdsbklEY0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTJDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVgyTnlaV1JwZEM5RFlYSmliMjVEY21Wa2FYUlViMnRsYmk1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCeVpYUnBjbVZ0Wlc1MGN5QTlJRUp2ZUUxaGNEeGllWFJsY3l3Z1VtVjBhWEpsYldWdWRGSmxZMjl5WkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R5ZENjZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWNuUWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6b3hOamNLSUNBZ0lDOHZJSFJvYVhNdWNtVjBhWEpsYldWdWRITW9jbVZqYjNKa1MyVjVLUzUyWVd4MVpTQTlJR05zYjI1bEtISmxZMjl5WkNrS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZNVGN3Q2lBZ0lDQXZMeUIwYUdsekxuSmxkR2x5WlcxbGJuUkRiM1Z1ZEhNb2MyVnVaR1Z5UW5sMFpYTXBMblpoYkhWbElEMGdZMjkxYm5RZ0t5QlZhVzUwTmpRb01Ta0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6b3hOek1LSUNBZ0lDOHZJR1Z0YVhROFEzSmxaR2wwYzFKbGRHbHlaV1ErS0NkRGNtVmthWFJ6VW1WMGFYSmxaQ2NzSUhObGJtUmxja0o1ZEdWekxDQmhiVzkxYm5Rc0lIUnBiV1Z6ZEdGdGNDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNakFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREV5Q2lBZ0lDQmthV2NnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM09EWTRZVFF6T0NBdkx5QnRaWFJvYjJRZ0lrTnlaV1JwZEhOU1pYUnBjbVZrS0dKNWRHVmJYU3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnlZbTl1WDJOeVpXUnBkQzlEWVhKaWIyNURjbVZrYVhSVWIydGxiaTVoYkdkdkxuUnpPakV6TWkweE16WUtJQ0FnSUM4dklIQjFZbXhwWXlCeVpYUnBjbVVvQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JoZUdabGNsUjRiam9nWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUxBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZWEppYjI1ZlkzSmxaR2wwTDBOaGNtSnZia055WldScGRGUnZhMlZ1TG1Gc1oyOHVkSE02T2tOaGNtSnZia055WldScGRGUnZhMlZ1TG1kbGRFRnpjMlYwU1dSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJCYzNObGRFbGtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem94T0RBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRnpjMlYwU1dRdWFHRnpWbUZzZFdVc0lDZE9iM1FnWW05dmRITjBjbUZ3Y0dWa0p5a0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGeVltOXVYMk55WldScGRDOURZWEppYjI1RGNtVmthWFJVYjJ0bGJpNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmhjM05sZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMkZ6YzJWMFNXUW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYzNObGRFbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem94T0RBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRnpjMlYwU1dRdWFHRnpWbUZzZFdVc0lDZE9iM1FnWW05dmRITjBjbUZ3Y0dWa0p5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdKdmIzUnpkSEpoY0hCbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6b3hOemtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJCYzNObGRFbGtLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhjbUp2Ymw5amNtVmthWFF2UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WVd4bmJ5NTBjem82UTJGeVltOXVRM0psWkdsMFZHOXJaVzR1WjJWMFVtVjBhWEpsYldWdWRFTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVbVYwYVhKbGJXVnVkRU52ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6b3hPRGNLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJTWlhScGNtVnRaVzUwUTI5MWJuUW9ZV1JrY2pvZ1FXTmpiM1Z1ZENrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNWZZM0psWkdsMEwwTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklISmxkR2x5WlcxbGJuUkRiM1Z1ZEhNZ1BTQkNiM2hOWVhBOFlubDBaWE1zSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZHlZeWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5Kaklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZNVGc1Q2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTV5WlhScGNtVnRaVzUwUTI5MWJuUnpLR0ZrWkhKQ2VYUmxjeWt1WlhocGMzUnpLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHZGxkRkpsZEdseVpXMWxiblJEYjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVhKaWIyNWZZM0psWkdsMEwwTmhjbUp2YmtOeVpXUnBkRlJ2YTJWdUxtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV5WlhScGNtVnRaVzUwUTI5MWJuUnpLR0ZrWkhKQ2VYUmxjeWt1ZG1Gc2RXVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdKMGIya0tDbWRsZEZKbGRHbHlaVzFsYm5SRGIzVnVkRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5allYSmliMjVmWTNKbFpHbDBMME5oY21KdmJrTnlaV1JwZEZSdmEyVnVMbUZzWjI4dWRITTZPa05oY21KdmJrTnlaV1JwZEZSdmEyVnVMbWRsZEZKbGRHbHlaVzFsYm5SRGIzVnVkRUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pveE9EY0tJQ0FnSUM4dklIQjFZbXhwWXlCblpYUlNaWFJwY21WdFpXNTBRMjkxYm5Rb1lXUmtjam9nUVdOamIzVnVkQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUlNaWFJwY21WdFpXNTBRMjkxYm5SZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oY21KdmJsOWpjbVZrYVhRdlEyRnlZbTl1UTNKbFpHbDBWRzlyWlc0dVlXeG5ieTUwY3pveE9USUtJQ0FnSUM4dklISmxkSFZ5YmlCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ5WW05dVgyTnlaV1JwZEM5RFlYSmliMjVEY21Wa2FYUlViMnRsYmk1aGJHZHZMblJ6T2pFNE53b2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGSmxkR2x5WlcxbGJuUkRiM1Z1ZENoaFpHUnlPaUJCWTJOdmRXNTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSWdaMlYwVW1WMGFYSmxiV1Z1ZEVOdmRXNTBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJOaGNtSnZibDlqY21Wa2FYUXZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVZV3huYnk1MGN6bzZRMkZ5WW05dVEzSmxaR2wwVkc5clpXNHVaMlYwVW1WMGFYSmxiV1Z1ZEVOdmRXNTBRRFFLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBZ0NDWUVCMkZ6YzJWMFNXUUhZM0psWVhSdmNnUVZIM3gxQW5Kak1Sa1VSREVZUVFBcmdnVUV1eWJiUUFSSUlMUjRCS2phYzlZRURMRFVpQVJEWk55b05ob0FqZ1VBRlFCL0FLMEJTQUZUQUlBRXVFUjdOallhQUk0QkFBRUFLVEVBWnlKRE1SWWlDVWs0RUNJU1JERUFJeWxsUkJKRUl5aGxSUUVVUkRnSE1nb1NSTEV5Q2tjQ3NpeXlLcklwZ0FORlEwT3lKWUFXUldOdlZISmhZMnNnUTJGeVltOXVJRU55WldScGRMSW1JN0lqZ1lDdDRnU3lJb0VEc2hBanNnR3p0RHdvU3dGbkZpcE1VTEFpUXpZYUFVa1ZKQkpFTmhvQ1NSVWxFa1FYTVFBaktXVkVFa1FqS0dWRXNiSVJzaEt5RklFRXNoQWpzZ0d6SWtNMkdnRkhBaFVsRWtRWFNURVdnUUlKU1RnUWdRUVNSREVXSWdsSk9CQWlFa1FqS0dWRVN3STRFUkpMQWpnVU1nb1NFRThDT0JKUEF4SVFSRGdITWdvU1JERUFNZ2NqS3pFQVVFbTlSUUZCQUFaSnZrUVhSUUpMQVVrV1N3VkpUZ05NVUVzSEZrc0dGa3hMQVZDQUFuSjBUd05RVEw5TUlnZ1dTd05NdjRBQ0FDQlBBbENBQWdBU1N3aFFUd0pRVEZDQUJIaG9wRGhNVUxBaVF5TW9aVVFXS2t4UXNDSkROaG9CU1JVa0VrUXJURkJKdlVVQlFRQUxTYjVFRnhZcVRGQ3dJa01qUXYvMSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkNyZWRpdHNSZXRpcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
