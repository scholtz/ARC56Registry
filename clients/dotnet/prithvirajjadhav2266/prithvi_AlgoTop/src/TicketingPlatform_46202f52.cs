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

namespace Arc56.Generated.prithvirajjadhav2266.prithvi_AlgoTop.TicketingPlatform_46202f52
{


    //
    // Main contract for decentralized campus ticketing
    //
    public class TicketingPlatformProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TicketingPlatformProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetEventDetailsReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetEventDetailsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetEventDetailsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is ulong vField7Value) { ret.Field7 = vField7Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetEventDetailsReturn);
                }
                public bool Equals(GetEventDetailsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetEventDetailsReturn left, GetEventDetailsReturn right)
                {
                    return EqualityComparer<GetEventDetailsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetEventDetailsReturn left, GetEventDetailsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Register a new club organization
        ///</summary>
        /// <param name="club_name">Name of the club </param>
        /// <param name="contact">Contact information (email/telegram) </param>
        public async Task<string> RegisterClub(string club_name, string contact, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 87, 169, 119 };
            var club_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); club_nameAbi.From(club_name);
            var contactAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contactAbi.From(contact);

            var result = await base.CallApp(new List<object> { abiHandle, club_nameAbi, contactAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterClub_Transactions(string club_name, string contact, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 87, 169, 119 };
            var club_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); club_nameAbi.From(club_name);
            var contactAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contactAbi.From(contact);

            return await base.MakeTransactionList(new List<object> { abiHandle, club_nameAbi, contactAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new ticketed event and mint ticket ASAs
        ///</summary>
        /// <param name="event_name">Name of the event </param>
        /// <param name="venue">Event location </param>
        /// <param name="event_date">Unix timestamp of event date </param>
        /// <param name="ticket_price">Price per ticket in microAlgos </param>
        /// <param name="ticket_count">Total number of tickets available </param>
        public async Task<ulong> CreateEvent(string event_name, string venue, ulong event_date, ulong ticket_price, ulong ticket_count, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 255, 64, 80 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var venueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); venueAbi.From(venue);
            var event_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_dateAbi.From(event_date);
            var ticket_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_priceAbi.From(ticket_price);
            var ticket_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_countAbi.From(ticket_count);

            var result = await base.CallApp(new List<object> { abiHandle, event_nameAbi, venueAbi, event_dateAbi, ticket_priceAbi, ticket_countAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateEvent_Transactions(string event_name, string venue, ulong event_date, ulong ticket_price, ulong ticket_count, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 255, 64, 80 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var venueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); venueAbi.From(venue);
            var event_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_dateAbi.From(event_date);
            var ticket_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_priceAbi.From(ticket_price);
            var ticket_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_countAbi.From(ticket_count);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_nameAbi, venueAbi, event_dateAbi, ticket_priceAbi, ticket_countAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Purchase a ticket for an event
        ///Student pays ALGO to club, receives ticket ASA
        ///</summary>
        /// <param name="event_id">ID of the event </param>
        /// <param name="payment">Payment transaction (must be grouped with this call) </param>
        public async Task<ulong> BuyTicket(PaymentTransaction payment, ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 142, 42, 168, 62 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            var result = await base.CallApp(new List<object> { abiHandle, event_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyTicket_Transactions(PaymentTransaction payment, ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 142, 42, 168, 62 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify if an attendee owns a ticket for an event (for check-in)
        ///</summary>
        /// <param name="event_id">ID of the event </param>
        /// <param name="attendee">Wallet address to check </param>
        public async Task<bool> VerifyTicket(Address attendee, ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { attendee });
            byte attendeeRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 141, 23, 34, 28 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);
            var attendeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); attendeeAbi.From(attendee);

            var result = await base.SimApp(new List<object> { abiHandle, event_idAbi, attendeeRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyTicket_Transactions(Address attendee, ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { attendee });
            byte attendeeRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 141, 23, 34, 28 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);
            var attendeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); attendeeAbi.From(attendee);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_idAbi, attendeeRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get detailed information about an event
        ///</summary>
        /// <param name="event_id">ID of the event </param>
        public async Task<Structs.GetEventDetailsReturn> GetEventDetails(ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 166, 12, 242 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            var result = await base.SimApp(new List<object> { abiHandle, event_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetEventDetailsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEventDetails_Transactions(ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 166, 12, 242 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the name of a registered club
        ///</summary>
        /// <param name="club_address">Wallet address of the club </param>
        public async Task<byte[]> GetClubName(byte[] club_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 220, 7, 229 };
            var club_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); club_addressAbi.From(club_address);

            var result = await base.SimApp(new List<object> { abiHandle, club_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetClubName_Transactions(byte[] club_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 220, 7, 229 };
            var club_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); club_addressAbi.From(club_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, club_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total number of events created
        ///</summary>
        public async Task<ulong> GetTotalEvents(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 145, 33, 255 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalEvents_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 145, 33, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if an address is a registered club
        ///</summary>
        /// <param name="club_address">Wallet address to check </param>
        public async Task<bool> IsClubRegistered(Address club_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { club_address });
            byte club_addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 188, 128, 32, 147 };
            var club_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); club_addressAbi.From(club_address);

            var result = await base.SimApp(new List<object> { abiHandle, club_addressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsClubRegistered_Transactions(Address club_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { club_address });
            byte club_addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 188, 128, 32, 147 };
            var club_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); club_addressAbi.From(club_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, club_addressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGlja2V0aW5nUGxhdGZvcm0iLCJkZXNjIjoiTWFpbiBjb250cmFjdCBmb3IgZGVjZW50cmFsaXplZCBjYW1wdXMgdGlja2V0aW5nIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldEV2ZW50RGV0YWlsc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDciLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InJlZ2lzdGVyX2NsdWIiLCJkZXNjIjoiUmVnaXN0ZXIgYSBuZXcgY2x1YiBvcmdhbml6YXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2x1Yl9uYW1lIiwiZGVzYyI6Ik5hbWUgb2YgdGhlIGNsdWIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRhY3QiLCJkZXNjIjoiQ29udGFjdCBpbmZvcm1hdGlvbiAoZW1haWwvdGVsZWdyYW0pIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MgbWVzc2FnZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9ldmVudCIsImRlc2MiOiJDcmVhdGUgYSBuZXcgdGlja2V0ZWQgZXZlbnQgYW5kIG1pbnQgdGlja2V0IEFTQXMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZlbnRfbmFtZSIsImRlc2MiOiJOYW1lIG9mIHRoZSBldmVudCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVudWUiLCJkZXNjIjoiRXZlbnQgbG9jYXRpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2ZW50X2RhdGUiLCJkZXNjIjoiVW5peCB0aW1lc3RhbXAgb2YgZXZlbnQgZGF0ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja2V0X3ByaWNlIiwiZGVzYyI6IlByaWNlIHBlciB0aWNrZXQgaW4gbWljcm9BbGdvcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja2V0X2NvdW50IiwiZGVzYyI6IlRvdGFsIG51bWJlciBvZiB0aWNrZXRzIGF2YWlsYWJsZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJVbmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGNyZWF0ZWQgZXZlbnQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlfdGlja2V0IiwiZGVzYyI6IlB1cmNoYXNlIGEgdGlja2V0IGZvciBhbiBldmVudFxuU3R1ZGVudCBwYXlzIEFMR08gdG8gY2x1YiwgcmVjZWl2ZXMgdGlja2V0IEFTQSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9pZCIsImRlc2MiOiJJRCBvZiB0aGUgZXZlbnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiUGF5bWVudCB0cmFuc2FjdGlvbiAobXVzdCBiZSBncm91cGVkIHdpdGggdGhpcyBjYWxsKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgQVNBIElEIG9mIHRoZSB0aWNrZXQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfdGlja2V0IiwiZGVzYyI6IlZlcmlmeSBpZiBhbiBhdHRlbmRlZSBvd25zIGEgdGlja2V0IGZvciBhbiBldmVudCAoZm9yIGNoZWNrLWluKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9pZCIsImRlc2MiOiJJRCBvZiB0aGUgZXZlbnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdHRlbmRlZSIsImRlc2MiOiJXYWxsZXQgYWRkcmVzcyB0byBjaGVjayIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiBhdHRlbmRlZSBvd25zIGEgdGlja2V0LCBGYWxzZSBvdGhlcndpc2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ldmVudF9kZXRhaWxzIiwiZGVzYyI6IkdldCBkZXRhaWxlZCBpbmZvcm1hdGlvbiBhYm91dCBhbiBldmVudCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9pZCIsImRlc2MiOiJJRCBvZiB0aGUgZXZlbnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbXSxieXRlW10sYnl0ZVtdLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0RXZlbnREZXRhaWxzUmV0dXJuIiwiZGVzYyI6IlR1cGxlIG9mIChjbHViX293bmVyLCBldmVudF9uYW1lLCB2ZW51ZSwgZGF0ZSwgcHJpY2UsIHRvdGFsLCBzb2xkLCBhc3NldF9pZCkifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jbHViX25hbWUiLCJkZXNjIjoiR2V0IHRoZSBuYW1lIG9mIGEgcmVnaXN0ZXJlZCBjbHViIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsdWJfYWRkcmVzcyIsImRlc2MiOiJXYWxsZXQgYWRkcmVzcyBvZiB0aGUgY2x1YiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJDbHViIG5hbWUgYXMgYnl0ZXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9ldmVudHMiLCJkZXNjIjoiR2V0IHRoZSB0b3RhbCBudW1iZXIgb2YgZXZlbnRzIGNyZWF0ZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVG90YWwgZXZlbnQgY291bnQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2NsdWJfcmVnaXN0ZXJlZCIsImRlc2MiOiJDaGVjayBpZiBhbiBhZGRyZXNzIGlzIGEgcmVnaXN0ZXJlZCBjbHViIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbHViX2FkZHJlc3MiLCJkZXNjIjoiV2FsbGV0IGFkZHJlc3MgdG8gY2hlY2siLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRydWUgaWYgcmVnaXN0ZXJlZCwgRmFsc2Ugb3RoZXJ3aXNlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzkzNV0sImVycm9yTWVzc2FnZSI6IkFkZHJlc3MgbGVuZ3RoIGlzIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQxXSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IGNyZWF0ZSBtb3JlIHRoYW4gMTAwMDAgdGlja2V0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MF0sImVycm9yTWVzc2FnZSI6IkNsdWIgYWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQxXSwiZXJyb3JNZXNzYWdlIjoiQ2x1YiBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyOF0sImVycm9yTWVzc2FnZSI6IkV2ZW50IG11c3QgYmUgaW4gZnV0dXJlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE1LDgyNSw4NjVdLCJlcnJvck1lc3NhZ2UiOiJFdmVudCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTNdLCJlcnJvck1lc3NhZ2UiOiJFdmVudCBzb2xkIG91dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2OV0sImVycm9yTWVzc2FnZSI6IkluY29ycmVjdCBwYXltZW50IGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNF0sImVycm9yTWVzc2FnZSI6Ik11c3QgaGF2ZSBhdCBsZWFzdCAxIHRpY2tldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMywxNTUsMTcyLDIwMiwzMTcsMzQzLDM3NCw0MTVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHJlZ2lzdGVyZWQgY2x1YnMgY2FuIGNyZWF0ZSBldmVudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjFdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gY2x1YiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3N10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTMxXSwiZXJyb3JNZXNzYWdlIjoiVGlja2V0IHByaWNlIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTZdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzYsMTU4LDE3NSwyMDUsMzIwLDM0NiwzNzcsNDE4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NSw1NTQsOTQ2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ldmVudF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaMUJzWVhSbWIzSnRMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKbGRtVnVkRjlqYjNWdWRHVnlJaUF3ZURZeklEQjROalUyTVNBd2VEWTFOak1nTUhnMk5UY3dJREI0TmpVM05DQXdlRFkxTnpNZ01IZzJOVFpsSURCNE5qVTNOaUF3ZURZMU5qUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5EQXROREVLSUNBZ0lDOHZJQ01nUTI5MWJuUmxjaUJtYjNJZ1oyVnVaWEpoZEdsdVp5QjFibWx4ZFdVZ1pYWmxiblFnU1VSekNpQWdJQ0F2THlCelpXeG1MbVYyWlc1MFgyTnZkVzUwWlhJZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltVjJaVzUwWDJOdmRXNTBaWElpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNZ29nSUNBZ0x5OGdZMnhoYzNNZ1ZHbGphMlYwYVc1blVHeGhkR1p2Y20wb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdKak5UZGhPVGMzSURCNFl6Qm1aalF3TlRBZ01IZzRaVEpoWVRnelpTQXdlRGhrTVRjeU1qRmpJREI0T0RkaE5qQmpaaklnTUhneU1tUmpNRGRsTlNBd2VHUmxPVEV5TVdabUlEQjRZbU00TURJd09UTWdMeThnYldWMGFHOWtJQ0p5WldkcGMzUmxjbDlqYkhWaUtITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pqY21WaGRHVmZaWFpsYm5Rb2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1KMWVWOTBhV05yWlhRb2RXbHVkRFkwTEhCaGVTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luWmxjbWxtZVY5MGFXTnJaWFFvZFdsdWREWTBMR0ZqWTI5MWJuUXBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBYMlYyWlc1MFgyUmxkR0ZwYkhNb2RXbHVkRFkwS1NoaWVYUmxXMTBzWW5sMFpWdGRMR0o1ZEdWYlhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDJOc2RXSmZibUZ0WlNoaWVYUmxXMTBwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0puWlhSZmRHOTBZV3hmWlhabGJuUnpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWx6WDJOc2RXSmZjbVZuYVhOMFpYSmxaQ2hoWTJOdmRXNTBLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNKbFoybHpkR1Z5WDJOc2RXSmZjbTkxZEdWQU5TQnRZV2x1WDJOeVpXRjBaVjlsZG1WdWRGOXliM1YwWlVBMklHMWhhVzVmWW5WNVgzUnBZMnRsZEY5eWIzVjBaVUEzSUcxaGFXNWZkbVZ5YVdaNVgzUnBZMnRsZEY5eWIzVjBaVUE0SUcxaGFXNWZaMlYwWDJWMlpXNTBYMlJsZEdGcGJITmZjbTkxZEdWQU9TQnRZV2x1WDJkbGRGOWpiSFZpWDI1aGJXVmZjbTkxZEdWQU1UQWdiV0ZwYmw5blpYUmZkRzkwWVd4ZlpYWmxiblJ6WDNKdmRYUmxRREV4SUcxaGFXNWZhWE5mWTJ4MVlsOXlaV2RwYzNSbGNtVmtYM0p2ZFhSbFFERXlDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QmpiR0Z6Y3lCVWFXTnJaWFJwYm1kUWJHRjBabTl5YlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjMTlqYkhWaVgzSmxaMmx6ZEdWeVpXUmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakkxT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl5Q2lBZ0lDQXZMeUJqYkdGemN5QlVhV05yWlhScGJtZFFiR0YwWm05eWJTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qVTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2x6WDJOc2RXSmZjbVZuYVhOMFpYSmxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmZEc5MFlXeGZaWFpsYm5SelgzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lORGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmRHOTBZV3hmWlhabGJuUnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjlqYkhWaVgyNWhiV1ZmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJek1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCamJHRnpjeUJVYVdOclpYUnBibWRRYkdGMFptOXliU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qTXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5amJIVmlYMjVoYldVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5bGRtVnVkRjlrWlhSaGFXeHpYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl3TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl5Q2lBZ0lDQXZMeUJqYkdGemN5QlVhV05yWlhScGJtZFFiR0YwWm05eWJTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdaMlYwWDJWMlpXNTBYMlJsZEdGcGJITUtJQ0FnSUdScFp5QTNDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURjS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTndvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUTJJQzh2SURRMkNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBNENpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRtVnlhV1o1WDNScFkydGxkRjl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TnprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnWTJ4aGMzTWdWR2xqYTJWMGFXNW5VR3hoZEdadmNtMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTNPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUIyWlhKcFpubGZkR2xqYTJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKMWVWOTBhV05yWlhSZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1USTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnWTJ4aGMzTWdWR2xqYTJWMGFXNW5VR3hoZEdadmNtMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJpZFhsZmRHbGphMlYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOWxkbVZ1ZEY5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNaklLSUNBZ0lDOHZJR05zWVhOeklGUnBZMnRsZEdsdVoxQnNZWFJtYjNKdEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWZlpYWmxiblFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjbVZuYVhOMFpYSmZZMngxWWw5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNaklLSUNBZ0lDOHZJR05zWVhOeklGUnBZMnRsZEdsdVoxQnNZWFJtYjNKdEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnlaV2RwYzNSbGNsOWpiSFZpQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QmpiR0Z6Y3lCVWFXTnJaWFJwYm1kUWJHRjBabTl5YlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaMUJzWVhSbWIzSnRMbkpsWjJsemRHVnlYMk5zZFdJb1kyeDFZbDl1WVcxbE9pQmllWFJsY3l3Z1kyOXVkR0ZqZERvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dweVpXZHBjM1JsY2w5amJIVmlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8wTXkwME5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnY21WbmFYTjBaWEpmWTJ4MVlpaHpaV3htTENCamJIVmlYMjVoYldVNklGTjBjbWx1Wnl3Z1kyOXVkR0ZqZERvZ1UzUnlhVzVuS1NBdFBpQlRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRVdE5UWUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2FXWWdZMngxWWlCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUdWNGFYTjBhVzVuWDI1aGJXVXNJR1Y0YVhOMGN5QTlJSE5sYkdZdVkyeDFZbDl1WVcxbGN5NXRZWGxpWlNoVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQmxlR2x6ZEhNc0lDSkRiSFZpSUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkNJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiSFZpSUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU9TMDJNQW9nSUNBZ0x5OGdJeUJUZEc5eVpTQmpiSFZpSUc1aGJXVWdLR052Ym5SaFkzUWdhVzVtYnlCallXNGdZbVVnYzNSdmNtVmtJRzltWmkxamFHRnBiaUJ2Y2lCcGJpQmhJSE5sY0dGeVlYUmxJR0p2ZUNCcFppQnVaV1ZrWldRcENpQWdJQ0F2THlCelpXeG1MbU5zZFdKZmJtRnRaWE5iVkhodUxuTmxibVJsY2wwZ1BTQmpiSFZpWDI1aGJXVXVZbmwwWlhNS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMk13b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSkRiSFZpSUhKbFoybHpkR1Z5WldRZ2MzVmpZMlZ6YzJaMWJHeDVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRMngxWWlCeVpXZHBjM1JsY21Wa0lITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBhV05yWlhScGJtY3VZMjl1ZEhKaFkzUXVWR2xqYTJWMGFXNW5VR3hoZEdadmNtMHVZM0psWVhSbFgyVjJaVzUwS0dWMlpXNTBYMjVoYldVNklHSjVkR1Z6TENCMlpXNTFaVG9nWW5sMFpYTXNJR1YyWlc1MFgyUmhkR1U2SUhWcGJuUTJOQ3dnZEdsamEyVjBYM0J5YVdObE9pQjFhVzUwTmpRc0lIUnBZMnRsZEY5amIzVnVkRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q21OeVpXRjBaVjlsZG1WdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOalF0TnpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOWxkbVZ1ZENnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lHVjJaVzUwWDI1aGJXVTZJRk4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IyWlc1MVpUb2dVM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR1YyWlc1MFgyUmhkR1U2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCMGFXTnJaWFJmY0hKcFkyVTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0IwYVdOclpYUmZZMjkxYm5RNklGVkpiblEyTkN3S0lDQWdJQzh2SUNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdOU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pnMkxUZzNDaUFnSUNBdkx5QWpJRlpsY21sbWVTQmpZV3hzWlhJZ2FYTWdZU0J5WldkcGMzUmxjbVZrSUdOc2RXSUtJQ0FnSUM4dklHTnNkV0pmYm1GdFpWOTJZV3dzSUdOc2RXSmZaWGhwYzNSeklEMGdjMlZzWmk1amJIVmlYMjVoYldWekxtMWhlV0psS0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5qTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCaGMzTmxjblFnWTJ4MVlsOWxlR2x6ZEhNc0lDSlBibXg1SUhKbFoybHpkR1Z5WldRZ1kyeDFZbk1nWTJGdUlHTnlaV0YwWlNCbGRtVnVkSE1pQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCeVpXZHBjM1JsY21Wa0lHTnNkV0p6SUdOaGJpQmpjbVZoZEdVZ1pYWmxiblJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2prd0xUa3hDaUFnSUNBdkx5QWpJRlpoYkdsa1lYUmxJR2x1Y0hWMGN3b2dJQ0FnTHk4Z1lYTnpaWEowSUdWMlpXNTBYMlJoZEdVZ1BpQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0N3Z0lrVjJaVzUwSUcxMWMzUWdZbVVnYVc0Z1puVjBkWEpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1JYWmxiblFnYlhWemRDQmlaU0JwYmlCbWRYUjFjbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T1RJS0lDQWdJQzh2SUdGemMyVnlkQ0IwYVdOclpYUmZjSEpwWTJVZ1BpQXdMQ0FpVkdsamEyVjBJSEJ5YVdObElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVhV05yWlhRZ2NISnBZMlVnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVNd29nSUNBZ0x5OGdZWE56WlhKMElIUnBZMnRsZEY5amIzVnVkQ0ErSURBc0lDSk5kWE4wSUdoaGRtVWdZWFFnYkdWaGMzUWdNU0IwYVdOclpYUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJR2hoZG1VZ1lYUWdiR1ZoYzNRZ01TQjBhV05yWlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk9UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGFXTnJaWFJmWTI5MWJuUWdQRDBnTVRBd01EQXNJQ0pEWVc1dWIzUWdZM0psWVhSbElHMXZjbVVnZEdoaGJpQXhNREF3TUNCMGFXTnJaWFJ6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERXdNREF3SUM4dklERXdNREF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFTmhibTV2ZENCamNtVmhkR1VnYlc5eVpTQjBhR0Z1SURFd01EQXdJSFJwWTJ0bGRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZPVFl0T1RjS0lDQWdJQzh2SUNNZ1IyVnVaWEpoZEdVZ2RXNXBjWFZsSUdWMlpXNTBJRWxFQ2lBZ0lDQXZMeUJ6Wld4bUxtVjJaVzUwWDJOdmRXNTBaWElnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWlhabGJuUmZZMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsZG1WdWRGOWpiM1Z1ZEdWeUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltVjJaVzUwWDJOdmRXNTBaWElpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z1pYWmxiblJmYVdRZ1BTQnpaV3htTG1WMlpXNTBYMk52ZFc1MFpYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbGRtVnVkRjlqYjNWdWRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WMlpXNTBYMk52ZFc1MFpYSWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdNQzB4TVRNS0lDQWdJQzh2SUNNZ1EzSmxZWFJsSUhScFkydGxkQ0JCVTBFZ0tFRnNaMjl5WVc1a0lGTjBZVzVrWVhKa0lFRnpjMlYwS1FvZ0lDQWdMeThnZEdsamEyVjBYMkZ6WVNBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OWRHbGphMlYwWDJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRBc0lDQWpJRlJwWTJ0bGRITWdZWEpsSUc1dmJpMWthWFpwYzJsaWJHVUtJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlVM1J5YVc1bktDSlVTMVFpS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQV1YyWlc1MFgyNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RYSnNQVk4wY21sdVp5Z2lhSFIwY0hNNkx5OWpZVzF3ZFhNdGRHbDRMbUZzWjI4aUtTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3hOVEF3TUNrc0lDQWpJRWx1WTNKbFlYTmxaQ0JtWldVZ1ptOXlJR2x1Ym1WeUlFRlRRU0JqY21WaGRHbHZiaUIwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TURnS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd09TMHhNVEVLSUNBZ0lDOHZJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklHWnlaV1Y2WlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnWTJ4aGQySmhZMnM5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHUjFjRzRnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVOc1lYZGlZV05yQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUm5KbFpYcGxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QjFjbXc5VTNSeWFXNW5LQ0pvZEhSd2N6b3ZMMk5oYlhCMWN5MTBhWGd1WVd4bmJ5SXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklDSm9kSFJ3Y3pvdkwyTmhiWEIxY3kxMGFYZ3VZV3huYnlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVlVrd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMUNpQWdJQ0F2THlCMWJtbDBYMjVoYldVOVUzUnlhVzVuS0NKVVMxUWlLU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QWlWRXRVSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd05Bb2dJQ0FnTHk4Z1pHVm1ZWFZzZEY5bWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxabUYxYkhSR2NtOTZaVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCa1pXTnBiV0ZzY3owd0xDQWdJeUJVYVdOclpYUnpJR0Z5WlNCdWIyNHRaR2wyYVhOcFlteGxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxZMmx0WVd4ekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TURBdE1UQXhDaUFnSUNBdkx5QWpJRU55WldGMFpTQjBhV05yWlhRZ1FWTkJJQ2hCYkdkdmNtRnVaQ0JUZEdGdVpHRnlaQ0JCYzNObGRDa0tJQ0FnSUM4dklIUnBZMnRsZEY5aGMyRWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtERTFNREF3S1N3Z0lDTWdTVzVqY21WaGMyVmtJR1psWlNCbWIzSWdhVzV1WlhJZ1FWTkJJR055WldGMGFXOXVJSFJ5WVc1ellXTjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElERTFNREF3SUM4dklERTFNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1EQXRNVEV6Q2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0IwYVdOclpYUWdRVk5CSUNoQmJHZHZjbUZ1WkNCVGRHRnVaR0Z5WkNCQmMzTmxkQ2tLSUNBZ0lDOHZJSFJwWTJ0bGRGOWhjMkVnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFhScFkydGxkRjlqYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejB3TENBZ0l5QlVhV05yWlhSeklHRnlaU0J1YjI0dFpHbDJhWE5wWW14bENpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBWTjBjbWx1WnlnaVZFdFVJaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMWxkbVZ1ZEY5dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEMVRkSEpwYm1jb0ltaDBkSEJ6T2k4dlkyRnRjSFZ6TFhScGVDNWhiR2R2SWlrc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01UVXdNREFwTENBZ0l5QkpibU55WldGelpXUWdabVZsSUdadmNpQnBibTVsY2lCQlUwRWdZM0psWVhScGIyNGdkSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXhOeTB4TVRnS0lDQWdJQzh2SUNNZ1UzUnZjbVVnWlhabGJuUWdhVzVtYjNKdFlYUnBiMjRnYVc0Z2MyVndZWEpoZEdVZ1ltOTRaWE1LSUNBZ0lDOHZJSE5sYkdZdVpYWmxiblJmWTJ4MVluTmJaWFpsYm5SZmFXUmRJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnMk5UWXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeE9Rb2dJQ0FnTHk4Z2MyVnNaaTVsZG1WdWRGOXVZVzFsYzF0bGRtVnVkRjlwWkYwZ1BTQmxkbVZ1ZEY5dVlXMWxMbUo1ZEdWekNpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE5qVTJaUW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNakFLSUNBZ0lDOHZJSE5sYkdZdVpYWmxiblJmZG1WdWRXVnpXMlYyWlc1MFgybGtYU0E5SUhabGJuVmxMbUo1ZEdWekNpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE5qVTNOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNakVLSUNBZ0lDOHZJSE5sYkdZdVpYWmxiblJmWkdGMFpYTmJaWFpsYm5SZmFXUmRJRDBnWlhabGJuUmZaR0YwWlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnMk5UWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1USXlDaUFnSUNBdkx5QnpaV3htTG1WMlpXNTBYM0J5YVdObGMxdGxkbVZ1ZEY5cFpGMGdQU0IwYVdOclpYUmZjSEpwWTJVS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnMk5UY3dDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QnpaV3htTG1WMlpXNTBYM1J2ZEdGc1cyVjJaVzUwWDJsa1hTQTlJSFJwWTJ0bGRGOWpiM1Z1ZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURZMU56UUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklITmxiR1l1WlhabGJuUmZjMjlzWkZ0bGRtVnVkRjlwWkYwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzJOVGN6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJSE5sYkdZdVpYWmxiblJmWVhOelpYUnpXMlYyWlc1MFgybGtYU0E5SUhScFkydGxkRjloYzNObGRGOXBaQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRFkxTmpFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUhKbGRIVnliaUJsZG1WdWRGOXBaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnBZMnRsZEdsdVp5NWpiMjUwY21GamRDNVVhV05yWlhScGJtZFFiR0YwWm05eWJTNWlkWGxmZEdsamEyVjBLR1YyWlc1MFgybGtPaUIxYVc1ME5qUXNJSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BpZFhsZmRHbGphMlYwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1qa3RNVE0wQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQmlkWGxmZEdsamEyVjBLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnWlhabGJuUmZhV1E2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCd1lYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaXdLSUNBZ0lDOHZJQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakUwTmkweE5EY0tJQ0FnSUM4dklDTWdWbVZ5YVdaNUlHVjJaVzUwSUdWNGFYTjBjd29nSUNBZ0x5OGdZMngxWWw5dmQyNWxjaXdnWlhocGMzUnpJRDBnYzJWc1ppNWxkbVZ1ZEY5amJIVmljeTV0WVhsaVpTaGxkbVZ1ZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWTFOak1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlSWFpsYm5RZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWVhOelpYSjBJQzh2SUVWMlpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TlRBdE1UVXhDaUFnSUNBdkx5QWpJRWRsZENCbGRtVnVkQ0JrWlhSaGFXeHpDaUFnSUNBdkx5QjBhV05yWlhSZmNISnBZMlVzSUhCeWFXTmxYMlY0YVhOMGN5QTlJSE5sYkdZdVpYWmxiblJmY0hKcFkyVnpMbTFoZVdKbEtHVjJaVzUwWDJsa0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEWTFOekFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJSFJ2ZEdGc1gzUnBZMnRsZEhNc0lIUnZkR0ZzWDJWNGFYTjBjeUE5SUhObGJHWXVaWFpsYm5SZmRHOTBZV3d1YldGNVltVW9aWFpsYm5SZmFXUXBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjROalUzTkFvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakUxTXdvZ0lDQWdMeThnYzI5c1pGOTBhV05yWlhSekxDQnpiMnhrWDJWNGFYTjBjeUE5SUhObGJHWXVaWFpsYm5SZmMyOXNaQzV0WVhsaVpTaGxkbVZ1ZEY5cFpDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzJOVGN6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVFFLSUNBZ0lDOHZJSFJwWTJ0bGRGOWhjM05sZEY5cFpDd2dZWE56WlhSZlpYaHBjM1J6SUQwZ2MyVnNaaTVsZG1WdWRGOWhjM05sZEhNdWJXRjVZbVVvWlhabGJuUmZhV1FwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TmpVMk1Rb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVFl0TVRVM0NpQWdJQ0F2THlBaklFTm9aV05ySUhScFkydGxkSE1nWVhaaGFXeGhZbXhsQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMjlzWkY5MGFXTnJaWFJ6SUR3Z2RHOTBZV3hmZEdsamEyVjBjeXdnSWtWMlpXNTBJSE52YkdRZ2IzVjBJZ29nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJRVYyWlc1MElITnZiR1FnYjNWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTFPUzB4TmpBS0lDQWdJQzh2SUNNZ1ZtVnlhV1o1SUhCaGVXMWxiblFnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5SUdOc2RXSmZiM2R1WlhJc0lDSlFZWGx0Wlc1MElHMTFjM1FnWjI4Z2RHOGdZMngxWWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdaMjhnZEc4Z1kyeDFZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TmpFS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQTlQU0IwYVdOclpYUmZjSEpwWTJVc0lDSkpibU52Y25KbFkzUWdjR0Y1YldWdWRDQmhiVzkxYm5RaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdVkyOXljbVZqZENCd1lYbHRaVzUwSUdGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TmpJS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbk5sYm1SbGNpQTlQU0JVZUc0dWMyVnVaR1Z5TENBaVVHRjViV1Z1ZENCelpXNWtaWElnYldsemJXRjBZMmdpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOalF0TVRjeUNpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlIUnBZMnRsZENCQlUwRWdkRzhnWW5WNVpYSUtJQ0FnSUM4dklDTWdUbTkwWlRvZ1FuVjVaWElnYlhWemRDQm9ZWFpsSUc5d2RHVmtMV2x1SUhSdklIUm9aU0JCVTBFZ1ptbHljM1FLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBYUnBZMnRsZEY5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQweExBb2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTWpBd01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJPQW9nSUNBZ0x5OGdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UY3dDaUFnSUNBdkx5QnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TmprS0lDQWdJQzh2SUdGemMyVjBYMkZ0YjNWdWREMHhMQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOalF0TVRZMkNpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlIUnBZMnRsZENCQlUwRWdkRzhnWW5WNVpYSUtJQ0FnSUM4dklDTWdUbTkwWlRvZ1FuVjVaWElnYlhWemRDQm9ZWFpsSUc5d2RHVmtMV2x1SUhSdklIUm9aU0JCVTBFZ1ptbHljM1FLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE56RUtJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NakF3TUNrc0NpQWdJQ0J3ZFhOb2FXNTBJREl3TURBZ0x5OGdNakF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UWTBMVEUzTWdvZ0lDQWdMeThnSXlCVWNtRnVjMlpsY2lCMGFXTnJaWFFnUVZOQklIUnZJR0oxZVdWeUNpQWdJQ0F2THlBaklFNXZkR1U2SUVKMWVXVnlJRzExYzNRZ2FHRjJaU0J2Y0hSbFpDMXBiaUIwYnlCMGFHVWdRVk5CSUdacGNuTjBDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxMGFXTnJaWFJmWVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREl3TURBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UYzBMVEUzTlFvZ0lDQWdMeThnSXlCVmNHUmhkR1VnYzI5c1pDQjBhV05yWlhSeklHTnZkVzUwWlhJS0lDQWdJQzh2SUhObGJHWXVaWFpsYm5SZmMyOXNaRnRsZG1WdWRGOXBaRjBnUFNCemIyeGtYM1JwWTJ0bGRITWdLeUJWU1c1ME5qUW9NU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UYzNDaUFnSUNBdkx5QnlaWFIxY200Z2RHbGphMlYwWDJGemMyVjBYMmxrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaMUJzWVhSbWIzSnRMblpsY21sbWVWOTBhV05yWlhRb1pYWmxiblJmYVdRNklIVnBiblEyTkN3Z1lYUjBaVzVrWldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RtVnlhV1o1WDNScFkydGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRjNUxURTROQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JSFpsY21sbWVWOTBhV05yWlhRb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQmxkbVZ1ZEY5cFpEb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR0YwZEdWdVpHVmxPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdLU0F0UGlCQ2IyOXNPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTVOUzB4T1RZS0lDQWdJQzh2SUNNZ1IyVjBJR1YyWlc1MElIUnBZMnRsZENCaGMzTmxkQ0JKUkFvZ0lDQWdMeThnZEdsamEyVjBYMkZ6YzJWMFgybGtMQ0JsZUdsemRITWdQU0J6Wld4bUxtVjJaVzUwWDJGemMyVjBjeTV0WVhsaVpTaGxkbVZ1ZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWTFOakVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNc0lDSkZkbVZ1ZENCdWIzUWdabTkxYm1RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoYzNObGNuUWdMeThnUlhabGJuUWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakU1T1MweU1EQUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2FXWWdZWFIwWlc1a1pXVWdhR0Z6SUdKaGJHRnVZMlVnYjJZZ2RHbGphMlYwSUVGVFFRb2dJQ0FnTHk4Z1lYTnpaWFJmWW1Gc1lXNWpaU3dnWW1Gc1lXNWpaVjlsZUdsemRITWdQU0J2Y0M1QmMzTmxkRWh2YkdScGJtZEhaWFF1WVhOelpYUmZZbUZzWVc1alpTaGhkSFJsYm1SbFpTd2dkR2xqYTJWMFgyRnpjMlYwWDJsa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZDJGd0NpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qQXlMVEl3TXdvZ0lDQWdMeThnSXlCU1pYUjFjbTRnVkhKMVpTQnBaaUIwYUdVZ1lXTmpiM1Z1ZENCb1lYTWdiM0IwWldRZ2FXNGdZVzVrSUdoaGN5QmhkQ0JzWldGemRDQXhJSFJwWTJ0bGRBb2dJQ0FnTHk4Z2NtVjBkWEp1SUVKdmIyd29ZbUZzWVc1alpWOWxlR2x6ZEhNZ1lXNWtJR0Z6YzJWMFgySmhiR0Z1WTJVZ1BpQXdLUW9nSUNBZ1lub2dkbVZ5YVdaNVgzUnBZMnRsZEY5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpZWlCMlpYSnBabmxmZEdsamEyVjBYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ25abGNtbG1lVjkwYVdOclpYUmZZbTl2YkY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1ESXRNakF6Q2lBZ0lDQXZMeUFqSUZKbGRIVnliaUJVY25WbElHbG1JSFJvWlNCaFkyTnZkVzUwSUdoaGN5QnZjSFJsWkNCcGJpQmhibVFnYUdGeklHRjBJR3hsWVhOMElERWdkR2xqYTJWMENpQWdJQ0F2THlCeVpYUjFjbTRnUW05dmJDaGlZV3hoYm1ObFgyVjRhWE4wY3lCaGJtUWdZWE56WlhSZlltRnNZVzVqWlNBK0lEQXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDblpsY21sbWVWOTBhV05yWlhSZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2RtVnlhV1o1WDNScFkydGxkRjlpYjI5c1gyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaMUJzWVhSbWIzSnRMbWRsZEY5bGRtVnVkRjlrWlhSaGFXeHpLR1YyWlc1MFgybGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN5d2dZbmwwWlhNc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BuWlhSZlpYWmxiblJmWkdWMFlXbHNjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMUxUSXdPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5bGRtVnVkRjlrWlhSaGFXeHpLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnWlhabGJuUmZhV1E2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z2RIVndiR1ZiUW5sMFpYTXNJRUo1ZEdWekxDQkNlWFJsY3l3Z1ZVbHVkRFkwTENCVlNXNTBOalFzSUZWSmJuUTJOQ3dnVlVsdWREWTBMQ0JWU1c1ME5qUmRPZ29nSUNBZ2NISnZkRzhnTVNBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXhPUW9nSUNBZ0x5OGdZMngxWWw5dmQyNWxjaXdnWlhocGMzUnpJRDBnYzJWc1ppNWxkbVZ1ZEY5amJIVmljeTV0WVhsaVpTaGxkbVZ1ZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWTFOak1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNakl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlSWFpsYm5RZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWVhOelpYSjBJQzh2SUVWMlpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TWpJS0lDQWdJQzh2SUdWMlpXNTBYMjVoYldVc0lHNWhiV1ZmWlhocGMzUnpJRDBnYzJWc1ppNWxkbVZ1ZEY5dVlXMWxjeTV0WVhsaVpTaGxkbVZ1ZEY5cFpDa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzJOVFpsQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNakl6Q2lBZ0lDQXZMeUIyWlc1MVpTd2dkbVZ1ZFdWZlpYaHBjM1J6SUQwZ2MyVnNaaTVsZG1WdWRGOTJaVzUxWlhNdWJXRjVZbVVvWlhabGJuUmZhV1FwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJREI0TmpVM05nb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU5Bb2dJQ0FnTHk4Z1pHRjBaU3dnWkdGMFpWOWxlR2x6ZEhNZ1BTQnpaV3htTG1WMlpXNTBYMlJoZEdWekxtMWhlV0psS0dWMlpXNTBYMmxrS1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnMk5UWTBDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qSTFDaUFnSUNBdkx5QndjbWxqWlN3Z2NISnBZMlZmWlhocGMzUnpJRDBnYzJWc1ppNWxkbVZ1ZEY5d2NtbGpaWE11YldGNVltVW9aWFpsYm5SZmFXUXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROalUzTUFvZ0lDQWdaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl5TmdvZ0lDQWdMeThnZEc5MFlXd3NJSFJ2ZEdGc1gyVjRhWE4wY3lBOUlITmxiR1l1WlhabGJuUmZkRzkwWVd3dWJXRjVZbVVvWlhabGJuUmZhV1FwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TmpVM05Bb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU53b2dJQ0FnTHk4Z2MyOXNaQ3dnYzI5c1pGOWxlR2x6ZEhNZ1BTQnpaV3htTG1WMlpXNTBYM052YkdRdWJXRjVZbVVvWlhabGJuUmZhV1FwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TmpVM013b2dJQ0FnWkdsbklEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU9Bb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRc0lHRnpjMlYwWDJWNGFYTjBjeUE5SUhObGJHWXVaWFpsYm5SZllYTnpaWFJ6TG0xaGVXSmxLR1YyWlc1MFgybGtLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRFkxTmpFS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qTXdDaUFnSUNBdkx5QnlaWFIxY200Z1kyeDFZbDl2ZDI1bGNpNWllWFJsY3l3Z1pYWmxiblJmYm1GdFpTd2dkbVZ1ZFdVc0lHUmhkR1VzSUhCeWFXTmxMQ0IwYjNSaGJDd2djMjlzWkN3Z1lYTnpaWFJmYVdRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOTJaWElnTndvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJwWTJ0bGRHbHVaeTVqYjI1MGNtRmpkQzVVYVdOclpYUnBibWRRYkdGMFptOXliUzVuWlhSZlkyeDFZbDl1WVcxbEtHTnNkV0pmWVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSZlkyeDFZbDl1WVcxbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNekl0TWpNekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYMk5zZFdKZmJtRnRaU2h6Wld4bUxDQmpiSFZpWDJGa1pISmxjM002SUVKNWRHVnpLU0F0UGlCQ2VYUmxjem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lORE10TWpRMENpQWdJQ0F2THlBaklFTnZiblpsY25RZ1FubDBaWE1nZEc4Z1FXTmpiM1Z1ZENCbWIzSWdRbTk0VFdGd0lHeHZiMnQxY0FvZ0lDQWdMeThnWTJ4MVlsOWhZMk52ZFc1MElEMGdRV05qYjNWdWRDaGpiSFZpWDJGa1pISmxjM01wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHeGxibWQwYUNCcGN5QXpNaUJpZVhSbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lORFVLSUNBZ0lDOHZJR05zZFdKZmJtRnRaU3dnWlhocGMzUnpJRDBnYzJWc1ppNWpiSFZpWDI1aGJXVnpMbTFoZVdKbEtHTnNkV0pmWVdOamIzVnVkQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNalEyQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlRMngxWWlCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiSFZpSUc1dmRDQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakkwTndvZ0lDQWdMeThnY21WMGRYSnVJR05zZFdKZmJtRnRaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnBZMnRsZEdsdVp5NWpiMjUwY21GamRDNVVhV05yWlhScGJtZFFiR0YwWm05eWJTNW5aWFJmZEc5MFlXeGZaWFpsYm5SektDa2dMVDRnZFdsdWREWTBPZ3BuWlhSZmRHOTBZV3hmWlhabGJuUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TlRjS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtVjJaVzUwWDJOdmRXNTBaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmxkbVZ1ZEY5amIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVjJaVzUwWDJOdmRXNTBaWElnWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHbGphMlYwYVc1bkxtTnZiblJ5WVdOMExsUnBZMnRsZEdsdVoxQnNZWFJtYjNKdExtbHpYMk5zZFdKZmNtVm5hWE4wWlhKbFpDaGpiSFZpWDJGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYVhOZlkyeDFZbDl5WldkcGMzUmxjbVZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU5Ua3RNall3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnYVhOZlkyeDFZbDl5WldkcGMzUmxjbVZrS0hObGJHWXNJR05zZFdKZllXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrZ0xUNGdRbTl2YkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TnpBS0lDQWdJQzh2SUdOc2RXSmZibUZ0WlY5MllXd3NJR1Y0YVhOMGN5QTlJSE5sYkdZdVkyeDFZbDl1WVcxbGN5NXRZWGxpWlNoamJIVmlYMkZrWkhKbGMzTXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROak1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNamN4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRbTl2YkNobGVHbHpkSE1wQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUFtQ3dRVkgzeDFEV1YyWlc1MFgyTnZkVzUwWlhJQll3SmxZUUpsWXdKbGNBSmxkQUpsY3dKbGJnSmxkZ0psWkRFWVFBQURLU05uTVJ0QkFYK0NDQVM4VjZsM0JNRC9RRkFFamlxb1BnU05GeUljQkllbURQSUVJdHdINVFUZWtTSC9CTHlBSUpNMkdnQ09DQUVjQVBNQTFBQzZBRWNBS1FBWUFBSWpRekVaRkVReEdFUTJHZ0VYd0J5SUF5SW9URkN3SWtNeEdSUkVNUmhFaUFNTkZpaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQ0lBdVZKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRVhpQUtBU3djVkZsY0dBazhJVUVzSEZSWlhCZ0pQQ0ZCTEJ4VVdWd1lDVHdoUVR3Y1dUd2NXVHdjV1R3Y1dUd2NXU3djVmdTNElTUlpYQmdLQUFnQXVURkJMQ0JWUEFnZ1dWd1lDVUU4RlVFOEVVRThEVUU4Q1VFeFFUd05RVHdKUVRGQW9URkN3SWtNeEdSUkVNUmhFTmhvQkZ6WWFBaGZBSElnQjNpaE1VTEFpUXpFWkZFUXhHRVEyR2dFWE1SWWlDVWs0RUNJU1JJZ0JVeFlvVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9ERnpZYUJCYzJHZ1VYaUFCckZpaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdDSUFCbEpGUlpYQmdKTVVDaE1VTEFpUXpFWlFQNjdNUmdVUkNKRGlnSUJLakVBVUw1RkFSUkVLakVBVUVtOFNJdit2NEFjUTJ4MVlpQnlaV2RwYzNSbGNtVmtJSE4xWTJObGMzTm1kV3hzZVltS0JRRXFNUUJRdmtVQlJJdjlNZ2NOUkl2K1JJdi9SSXYvZ1pCT0RrUWpLV1ZFSWdncFRHY2pLV1ZFc1RJS1J3T3lMTElyc2lxeUtZQVhhSFIwY0hNNkx5OWpZVzF3ZFhNdGRHbDRMbUZzWjIreUo0djdzaWFBQTFSTFZMSWxJN0lrSTdJamkvK3lJb0VEc2hDQm1IV3lBYk8wUEVzQkZpY0VTd0ZRTVFDL0p3aExBVkJKdkVpTCs3OG5DVXNCVUVtOFNJdjh2eWNLU3dGUWkvMFd2eWNGU3dGUWkvNFd2eWNHU3dGUWkvOFd2eWNIU3dGUUl4YS9LMHhRVEJhL2lZb0NBWXYrRmljRVN3RlF2a1FuQlVzQ1VMNUlGeWNHU3dOUXZrZ1hKd2RMQkZCSnZrZ1hLMDhHVUw1SUYwc0JUd1FNUkl2L09BZFBCUkpFaS84NENFOEVFa1NML3pnQU1RQVNSTEV4QURJS3NnQWlzaEt5RkVteUVZRUVzaENCMEEreUFiTk1JZ2dXVHdKTXY0bUtBZ0dML2hZclRGQytUQmRNUkl2L1RIQUFRUUFQaXdCQkFBb2lnQUVBSTA4Q1ZFeUpJMEwvODRvQkNJdi9GaWNFU3dGUXZrUW5DRXNDVUw1SVRDY0pTd05RdmtoTUp3cExCRkMrU0JjbkJVc0ZVTDVJRnljR1N3WlF2a2dYSndkTEIxQytTQmNyVHdoUXZrZ1hUd1ZPQjRtS0FRR0wveFdCSUJKRUtvdi9VTDVFaVNNcFpVU0ppZ0VCS292L1VMNUZBWUFCQUNOUEFsU0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
