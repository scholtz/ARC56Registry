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

namespace Arc56.Generated.zainab_06_p.Hackathon_QuickStart_template.Ticketing_5c34f58a
{


    //
    // 
    //    CampusChain Ticketing Contract
    //    NFT-based event tickets with anti-scalping and entry verification
    //    Each deployment = one event (fully decentralized)
    //    Features:
    //    - Mints NFT ticket on purchase
    //    - QR code verification at entry
    //    - Prevents double entry
    //    
    //
    public class TicketingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TicketingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetEventInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public bool Field6 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetEventInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetEventInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is bool vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetEventInfoReturn);
                }
                public bool Equals(GetEventInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetEventInfoReturn left, GetEventInfoReturn right)
                {
                    return EqualityComparer<GetEventInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetEventInfoReturn left, GetEventInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create a new ticketed event (called during contract creation)
        ///</summary>
        /// <param name="price"> </param>
        /// <param name="supply"> </param>
        /// <param name="event_date"> </param>
        /// <param name="sale_end_date"> </param>
        public async Task<ulong> CreateEvent(ulong price, ulong supply, ulong event_date, ulong sale_end_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 221, 107, 253 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyAbi.From(supply);
            var event_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_dateAbi.From(event_date);
            var sale_end_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sale_end_dateAbi.From(sale_end_date);

            var result = await base.CallApp(new List<object> { abiHandle, priceAbi, supplyAbi, event_dateAbi, sale_end_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateEvent_Transactions(ulong price, ulong supply, ulong event_date, ulong sale_end_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 221, 107, 253 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyAbi.From(supply);
            var event_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_dateAbi.From(event_date);
            var sale_end_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sale_end_dateAbi.From(sale_end_date);

            return await base.MakeTransactionList(new List<object> { abiHandle, priceAbi, supplyAbi, event_dateAbi, sale_end_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Purchase an event ticket - Mints NFT to buyer
        ///Returns the NFT Asset ID
        ///</summary>
        /// <param name="payment"> </param>
        public async Task<ulong> BuyTicket(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 113, 239, 91, 211 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyTicket_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 113, 239, 91, 211 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify ticket at event entry (called by organizer/staff)
        ///Checks NFT ownership and check-in status
        ///</summary>
        /// <param name="ticket_holder"> </param>
        /// <param name="ticket_asset_id"> </param>
        public async Task<bool> VerifyEntry(Address ticket_holder, ulong ticket_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { ticket_holder });
            byte ticket_holderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 51, 248, 136, 157 };
            var ticket_holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ticket_holderAbi.From(ticket_holder);
            var ticket_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_asset_idAbi.From(ticket_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, ticket_holderRefIndex, ticket_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyEntry_Transactions(Address ticket_holder, ulong ticket_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { ticket_holder });
            byte ticket_holderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 51, 248, 136, 157 };
            var ticket_holderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ticket_holderAbi.From(ticket_holder);
            var ticket_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_asset_idAbi.From(ticket_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, ticket_holderRefIndex, ticket_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a ticket has been used for entry
        ///</summary>
        /// <param name="ticket_asset_id"> </param>
        public async Task<bool> IsCheckedIn(ulong ticket_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 189, 219, 34 };
            var ticket_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_asset_idAbi.From(ticket_asset_id);

            var result = await base.SimApp(new List<object> { abiHandle, ticket_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsCheckedIn_Transactions(ulong ticket_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 189, 219, 34 };
            var ticket_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_asset_idAbi.From(ticket_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, ticket_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Toggle ticket sales on/off (organizer only)
        ///</summary>
        public async Task<bool> ToggleSale(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 25, 192, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ToggleSale_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 25, 192, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get event information
        ///</summary>
        public async Task<Structs.GetEventInfoReturn> GetEventInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 16, 191, 178 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetEventInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEventInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 16, 191, 178 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get event organizer address
        ///</summary>
        public async Task<Algorand.Address> GetOrganizer(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 25, 217, 39 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetOrganizer_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 25, 217, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGlja2V0aW5nIiwiZGVzYyI6IlxuICAgIENhbXB1c0NoYWluIFRpY2tldGluZyBDb250cmFjdFxuICAgIE5GVC1iYXNlZCBldmVudCB0aWNrZXRzIHdpdGggYW50aS1zY2FscGluZyBhbmQgZW50cnkgdmVyaWZpY2F0aW9uXG4gICAgRWFjaCBkZXBsb3ltZW50ID0gb25lIGV2ZW50IChmdWxseSBkZWNlbnRyYWxpemVkKVxuICAgIEZlYXR1cmVzOlxuICAgIC0gTWludHMgTkZUIHRpY2tldCBvbiBwdXJjaGFzZVxuICAgIC0gUVIgY29kZSB2ZXJpZmljYXRpb24gYXQgZW50cnlcbiAgICAtIFByZXZlbnRzIGRvdWJsZSBlbnRyeVxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRFdmVudEluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfZXZlbnQiLCJkZXNjIjoiQ3JlYXRlIGEgbmV3IHRpY2tldGVkIGV2ZW50IChjYWxsZWQgZHVyaW5nIGNvbnRyYWN0IGNyZWF0aW9uKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlX2VuZF9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5X3RpY2tldCIsImRlc2MiOiJQdXJjaGFzZSBhbiBldmVudCB0aWNrZXQgLSBNaW50cyBORlQgdG8gYnV5ZXJcblJldHVybnMgdGhlIE5GVCBBc3NldCBJRCIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2VudHJ5IiwiZGVzYyI6IlZlcmlmeSB0aWNrZXQgYXQgZXZlbnQgZW50cnkgKGNhbGxlZCBieSBvcmdhbml6ZXIvc3RhZmYpXG5DaGVja3MgTkZUIG93bmVyc2hpcCBhbmQgY2hlY2staW4gc3RhdHVzIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWNrZXRfaG9sZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWNrZXRfYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfY2hlY2tlZF9pbiIsImRlc2MiOiJDaGVjayBpZiBhIHRpY2tldCBoYXMgYmVlbiB1c2VkIGZvciBlbnRyeSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWNrZXRfYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2dnbGVfc2FsZSIsImRlc2MiOiJUb2dnbGUgdGlja2V0IHNhbGVzIG9uL29mZiAob3JnYW5pemVyIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ldmVudF9pbmZvIiwiZGVzYyI6IkdldCBldmVudCBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJHZXRFdmVudEluZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfb3JnYW5pemVyIiwiZGVzYyI6IkdldCBldmVudCBvcmdhbml6ZXIgYWRkcmVzcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo3LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDY0XSwiZXJyb3JNZXNzYWdlIjoiRXZlbnQgaGFzIHBhc3NlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzOF0sImVycm9yTWVzc2FnZSI6IkV2ZW50IHZlcmlmaWNhdGlvbiBwZXJpb2QgZW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODNdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgcGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2Ml0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgdGlja2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5LDE5NSwyNTMsMjc0LDI5OSwzMzAsMzU3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvcmdhbml6ZXIgY2FuIHRvZ2dsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3JnYW5pemVyIGNhbiB2ZXJpZnkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzVdLCJlcnJvck1lc3NhZ2UiOiJTYWxlIG5vdCBhY3RpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDZdLCJlcnJvck1lc3NhZ2UiOiJTb2xkIG91dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2Nl0sImVycm9yTWVzc2FnZSI6IlRpY2tldCBhbHJlYWR5IHVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTZdLCJlcnJvck1lc3NhZ2UiOiJUaWNrZXQgbm90IG93bmVkIGJ5IGhvbGRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1NV0sImVycm9yTWVzc2FnZSI6IlRpY2tldCBzYWxlcyBoYXZlIGVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyLDE5OCwyNTYsMjc3LDMwMiwzMzNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYyLDYzMSw3MzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmV2ZW50X2RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM0LDcxMCw3MTgsNzUyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc19zYWxlX2FjdGl2ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDQsNzI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYXhfc3VwcGx5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyMiw3MDQsNzU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcmdhbml6ZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUzLDc0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2FsZV9lbmRfZGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzksNDg3LDczM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc29sZF9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODEsNzI0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50aWNrZXRfcHJpY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk3LDc0OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudW5pcXVlX2J1eWVycyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpYVhOZmMyRnNaVjloWTNScGRtVWlJREI0TURBZ0luTnZiR1JmWTI5MWJuUWlJQ0psZG1WdWRGOWtZWFJsSWlBaWIzSm5ZVzVwZW1WeUlpQWlkVzVwY1hWbFgySjFlV1Z5Y3lJZ0luUnBZMnRsZEY5d2NtbGpaU0lnSW0xaGVGOXpkWEJ3YkhraUlDSnpZV3hsWDJWdVpGOWtZWFJsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJVYVdOclpYUnBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsT0dSa05tSm1aQ0F3ZURjeFpXWTFZbVF6SURCNE16Tm1PRGc0T1dRZ01IZzRPR0prWkdJeU1pQXdlREJoTVRsak1EUTRJREI0WVdReE1HSm1ZaklnTUhobE5qRTVaRGt5TnlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlY5bGRtVnVkQ2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ppZFhsZmRHbGphMlYwS0hCaGVTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVY5bGJuUnllU2hoWTJOdmRXNTBMSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKcGMxOWphR1ZqYTJWa1gybHVLSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKMGIyZG5iR1ZmYzJGc1pTZ3BZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBYMlYyWlc1MFgybHVabThvS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0tTSXNJRzFsZEdodlpDQWlaMlYwWDI5eVoyRnVhWHBsY2lncFlXUmtjbVZ6Y3lJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxYMlYyWlc1MFgzSnZkWFJsUURNZ2JXRnBibDlpZFhsZmRHbGphMlYwWDNKdmRYUmxRRFFnYldGcGJsOTJaWEpwWm5sZlpXNTBjbmxmY205MWRHVkFOU0J0WVdsdVgybHpYMk5vWldOclpXUmZhVzVmY205MWRHVkFOaUJ0WVdsdVgzUnZaMmRzWlY5ellXeGxYM0p2ZFhSbFFEY2diV0ZwYmw5blpYUmZaWFpsYm5SZmFXNW1iMTl5YjNWMFpVQTRJRzFoYVc1ZloyVjBYMjl5WjJGdWFYcGxjbDl5YjNWMFpVQTVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUZScFkydGxkR2x1WnloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYjNKbllXNXBlbVZ5WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl2Y21kaGJtbDZaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJWMlpXNTBYMmx1Wm05ZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZaWFpsYm5SZmFXNW1id29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCelpYUmlhWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHOW5aMnhsWDNOaGJHVmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEUyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQjBiMmRuYkdWZmMyRnNaUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmFYTmZZMmhsWTJ0bFpGOXBibDl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5QlVhV05yWlhScGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2x6WDJOb1pXTnJaV1JmYVc0S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1psY21sbWVWOWxiblJ5ZVY5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZHbGphMlYwYVc1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhabGNtbG1lVjlsYm5SeWVRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW5WNVgzUnBZMnRsZEY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZHbGphMlYwYVc1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmlkWGxmZEdsamEyVjBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5bGRtVnVkRjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNuVG05UGNDZGRMQ0JqY21WaGRHVTlKM0psY1hWcGNtVW5LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdWR2xqYTJWMGFXNW5LRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5ZE9iMDl3SjEwc0lHTnlaV0YwWlQwbmNtVnhkV2x5WlNjcENpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpWOWxkbVZ1ZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBhV05yWlhScGJtY3VZMjl1ZEhKaFkzUXVWR2xqYTJWMGFXNW5MbU55WldGMFpWOWxkbVZ1ZENod2NtbGpaVG9nZFdsdWREWTBMQ0J6ZFhCd2JIazZJSFZwYm5RMk5Dd2daWFpsYm5SZlpHRjBaVG9nZFdsdWREWTBMQ0J6WVd4bFgyVnVaRjlrWVhSbE9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tZM0psWVhSbFgyVjJaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU5TMHlOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc25UbTlQY0NkZExDQmpjbVZoZEdVOUozSmxjWFZwY21VbktRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOWxkbVZ1ZENoelpXeG1MQ0J3Y21salpUb2dWVWx1ZERZMExDQnpkWEJ3YkhrNklGVkpiblEyTkN3Z1pYWmxiblJmWkdGMFpUb2dWVWx1ZERZMExDQnpZV3hsWDJWdVpGOWtZWFJsT2lCVlNXNTBOalFwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnYzJWc1ppNTBhV05yWlhSZmNISnBZMlVnUFNCd2NtbGpaUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkR2xqYTJWMFgzQnlhV05sSWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z2MyVnNaaTV0WVhoZmMzVndjR3g1SUQwZ2MzVndjR3g1Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0p0WVhoZmMzVndjR3g1SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z2MyVnNaaTV6YjJ4a1gyTnZkVzUwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemIyeGtYMk52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QnpaV3htTG1WMlpXNTBYMlJoZEdVZ1BTQmxkbVZ1ZEY5a1lYUmxDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmxkbVZ1ZEY5a1lYUmxJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG96TWdvZ0lDQWdMeThnYzJWc1ppNXpZV3hsWDJWdVpGOWtZWFJsSUQwZ2MyRnNaVjlsYm1SZlpHRjBaU0FnSXlCVGRHOXlaU0J6WVd4bElHVnVaQ0JrWVhSbENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKellXeGxYMlZ1WkY5a1lYUmxJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnYzJWc1ppNXZjbWRoYm1sNlpYSWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p2Y21kaGJtbDZaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnYzJWc1ppNXBjMTl6WVd4bFgyRmpkR2wyWlNBOUlGUnlkV1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWx6WDNOaGJHVmZZV04wYVhabElnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QnpaV3htTG5WdWFYRjFaVjlpZFhsbGNuTWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblZ1YVhGMVpWOWlkWGxsY25NaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk16WUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaeTVpZFhsZmRHbGphMlYwS0hCaGVXMWxiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwaWRYbGZkR2xqYTJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3pPQzB6T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdZblY1WDNScFkydGxkQ2h6Wld4bUxDQndZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2YmlrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXBjMTl6WVd4bFgyRmpkR2wyWlN3Z0lsTmhiR1VnYm05MElHRmpkR2wyWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pwYzE5ellXeGxYMkZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5ellXeGxYMkZqZEdsMlpTQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWVd4bElHNXZkQ0JoWTNScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OdmJHUmZZMjkxYm5RZ1BDQnpaV3htTG0xaGVGOXpkWEJ3Ykhrc0lDSlRiMnhrSUc5MWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemIyeGtYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk52YkdSZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWJXRjRYM04xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WVhoZmMzVndjR3g1SUdWNGFYTjBjd29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUZOdmJHUWdiM1YwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQQ0J6Wld4bUxuTmhiR1ZmWlc1a1gyUmhkR1VzSUNKVWFXTnJaWFFnYzJGc1pYTWdhR0YyWlNCbGJtUmxaQ0lLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnpZV3hsWDJWdVpGOWtZWFJsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmhiR1ZmWlc1a1gyUmhkR1VnWlhocGMzUnpDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnVkdsamEyVjBJSE5oYkdWeklHaGhkbVVnWlc1a1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBOElITmxiR1l1WlhabGJuUmZaR0YwWlN3Z0lrVjJaVzUwSUdoaGN5QndZWE56WldRaUNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWlhabGJuUmZaR0YwWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxkbVZ1ZEY5a1lYUmxJR1Y0YVhOMGN3b2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJRVYyWlc1MElHaGhjeUJ3WVhOelpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNWhiVzkxYm5RZ1BqMGdjMlZzWmk1MGFXTnJaWFJmY0hKcFkyVXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2NHRjViV1Z1ZENJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkR2xqYTJWMFgzQnlhV05sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnBZMnRsZEY5d2NtbGpaU0JsZUdsemRITUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElIQmhlVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5URXROVElLSUNBZ0lDOHZJQ01nU1c1amNtVnRaVzUwSUhScFkydGxkQ0JqYjNWdWRHVnlDaUFnSUNBdkx5QnpaV3htTG5OdmJHUmZZMjkxYm5RZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWMyOXNaRjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6YjJ4a1gyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5OdmJHUmZZMjkxYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdjMlZzWmk1MWJtbHhkV1ZmWW5WNVpYSnpJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblZ1YVhGMVpWOWlkWGxsY25NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkVzVwY1hWbFgySjFlV1Z5Y3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMWJtbHhkV1ZmWW5WNVpYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRVdE5qWUtJQ0FnSUM4dklDTWdUV2x1ZENCT1JsUWdkR2xqYTJWMElIUnZJR0oxZVdWeUNpQWdJQ0F2THlCMGFXTnJaWFJmWVhOelpYUmZhV1FnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFRFc0lDQWpJRTVHVkNBb01TQjFibWwwSUc5dWJIa3BDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TUN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQV0lpUlhabGJuUWdWR2xqYTJWMElpd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5WWlKVVNWZ2lMQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEMWlJbWx3Wm5NNkx5OWpZVzF3ZFhNdGRHbGphMlYwSWl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMXdZWGx0Wlc1MExuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExuTjFZbTFwZENncExtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCeVpYTmxjblpsUFhCaGVXMWxiblF1YzJWdVpHVnlMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJR1p5WldWNlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJuSmxaWHBsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJTWlhObGNuWmxDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdkWEpzUFdJaWFYQm1jem92TDJOaGJYQjFjeTEwYVdOclpYUWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROamszTURZMk56TXpZVEptTW1ZMk16WXhObVEzTURjMU56TXlaRGMwTmprMk16WmlOalUzTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWU1RBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQV0lpVkVsWUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVTBORGsxT0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCaGMzTmxkRjl1WVcxbFBXSWlSWFpsYm5RZ1ZHbGphMlYwSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRMU56WTJOVFpsTnpReU1EVTBOamsyTXpaaU5qVTNOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklHUmxZMmx0WVd4elBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxZMmx0WVd4ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QjBiM1JoYkQweExDQWdJeUJPUmxRZ0tERWdkVzVwZENCdmJteDVLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU5TMDFOZ29nSUNBZ0x5OGdJeUJOYVc1MElFNUdWQ0IwYVdOclpYUWdkRzhnWW5WNVpYSUtJQ0FnSUM4dklIUnBZMnRsZEY5aGMzTmxkRjlwWkNBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z1lXTm1ad29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qVTFMVFkyQ2lBZ0lDQXZMeUFqSUUxcGJuUWdUa1pVSUhScFkydGxkQ0IwYnlCaWRYbGxjZ29nSUNBZ0x5OGdkR2xqYTJWMFgyRnpjMlYwWDJsa0lEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMHhMQ0FnSXlCT1JsUWdLREVnZFc1cGRDQnZibXg1S1FvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQxaUlrVjJaVzUwSUZScFkydGxkQ0lzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBXSWlWRWxZSWl3S0lDQWdJQzh2SUNBZ0lDQjFjbXc5WWlKcGNHWnpPaTh2WTJGdGNIVnpMWFJwWTJ0bGRDSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5Y0dGNWJXVnVkQzV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnM5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUzVqY21WaGRHVmtYMkZ6YzJWMExtbGtDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQkRjbVZoZEdWa1FYTnpaWFJKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk9DMDNNd29nSUNBZ0x5OGdJeUJVY21GdWMyWmxjaUJPUmxRZ2RHOGdZblY1WlhJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxd1lYbHRaVzUwTG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNU3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBYUnBZMnRsZEY5aGMzTmxkRjlwWkFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFRFc0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qWTRMVFk1Q2lBZ0lDQXZMeUFqSUZSeVlXNXpabVZ5SUU1R1ZDQjBieUJpZFhsbGNnb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOamd0TnpNS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ1RrWlVJSFJ2SUdKMWVXVnlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljR0Y1YldWdWRDNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRFc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDEwYVdOclpYUmZZWE56WlhSZmFXUUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qYzFMVGMyQ2lBZ0lDQXZMeUFqSUVsdWFYUnBZV3hwZW1VZ1kyaGxZMnN0YVc0Z2MzUmhkSFZ6SUdsdUlHSnZlQ0J6ZEc5eVlXZGxDaUFnSUNBdkx5QmliM2hmYTJWNUlEMGdiM0F1YVhSdllpaDBhV05yWlhSZllYTnpaWFJmYVdRcENpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklFSnZlQ2hDZVhSbGN5d2dhMlY1UFdKdmVGOXJaWGtwTG5aaGJIVmxJRDBnUW5sMFpYTW9ZaUpjZURBd0lpa2dJQ01nTUNBOUlHNXZkQ0JqYUdWamEyVmtJR2x1Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2xqYTJWMFgyRnpjMlYwWDJsa0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEdsamEyVjBhVzVuTG1OdmJuUnlZV04wTGxScFkydGxkR2x1Wnk1MlpYSnBabmxmWlc1MGNua29kR2xqYTJWMFgyaHZiR1JsY2pvZ1lubDBaWE1zSUhScFkydGxkRjloYzNObGRGOXBaRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q25abGNtbG1lVjlsYm5SeWVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZPREV0T0RJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JSFpsY21sbWVWOWxiblJ5ZVNoelpXeG1MQ0IwYVdOclpYUmZhRzlzWkdWeU9pQkJZMk52ZFc1MExDQjBhV05yWlhSZllYTnpaWFJmYVdRNklGVkpiblEyTkNrZ0xUNGdZbTl2YkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG80TndvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTV2Y21kaGJtbDZaWElzSUNKUGJteDVJRzl5WjJGdWFYcGxjaUJqWVc0Z2RtVnlhV1o1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltOXlaMkZ1YVhwbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2Y21kaGJtbDZaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diM0puWVc1cGVtVnlJR05oYmlCMlpYSnBabmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQThQU0J6Wld4bUxtVjJaVzUwWDJSaGRHVWdLeUJWU1c1ME5qUW9PRFkwTURBcExDQWlSWFpsYm5RZ2RtVnlhV1pwWTJGMGFXOXVJSEJsY21sdlpDQmxibVJsWkNJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0psZG1WdWRGOWtZWFJsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVjJaVzUwWDJSaGRHVWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRGcyTkRBd0lDOHZJRGcyTkRBd0NpQWdJQ0FyQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFVjJaVzUwSUhabGNtbG1hV05oZEdsdmJpQndaWEpwYjJRZ1pXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T1RBdE9URUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2RHbGphMlYwWDJodmJHUmxjaUJ2ZDI1eklIUm9aU0JPUmxRS0lDQWdJQzh2SUdodmJHUmxjbDlpWVd4aGJtTmxMQ0JvYjJ4a1pYSmZaWGhwYzNSeklEMGdiM0F1UVhOelpYUkliMnhrYVc1blIyVjBMbUZ6YzJWMFgySmhiR0Z1WTJVb2RHbGphMlYwWDJodmJHUmxjaXdnZEdsamEyVjBYMkZ6YzJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdZWE56WlhKMElHaHZiR1JsY2w5bGVHbHpkSE1nWVc1a0lHaHZiR1JsY2w5aVlXeGhibU5sSUQwOUlGVkpiblEyTkNneEtTd2dJbFJwWTJ0bGRDQnViM1FnYjNkdVpXUWdZbmtnYUc5c1pHVnlJZ29nSUNBZ1lub2dkbVZ5YVdaNVgyVnVkSEo1WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dkbVZ5YVdaNVgyVnVkSEo1WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuWmxjbWxtZVY5bGJuUnllVjlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qa3lDaUFnSUNBdkx5QmhjM05sY25RZ2FHOXNaR1Z5WDJWNGFYTjBjeUJoYm1RZ2FHOXNaR1Z5WDJKaGJHRnVZMlVnUFQwZ1ZVbHVkRFkwS0RFcExDQWlWR2xqYTJWMElHNXZkQ0J2ZDI1bFpDQmllU0JvYjJ4a1pYSWlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHbGphMlYwSUc1dmRDQnZkMjVsWkNCaWVTQm9iMnhrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk9UUXRPVFVLSUNBZ0lDOHZJQ01nUTJobFkyc2dkR2xqYTJWMElHaGhjMjRuZENCaVpXVnVJSFZ6WldRS0lDQWdJQzh2SUdKdmVGOXJaWGtnUFNCdmNDNXBkRzlpS0hScFkydGxkRjloYzNObGRGOXBaQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnZEdsamEyVjBYM04wWVhSMWN5d2dZbTk0WDJWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb1ltOTRYMnRsZVNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjlsZUdsemRITXNJQ0pKYm5aaGJHbGtJSFJwWTJ0bGRDSUtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhScFkydGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnWVhOelpYSjBJRzl3TG1WNGRISmhZM1JmZFdsdWREWTBLSFJwWTJ0bGRGOXpkR0YwZFhNc0lEQXBJRDA5SUZWSmJuUTJOQ2d3S1N3Z0lsUnBZMnRsZENCaGJISmxZV1I1SUhWelpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJVYVdOclpYUWdZV3h5WldGa2VTQjFjMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd01DMHhNREVLSUNBZ0lDOHZJQ01nVFdGeWF5QmhjeUJqYUdWamEyVmtMV2x1Q2lBZ0lDQXZMeUJ2Y0M1Q2IzZ3VjSFYwS0dKdmVGOXJaWGtzSUc5d0xtbDBiMklvVlVsdWREWTBLREVwS1NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ25abGNtbG1lVjlsYm5SeWVWOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQjJaWEpwWm5sZlpXNTBjbmxmWW05dmJGOXRaWEpuWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJwWTJ0bGRHbHVaeTVqYjI1MGNtRmpkQzVVYVdOclpYUnBibWN1YVhOZlkyaGxZMnRsWkY5cGJpaDBhV05yWlhSZllYTnpaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncHBjMTlqYUdWamEyVmtYMmx1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1EVXRNVEEyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnYVhOZlkyaGxZMnRsWkY5cGJpaHpaV3htTENCMGFXTnJaWFJmWVhOelpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1ltOXZiRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJR0p2ZUY5clpYa2dQU0J2Y0M1cGRHOWlLSFJwWTJ0bGRGOWhjM05sZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJSFJwWTJ0bGRGOXpkR0YwZFhNc0lHSnZlRjlsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0dKdmVGOXJaWGtwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXhNUW9nSUNBZ0x5OGdhV1lnYm05MElHSnZlRjlsZUdsemRITTZDaUFnSUNCaWJub2dhWE5mWTJobFkydGxaRjlwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCeVpYUjFjbTRnUm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWx6WDJOb1pXTnJaV1JmYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1UUUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNWxlSFJ5WVdOMFgzVnBiblEyTkNoMGFXTnJaWFJmYzNSaGRIVnpMQ0F3S1NBOVBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnBZMnRsZEdsdVp5NWpiMjUwY21GamRDNVVhV05yWlhScGJtY3VkRzluWjJ4bFgzTmhiR1VvS1NBdFBpQjFhVzUwTmpRNkNuUnZaMmRzWlY5ellXeGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNKbllXNXBlbVZ5TENBaVQyNXNlU0J2Y21kaGJtbDZaWElnWTJGdUlIUnZaMmRzWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSnZjbWRoYm1sNlpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNKbllXNXBlbVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzl5WjJGdWFYcGxjaUJqWVc0Z2RHOW5aMnhsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU1Bb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5ellXeGxYMkZqZEdsMlpTQTlJRzV2ZENCelpXeG1MbWx6WDNOaGJHVmZZV04wYVhabENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVhOZmMyRnNaVjloWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOZmMyRnNaVjloWTNScGRtVWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pwYzE5ellXeGxYMkZqZEdsMlpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakV5TVFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWFYTmZjMkZzWlY5aFkzUnBkbVVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBjMTl6WVd4bFgyRmpkR2wyWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBjMTl6WVd4bFgyRmpkR2wyWlNCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBhV05yWlhScGJtY3VZMjl1ZEhKaFkzUXVWR2xqYTJWMGFXNW5MbWRsZEY5bGRtVnVkRjlwYm1adktDa2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwblpYUmZaWFpsYm5SZmFXNW1iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJM0NpQWdJQ0F2THlCelpXeG1MblJwWTJ0bGRGOXdjbWxqWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0owYVdOclpYUmZjSEpwWTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkR2xqYTJWMFgzQnlhV05sSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TWpnS0lDQWdJQzh2SUhObGJHWXViV0Y0WDNOMWNIQnNlU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSnRZWGhmYzNWd2NHeDVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xaGVGOXpkWEJ3YkhrZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z2MyVnNaaTV6YjJ4a1gyTnZkVzUwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbk52YkdSZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMyOXNaRjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UTXdDaUFnSUNBdkx5QnpaV3htTG1WMlpXNTBYMlJoZEdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWlhabGJuUmZaR0YwWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxkbVZ1ZEY5a1lYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNekVLSUNBZ0lDOHZJSE5sYkdZdWMyRnNaVjlsYm1SZlpHRjBaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnpZV3hsWDJWdVpGOWtZWFJsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmhiR1ZmWlc1a1gyUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakV6TWdvZ0lDQWdMeThnYzJWc1ppNTFibWx4ZFdWZlluVjVaWEp6TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblZ1YVhGMVpWOWlkWGxsY25NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkVzVwY1hWbFgySjFlV1Z5Y3lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCelpXeG1MbWx6WDNOaGJHVmZZV04wYVhabENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVhOZmMyRnNaVjloWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOZmMyRnNaVjloWTNScGRtVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXlOaTB4TXpRS0lDQWdJQzh2SUhKbGRIVnliaUFvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVc0NpQWdJQ0F2THlBZ0lDQWdjMlZzWmk1dFlYaGZjM1Z3Y0d4NUxBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZdWMyOXNaRjlqYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxtVjJaVzUwWDJSaGRHVXNDaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNXpZV3hsWDJWdVpGOWtZWFJsTEFvZ0lDQWdMeThnSUNBZ0lITmxiR1l1ZFc1cGNYVmxYMkoxZVdWeWN5d0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxtbHpYM05oYkdWZllXTjBhWFpsQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaeTVuWlhSZmIzSm5ZVzVwZW1WeUtDa2dMVDRnWW5sMFpYTTZDbWRsZEY5dmNtZGhibWw2WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXpPUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1YjNKbllXNXBlbVZ5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWliM0puWVc1cGVtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05eVoyRnVhWHBsY2lCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUNnUVZIM3gxRG1selgzTmhiR1ZmWVdOMGFYWmxBUUFLYzI5c1pGOWpiM1Z1ZEFwbGRtVnVkRjlrWVhSbENXOXlaMkZ1YVhwbGNnMTFibWx4ZFdWZlluVjVaWEp6REhScFkydGxkRjl3Y21salpRcHRZWGhmYzNWd2NHeDVEWE5oYkdWZlpXNWtYMlJoZEdVeEcwRUFPSUlIQk9qZGEvMEVjZTliMHdReitJaWRCSWk5MnlJRUNobkFTQVN0RUwreUJPWVoyU2MyR2dDT0J3QzBBSmtBZWdCaEFFd0FFZ0FDSWtNeEdSUkVNUmhFaUFJNEtFeFFzQ05ETVJrVVJERVlSSWdDQms4R0ZrOEdGazhHRms4R0ZrOEdGazhHRmlvaVR3aFVUd1pQQmxCUEJWQlBCRkJQQTFCUEFsQk1VQ2hNVUxBalF6RVpGRVF4R0VTSUFiWXFJazhDVkNoTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFHSUtpSlBBbFFvVEZDd0kwTXhHUlJFTVJoRU5ob0JGOEFjTmhvQ0Y0Z0JLU29pVHdKVUtFeFFzQ05ETVJrVVJERVlSREVXSXdsSk9CQWpFa1NJQUZFV0tFeFFzQ05ETVJrVVJERVlGRVEyR2dFWE5ob0NGellhQXhjMkdnUVhpQUFIRmloTVVMQWpRNG9FQVNjSGkveG5Kd2lML1djckltY25CSXYrWnljSmkvOW5Kd1V4QUdjcEkyY25CaUpuSTRtS0FRRWlLV1ZFUkNJclpVUWlKd2hsUkF4RU1nY2lKd2xsUkF4RU1nY2lKd1JsUkF4RWkvODRCeklLRWtTTC96Z0lJaWNIWlVRUFJDSXJaVVFqQ0N0TVp5SW5CbVZFSXdnbkJreG5zVElLaS84NEFESUtTYklzc2l0SnNpcE1zaW1BRkdsd1puTTZMeTlqWVcxd2RYTXRkR2xqYTJWMHNpZUFBMVJKV0xJbGdBeEZkbVZ1ZENCVWFXTnJaWFN5SmlLeUl5T3lJb0VEc2hBaXNnR3p0RHl4U2JJUkk3SVNUTElVZ1FTeUVDS3lBYk5KRmttOFNDcS9pWW9DQVRFQUlpY0ZaVVFTUkRJSElpY0VaVVNCZ0tNRkNBNUVpLzZMLzNBQVFRQVppd0FqRWtFQUVpTkVpLzhXU2I1RUlsc1VSQ01XdnlOTWlTSkMvK3VLQVFHTC94YStRQUFESWt5Sml3QWlXeU1TVElreEFDSW5CV1ZFRWtRaUtXVkVGQ2xNWnlJcFpVU0pJaWNIWlVRaUp3aGxSQ0lyWlVRaUp3UmxSQ0luQ1dWRUlpY0daVVFpS1dWRWlTSW5CV1ZFaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
