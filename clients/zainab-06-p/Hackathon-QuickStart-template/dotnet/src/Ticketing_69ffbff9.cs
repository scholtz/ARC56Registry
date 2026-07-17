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

namespace Arc56.Generated.zainab_06_p.Hackathon_QuickStart_template.Ticketing_69ffbff9
{


    //
    // 
    //    CampusChain Multi-Organizer Ticketing Contract
    //    NFT-based event tickets with anti-scalping and entry verification
    //    Each deployment = one event (fully decentralized)
    //    Features:
    //    - Mints NFT ticket on purchase
    //    - Multi-organizer support (creator can add up to 10 organizers)
    //    - All organizers can scan tickets and verify entry
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
        ///Create a new ticketed event
        ///Additional organizers can be added after creation using add_organizer()
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
        ///Add an organizer who can scan tickets (creator only)
        ///Stores organizer in box with key "org_{index}" Requires box MBR funding before calling (20,100 microAlgos per organizer) Returns the organizer index
        ///</summary>
        /// <param name="organizer_address"> </param>
        public async Task<ulong> AddOrganizer(Algorand.Address organizer_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 142, 82, 252 };
            var organizer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organizer_addressAbi.From(organizer_address);

            var result = await base.CallApp(new List<object> { abiHandle, organizer_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddOrganizer_Transactions(Algorand.Address organizer_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 142, 82, 252 };
            var organizer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organizer_addressAbi.From(organizer_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizer_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Store IPFS CID for event media (image/video)
        ///Creator only, can be called once Requires box MBR funding: 2500 + 400 * (5 + cid_length) microAlgos Max CID length: 64 characters
        ///</summary>
        /// <param name="cid"> </param>
        public async Task<ulong> SetMediaCid(byte[] cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 255, 64, 125 };
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cidAbi.From(cid);

            var result = await base.CallApp(new List<object> { abiHandle, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetMediaCid_Transactions(byte[] cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 255, 64, 125 };
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cidAbi.From(cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve IPFS CID for event media
        ///Returns empty bytes if no media set
        ///</summary>
        public async Task<byte[]> GetMediaCid(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 16, 141, 248 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetMediaCid_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 16, 141, 248 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Claim your purchased ticket NFT after opting in to the asset.
        ///Uses asset reserve field to verify the rightful buyer.
        ///</summary>
        /// <param name="ticket_asset_id"> </param>
        public async Task ClaimTicket(ulong ticket_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 165, 36, 106 };
            var ticket_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_asset_idAbi.From(ticket_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, ticket_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimTicket_Transactions(ulong ticket_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 165, 36, 106 };
            var ticket_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_asset_idAbi.From(ticket_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, ticket_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify ticket at event entry (called by creator or any organizer)
        ///Checks NFT ownership and check-in status All organizers have permission to scan and verify tickets
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
        ///Toggle ticket sales on/off (creator or organizers only)
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
        ///Get event creator address (main organizer)
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
        ///Get organizer address by index
        ///Returns zero address if index is out of bounds
        ///</summary>
        /// <param name="index"> </param>
        public async Task<Algorand.Address> GetOrganizerByIndex(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 193, 16, 88 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.SimApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetOrganizerByIndex_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 193, 16, 88 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the number of additional organizers
        ///</summary>
        public async Task<ulong> GetOrganizerCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 116, 251, 0 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetOrganizerCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 116, 251, 0 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if an address is an organizer
        ///</summary>
        /// <param name="address"> </param>
        public async Task<bool> IsOrganizer(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 121, 193, 123 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsOrganizer_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 121, 193, 123 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGlja2V0aW5nIiwiZGVzYyI6IlxuICAgIENhbXB1c0NoYWluIE11bHRpLU9yZ2FuaXplciBUaWNrZXRpbmcgQ29udHJhY3RcbiAgICBORlQtYmFzZWQgZXZlbnQgdGlja2V0cyB3aXRoIGFudGktc2NhbHBpbmcgYW5kIGVudHJ5IHZlcmlmaWNhdGlvblxuICAgIEVhY2ggZGVwbG95bWVudCA9IG9uZSBldmVudCAoZnVsbHkgZGVjZW50cmFsaXplZClcbiAgICBGZWF0dXJlczpcbiAgICAtIE1pbnRzIE5GVCB0aWNrZXQgb24gcHVyY2hhc2VcbiAgICAtIE11bHRpLW9yZ2FuaXplciBzdXBwb3J0IChjcmVhdG9yIGNhbiBhZGQgdXAgdG8gMTAgb3JnYW5pemVycylcbiAgICAtIEFsbCBvcmdhbml6ZXJzIGNhbiBzY2FuIHRpY2tldHMgYW5kIHZlcmlmeSBlbnRyeVxuICAgIC0gUVIgY29kZSB2ZXJpZmljYXRpb24gYXQgZW50cnlcbiAgICAtIFByZXZlbnRzIGRvdWJsZSBlbnRyeVxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRFdmVudEluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfZXZlbnQiLCJkZXNjIjoiQ3JlYXRlIGEgbmV3IHRpY2tldGVkIGV2ZW50XG5BZGRpdGlvbmFsIG9yZ2FuaXplcnMgY2FuIGJlIGFkZGVkIGFmdGVyIGNyZWF0aW9uIHVzaW5nIGFkZF9vcmdhbml6ZXIoKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlX2VuZF9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX29yZ2FuaXplciIsImRlc2MiOiJBZGQgYW4gb3JnYW5pemVyIHdobyBjYW4gc2NhbiB0aWNrZXRzIChjcmVhdG9yIG9ubHkpXG5TdG9yZXMgb3JnYW5pemVyIGluIGJveCB3aXRoIGtleSBcIm9yZ197aW5kZXh9XCIgUmVxdWlyZXMgYm94IE1CUiBmdW5kaW5nIGJlZm9yZSBjYWxsaW5nICgyMCwxMDAgbWljcm9BbGdvcyBwZXIgb3JnYW5pemVyKSBSZXR1cm5zIHRoZSBvcmdhbml6ZXIgaW5kZXgiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZ2FuaXplcl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X21lZGlhX2NpZCIsImRlc2MiOiJTdG9yZSBJUEZTIENJRCBmb3IgZXZlbnQgbWVkaWEgKGltYWdlL3ZpZGVvKVxuQ3JlYXRvciBvbmx5LCBjYW4gYmUgY2FsbGVkIG9uY2UgUmVxdWlyZXMgYm94IE1CUiBmdW5kaW5nOiAyNTAwICsgNDAwICogKDUgKyBjaWRfbGVuZ3RoKSBtaWNyb0FsZ29zIE1heCBDSUQgbGVuZ3RoOiA2NCBjaGFyYWN0ZXJzIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tZWRpYV9jaWQiLCJkZXNjIjoiUmV0cmlldmUgSVBGUyBDSUQgZm9yIGV2ZW50IG1lZGlhXG5SZXR1cm5zIGVtcHR5IGJ5dGVzIGlmIG5vIG1lZGlhIHNldCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eV90aWNrZXQiLCJkZXNjIjoiUHVyY2hhc2UgYW4gZXZlbnQgdGlja2V0IC0gTWludHMgTkZUIHRvIGJ1eWVyXG5SZXR1cm5zIHRoZSBORlQgQXNzZXQgSUQiLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX3RpY2tldCIsImRlc2MiOiJDbGFpbSB5b3VyIHB1cmNoYXNlZCB0aWNrZXQgTkZUIGFmdGVyIG9wdGluZyBpbiB0byB0aGUgYXNzZXQuXG5Vc2VzIGFzc2V0IHJlc2VydmUgZmllbGQgdG8gdmVyaWZ5IHRoZSByaWdodGZ1bCBidXllci4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja2V0X2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9lbnRyeSIsImRlc2MiOiJWZXJpZnkgdGlja2V0IGF0IGV2ZW50IGVudHJ5IChjYWxsZWQgYnkgY3JlYXRvciBvciBhbnkgb3JnYW5pemVyKVxuQ2hlY2tzIE5GVCBvd25lcnNoaXAgYW5kIGNoZWNrLWluIHN0YXR1cyBBbGwgb3JnYW5pemVycyBoYXZlIHBlcm1pc3Npb24gdG8gc2NhbiBhbmQgdmVyaWZ5IHRpY2tldHMiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tldF9ob2xkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tldF9hc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19jaGVja2VkX2luIiwiZGVzYyI6IkNoZWNrIGlmIGEgdGlja2V0IGhhcyBiZWVuIHVzZWQgZm9yIGVudHJ5IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tldF9hc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvZ2dsZV9zYWxlIiwiZGVzYyI6IlRvZ2dsZSB0aWNrZXQgc2FsZXMgb24vb2ZmIChjcmVhdG9yIG9yIG9yZ2FuaXplcnMgb25seSkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2V2ZW50X2luZm8iLCJkZXNjIjoiR2V0IGV2ZW50IGluZm9ybWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sKSIsInN0cnVjdCI6IkdldEV2ZW50SW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9vcmdhbml6ZXIiLCJkZXNjIjoiR2V0IGV2ZW50IGNyZWF0b3IgYWRkcmVzcyAobWFpbiBvcmdhbml6ZXIpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X29yZ2FuaXplcl9ieV9pbmRleCIsImRlc2MiOiJHZXQgb3JnYW5pemVyIGFkZHJlc3MgYnkgaW5kZXhcblJldHVybnMgemVybyBhZGRyZXNzIGlmIGluZGV4IGlzIG91dCBvZiBib3VuZHMiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfb3JnYW5pemVyX2NvdW50IiwiZGVzYyI6IkdldCB0aGUgbnVtYmVyIG9mIGFkZGl0aW9uYWwgb3JnYW5pemVycyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfb3JnYW5pemVyIiwiZGVzYyI6IkNoZWNrIGlmIGFuIGFkZHJlc3MgaXMgYW4gb3JnYW5pemVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjksImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMDUzLDEyMjYsMTM0MSwxNDEyXSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBsZW5ndGggaXMgMzIgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDldLCJlcnJvck1lc3NhZ2UiOiJBc3NldCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDddLCJlcnJvck1lc3NhZ2UiOiJDSUQgdG9vIGxvbmcgKG1heCA2NCBjaGFycykiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MThdLCJlcnJvck1lc3NhZ2UiOiJFdmVudCBoYXMgcGFzc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA3OV0sImVycm9yTWVzc2FnZSI6IkV2ZW50IHZlcmlmaWNhdGlvbiBwZXJpb2QgZW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTNdLCJlcnJvck1lc3NhZ2UiOiJGYWlsZWQgdG8gY3JlYXRlIG1lZGlhIGJveCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwOF0sImVycm9yTWVzc2FnZSI6IkZhaWxlZCB0byBjcmVhdGUgb3JnYW5pemVyIGJveCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzN10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBwYXltZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjk0XSwiZXJyb3JNZXNzYWdlIjoiTWF4aW11bSAxMCBvcmdhbml6ZXJzIGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzldLCJlcnJvck1lc3NhZ2UiOiJNZWRpYSBhbHJlYWR5IHNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3OV0sImVycm9yTWVzc2FnZSI6Ik1lZGlhIGJveCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjJdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IG9wdC1pbiB0byBhc3NldCBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1M10sImVycm9yTWVzc2FnZSI6Ik5vdCB5b3VyIHRpY2tldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MSwyOTYsMzEzLDMzMywzNDksNDA4LDQzMCw0NTYsNDg4LDUwNCw1MzEsNTU1LDU3OCw1OThdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGFkZCBvcmdhbml6ZXJzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBzZXQgbWVkaWEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjM4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIG9yIG9yZ2FuaXplcnMgY2FuIHRvZ2dsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3Igb3Igb3JnYW5pemVycyBjYW4gdmVyaWZ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzg4XSwiZXJyb3JNZXNzYWdlIjoiU2FsZSBub3QgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAwXSwiZXJyb3JNZXNzYWdlIjoiU29sZCBvdXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTE5XSwiZXJyb3JNZXNzYWdlIjoiVGlja2V0IGFscmVhZHkgdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDBdLCJlcnJvck1lc3NhZ2UiOiJUaWNrZXQgbm90IG93bmVkIGJ5IGhvbGRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwOV0sImVycm9yTWVzc2FnZSI6IlRpY2tldCBzYWxlcyBoYXZlIGVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0LDI5OSwzMTYsMzM2LDM1Miw0MTEsNDMzLDQ1OSw0OTEsNTA3LDUzNCw1NTgsNTgxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4NCw3MzAsMTAwNCwxMTc3LDEzMDEsMTM2M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY3JlYXRvciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MTYsMTA3MiwxMjgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ldmVudF9kYXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4NywxMjQyLDEyNTAsMTI5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNfc2FsZV9hY3RpdmUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzk4LDEyNzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1heF9zdXBwbHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzM3LDc2OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWVkaWFfY2lkX2xlbmd0aCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTAsNjk4LDcxNSwxMDE3LDExOTAsMTMxMCwxMzUxLDEzODBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9yZ2FuaXplcl9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDcsMTI4N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2FsZV9lbmRfZGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTMsODQyLDEyNzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNvbGRfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODM1LDEyNjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRpY2tldF9wcmljZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTMsMTI5Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudW5pcXVlX2J1eWVycyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaWIzSm5ZVzVwZW1WeVgyTnZkVzUwSWlBaVkzSmxZWFJ2Y2lJZ0ltbHpYM05oYkdWZllXTjBhWFpsSWlBd2VEQXdJQ0p6YjJ4a1gyTnZkVzUwSWlBd2VEWm1OekkyTnpWbUlDSmxkbVZ1ZEY5a1lYUmxJaUFpZFc1cGNYVmxYMkoxZVdWeWN5SWdJbTFsWkdsaFgyTnBaRjlzWlc1bmRHZ2lJQ0owYVdOclpYUmZjSEpwWTJVaUlDSnRZWGhmYzNWd2NHeDVJaUFpYzJGc1pWOWxibVJmWkdGMFpTSWdNSGcyWkRZMU5qUTJPVFl4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlJwWTJ0bGRHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1U0WkdRMlltWmtJREI0WXpJNFpUVXlabU1nTUhnMk1HWm1OREEzWkNBd2VEVXhNVEE0WkdZNElEQjROekZsWmpWaVpETWdNSGhsWTJFMU1qUTJZU0F3ZURNelpqZzRPRGxrSURCNE9EaGlaR1JpTWpJZ01IZ3dZVEU1WXpBME9DQXdlR0ZrTVRCaVptSXlJREI0WlRZeE9XUTVNamNnTUhobVlXTXhNVEExT0NBd2VEbGtOelJtWWpBd0lEQjRNVFUzT1dNeE4ySWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZaWFpsYm5Rb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlXUmtYMjl5WjJGdWFYcGxjaWhoWkdSeVpYTnpLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljMlYwWDIxbFpHbGhYMk5wWkNoaWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZmJXVmthV0ZmWTJsa0tDbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0ltSjFlVjkwYVdOclpYUW9jR0Y1S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWTJ4aGFXMWZkR2xqYTJWMEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZaVzUwY25rb1lXTmpiM1Z1ZEN4MWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlhWE5mWTJobFkydGxaRjlwYmloMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlkRzluWjJ4bFgzTmhiR1VvS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEY5bGRtVnVkRjlwYm1adktDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1kbGRGOXZjbWRoYm1sNlpYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbWRsZEY5dmNtZGhibWw2WlhKZllubGZhVzVrWlhnb2RXbHVkRFkwS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1kbGRGOXZjbWRoYm1sNlpYSmZZMjkxYm5Rb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWFYTmZiM0puWVc1cGVtVnlLR0ZrWkhKbGMzTXBZbTl2YkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxYMlYyWlc1MFgzSnZkWFJsUURNZ2JXRnBibDloWkdSZmIzSm5ZVzVwZW1WeVgzSnZkWFJsUURRZ2JXRnBibDl6WlhSZmJXVmthV0ZmWTJsa1gzSnZkWFJsUURVZ2JXRnBibDluWlhSZmJXVmthV0ZmWTJsa1gzSnZkWFJsUURZZ2JXRnBibDlpZFhsZmRHbGphMlYwWDNKdmRYUmxRRGNnYldGcGJsOWpiR0ZwYlY5MGFXTnJaWFJmY205MWRHVkFPQ0J0WVdsdVgzWmxjbWxtZVY5bGJuUnllVjl5YjNWMFpVQTVJRzFoYVc1ZmFYTmZZMmhsWTJ0bFpGOXBibDl5YjNWMFpVQXhNQ0J0WVdsdVgzUnZaMmRzWlY5ellXeGxYM0p2ZFhSbFFERXhJRzFoYVc1ZloyVjBYMlYyWlc1MFgybHVabTlmY205MWRHVkFNVElnYldGcGJsOW5aWFJmYjNKbllXNXBlbVZ5WDNKdmRYUmxRREV6SUcxaGFXNWZaMlYwWDI5eVoyRnVhWHBsY2w5aWVWOXBibVJsZUY5eWIzVjBaVUF4TkNCdFlXbHVYMmRsZEY5dmNtZGhibWw2WlhKZlkyOTFiblJmY205MWRHVkFNVFVnYldGcGJsOXBjMTl2Y21kaGJtbDZaWEpmY205MWRHVkFNVFlLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZHbGphMlYwYVc1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmx6WDI5eVoyRnVhWHBsY2w5eWIzVjBaVUF4TmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qZ3pDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVkdsamEyVjBhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakk0TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCcGMxOXZjbWRoYm1sNlpYSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXZjbWRoYm1sNlpYSmZZMjkxYm5SZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTNPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5dmNtZGhibWw2WlhKZlkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDI5eVoyRnVhWHBsY2w5aWVWOXBibVJsZUY5eWIzVjBaVUF4TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVkdsamEyVjBhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakkyTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZiM0puWVc1cGVtVnlYMko1WDJsdVpHVjRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl2Y21kaGJtbDZaWEpmY205MWRHVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJMU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl2Y21kaGJtbDZaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJWMlpXNTBYMmx1Wm05ZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTBOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMlYyWlc1MFgybHVabThLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUnZaMmRzWlY5ellXeGxYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TWpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJSFJ2WjJkc1pWOXpZV3hsQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjMTlqYUdWamEyVmtYMmx1WDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJVYVdOclpYUnBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNakV3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdselgyTm9aV05yWldSZmFXNEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNabGNtbG1lVjlsYm5SeWVWOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlJwWTJ0bGRHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdkbVZ5YVdaNVgyVnVkSEo1Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpiR0ZwYlY5MGFXTnJaWFJmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCVWFXTnJaWFJwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTJ4aGFXMWZkR2xqYTJWMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKMWVWOTBhV05yWlhSZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1URXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5QlVhV05yWlhScGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJpZFhsZmRHbGphMlYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5dFpXUnBZVjlqYVdSZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOXRaV1JwWVY5amFXUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGOXRaV1JwWVY5amFXUmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlJwWTJ0bGRHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk56WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCelpYUmZiV1ZrYVdGZlkybGtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRmtaRjl2Y21kaGJtbDZaWEpmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUZScFkydGxkR2x1WnloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0ZrWkY5dmNtZGhibWw2WlhJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxYMlYyWlc1MFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5ZE9iMDl3SjEwc0lHTnlaV0YwWlQwbmNtVnhkV2x5WlNjcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCVWFXTnJaWFJwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSjA1dlQzQW5YU3dnWTNKbFlYUmxQU2R5WlhGMWFYSmxKeWtLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsWDJWMlpXNTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5ScFkydGxkR2x1Wnk1amIyNTBjbUZqZEM1VWFXTnJaWFJwYm1jdVkzSmxZWFJsWDJWMlpXNTBLSEJ5YVdObE9pQjFhVzUwTmpRc0lITjFjSEJzZVRvZ2RXbHVkRFkwTENCbGRtVnVkRjlrWVhSbE9pQjFhVzUwTmpRc0lITmhiR1ZmWlc1a1gyUmhkR1U2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwamNtVmhkR1ZmWlhabGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakk1TFRNMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lkT2IwOXdKMTBzSUdOeVpXRjBaVDBuY21WeGRXbHlaU2NwQ2lBZ0lDQXZMeUJrWldZZ1kzSmxZWFJsWDJWMlpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnY0hKcFkyVTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0J6ZFhCd2JIazZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JsZG1WdWRGOWtZWFJsT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2MyRnNaVjlsYm1SZlpHRjBaVG9nVlVsdWREWTBDaUFnSUNBdkx5QXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURRZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1MGFXTnJaWFJmY0hKcFkyVWdQU0J3Y21salpRb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luUnBZMnRsZEY5d2NtbGpaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUhObGJHWXViV0Y0WDNOMWNIQnNlU0E5SUhOMWNIQnNlUW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbTFoZUY5emRYQndiSGtpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCelpXeG1Mbk52YkdSZlkyOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5OdmJHUmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5EUUtJQ0FnSUM4dklITmxiR1l1WlhabGJuUmZaR0YwWlNBOUlHVjJaVzUwWDJSaGRHVUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltVjJaVzUwWDJSaGRHVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJ6Wld4bUxuTmhiR1ZmWlc1a1gyUmhkR1VnUFNCellXeGxYMlZ1WkY5a1lYUmxDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWljMkZzWlY5bGJtUmZaR0YwWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklITmxiR1l1WTNKbFlYUnZjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OeVpXRjBiM0lpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnYzJWc1ppNXBjMTl6WVd4bFgyRmpkR2wyWlNBOUlGUnlkV1VLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWx6WDNOaGJHVmZZV04wYVhabElnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QnpaV3htTG5WdWFYRjFaVjlpZFhsbGNuTWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblZ1YVhGMVpWOWlkWGxsY25NaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklITmxiR1l1YjNKbllXNXBlbVZ5WDJOdmRXNTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2Y21kaGJtbDZaWEpmWTI5MWJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJSE5sYkdZdWJXVmthV0ZmWTJsa1gyeGxibWQwYUNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWJXVmthV0ZmWTJsa1gyeGxibWQwYUNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBhV05yWlhScGJtY3VZMjl1ZEhKaFkzUXVWR2xqYTJWMGFXNW5MbUZrWkY5dmNtZGhibWw2WlhJb2IzSm5ZVzVwZW1WeVgyRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNtRmtaRjl2Y21kaGJtbDZaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVekxUVTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCaFpHUmZiM0puWVc1cGVtVnlLSE5sYkdZc0lHOXlaMkZ1YVhwbGNsOWhaR1J5WlhOek9pQkJaR1J5WlhOektTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVkzSmxZWFJ2Y2l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z1lXUmtJRzl5WjJGdWFYcGxjbk1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkzSmxZWFJ2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpjbVZoZEc5eUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHRmtaQ0J2Y21kaGJtbDZaWEp6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RZ1BDQlZTVzUwTmpRb01UQXBMQ0FpVFdGNGFXMTFiU0F4TUNCdmNtZGhibWw2WlhKeklHRnNiRzkzWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNKbllXNXBlbVZ5WDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05eVoyRnVhWHBsY2w5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTVRBZ0x5OGdNVEFLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCTllYaHBiWFZ0SURFd0lHOXlaMkZ1YVhwbGNuTWdZV3hzYjNkbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJOQzAyTlFvZ0lDQWdMeThnSXlCRGNtVmhkR1VnWW05NElHdGxlU0JtY205dElHTjFjbkpsYm5RZ1kyOTFiblFLSUNBZ0lDOHZJR04xY25KbGJuUmZhVzVrWlhnZ1BTQnpaV3htTG05eVoyRnVhWHBsY2w5amIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOXlaMkZ1YVhwbGNsOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCaWIzaGZhMlY1SUQwZ1lpSnZjbWRmSWlBcklHOXdMbWwwYjJJb1kzVnljbVZ1ZEY5cGJtUmxlQ2tLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTmlBdkx5QXdlRFptTnpJMk56Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpndE56QUtJQ0FnSUM4dklDTWdRM0psWVhSbElHSnZlQ0FvTXpJZ1lubDBaWE1nWm05eUlHRmtaSEpsYzNNcElHRnVaQ0J6ZEc5eVpTQnZjbWRoYm1sNlpYSUtJQ0FnSUM4dklDTWdRbTk0SUUxQ1Vqb2dNalV3TUNBcklEUXdNQ0FxSUNneE1pQXJJRE15S1NBOUlESXdMREV3TUNCdGFXTnliMEZzWjI5ekNpQWdJQ0F2THlCaGMzTmxjblFnYjNBdVFtOTRMbU55WldGMFpTaGliM2hmYTJWNUxDQXpNaWtzSUNKR1lXbHNaV1FnZEc4Z1kzSmxZWFJsSUc5eVoyRnVhWHBsY2lCaWIzZ2lDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdZWE56WlhKMElDOHZJRVpoYVd4bFpDQjBieUJqY21WaGRHVWdiM0puWVc1cGVtVnlJR0p2ZUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z2IzQXVRbTk0TG5CMWRDaGliM2hmYTJWNUxDQnZjbWRoYm1sNlpYSmZZV1JrY21WemN5NWllWFJsY3lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdjMlZzWmk1dmNtZGhibWw2WlhKZlkyOTFiblFnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNKbllXNXBlbVZ5WDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05eVoyRnVhWHBsY2w5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2Y21kaGJtbDZaWEpmWTI5MWJuUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnY21WMGRYSnVJR04xY25KbGJuUmZhVzVrWlhnS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwYVdOclpYUnBibWN1WTI5dWRISmhZM1F1VkdsamEyVjBhVzVuTG5ObGRGOXRaV1JwWVY5amFXUW9ZMmxrT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwelpYUmZiV1ZrYVdGZlkybGtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8zTmkwM053b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnYzJWMFgyMWxaR2xoWDJOcFpDaHpaV3htTENCamFXUTZJRUo1ZEdWektTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk9EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVkzSmxZWFJ2Y2l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2MyVjBJRzFsWkdsaElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNKbFlYUnZjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ6WlhRZ2JXVmthV0VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtMWxaR2xoWDJOcFpGOXNaVzVuZEdnZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpVFdWa2FXRWdZV3h5WldGa2VTQnpaWFFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWliV1ZrYVdGZlkybGtYMnhsYm1kMGFDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WldScFlWOWphV1JmYkdWdVozUm9JR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTFsWkdsaElHRnNjbVZoWkhrZ2MyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJqYVdSZmJHVnVJRDBnWTJsa0xteGxibWQwYUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0JqYVdSZmJHVnVJRHc5SUZWSmJuUTJOQ2cyTkNrc0lDSkRTVVFnZEc5dklHeHZibWNnS0cxaGVDQTJOQ0JqYUdGeWN5a2lDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1EwbEVJSFJ2YnlCc2IyNW5JQ2h0WVhnZ05qUWdZMmhoY25NcENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qa3dMVGt5Q2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0JpYjNnZ2RHOGdjM1J2Y21VZ2RHaGxJRU5KUkFvZ0lDQWdMeThnSXlCQ2IzZ2dUVUpTT2lBeU5UQXdJQ3NnTkRBd0lDb2dLRFVnS3lCc1pXNG9ZMmxrS1NrS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1Q2IzZ3VZM0psWVhSbEtFSjVkR1Z6S0dJaWJXVmthV0VpS1N3Z1kybGtYMnhsYmlrc0lDSkdZV2xzWldRZ2RHOGdZM0psWVhSbElHMWxaR2xoSUdKdmVDSUtJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjRObVEyTlRZME5qazJNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUdGemMyVnlkQ0F2THlCR1lXbHNaV1FnZEc4Z1kzSmxZWFJsSUcxbFpHbGhJR0p2ZUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z2IzQXVRbTk0TG5CMWRDaENlWFJsY3loaUltMWxaR2xoSWlrc0lHTnBaQ2tLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0Tm1RMk5UWTBOamsyTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qazFDaUFnSUNBdkx5QnpaV3htTG0xbFpHbGhYMk5wWkY5c1pXNW5kR2dnUFNCamFXUmZiR1Z1Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p0WldScFlWOWphV1JmYkdWdVozUm9JZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2prMkNpQWdJQ0F2THlCeVpYUjFjbTRnWTJsa1gyeGxiZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnBZMnRsZEdsdVp5NWpiMjUwY21GamRDNVVhV05yWlhScGJtY3VaMlYwWDIxbFpHbGhYMk5wWkNncElDMCtJR0o1ZEdWek9ncG5aWFJmYldWa2FXRmZZMmxrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHbG1JSE5sYkdZdWJXVmthV0ZmWTJsa1gyeGxibWQwYUNBOVBTQlZTVzUwTmpRb01DazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWJXVmthV0ZmWTJsa1gyeGxibWQwYUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRaV1JwWVY5amFXUmZiR1Z1WjNSb0lHVjRhWE4wY3dvZ0lDQWdZbTU2SUdkbGRGOXRaV1JwWVY5amFXUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdjbVYwZFhKdUlFSjVkR1Z6S0dJaUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnY21WMGMzVmlDZ3BuWlhSZmJXVmthV0ZmWTJsa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QmphV1JmWW5sMFpYTXNJR1Y0YVhOMGN5QTlJRzl3TGtKdmVDNW5aWFFvUW5sMFpYTW9ZaUp0WldScFlTSXBLUW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdNSGcyWkRZMU5qUTJPVFl4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3l3Z0lrMWxaR2xoSUdKdmVDQnViM1FnWm05MWJtUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1RXVmthV0VnWW05NElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJSEpsZEhWeWJpQmphV1JmWW5sMFpYTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGFXTnJaWFJwYm1jdVkyOXVkSEpoWTNRdVZHbGphMlYwYVc1bkxtSjFlVjkwYVdOclpYUW9jR0Y1YldWdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbUoxZVY5MGFXTnJaWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeE1TMHhNVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHSjFlVjkwYVdOclpYUW9jMlZzWml3Z2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRjS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpYM05oYkdWZllXTjBhWFpsTENBaVUyRnNaU0J1YjNRZ1lXTjBhWFpsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWx6WDNOaGJHVmZZV04wYVhabElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx6WDNOaGJHVmZZV04wYVhabElHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRk5oYkdVZ2JtOTBJR0ZqZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OdmJHUmZZMjkxYm5RZ1BDQnpaV3htTG0xaGVGOXpkWEJ3Ykhrc0lDSlRiMnhrSUc5MWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKemIyeGtYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk52YkdSZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltMWhlRjl6ZFhCd2JIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGNFgzTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCVGIyeGtJRzkxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0E4SUhObGJHWXVjMkZzWlY5bGJtUmZaR0YwWlN3Z0lsUnBZMnRsZENCellXeGxjeUJvWVhabElHVnVaR1ZrSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0p6WVd4bFgyVnVaRjlrWVhSbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk5oYkdWZlpXNWtYMlJoZEdVZ1pYaHBjM1J6Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHbGphMlYwSUhOaGJHVnpJR2hoZG1VZ1pXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQQ0J6Wld4bUxtVjJaVzUwWDJSaGRHVXNJQ0pGZG1WdWRDQm9ZWE1nY0dGemMyVmtJZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltVjJaVzUwWDJSaGRHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WlhabGJuUmZaR0YwWlNCbGVHbHpkSE1LSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCRmRtVnVkQ0JvWVhNZ2NHRnpjMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1USXlDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1aGJXOTFiblFnUGowZ2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVc0lDSkpibk4xWm1acFkybGxiblFnY0dGNWJXVnVkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luUnBZMnRsZEY5d2NtbGpaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGFXTnJaWFJmY0hKcFkyVWdaWGhwYzNSekNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCd1lYbHRaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU5DMHhNalVLSUNBZ0lDOHZJQ01nU1c1amNtVnRaVzUwSUhScFkydGxkQ0JqYjNWdWRHVnlDaUFnSUNBdkx5QnpaV3htTG5OdmJHUmZZMjkxYm5RZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWMyOXNaRjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6YjJ4a1gyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5OdmJHUmZZMjkxYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNallLSUNBZ0lDOHZJSE5sYkdZdWRXNXBjWFZsWDJKMWVXVnljeUFyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0oxYm1seGRXVmZZblY1WlhKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ1YVhGMVpWOWlkWGxsY25NZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRXNXBjWFZsWDJKMWVXVnljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU9DMHhNemtLSUNBZ0lDOHZJQ01nVFdsdWRDQk9SbFFnZEdsamEyVjBJQzBnYTJWbGNDQnBiaUJqYjI1MGNtRmpkQ0IxYm5ScGJDQmlkWGxsY2lCdmNIUnpJR2x1Q2lBZ0lDQXZMeUIwYVdOclpYUmZZWE56WlhSZmFXUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQVEVzSUNBaklFNUdWQ0FvTVNCMWJtbDBJRzl1YkhrcENpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBXSWlSWFpsYm5RZ1ZHbGphMlYwSWl3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlZaUpVU1ZnaUxBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQxaUltbHdabk02THk5allXMXdkWE10ZEdsamEyVjBJaXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxd1lYbHRaVzUwTG5ObGJtUmxjaXdnSUNNZ1RXRnlheUIwYUdVZ1luVjVaWElnYVc0Z2NtVnpaWEoyWlNCbWFXVnNaQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2t1WTNKbFlYUmxaRjloYzNObGRDNXBaQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNelVLSUNBZ0lDOHZJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakV6TmdvZ0lDQWdMeThnY21WelpYSjJaVDF3WVhsdFpXNTBMbk5sYm1SbGNpd2dJQ01nVFdGeWF5QjBhR1VnWW5WNVpYSWdhVzRnY21WelpYSjJaU0JtYVdWc1pBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UTTNDaUFnSUNBdkx5Qm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXpPQW9nSUNBZ0x5OGdZMnhoZDJKaFkyczlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFEyeGhkMkpoWTJzS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSR2NtVmxlbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJTWlhObGNuWmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNelFLSUNBZ0lDOHZJSFZ5YkQxaUltbHdabk02THk5allXMXdkWE10ZEdsamEyVjBJaXdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFk1TnpBMk5qY3pNMkV5WmpKbU5qTTJNVFprTnpBM05UY3pNbVEzTkRZNU5qTTJZalkxTnpRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVlVrd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVE16Q2lBZ0lDQXZMeUIxYm1sMFgyNWhiV1U5WWlKVVNWZ2lMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROVFEwT1RVNENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQV0lpUlhabGJuUWdWR2xqYTJWMElpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTFOelkyTlRabE56UXlNRFUwTmprMk16WmlOalUzTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJrWldOcGJXRnNjejB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldOcGJXRnNjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TXpBS0lDQWdJQzh2SUhSdmRHRnNQVEVzSUNBaklFNUdWQ0FvTVNCMWJtbDBJRzl1YkhrcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakV5T0MweE1qa0tJQ0FnSUM4dklDTWdUV2x1ZENCT1JsUWdkR2xqYTJWMElDMGdhMlZsY0NCcGJpQmpiMjUwY21GamRDQjFiblJwYkNCaWRYbGxjaUJ2Y0hSeklHbHVDaUFnSUNBdkx5QjBhV05yWlhSZllYTnpaWFJmYVdRZ1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNamd0TVRNNUNpQWdJQ0F2THlBaklFMXBiblFnVGtaVUlIUnBZMnRsZENBdElHdGxaWEFnYVc0Z1kyOXVkSEpoWTNRZ2RXNTBhV3dnWW5WNVpYSWdiM0IwY3lCcGJnb2dJQ0FnTHk4Z2RHbGphMlYwWDJGemMyVjBYMmxrSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQweExDQWdJeUJPUmxRZ0tERWdkVzVwZENCdmJteDVLUW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRBc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDFpSWtWMlpXNTBJRlJwWTJ0bGRDSXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdJaVZFbFlJaXdLSUNBZ0lDOHZJQ0FnSUNCMWNtdzlZaUpwY0daek9pOHZZMkZ0Y0hWekxYUnBZMnRsZENJc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTljR0Y1YldWdWRDNXpaVzVrWlhJc0lDQWpJRTFoY21zZ2RHaGxJR0oxZVdWeUlHbHVJSEpsYzJWeWRtVWdabWxsYkdRS0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExuTjFZbTFwZENncExtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCYzNObGRFbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakUwTVMweE5ETUtJQ0FnSUM4dklDTWdUa1pVSUhOMFlYbHpJSGRwZEdnZ1kyOXVkSEpoWTNRZ0xTQmlkWGxsY2lCdGRYTjBJRzl3ZEMxcGJpQjBhR1Z1SUdOaGJHd2dZMnhoYVcxZmRHbGphMlYwQ2lBZ0lDQXZMeUFqSUVOb1pXTnJMV2x1SUdKdmVDQjNhV3hzSUdKbElHTnlaV0YwWldRZ2JHRjBaWElnWkhWeWFXNW5JSFpsY21sbWVWOWxiblJ5ZVFvZ0lDQWdMeThnY21WMGRYSnVJSFJwWTJ0bGRGOWhjM05sZEY5cFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5ScFkydGxkR2x1Wnk1amIyNTBjbUZqZEM1VWFXTnJaWFJwYm1jdVkyeGhhVzFmZEdsamEyVjBLSFJwWTJ0bGRGOWhjM05sZEY5cFpEb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGpiR0ZwYlY5MGFXTnJaWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFME5TMHhORFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHTnNZV2x0WDNScFkydGxkQ2h6Wld4bUxDQjBhV05yWlhSZllYTnpaWFJmYVdRNklGVkpiblEyTkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TlRFdE1UVXlDaUFnSUNBdkx5QWpJRlpsY21sbWVTQjBhR2x6SUdGemMyVjBJSGRoY3lCamNtVmhkR1ZrSUdKNUlIUm9hWE1nWTI5dWRISmhZM1FnWVc1a0lHSjFlV1Z5SUdseklHMWhjbXRsWkFvZ0lDQWdMeThnY21WelpYSjJaVjloWkdSeUxDQnlaWE5sY25abFgyVjRhWE4wY3lBOUlHOXdMa0Z6YzJWMFVHRnlZVzF6UjJWMExtRnpjMlYwWDNKbGMyVnlkbVVvZEdsamEyVjBYMkZ6YzJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaWE5sY25abFgyVjRhWE4wY3l3Z0lrRnpjMlYwSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYzNObGRDQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZ6WlhKMlpWOWhaR1J5SUQwOUlGUjRiaTV6Wlc1a1pYSXNJQ0pPYjNRZ2VXOTFjaUIwYVdOclpYUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCNWIzVnlJSFJwWTJ0bGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVFl0TVRVM0NpQWdJQ0F2THlBaklGWmxjbWxtZVNCaWRYbGxjaUJvWVhNZ2IzQjBaV1FnYVc1MGJ5QjBhR1VnWVhOelpYUUtJQ0FnSUM4dklHSjFlV1Z5WDJKaGJHRnVZMlVzSUdKMWVXVnlYMjl3ZEdWa1gybHVJRDBnYjNBdVFYTnpaWFJJYjJ4a2FXNW5SMlYwTG1GemMyVjBYMkpoYkdGdVkyVW9WSGh1TG5ObGJtUmxjaXdnZEdsamEyVjBYMkZ6YzJWMFgybGtLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmlkWGxsY2w5dmNIUmxaRjlwYml3Z0lrMTFjM1FnYjNCMExXbHVJSFJ2SUdGemMyVjBJR1pwY25OMElnb2dJQ0FnWVhOelpYSjBJQzh2SUUxMWMzUWdiM0IwTFdsdUlIUnZJR0Z6YzJWMElHWnBjbk4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFMk1DMHhOallLSUNBZ0lDOHZJQ01nVkhKaGJuTm1aWElnZFhOcGJtY2dZMnhoZDJKaFkyc0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQweExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5ZEdsamEyVjBYMkZ6YzJWMFgybGtDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJNZ29nSUNBZ0x5OGdZWE56WlhSZmMyVnVaR1Z5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5qTUtJQ0FnSUM4dklHRnpjMlYwWDNKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBURXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakUyTUMweE5qRUtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdkWE5wYm1jZ1kyeGhkMkpoWTJzS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJNQzB4TmpZS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ2RYTnBibWNnWTJ4aGQySmhZMnNLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl6Wlc1a1pYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHhMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROWRHbGphMlYwWDJGemMyVjBYMmxrQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnBZMnRsZEdsdVp5NWpiMjUwY21GamRDNVVhV05yWlhScGJtY3VkbVZ5YVdaNVgyVnVkSEo1S0hScFkydGxkRjlvYjJ4a1pYSTZJR0o1ZEdWekxDQjBhV05yWlhSZllYTnpaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncDJaWEpwWm5sZlpXNTBjbms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFMk9DMHhOamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlIWmxjbWxtZVY5bGJuUnllU2h6Wld4bUxDQjBhV05yWlhSZmFHOXNaR1Z5T2lCQlkyTnZkVzUwTENCMGFXTnJaWFJmWVhOelpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1ltOXZiRG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGMxTFRFM05nb2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCcFppQnpaVzVrWlhJZ2FYTWdZM0psWVhSdmNpQnZjaUJ2Ym1VZ2IyWWdkR2hsSUc5eVoyRnVhWHBsY25NS0lDQWdJQzh2SUhObGJtUmxjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TnpjS0lDQWdJQzh2SUdselgyRjFkR2h2Y21sNlpXUWdQU0J6Wlc1a1pYSWdQVDBnYzJWc1ppNWpjbVZoZEc5eUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTNKbFlYUnZjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amNtVmhkRzl5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TnprdE1UZ3dDaUFnSUNBdkx5QWpJRU5vWldOcklHOXlaMkZ1YVhwbGNuTWdabkp2YlNCaWIzZ2djM1J2Y21GblpRb2dJQ0FnTHk4Z2FXWWdibTkwSUdselgyRjFkR2h2Y21sNlpXUTZDaUFnSUNCaWJub2dkbVZ5YVdaNVgyVnVkSEo1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRneENpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW05eVoyRnVhWHBsY2w5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05eVoyRnVhWHBsY2w5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0NuWmxjbWxtZVY5bGJuUnllVjltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTRNUW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1YjNKbllXNXBlbVZ5WDJOdmRXNTBLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lHWnlZVzFsWDJKMWNua2dPQW9nSUNBZ1lub2dkbVZ5YVdaNVgyVnVkSEo1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRneUNpQWdJQ0F2THlCaWIzaGZhMlY1SUQwZ1lpSnZjbWRmSWlBcklHOXdMbWwwYjJJb2FTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE5tWTNNalkzTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hPRE1LSUNBZ0lDOHZJRzl5WjJGdWFYcGxjbDlpZVhSbGN5d2daWGhwYzNSeklEMGdiM0F1UW05NExtZGxkQ2hpYjNoZmEyVjVLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNE5Bb2dJQ0FnTHk4Z2FXWWdaWGhwYzNSek9nb2dJQ0FnWW5vZ2RtVnlhV1o1WDJWdWRISjVYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hPRFVLSUNBZ0lDOHZJRzl5WjJGdWFYcGxjaUE5SUVGalkyOTFiblFvYjNKbllXNXBlbVZ5WDJKNWRHVnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1JrY21WemN5QnNaVzVuZEdnZ2FYTWdNeklnWW5sMFpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGcyQ2lBZ0lDQXZMeUJwWmlCelpXNWtaWElnUFQwZ2IzSm5ZVzVwZW1WeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURZS0lDQWdJRDA5Q2lBZ0lDQmllaUIyWlhKcFpubGZaVzUwY25sZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNE53b2dJQ0FnTHk4Z2FYTmZZWFYwYUc5eWFYcGxaQ0E5SUZSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURnS0NuWmxjbWxtZVY5bGJuUnllVjloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ1puSmhiV1ZmWkdsbklEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGt3Q2lBZ0lDQXZMeUJoYzNObGNuUWdhWE5mWVhWMGFHOXlhWHBsWkN3Z0lrOXViSGtnWTNKbFlYUnZjaUJ2Y2lCdmNtZGhibWw2WlhKeklHTmhiaUIyWlhKcFpua2lDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJRzl5SUc5eVoyRnVhWHBsY25NZ1kyRnVJSFpsY21sbWVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBOFBTQnpaV3htTG1WMlpXNTBYMlJoZEdVZ0t5QlZTVzUwTmpRb09EWTBNREFwTENBaVJYWmxiblFnZG1WeWFXWnBZMkYwYVc5dUlIQmxjbWx2WkNCbGJtUmxaQ0lLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmxkbVZ1ZEY5a1lYUmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WMlpXNTBYMlJoZEdVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElEZzJOREF3SUM4dklEZzJOREF3Q2lBZ0lDQXJDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVWMlpXNTBJSFpsY21sbWFXTmhkR2x2YmlCd1pYSnBiMlFnWlc1a1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGt6TFRFNU5Bb2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCMGFXTnJaWFJmYUc5c1pHVnlJRzkzYm5NZ2RHaGxJRTVHVkFvZ0lDQWdMeThnYUc5c1pHVnlYMkpoYkdGdVkyVXNJR2h2YkdSbGNsOWxlR2x6ZEhNZ1BTQnZjQzVCYzNObGRFaHZiR1JwYm1kSFpYUXVZWE56WlhSZlltRnNZVzVqWlNoMGFXTnJaWFJmYUc5c1pHVnlMQ0IwYVdOclpYUmZZWE56WlhSZmFXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UazFDaUFnSUNBdkx5QmhjM05sY25RZ2FHOXNaR1Z5WDJWNGFYTjBjeUJoYm1RZ2FHOXNaR1Z5WDJKaGJHRnVZMlVnUFQwZ1ZVbHVkRFkwS0RFcExDQWlWR2xqYTJWMElHNXZkQ0J2ZDI1bFpDQmllU0JvYjJ4a1pYSWlDaUFnSUNCaWVpQjJaWEpwWm5sZlpXNTBjbmxmWW05dmJGOW1ZV3h6WlVBeE13b2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dkbVZ5YVdaNVgyVnVkSEo1WDJKdmIyeGZabUZzYzJWQU1UTUtJQ0FnSUdsdWRHTmZNU0F2THlBeENncDJaWEpwWm5sZlpXNTBjbmxmWW05dmJGOXRaWEpuWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGsxQ2lBZ0lDQXZMeUJoYzNObGNuUWdhRzlzWkdWeVgyVjRhWE4wY3lCaGJtUWdhRzlzWkdWeVgySmhiR0Z1WTJVZ1BUMGdWVWx1ZERZMEtERXBMQ0FpVkdsamEyVjBJRzV2ZENCdmQyNWxaQ0JpZVNCb2IyeGtaWElpQ2lBZ0lDQmhjM05sY25RZ0x5OGdWR2xqYTJWMElHNXZkQ0J2ZDI1bFpDQmllU0JvYjJ4a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGszTFRFNU9Bb2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCMGFXTnJaWFFnYUdGemJpZDBJR0psWlc0Z2RYTmxaQ0FvWTNKbFlYUmxJR0p2ZUNCcFppQm1hWEp6ZENCMGFXMWxLUW9nSUNBZ0x5OGdZbTk0WDJ0bGVTQTlJRzl3TG1sMGIySW9kR2xqYTJWMFgyRnpjMlYwWDJsa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9Ua0tJQ0FnSUM4dklIUnBZMnRsZEY5emRHRjBkWE1zSUdKdmVGOWxlR2x6ZEhNZ1BTQnZjQzVDYjNndVoyVjBLR0p2ZUY5clpYa3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeENpQWdJQ0F2THlCcFppQmliM2hmWlhocGMzUnpPZ29nSUNBZ1lub2dkbVZ5YVdaNVgyVnVkSEo1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeUxUSXdNd29nSUNBZ0x5OGdJeUJDYjNnZ1pYaHBjM1J6SUMwZ1kyaGxZMnNnYVdZZ1lXeHlaV0ZrZVNCMWMyVmtDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVaWGgwY21GamRGOTFhVzUwTmpRb2RHbGphMlYwWDNOMFlYUjFjeXdnTUNrZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpVkdsamEyVjBJR0ZzY21WaFpIa2dkWE5sWkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCVWFXTnJaWFFnWVd4eVpXRmtlU0IxYzJWa0NncDJaWEpwWm5sZlpXNTBjbmxmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMUxUSXdOZ29nSUNBZ0x5OGdJeUJOWVhKcklHRnpJR05vWldOclpXUXRhVzRnS0dOeVpXRjBaWE1nWW05NElHbG1JR1J2WlhOdUozUWdaWGhwYzNRcENpQWdJQ0F2THlCdmNDNUNiM2d1Y0hWMEtHSnZlRjlyWlhrc0lHOXdMbWwwYjJJb1ZVbHVkRFkwS0RFcEtTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNRGdLSUNBZ0lDOHZJSEpsZEhWeWJpQlVjblZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ25abGNtbG1lVjlsYm5SeWVWOWliMjlzWDJaaGJITmxRREV6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdkbVZ5YVdaNVgyVnVkSEo1WDJKdmIyeGZiV1Z5WjJWQU1UUUtDblpsY21sbWVWOWxiblJ5ZVY5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNE1Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hObGJHWXViM0puWVc1cGVtVnlYMk52ZFc1MEtUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCaUlIWmxjbWxtZVY5bGJuUnllVjltYjNKZmFHVmhaR1Z5UURJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaeTVwYzE5amFHVmphMlZrWDJsdUtIUnBZMnRsZEY5aGMzTmxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtbHpYMk5vWldOclpXUmZhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeE1DMHlNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJwYzE5amFHVmphMlZrWDJsdUtITmxiR1lzSUhScFkydGxkRjloYzNObGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCaWIyOXNPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXhNd29nSUNBZ0x5OGdZbTk0WDJ0bGVTQTlJRzl3TG1sMGIySW9kR2xqYTJWMFgyRnpjMlYwWDJsa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXhOQW9nSUNBZ0x5OGdkR2xqYTJWMFgzTjBZWFIxY3l3Z1ltOTRYMlY0YVhOMGN5QTlJRzl3TGtKdmVDNW5aWFFvWW05NFgydGxlU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qRTJDaUFnSUNBdkx5QnBaaUJ1YjNRZ1ltOTRYMlY0YVhOMGN6b0tJQ0FnSUdKdWVpQnBjMTlqYUdWamEyVmtYMmx1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TVRjS0lDQWdJQzh2SUhKbGRIVnliaUJHWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0thWE5mWTJobFkydGxaRjlwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xtVjRkSEpoWTNSZmRXbHVkRFkwS0hScFkydGxkRjl6ZEdGMGRYTXNJREFwSUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHbGphMlYwYVc1bkxtTnZiblJ5WVdOMExsUnBZMnRsZEdsdVp5NTBiMmRuYkdWZmMyRnNaU2dwSUMwK0lIVnBiblEyTkRvS2RHOW5aMnhsWDNOaGJHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl5TVMweU1qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhSdloyZHNaVjl6WVd4bEtITmxiR1lwSUMwK0lHSnZiMnc2Q2lBZ0lDQndjbTkwYnlBd0lERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1qUXRNakkxQ2lBZ0lDQXZMeUFqSUVOb1pXTnJJR2xtSUhObGJtUmxjaUJwY3lCamNtVmhkRzl5SUc5eUlHOXVaU0J2WmlCMGFHVWdiM0puWVc1cGVtVnljd29nSUNBZ0x5OGdjMlZ1WkdWeUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXlOZ29nSUNBZ0x5OGdhWE5mWVhWMGFHOXlhWHBsWkNBOUlITmxibVJsY2lBOVBTQnpaV3htTG1OeVpXRjBiM0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpjbVZoZEc5eUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU55WldGMGIzSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXlPQzB5TWprS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYjNKbllXNXBlbVZ5Y3lCbWNtOXRJR0p2ZUNCemRHOXlZV2RsQ2lBZ0lDQXZMeUJwWmlCdWIzUWdhWE5mWVhWMGFHOXlhWHBsWkRvS0lDQWdJR0p1ZWlCMGIyZG5iR1ZmYzJGc1pWOWhablJsY2w5cFpsOWxiSE5sUURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXpNQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1YjNKbllXNXBlbVZ5WDJOdmRXNTBLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZjbWRoYm1sNlpYSmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3AwYjJkbmJHVmZjMkZzWlY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6TUFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSE5sYkdZdWIzSm5ZVzVwZW1WeVgyTnZkVzUwS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1p5WVcxbFgySjFjbmtnTlFvZ0lDQWdZbm9nZEc5bloyeGxYM05oYkdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU16RUtJQ0FnSUM4dklHSnZlRjlyWlhrZ1BTQmlJbTl5WjE4aUlDc2diM0F1YVhSdllpaHBLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzJaamN5TmpjMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6TWdvZ0lDQWdMeThnYjNKbllXNXBlbVZ5WDJKNWRHVnpMQ0JsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0dKdmVGOXJaWGtwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qTXpDaUFnSUNBdkx5QnBaaUJsZUdsemRITTZDaUFnSUNCaWVpQjBiMmRuYkdWZmMyRnNaVjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNak0wQ2lBZ0lDQXZMeUJ2Y21kaGJtbDZaWElnUFNCQlkyTnZkVzUwS0c5eVoyRnVhWHBsY2w5aWVYUmxjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZrWkhKbGMzTWdiR1Z1WjNSb0lHbHpJRE15SUdKNWRHVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6TlFvZ0lDQWdMeThnYVdZZ2MyVnVaR1Z5SUQwOUlHOXlaMkZ1YVhwbGNqb0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZbm9nZEc5bloyeGxYM05oYkdWZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJek5nb2dJQ0FnTHk4Z2FYTmZZWFYwYUc5eWFYcGxaQ0E5SUZSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0NuUnZaMmRzWlY5ellXeGxYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBjMTloZFhSb2IzSnBlbVZrTENBaVQyNXNlU0JqY21WaGRHOXlJRzl5SUc5eVoyRnVhWHBsY25NZ1kyRnVJSFJ2WjJkc1pTSUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdiM0lnYjNKbllXNXBlbVZ5Y3lCallXNGdkRzluWjJ4bENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTBNQW9nSUNBZ0x5OGdjMlZzWmk1cGMxOXpZV3hsWDJGamRHbDJaU0E5SUc1dmRDQnpaV3htTG1selgzTmhiR1ZmWVdOMGFYWmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWFYTmZjMkZzWlY5aFkzUnBkbVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTmZjMkZzWlY5aFkzUnBkbVVnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKcGMxOXpZV3hsWDJGamRHbDJaU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJME1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVhWE5mYzJGc1pWOWhZM1JwZG1VS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pwYzE5ellXeGxYMkZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5ellXeGxYMkZqZEdsMlpTQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncDBiMmRuYkdWZmMyRnNaVjloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6TUFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSE5sYkdZdWIzSm5ZVzVwZW1WeVgyTnZkVzUwS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JpSUhSdloyZHNaVjl6WVd4bFgyWnZjbDlvWldGa1pYSkFNZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGFXTnJaWFJwYm1jdVkyOXVkSEpoWTNRdVZHbGphMlYwYVc1bkxtZGxkRjlsZG1WdWRGOXBibVp2S0NrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BuWlhSZlpYWmxiblJmYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNalE0Q2lBZ0lDQXZMeUJ6Wld4bUxuUnBZMnRsZEY5d2NtbGpaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkR2xqYTJWMFgzQnlhV05sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnBZMnRsZEY5d2NtbGpaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNalE1Q2lBZ0lDQXZMeUJ6Wld4bUxtMWhlRjl6ZFhCd2JIa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltMWhlRjl6ZFhCd2JIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGNFgzTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVd0NpQWdJQ0F2THlCelpXeG1Mbk52YkdSZlkyOTFiblFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWljMjlzWkY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emIyeGtYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU5URUtJQ0FnSUM4dklITmxiR1l1WlhabGJuUmZaR0YwWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0psZG1WdWRGOWtZWFJsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVjJaVzUwWDJSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTFNZ29nSUNBZ0x5OGdjMlZzWmk1ellXeGxYMlZ1WkY5a1lYUmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSnpZV3hsWDJWdVpGOWtZWFJsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmhiR1ZmWlc1a1gyUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakkxTXdvZ0lDQWdMeThnYzJWc1ppNTFibWx4ZFdWZlluVjVaWEp6TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblZ1YVhGMVpWOWlkWGxsY25NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkVzVwY1hWbFgySjFlV1Z5Y3lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVMENpQWdJQ0F2THlCelpXeG1MbWx6WDNOaGJHVmZZV04wYVhabENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYVhOZmMyRnNaVjloWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOZmMyRnNaVjloWTNScGRtVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTBOeTB5TlRVS0lDQWdJQzh2SUhKbGRIVnliaUFvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVc0NpQWdJQ0F2THlBZ0lDQWdjMlZzWmk1dFlYaGZjM1Z3Y0d4NUxBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZdWMyOXNaRjlqYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxtVjJaVzUwWDJSaGRHVXNDaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNXpZV3hsWDJWdVpGOWtZWFJsTEFvZ0lDQWdMeThnSUNBZ0lITmxiR1l1ZFc1cGNYVmxYMkoxZVdWeWN5d0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxtbHpYM05oYkdWZllXTjBhWFpsQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaeTVuWlhSZmIzSm5ZVzVwZW1WeUtDa2dMVDRnWW5sMFpYTTZDbWRsZEY5dmNtZGhibWw2WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WTNKbFlYUnZjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWVhSdmNpQmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwYVdOclpYUnBibWN1WTI5dWRISmhZM1F1VkdsamEyVjBhVzVuTG1kbGRGOXZjbWRoYm1sNlpYSmZZbmxmYVc1a1pYZ29hVzVrWlhnNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjl2Y21kaGJtbDZaWEpmWW5sZmFXNWtaWGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJMk1pMHlOak1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJuWlhSZmIzSm5ZVzVwZW1WeVgySjVYMmx1WkdWNEtITmxiR1lzSUdsdVpHVjRPaUJWU1c1ME5qUXBJQzArSUVGa1pISmxjM002Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTJPQW9nSUNBZ0x5OGdhV1lnYVc1a1pYZ2dQajBnYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW05eVoyRnVhWHBsY2w5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmNtZGhibWw2WlhKZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUR3OUNpQWdJQ0JpZWlCblpYUmZiM0puWVc1cGVtVnlYMko1WDJsdVpHVjRYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOamtLSUNBZ0lDOHZJSEpsZEhWeWJpQkJaR1J5WlhOektDa2dJQ01nVW1WMGRYSnVJSHBsY204Z1lXUmtjbVZ6Y3dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOXZjbWRoYm1sNlpYSmZZbmxmYVc1a1pYaGZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOekVLSUNBZ0lDOHZJR0p2ZUY5clpYa2dQU0JpSW05eVoxOGlJQ3NnYjNBdWFYUnZZaWhwYm1SbGVDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEWm1OekkyTnpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNamN5Q2lBZ0lDQXZMeUJ2Y21kaGJtbDZaWEpmWW5sMFpYTXNJR1Y0YVhOMGN5QTlJRzl3TGtKdmVDNW5aWFFvWW05NFgydGxlU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU56UUtJQ0FnSUM4dklHbG1JR1Y0YVhOMGN6b0tJQ0FnSUdKNklHZGxkRjl2Y21kaGJtbDZaWEpmWW5sZmFXNWtaWGhmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakkzTlFvZ0lDQWdMeThnY21WMGRYSnVJRUZrWkhKbGMzTW9iM0puWVc1cGVtVnlYMko1ZEdWektRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUmtjbVZ6Y3lCc1pXNW5kR2dnYVhNZ016SWdZbmwwWlhNS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0taMlYwWDI5eVoyRnVhWHBsY2w5aWVWOXBibVJsZUY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJM05nb2dJQ0FnTHk4Z2NtVjBkWEp1SUVGa1pISmxjM01vS1NBZ0l5QlNaWFIxY200Z2VtVnlieUJoWkdSeVpYTnpJR2xtSUc1dmRDQm1iM1Z1WkFvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHbGphMlYwYVc1bkxtTnZiblJ5WVdOMExsUnBZMnRsZEdsdVp5NW5aWFJmYjNKbllXNXBlbVZ5WDJOdmRXNTBLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUmZiM0puWVc1cGVtVnlYMk52ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lPREVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG05eVoyRnVhWHBsY2w5amIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOXlaMkZ1YVhwbGNsOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkR2xqYTJWMGFXNW5MbU52Ym5SeVlXTjBMbFJwWTJ0bGRHbHVaeTVwYzE5dmNtZGhibWw2WlhJb1lXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2FYTmZiM0puWVc1cGVtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95T0RNdE1qZzBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdhWE5mYjNKbllXNXBlbVZ5S0hObGJHWXNJR0ZrWkhKbGMzTTZJRUZrWkhKbGMzTXBJQzArSUdKdmIydzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95T0RnS0lDQWdJQzh2SUdsbUlHRmpZMjkxYm5RZ1BUMGdjMlZzWmk1amNtVmhkRzl5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNKbFlYUnZjaUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdselgyOXlaMkZ1YVhwbGNsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qZzVDaUFnSUNBdkx5QnlaWFIxY200Z1ZISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BwYzE5dmNtZGhibWw2WlhKZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU9URXRNamt5Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJRzl5WjJGdWFYcGxjbk1nWm5KdmJTQmliM2dnYzNSdmNtRm5aUW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1YjNKbllXNXBlbVZ5WDJOdmRXNTBLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZjbWRoYm1sNlpYSmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3BwYzE5dmNtZGhibWw2WlhKZlptOXlYMmhsWVdSbGNrQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95T1RFdE1qa3lDaUFnSUNBdkx5QWpJRU5vWldOcklHOXlaMkZ1YVhwbGNuTWdabkp2YlNCaWIzZ2djM1J2Y21GblpRb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hObGJHWXViM0puWVc1cGVtVnlYMk52ZFc1MEtUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2dhWE5mYjNKbllXNXBlbVZ5WDJGbWRHVnlYMlp2Y2tBeE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lPVE1LSUNBZ0lDOHZJR0p2ZUY5clpYa2dQU0JpSW05eVoxOGlJQ3NnYjNBdWFYUnZZaWhwS1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGcyWmpjeU5qYzFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJNU5Bb2dJQ0FnTHk4Z2IzSm5ZVzVwZW1WeVgySjVkR1Z6TENCbGVHbHpkSE1nUFNCdmNDNUNiM2d1WjJWMEtHSnZlRjlyWlhrcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZNamsxQ2lBZ0lDQXZMeUJwWmlCbGVHbHpkSE02Q2lBZ0lDQmllaUJwYzE5dmNtZGhibWw2WlhKZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJNU5nb2dJQ0FnTHk4Z2IzSm5ZVzVwZW1WeUlEMGdRV05qYjNWdWRDaHZjbWRoYm1sNlpYSmZZbmwwWlhNcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU9UY0tJQ0FnSUM4dklHbG1JR0ZqWTI5MWJuUWdQVDBnYjNKbllXNXBlbVZ5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lub2dhWE5mYjNKbllXNXBlbVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG95T1RnS0lDQWdJQzh2SUhKbGRIVnliaUJVY25WbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtbHpYMjl5WjJGdWFYcGxjbDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPakk1TVMweU9USUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2IzSm5ZVzVwZW1WeWN5Qm1jbTl0SUdKdmVDQnpkRzl5WVdkbENpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYzJWc1ppNXZjbWRoYm1sNlpYSmZZMjkxYm5RcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdJZ2FYTmZiM0puWVc1cGVtVnlYMlp2Y2w5b1pXRmtaWEpBTXdvS2FYTmZiM0puWVc1cGVtVnlYMkZtZEdWeVgyWnZja0F4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk16QXdDaUFnSUNBdkx5QnlaWFIxY200Z1JtRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVnSmc0RUZSOThkUTl2Y21kaGJtbDZaWEpmWTI5MWJuUUhZM0psWVhSdmNnNXBjMTl6WVd4bFgyRmpkR2wyWlFFQUNuTnZiR1JmWTI5MWJuUUViM0puWHdwbGRtVnVkRjlrWVhSbERYVnVhWEYxWlY5aWRYbGxjbk1RYldWa2FXRmZZMmxrWDJ4bGJtZDBhQXgwYVdOclpYUmZjSEpwWTJVS2JXRjRYM04xY0hCc2VRMXpZV3hsWDJWdVpGOWtZWFJsQlcxbFpHbGhNUnRCQUdtQ0RnVG8zV3Y5Qk1LT1V2d0VZUDlBZlFSUkVJMzRCSEh2VzlNRTdLVWthZ1F6K0lpZEJJaTkyeUlFQ2huQVNBU3RFTCt5Qk9ZWjJTY0Urc0VRV0FTZGRQc0FCQlY1d1hzMkdnQ09EZ0ZKQVRVQkhnRUdBT3NBMndDN0FLRUFpd0JRQUVBQUxBQWJBQUlpUXpFWkZFUXhHRVEyR2dHSUJEQW5CQ0pQQWxRb1RGQ3dJME14R1JSRU1SaEVpQVFWRmloTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFQVEtFeFFzQ05ETVJrVVJERVlSSWdEdmloTVVMQWpRekVaRkVReEdFU0lBNHRQQmhaUEJoWlBCaFpQQmhaUEJoWlBCaFluQkNKUENGUlBCazhHVUU4RlVFOEVVRThEVUU4Q1VFeFFLRXhRc0NORE1Sa1VSREVZUklnQzdTY0VJazhDVkNoTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFLK0p3UWlUd0pVS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmZBSERZYUFoZUlBZ01uQkNKUEFsUW9URkN3STBNeEdSUkVNUmhFTmhvQkY0Z0J1eU5ETVJrVVJERVlSREVXSXdsSk9CQWpFa1NJQVFRV0tFeFFzQ05ETVJrVVJERVlSSWdBNDBrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBVmNDQUlnQW1oWW9URkN3STBNeEdSUkVNUmhFTmhvQmlBQllGaWhNVUxBalF6RVpGRVF4R0JSRU5ob0JGellhQWhjMkdnTVhOaG9FRjRnQUJ4WW9URkN3STBPS0JBRW5Db3Y4WnljTGkvMW5Kd1VpWnljSGkvNW5Kd3lMLzJjcU1RQm5LeU5uSndnaVp5a2laeWNKSW1jamlZb0JBVEVBSWlwbFJCSkVJaWxsUklFS0RFUWlLV1ZFU1JZbkJreFFTU1M1Ukl2L3Z5SXBaVVFqQ0NsTVo0bUtBUUV4QUNJcVpVUVNSQ0luQ1dWRUZFU0wveFZKZ1VBT1JDY05Td0c1UkNjTmkvKy9Kd2xMQVdlSklpY0paVVJBQUFPQUFJa25EYjVFaVlvQkFTSXJaVVJFSWljRlpVUWlKd3RsUkF4RU1nY2lKd3hsUkF4RU1nY2lKd2RsUkF4RWkvODRCeklLRWtTTC96Z0lJaWNLWlVRUFJDSW5CV1ZFSXdnbkJVeG5JaWNJWlVRakNDY0lUR2V4TWdxTC96Z0FNZ3BKc2l5eUs3SXFzaW1BRkdsd1puTTZMeTlqWVcxd2RYTXRkR2xqYTJWMHNpZUFBMVJKV0xJbGdBeEZkbVZ1ZENCVWFXTnJaWFN5SmlLeUl5T3lJb0VEc2hBaXNnR3p0RHlKaWdFQWkvOXhDRVF4QUJKRU1RQ0wvM0FBUlFGRXNUSUtNUUNMLzdJUkk3SVNzaFN5RTRFRXNoQWlzZ0d6aVlvQ0FTSkhBb0FBUndJeEFFa2lLbVZFRWtjQ1FBQTBJaWxsVEl3RlJDS01CSXNFaXdVTWl3ZU1DRUVBSG9zRUZpY0dURkMrVEl3QlFRQlhpd0ZKRlNRU1JJc0dFa0VBU2lPTUNJc0lSRElISWljSFpVU0JnS01GQ0E1RWkvNkwvM0FBVEl3RFFRQW1pd01qRWtFQUh5TkVpLzhXU1l3QXZreU1Ba0VBQm9zQ0lsc1VSQ01XaXdCTXZ5T01BSWtpUXYvZWl3UWpDSXdFUXYrR2lnRUJpLzhXdmtBQUF5Sk1pWXNBSWxzakVreUppZ0FCSW9BQVNURUFTU0lxWlVRU1J3SkFBRFFpS1dWTWpBSkVJb3dCaXdHTEFneUxCSXdGUVFBZWl3RVdKd1pNVUw1TWpBQkJBQ0tMQUVrVkpCSkVpd01TUVFBVkk0d0Zpd1ZFSWl0bFJCUXJUR2NpSzJWRWpBQ0ppd0VqQ0l3QlF2KzdJaWNLWlVRaUp3dGxSQ0luQldWRUlpY0haVVFpSnd4bFJDSW5DR1ZFSWl0bFJJa2lLbVZFaVlvQkFTSkpLV1ZFaS84T1FRQUVNZ05NaVl2L0ZpY0dURkMrVEl3QVFRQUppd0JKRlNRU1JFeUpNZ05NaVNJcFpVU0ppZ0VCSW9BQVNTSXFaVVNML3hKQkFBUWpqQUNKSWlsbFRJd0NSQ0tNQVlzQml3SU1RUUFvaXdFV0p3Wk1VTDVNakFCQkFCR0xBRWtWSkJKRWkvOFNRUUFFSTR3QWlZc0JJd2lNQVVMLzBDS01BSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
