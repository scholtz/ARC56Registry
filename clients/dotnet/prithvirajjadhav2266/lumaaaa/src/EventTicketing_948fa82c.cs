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

namespace Arc56.Generated.prithvirajjadhav2266.lumaaaa.EventTicketing_948fa82c
{


    //
    // 
    //    Event Ticketing Smart Contract on Algorand
    //    Manages event creation, ticket minting (as ASA), and ticket sales
    //    
    //
    public class EventTicketingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EventTicketingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetEventInfoReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public string Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public string Field7 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField7.From(Field7);
                    stringRef[ret.Count] = vField7.Encode();
                    ret.AddRange(new byte[2]);
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
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetEventInfoReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
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
                    var indexField7 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField7.Decode(bytes.Skip(indexField7 + prefixOffset).ToArray());
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is string vField7Value) { ret.Field7 = vField7Value; }
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
        ///Create a new event and mint tickets as ASA
        ///</summary>
        /// <param name="event_name">Name of the event </param>
        /// <param name="event_date">Date of the event </param>
        /// <param name="venue">Venue location </param>
        /// <param name="ticket_price">Price per ticket in microALGOs </param>
        /// <param name="total_supply">Total number of tickets </param>
        /// <param name="organizer_type">Type of organizer (organization/college/individual) </param>
        public async Task<ulong> CreateEvent(string event_name, string event_date, string venue, ulong ticket_price, ulong total_supply, string organizer_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 99, 206, 41 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var event_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_dateAbi.From(event_date);
            var venueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); venueAbi.From(venue);
            var ticket_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_priceAbi.From(ticket_price);
            var total_supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_supplyAbi.From(total_supply);
            var organizer_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizer_typeAbi.From(organizer_type);

            var result = await base.CallApp(new List<object> { abiHandle, event_nameAbi, event_dateAbi, venueAbi, ticket_priceAbi, total_supplyAbi, organizer_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateEvent_Transactions(string event_name, string event_date, string venue, ulong ticket_price, ulong total_supply, string organizer_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 99, 206, 41 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var event_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_dateAbi.From(event_date);
            var venueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); venueAbi.From(venue);
            var ticket_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_priceAbi.From(ticket_price);
            var total_supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_supplyAbi.From(total_supply);
            var organizer_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizer_typeAbi.From(organizer_type);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_nameAbi, event_dateAbi, venueAbi, ticket_priceAbi, total_supplyAbi, organizer_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy a ticket for the event
        ///</summary>
        /// <param name="payment">Payment transaction with ticket price </param>
        /// <param name="ticket_asset">The ticket ASA to receive </param>
        public async Task<string> BuyTicket(PaymentTransaction payment, ulong ticket_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { ticket_asset });
            byte ticket_assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 117, 103, 18, 245 };
            var ticket_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); ticket_assetAbi.From(ticket_asset);

            var result = await base.CallApp(new List<object> { abiHandle, payment, ticket_assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> BuyTicket_Transactions(PaymentTransaction payment, ulong ticket_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { ticket_asset });
            byte ticket_assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 117, 103, 18, 245 };
            var ticket_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); ticket_assetAbi.From(ticket_asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, ticket_assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 198, 241, 247, 122 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 198, 241, 247, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get number of tickets remaining
        ///</summary>
        public async Task<ulong> GetTicketsRemaining(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 243, 77, 86 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTicketsRemaining_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 243, 77, 86 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow the contract to opt-in to receive the ticket asset back
        ///This is needed for the contract to hold tickets
        ///</summary>
        /// <param name="ticket_asset"> </param>
        public async Task<string> OptInToAsset(ulong ticket_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { ticket_asset });
            byte ticket_assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 86, 56, 82, 139 };
            var ticket_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); ticket_assetAbi.From(ticket_asset);

            var result = await base.CallApp(new List<object> { abiHandle, ticket_assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(ulong ticket_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { ticket_asset });
            byte ticket_assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 86, 56, 82, 139 };
            var ticket_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); ticket_assetAbi.From(ticket_asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, ticket_assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXZlbnRUaWNrZXRpbmciLCJkZXNjIjoiXG4gICAgRXZlbnQgVGlja2V0aW5nIFNtYXJ0IENvbnRyYWN0IG9uIEFsZ29yYW5kXG4gICAgTWFuYWdlcyBldmVudCBjcmVhdGlvbiwgdGlja2V0IG1pbnRpbmcgKGFzIEFTQSksIGFuZCB0aWNrZXQgc2FsZXNcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0RXZlbnRJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2V2ZW50IiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBldmVudCBhbmQgbWludCB0aWNrZXRzIGFzIEFTQSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9uYW1lIiwiZGVzYyI6Ik5hbWUgb2YgdGhlIGV2ZW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9kYXRlIiwiZGVzYyI6IkRhdGUgb2YgdGhlIGV2ZW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZW51ZSIsImRlc2MiOiJWZW51ZSBsb2NhdGlvbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja2V0X3ByaWNlIiwiZGVzYyI6IlByaWNlIHBlciB0aWNrZXQgaW4gbWljcm9BTEdPcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxfc3VwcGx5IiwiZGVzYyI6IlRvdGFsIG51bWJlciBvZiB0aWNrZXRzIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmdhbml6ZXJfdHlwZSIsImRlc2MiOiJUeXBlIG9mIG9yZ2FuaXplciAob3JnYW5pemF0aW9uL2NvbGxlZ2UvaW5kaXZpZHVhbCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiQXNzZXQgSUQgb2YgdGhlIGNyZWF0ZWQgdGlja2V0IEFTQSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eV90aWNrZXQiLCJkZXNjIjoiQnV5IGEgdGlja2V0IGZvciB0aGUgZXZlbnQiLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiJQYXltZW50IHRyYW5zYWN0aW9uIHdpdGggdGlja2V0IHByaWNlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tldF9hc3NldCIsImRlc2MiOiJUaGUgdGlja2V0IEFTQSB0byByZWNlaXZlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRyYW5zYWN0aW9uIElEIG9mIHRoZSB0aWNrZXQgdHJhbnNmZXIifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZXZlbnRfaW5mbyIsImRlc2MiOiJHZXQgZXZlbnQgaW5mb3JtYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxzdHJpbmcpIiwic3RydWN0IjoiR2V0RXZlbnRJbmZvUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdGlja2V0c19yZW1haW5pbmciLCJkZXNjIjoiR2V0IG51bWJlciBvZiB0aWNrZXRzIHJlbWFpbmluZyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3RvX2Fzc2V0IiwiZGVzYyI6IkFsbG93IHRoZSBjb250cmFjdCB0byBvcHQtaW4gdG8gcmVjZWl2ZSB0aGUgdGlja2V0IGFzc2V0IGJhY2tcblRoaXMgaXMgbmVlZGVkIGZvciB0aGUgY29udHJhY3QgdG8gaG9sZCB0aWNrZXRzIiwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja2V0X2Fzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjUsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NzhdLCJlcnJvck1lc3NhZ2UiOiJBbGwgdGlja2V0cyBzb2xkIG91dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MF0sImVycm9yTWVzc2FnZSI6IkV2ZW50IG5vdCBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5NF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBwYXltZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAyXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBwYXltZW50IHJlY2VpdmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY4LDc3OV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgdGlja2V0IGFzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3LDI1OSwyNzUsMzU5LDM5MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNV0sImVycm9yTWVzc2FnZSI6IlRpY2tldCBwcmljZSBtdXN0IGJlIGF0IGxlYXN0IDAuMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQwXSwiZXJyb3JNZXNzYWdlIjoiVG90YWwgc3VwcGx5IG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDAsMjYyLDI3OCwzNjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzAxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ldmVudF9kYXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZXZlbnRfbmFtZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzX2luaXRpYWxpemVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3JnYW5pemVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3JnYW5pemVyX3R5cGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ5LDU2NCw3NDIsNzc1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50aWNrZXRfYXNzZXRfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgzLDcyN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGlja2V0X3ByaWNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3Miw2MjUsNzM3LDc2NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGlja2V0c19zb2xkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMyw1NzYsNzMyLDc2MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfc3VwcGx5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudmVudWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpYWmxiblJmZEdsamEyVjBhVzVuTG1OdmJuUnlZV04wTGtWMlpXNTBWR2xqYTJWMGFXNW5MbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTVNBeE1EQXdJRFFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJblJwWTJ0bGRITmZjMjlzWkNJZ0luUnZkR0ZzWDNOMWNIQnNlU0lnSW5ScFkydGxkRjloYzNObGRGOXBaQ0lnTUhneE5URm1OMk0zTlNBaWRHbGphMlYwWDNCeWFXTmxJaUFpWlhabGJuUmZibUZ0WlNJZ0ltVjJaVzUwWDJSaGRHVWlJQ0oyWlc1MVpTSWdJbTl5WjJGdWFYcGxjaUlnSW05eVoyRnVhWHBsY2w5MGVYQmxJaUFpYVhOZmFXNXBkR2xoYkdsNlpXUWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJekxUSTBDaUFnSUNBdkx5QWpJRVYyWlc1MElHUmxkR0ZwYkhNS0lDQWdJQzh2SUhObGJHWXVaWFpsYm5SZmJtRnRaU0E5SUZOMGNtbHVaeWdpSWlrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1WMlpXNTBYMjVoYldVaUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCelpXeG1MbVYyWlc1MFgyUmhkR1VnUFNCVGRISnBibWNvSWlJcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbGRtVnVkRjlrWVhSbElnb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU5nb2dJQ0FnTHk4Z2MyVnNaaTUyWlc1MVpTQTlJRk4wY21sdVp5Z2lJaWtLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblpsYm5WbElnb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU53b2dJQ0FnTHk4Z2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnBZMnRsZEY5d2NtbGpaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95T1FvZ0lDQWdMeThnYzJWc1ppNXZjbWRoYm1sNlpYSWdQU0JCWTJOdmRXNTBLQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbTl5WjJGdWFYcGxjaUlLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklITmxiR1l1ZEdsamEyVjBYMkZ6YzJWMFgybGtJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYVdOclpYUmZZWE56WlhSZmFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklITmxiR1l1ZEdsamEyVjBjMTl6YjJ4a0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBhV05yWlhSelgzTnZiR1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNeklLSUNBZ0lDOHZJSE5sYkdZdWIzSm5ZVzVwZW1WeVgzUjVjR1VnUFNCVGRISnBibWNvSWlJcElDQWpJQ0p2Y21kaGJtbDZZWFJwYjI0aUxDQWlZMjlzYkdWblpTSXNJQ0pwYm1ScGRtbGtkV0ZzSWdvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYjNKbllXNXBlbVZ5WDNSNWNHVWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qTXpDaUFnSUNBdkx5QnpaV3htTG1selgybHVhWFJwWVd4cGVtVmtJRDBnUm1Gc2MyVUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSnBjMTlwYm1sMGFXRnNhWHBsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QmpiR0Z6Y3lCRmRtVnVkRlJwWTJ0bGRHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE5sTmpOalpUSTVJREI0TnpVMk56RXlaalVnTUhoak5tWXhaamMzWVNBd2VHUXhaak0wWkRVMklEQjROVFl6T0RVeU9HSWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZaWFpsYm5Rb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkN4emRISnBibWNwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ppZFhsZmRHbGphMlYwS0hCaGVTeGhjM05sZENsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGOWxkbVZ1ZEY5cGJtWnZLQ2tvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1WnlraUxDQnRaWFJvYjJRZ0ltZGxkRjkwYVdOclpYUnpYM0psYldGcGJtbHVaeWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p2Y0hSZmFXNWZkRzlmWVhOelpYUW9ZWE56WlhRcGMzUnlhVzVuSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZaWFpsYm5SZmNtOTFkR1ZBTlNCdFlXbHVYMkoxZVY5MGFXTnJaWFJmY205MWRHVkFOaUJ0WVdsdVgyZGxkRjlsZG1WdWRGOXBibVp2WDNKdmRYUmxRRGNnYldGcGJsOW5aWFJmZEdsamEyVjBjMTl5WlcxaGFXNXBibWRmY205MWRHVkFPQ0J0WVdsdVgyOXdkRjlwYmw5MGIxOWhjM05sZEY5eWIzVjBaVUE1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QmpiR0Z6Y3lCRmRtVnVkRlJwWTJ0bGRHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dmNIUmZhVzVmZEc5ZllYTnpaWFJmY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1kyeGhjM01nUlhabGJuUlVhV05yWlhScGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TmprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCdmNIUmZhVzVmZEc5ZllYTnpaWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNScFkydGxkSE5mY21WdFlXbHVhVzVuWDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwWDNScFkydGxkSE5mY21WdFlXbHVhVzVuQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5bGRtVnVkRjlwYm1adlgzSnZkWFJsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFME1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyVjJaVzUwWDJsdVptOEtJQ0FnSUdScFp5QTNDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkRBZ0x5OGdOREFLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01qZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEY0tJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKMWVWOTBhV05yWlhSZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QmpiR0Z6Y3lCRmRtVnVkRlJwWTJ0bGRHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmMzTmxkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJpZFhsZmRHbGphMlYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOWxkbVZ1ZEY5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOZ29nSUNBZ0x5OGdZMnhoYzNNZ1JYWmxiblJVYVdOclpYUnBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWZlpYWmxiblFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpYWmxiblJmZEdsamEyVjBhVzVuTG1OdmJuUnlZV04wTGtWMlpXNTBWR2xqYTJWMGFXNW5MbU55WldGMFpWOWxkbVZ1ZENobGRtVnVkRjl1WVcxbE9pQmllWFJsY3l3Z1pYWmxiblJmWkdGMFpUb2dZbmwwWlhNc0lIWmxiblZsT2lCaWVYUmxjeXdnZEdsamEyVjBYM0J5YVdObE9pQmllWFJsY3l3Z2RHOTBZV3hmYzNWd2NHeDVPaUJpZVhSbGN5d2diM0puWVc1cGVtVnlYM1I1Y0dVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1kzSmxZWFJsWDJWMlpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3pOUzAwTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNBdkx5QmtaV1lnWTNKbFlYUmxYMlYyWlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdaWFpsYm5SZmJtRnRaVG9nWVhKak5DNVRkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdaWFpsYm5SZlpHRjBaVG9nWVhKak5DNVRkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkbVZ1ZFdVNklHRnlZelF1VTNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhScFkydGxkRjl3Y21salpUb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3hmYzNWd2NHeDVPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnZjbWRoYm1sNlpYSmZkSGx3WlRvZ1lYSmpOQzVUZEhKcGJtY3NDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdOaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPalU1TFRZeENpQWdJQ0F2THlBaklFVnVjM1Z5WlNCdGFXNXBiWFZ0SUhScFkydGxkQ0J3Y21salpTQjBieUJqYjNabGNpQjBjbUZ1YzJGamRHbHZiaUJtWldWekNpQWdJQ0F2THlBaklFMXBibWx0ZFcwZ01DNHhJRUZNUjA4Z0tERXdNQ3d3TURBZ2JXbGpjbTlCVEVkUGN5a2dkRzhnYUdGdVpHeGxJR1psWlhNZ2NISnZjR1Z5YkhrS0lDQWdJQzh2SUdGemMyVnlkQ0IwYVdOclpYUmZjSEpwWTJVdWJtRjBhWFpsSUQ0OUlERXdNRjh3TURBc0lDSlVhV05yWlhRZ2NISnBZMlVnYlhWemRDQmlaU0JoZENCc1pXRnpkQ0F3TGpFZ1FVeEhUeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNQ0F2THlBeE1EQXdNREFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHbGphMlYwSUhCeWFXTmxJRzExYzNRZ1ltVWdZWFFnYkdWaGMzUWdNQzR4SUVGTVIwOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGIzUmhiRjl6ZFhCd2JIa3VibUYwYVhabElENGdNQ3dnSWxSdmRHRnNJSE4xY0hCc2VTQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QlViM1JoYkNCemRYQndiSGtnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk5DMDJOUW9nSUNBZ0x5OGdJeUJUZEc5eVpTQmxkbVZ1ZENCa1pYUmhhV3h6Q2lBZ0lDQXZMeUJ6Wld4bUxtVjJaVzUwWDI1aGJXVWdQU0JsZG1WdWRGOXVZVzFsTG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVpYWmxiblJmYm1GdFpTSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdjMlZzWmk1bGRtVnVkRjlrWVhSbElEMGdaWFpsYm5SZlpHRjBaUzV1WVhScGRtVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1WMlpXNTBYMlJoZEdVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z2MyVnNaaTUyWlc1MVpTQTlJSFpsYm5WbExtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkbVZ1ZFdVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVZ1BTQjBhV05yWlhSZmNISnBZMlV1Ym1GMGFYWmxDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBhV05yWlhSZmNISnBZMlVpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qWTVDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM04xY0hCc2VTQTlJSFJ2ZEdGc1gzTjFjSEJzZVM1dVlYUnBkbVVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOekFLSUNBZ0lDOHZJSE5sYkdZdWIzSm5ZVzVwZW1WeUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1lubDBaV01nT0NBdkx5QWliM0puWVc1cGVtVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklITmxiR1l1YjNKbllXNXBlbVZ5WDNSNWNHVWdQU0J2Y21kaGJtbDZaWEpmZEhsd1pTNXVZWFJwZG1VS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbTl5WjJGdWFYcGxjbDkwZVhCbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklITmxiR1l1ZEdsamEyVjBjMTl6YjJ4a0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBhV05yWlhSelgzTnZiR1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJSE5sYkdZdWFYTmZhVzVwZEdsaGJHbDZaV1FnUFNCVWNuVmxDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlhWE5mYVc1cGRHbGhiR2w2WldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TnpVdE9EZ0tJQ0FnSUM4dklDTWdRM0psWVhSbElFRlRRU0JtYjNJZ2RHbGphMlYwY3dvZ0lDQWdMeThnSXlCRllXTm9JSFJwWTJ0bGRDQnBjeUF4SUhWdWFYUWdiMllnZEdocGN5QkJVMEVLSUNBZ0lDOHZJSFJwWTJ0bGRGOWhjM05sZENBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OWMyVnNaaTUwYjNSaGJGOXpkWEJ3Ykhrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlNQ3dnSUNNZ1ZHbGphMlYwY3lCaGNtVWdkMmh2YkdVZ2RXNXBkSE1LSUNBZ0lDOHZJQ0FnSUNCa1pXWmhkV3gwWDJaeWIzcGxiajFHWVd4elpTd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5WVhKak5DNVRkSEpwYm1jb0lsUkxWQ0lwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBXVjJaVzUwWDI1aGJXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnM5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklIUnZkR0ZzUFhObGJHWXVkRzkwWVd4ZmMzVndjR3g1TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRYQndiSGtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE5DMDROZ29nSUNBZ0x5OGdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z1puSmxaWHBsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUJqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndiaUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUTJ4aGQySmhZMnNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJHY21WbGVtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlNaWE5sY25abENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRXRnVZV2RsY2dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMWhjbU0wTGxOMGNtbHVaeWdpVkV0VUlpa3VibUYwYVhabExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5UUTBZalUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJR1JsWm1GMWJIUmZabkp2ZW1WdVBVWmhiSE5sTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldaaGRXeDBSbkp2ZW1WdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCa1pXTnBiV0ZzY3owd0xDQWdJeUJVYVdOclpYUnpJR0Z5WlNCM2FHOXNaU0IxYm1sMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qYzFMVGMzQ2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0JCVTBFZ1ptOXlJSFJwWTJ0bGRITUtJQ0FnSUM4dklDTWdSV0ZqYUNCMGFXTnJaWFFnYVhNZ01TQjFibWwwSUc5bUlIUm9hWE1nUVZOQkNpQWdJQ0F2THlCMGFXTnJaWFJmWVhOelpYUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pjMUxUZzRDaUFnSUNBdkx5QWpJRU55WldGMFpTQkJVMEVnWm05eUlIUnBZMnRsZEhNS0lDQWdJQzh2SUNNZ1JXRmphQ0IwYVdOclpYUWdhWE1nTVNCMWJtbDBJRzltSUhSb2FYTWdRVk5CQ2lBZ0lDQXZMeUIwYVdOclpYUmZZWE56WlhRZ1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BYTmxiR1l1ZEc5MFlXeGZjM1Z3Y0d4NUxBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVEFzSUNBaklGUnBZMnRsZEhNZ1lYSmxJSGRvYjJ4bElIVnVhWFJ6Q2lBZ0lDQXZMeUFnSUNBZ1pHVm1ZWFZzZEY5bWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdGeVl6UXVVM1J5YVc1bktDSlVTMVFpS1M1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMWxkbVZ1ZEY5dVlXMWxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVNQW9nSUNBZ0x5OGdjMlZzWmk1MGFXTnJaWFJmWVhOelpYUmZhV1FnUFNCMGFXTnJaWFJmWVhOelpYUXVZM0psWVhSbFpGOWhjM05sZEM1cFpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHbGphMlYwWDJGemMyVjBYMmxrSWdvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZPVElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnBZMnRsZEY5aGMzTmxkRjlwWkNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYVdOclpYUmZZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdsamEyVjBYMkZ6YzJWMFgybGtJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1WMlpXNTBYM1JwWTJ0bGRHbHVaeTVqYjI1MGNtRmpkQzVGZG1WdWRGUnBZMnRsZEdsdVp5NWlkWGxmZEdsamEyVjBLSEJoZVcxbGJuUTZJSFZwYm5RMk5Dd2dkR2xqYTJWMFgyRnpjMlYwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwaWRYbGZkR2xqYTJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNU5DMDVPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdZblY1WDNScFkydGxkQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUhScFkydGxkRjloYzNObGREb2dRWE56WlhRc0NpQWdJQ0F2THlBcElDMCtJR0Z5WXpRdVUzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YVhOZmFXNXBkR2xoYkdsNlpXUXNJQ0pGZG1WdWRDQnViM1FnYVc1cGRHbGhiR2w2WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW1selgybHVhWFJwWVd4cGVtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgybHVhWFJwWVd4cGVtVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUVWMlpXNTBJRzV2ZENCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGFXTnJaWFJmWVhOelpYUXVhV1FnUFQwZ2MyVnNaaTUwYVdOclpYUmZZWE56WlhSZmFXUXNJQ0pKYm5aaGJHbGtJSFJwWTJ0bGRDQmhjM05sZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYVdOclpYUmZZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdsamEyVjBYMkZ6YzJWMFgybGtJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdkR2xqYTJWMElHRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakV4TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWRHbGphMlYwYzE5emIyeGtJRHdnYzJWc1ppNTBiM1JoYkY5emRYQndiSGtzSUNKQmJHd2dkR2xqYTJWMGN5QnpiMnhrSUc5MWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGFXTnJaWFJ6WDNOdmJHUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdsamEyVjBjMTl6YjJ4a0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRYQndiSGtnWlhocGMzUnpDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnUVd4c0lIUnBZMnRsZEhNZ2MyOXNaQ0J2ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRFMExURXhOZ29nSUNBZ0x5OGdJeUJXWlhKcFpua2djR0Y1YldWdWRDQmhiVzkxYm5RZ0tHMTFjM1FnWW1VZ1pYaGhZM1FnZEdsamEyVjBJSEJ5YVdObElDc2dabVZsY3lrS0lDQWdJQzh2SUNNZ1FXUmtJREV3TURBZ2JXbGpjbTlCVEVkUGN5Qm1iM0lnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRnWm1WbENpQWdJQ0F2THlCeVpYRjFhWEpsWkY5d1lYbHRaVzUwSUQwZ2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVZ0t5QXhYekF3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJwWTJ0bGRGOXdjbWxqWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBhV05yWlhSZmNISnBZMlVnWlhocGMzUnpDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNQW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCeVpYRjFhWEpsWkY5d1lYbHRaVzUwTENBaVNXNXpkV1ptYVdOcFpXNTBJSEJoZVcxbGJuUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJSEJoZVcxbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1URTRDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlTVzUyWVd4cFpDQndZWGx0Wlc1MElISmxZMlZwZG1WeUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0J3WVhsdFpXNTBJSEpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXlNQzB4TWpZS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ2RHbGphMlYwSUNoQlUwRXBJSFJ2SUdKMWVXVnlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxMGFXTnJaWFJmWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TWpRS0lDQWdJQzh2SUdGemMyVjBYMkZ0YjNWdWREMHhMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1qQXRNVEl4Q2lBZ0lDQXZMeUFqSUZSeVlXNXpabVZ5SUhScFkydGxkQ0FvUVZOQktTQjBieUJpZFhsbGNnb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU5Rb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEl3TFRFeU5nb2dJQ0FnTHk4Z0l5QlVjbUZ1YzJabGNpQjBhV05yWlhRZ0tFRlRRU2tnZEc4Z1luVjVaWElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBYUnBZMnRsZEY5aGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB4TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEk0TFRFeU9Rb2dJQ0FnTHk4Z0l5QkpibU55WlcxbGJuUWdkR2xqYTJWMGN5QnpiMnhrQ2lBZ0lDQXZMeUJ6Wld4bUxuUnBZMnRsZEhOZmMyOXNaQ0FyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEdsamEyVjBjMTl6YjJ4a0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJwWTJ0bGRITmZjMjlzWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGFXTnJaWFJ6WDNOdmJHUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNekV0TVRNeUNpQWdJQ0F2THlBaklGTmxibVFnY0dGNWJXVnVkQ0IwYnlCdmNtZGhibWw2WlhJZ0tHMXBiblZ6SUdabFpYTXBDaUFnSUNBdkx5QndZWGx2ZFhSZllXMXZkVzUwSUQwZ2NHRjViV1Z1ZEM1aGJXOTFiblFnTFNBeFh6QXdNQ0FnSXlCTFpXVndJREV3TURBZ2JXbGpjbTlCVEVkUGN5Qm1iM0lnWm1WbGN3b2dJQ0FnYVc1MFkxOHlJQzh2SURFd01EQUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNekxURXpOd29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYTmxiR1l1YjNKbllXNXBlbVZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxd1lYbHZkWFJmWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE16UUtJQ0FnSUM4dklISmxZMlZwZG1WeVBYTmxiR1l1YjNKbllXNXBlbVZ5TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbTl5WjJGdWFYcGxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmNtZGhibWw2WlhJZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNMkNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNek10TVRNM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNXZjbWRoYm1sNlpYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEJoZVc5MWRGOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TXprS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsTjBjbWx1WnlnaVZHbGphMlYwSUhCMWNtTm9ZWE5sWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF4WkRVME5qazJNelppTmpVM05ESXdOekEzTlRjeU5qTTJPRFl4TnpNMk5UWTBNakEzTXpjMU5qTTJNelkxTnpNM016WTJOelUyWXpaak56a0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1bGRtVnVkRjkwYVdOclpYUnBibWN1WTI5dWRISmhZM1F1UlhabGJuUlVhV05yWlhScGJtY3VaMlYwWDJWMlpXNTBYMmx1Wm04b0tTQXRQaUJpZVhSbGN5d2dZbmwwWlhNc0lHSjVkR1Z6TENCaWVYUmxjeXdnWW5sMFpYTXNJR0o1ZEdWekxDQmllWFJsY3l3Z1lubDBaWE02Q21kbGRGOWxkbVZ1ZEY5cGJtWnZPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVFFLSUNBZ0lDOHZJR0Z5WXpRdVUzUnlhVzVuS0hObGJHWXVaWFpsYm5SZmJtRnRaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaWFpsYm5SZmJtRnRaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGRtVnVkRjl1WVcxbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFUxQ2lBZ0lDQXZMeUJoY21NMExsTjBjbWx1WnloelpXeG1MbVYyWlc1MFgyUmhkR1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbVYyWlc1MFgyUmhkR1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYWmxiblJmWkdGMFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakUxTmdvZ0lDQWdMeThnWVhKak5DNVRkSEpwYm1jb2MyVnNaaTUyWlc1MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRtVnVkV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtVnVkV1VnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5UY0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHbGphMlYwWDNCeWFXTmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBhV05yWlhSZmNISnBZMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHbGphMlYwWDNCeWFXTmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5UZ0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5emRYQndiSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5Ua0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHbGphMlYwYzE5emIyeGtLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBhV05yWlhSelgzTnZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHbGphMlYwYzE5emIyeGtJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5qQUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHbGphMlYwWDJGemMyVjBYMmxrS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYVdOclpYUmZZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdsamEyVjBYMkZ6YzJWMFgybGtJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5qRUtJQ0FnSUM4dklHRnlZelF1VTNSeWFXNW5LSE5sYkdZdWIzSm5ZVzVwZW1WeVgzUjVjR1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbTl5WjJGdWFYcGxjbDkwZVhCbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTl5WjJGdWFYcGxjbDkwZVhCbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFV6TFRFMk1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUNnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxOMGNtbHVaeWh6Wld4bUxtVjJaVzUwWDI1aGJXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVVM1J5YVc1bktITmxiR1l1WlhabGJuUmZaR0YwWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VGRISnBibWNvYzJWc1ppNTJaVzUxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBhV05yWlhSZmNISnBZMlVwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5ScFkydGxkSE5mYzI5c1pDa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYVdOclpYUmZZWE56WlhSZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVVM1J5YVc1bktITmxiR1l1YjNKbllXNXBlbVZ5WDNSNWNHVXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtVjJaVzUwWDNScFkydGxkR2x1Wnk1amIyNTBjbUZqZEM1RmRtVnVkRlJwWTJ0bGRHbHVaeTVuWlhSZmRHbGphMlYwYzE5eVpXMWhhVzVwYm1jb0tTQXRQaUJpZVhSbGN6b0taMlYwWDNScFkydGxkSE5mY21WdFlXbHVhVzVuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TmpjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVNBdElITmxiR1l1ZEdsamEyVjBjMTl6YjJ4a0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYM04xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXpkWEJ3YkhrZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkR2xqYTJWMGMxOXpiMnhrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnBZMnRsZEhOZmMyOXNaQ0JsZUdsemRITUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVsZG1WdWRGOTBhV05yWlhScGJtY3VZMjl1ZEhKaFkzUXVSWFpsYm5SVWFXTnJaWFJwYm1jdWIzQjBYMmx1WDNSdlgyRnpjMlYwS0hScFkydGxkRjloYzNObGREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tiM0IwWDJsdVgzUnZYMkZ6YzJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5qa3RNVGN3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJ2Y0hSZmFXNWZkRzlmWVhOelpYUW9jMlZzWml3Z2RHbGphMlYwWDJGemMyVjBPaUJCYzNObGRDa2dMVDRnWVhKak5DNVRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdkR2xqYTJWMFgyRnpjMlYwTG1sa0lEMDlJSE5sYkdZdWRHbGphMlYwWDJGemMyVjBYMmxrTENBaVNXNTJZV3hwWkNCMGFXTnJaWFFnWVhOelpYUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHbGphMlYwWDJGemMyVjBYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnBZMnRsZEY5aGMzTmxkRjlwWkNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhScFkydGxkQ0JoYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE56Y3RNVGd5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMTBhV05yWlhSZllYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UYzVDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRnd0NpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UYzNDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UZ3hDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TnpjdE1UZ3lDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxMGFXTnJaWFJmWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNE5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVVM1J5YVc1bktDSkRiMjUwY21GamRDQnZjSFJsWkNCcGJpQjBieUJoYzNObGRDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREZoTkRNMlpqWmxOelEzTWpZeE5qTTNOREl3Tm1ZM01EYzBOalUyTkRJd05qazJaVEl3TnpRMlpqSXdOakUzTXpjek5qVTNOQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFIb0J3UW1Dd3gwYVdOclpYUnpYM052YkdRTWRHOTBZV3hmYzNWd2NHeDVEM1JwWTJ0bGRGOWhjM05sZEY5cFpBUVZIM3gxREhScFkydGxkRjl3Y21salpRcGxkbVZ1ZEY5dVlXMWxDbVYyWlc1MFgyUmhkR1VGZG1WdWRXVUpiM0puWVc1cGVtVnlEbTl5WjJGdWFYcGxjbDkwZVhCbERtbHpYMmx1YVhScFlXeHBlbVZrTVJoQUFDb25CWUFBWnljR2dBQm5Kd2VBQUdjbkJDSm5LU0puSndneUEyY3FJbWNvSW1jbkNZQUFaeWNLSW1jeEcwRUFLb0lGQkQ1anppa0VkV2NTOVFURzhmZDZCTkh6VFZZRVZqaFNpellhQUk0RkFKd0FmQUFvQUJnQUFpSkRNUmtVUkRFWVJEWWFBUmZBTUlnQ0J5dE1VTEFqUXpFWkZFUXhHRVNJQWV3clRGQ3dJME14R1JSRU1SaEVpQUdTU3djVmdTZ0lTUlpYQmdLQUFnQW9URkJMQ0JWUEFnaEpGbGNHQWs4Q1RGQkxCeFZQQWdoTVR3WlFUd1ZRVHdSUVR3TlFUQlpYQmdKUVR3UlFUd05RVHdKUVRGQXJURkN3STBNeEdSUkVNUmhFTVJZakNVazRFQ01TUkRZYUFSZkFNSWdBcWl0TVVMQWpRekVaRkVReEdCUkVOaG9CTmhvQ05ob0ROaG9FTmhvRk5ob0dpQUFHSzB4UXNDTkRpZ1lCaS8wWFNZR2dqUVlQUkl2K0YwbEVpL3BYQWdBbkJVc0JaNHY3VndJQUp3Wk1aNHY4VndJQUp3ZE1aeWNFVHdObktVOENaeWNJTVFCbmkvOVhBZ0FuQ1V4bktDSm5Kd29qWjdFaUtXVkVNZ3BIQTdJc3NpdXlLcklwVExJbWdBTlVTMVN5SlNLeUpDS3lJN0lpZ1FPeUVDS3lBYk1xdER4bklpcGxSQmFKaWdJQklpY0taVVJFSWlwbFJJdi9Fa1FpS0dWRUlpbGxSQXhFSWljRVpVUWtDSXYrT0FoSlR3SVBSSXYrT0FjeUNoSkVzVEVBSTdJU3NoU0wvN0lSSmJJUUlySUJzeUlvWlVRakNDaE1aeVFKc1NJbkNHVkVzZ2V5Q0NPeUVDS3lBYk9BSHdBZFZHbGphMlYwSUhCMWNtTm9ZWE5sWkNCemRXTmpaWE56Wm5Wc2JIbUpJaWNGWlVSSkZSWlhCZ0pNVUNJbkJtVkVTUlVXVndZQ1RGQWlKd2RsUkVrVkZsY0dBa3hRSWljRVpVUVdJaWxsUkJZaUtHVkVGaUlxWlVRV0lpY0paVVJKRlJaWEJnSk1VSWtpS1dWRUlpaGxSQWtXaVlvQkFTSXFaVVNML3hKRXNUSUtJcklTc2hTTC83SVJKYklRSXJJQnM0QWNBQnBEYjI1MGNtRmpkQ0J2Y0hSbFpDQnBiaUIwYnlCaGMzTmxkSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
