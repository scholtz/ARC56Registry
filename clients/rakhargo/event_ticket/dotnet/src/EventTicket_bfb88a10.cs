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

namespace Arc56.Generated.rakhargo.event_ticket.EventTicket_bfb88a10
{


    public class EventTicketProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EventTicketProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EventData : AVMObjectType
            {
                public Algorand.Address Organizer { get; set; }

                public ulong Price { get; set; }

                public ulong Supply { get; set; }

                public ulong TicketsAvailable { get; set; }

                public ulong AsaId { get; set; }

                public ulong IsActive { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrganizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOrganizer.From(Organizer);
                    ret.AddRange(vOrganizer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSupply = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSupply.From(Supply);
                    ret.AddRange(vSupply.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicketsAvailable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTicketsAvailable.From(TicketsAvailable);
                    ret.AddRange(vTicketsAvailable.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsaId.From(AsaId);
                    ret.AddRange(vAsaId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EventData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EventData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrganizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrganizer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrganizer = vOrganizer.ToValue();
                    if (valueOrganizer is Algorand.Address vOrganizerValue) { ret.Organizer = vOrganizerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSupply = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSupply.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSupply = vSupply.ToValue();
                    if (valueSupply is ulong vSupplyValue) { ret.Supply = vSupplyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicketsAvailable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTicketsAvailable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTicketsAvailable = vTicketsAvailable.ToValue();
                    if (valueTicketsAvailable is ulong vTicketsAvailableValue) { ret.TicketsAvailable = vTicketsAvailableValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsaId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsaId = vAsaId.ToValue();
                    if (valueAsaId is ulong vAsaIdValue) { ret.AsaId = vAsaIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is ulong vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EventData);
                }
                public bool Equals(EventData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EventData left, EventData right)
                {
                    return EqualityComparer<EventData>.Default.Equals(left, right);
                }
                public static bool operator !=(EventData left, EventData right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///[STEP 1] Membuat ASA baru dan mengembalikan ID-nya.
        ///Membuat Box agar Client tahu Box Reference.
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="supply"> </param>
        public async Task<ulong> InitializeEventAsa(string name, string symbol, ulong supply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 183, 248, 114 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyAbi.From(supply);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, supplyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InitializeEventAsa_Transactions(string name, string symbol, ulong supply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 183, 248, 114 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyAbi.From(supply);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, supplyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///[STEP 2] Menyelesaikan setup Box dengan data harga.
        ///Memerlukan ASA ID yang dihasilkan dari STEP 1. Klien HARUS menyertakan ASA ID ini di parameter 'boxes' pada App Call.
        ///</summary>
        /// <param name="asa_id"> </param>
        /// <param name="price"> </param>
        public async Task<ulong> FinalizeEventBox(ulong asa_id, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 104, 24, 191 };
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            var result = await base.CallApp(new List<object> { abiHandle, asa_idAbi, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FinalizeEventBox_Transactions(ulong asa_id, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 104, 24, 191 };
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            return await base.MakeTransactionList(new List<object> { abiHandle, asa_idAbi, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Membeli tiket untuk event yang diwakili oleh asa_id.
        ///Klien HARUS menyertakan ASA ID ini di parameter 'boxes' pada App Call.
        ///</summary>
        /// <param name="asa_id"> </param>
        /// <param name="payment"> </param>
        /// <param name="qty"> </param>
        public async Task<ulong> BuyTicket(PaymentTransaction payment, ulong asa_id, ulong qty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 110, 154, 153, 214 };
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);
            var qtyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); qtyAbi.From(qty);

            var result = await base.CallApp(new List<object> { abiHandle, asa_idAbi, payment, qtyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyTicket_Transactions(PaymentTransaction payment, ulong asa_id, ulong qty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 110, 154, 153, 214 };
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);
            var qtyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); qtyAbi.From(qty);

            return await base.MakeTransactionList(new List<object> { abiHandle, asa_idAbi, payment, qtyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Menggunakan (redeem) tiket. Aset ditransfer ke kontrak, lalu dibakar (burn).
        ///Klien HARUS menyertakan ASA ID ini di parameter 'boxes' pada App Call.
        ///</summary>
        /// <param name="ticket_xfer"> </param>
        /// <param name="qty"> </param>
        public async Task<string> RedeemTicket(AssetTransferTransaction ticket_xfer, ulong qty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { ticket_xfer });
            byte[] abiHandle = { 109, 217, 217, 69 };
            var qtyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); qtyAbi.From(qty);

            var result = await base.CallApp(new List<object> { abiHandle, ticket_xfer, qtyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RedeemTicket_Transactions(AssetTransferTransaction ticket_xfer, ulong qty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { ticket_xfer });
            byte[] abiHandle = { 109, 217, 217, 69 };
            var qtyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); qtyAbi.From(qty);

            return await base.MakeTransactionList(new List<object> { abiHandle, ticket_xfer, qtyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mengembalikan seluruh data Box untuk ASA ID tertentu.
        ///</summary>
        /// <param name="asa_id"> </param>
        public async Task<Structs.EventData> GetEventDetails(ulong asa_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 22, 136, 185 };
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);

            var result = await base.CallApp(new List<object> { abiHandle, asa_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EventData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEventDetails_Transactions(ulong asa_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 22, 136, 185 };
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asa_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Contoh view method.
        ///</summary>
        public async Task<ulong> GetMyEvents(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 27, 39, 198 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMyEvents_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 27, 39, 198 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXZlbnRUaWNrZXQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRXZlbnREYXRhIjpbeyJuYW1lIjoib3JnYW5pemVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdXBwbHkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidGlja2V0c19hdmFpbGFibGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNhX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlzX2FjdGl2ZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZV9ldmVudF9hc2EiLCJkZXNjIjoiW1NURVAgMV0gTWVtYnVhdCBBU0EgYmFydSBkYW4gbWVuZ2VtYmFsaWthbiBJRC1ueWEuXG5NZW1idWF0IEJveCBhZ2FyIENsaWVudCB0YWh1IEJveCBSZWZlcmVuY2UuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpbmFsaXplX2V2ZW50X2JveCIsImRlc2MiOiJbU1RFUCAyXSBNZW55ZWxlc2Fpa2FuIHNldHVwIEJveCBkZW5nYW4gZGF0YSBoYXJnYS5cbk1lbWVybHVrYW4gQVNBIElEIHlhbmcgZGloYXNpbGthbiBkYXJpIFNURVAgMS4gS2xpZW4gSEFSVVMgbWVueWVydGFrYW4gQVNBIElEIGluaSBkaSBwYXJhbWV0ZXIgJ2JveGVzJyBwYWRhIEFwcCBDYWxsLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc2FfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5X3RpY2tldCIsImRlc2MiOiJNZW1iZWxpIHRpa2V0IHVudHVrIGV2ZW50IHlhbmcgZGl3YWtpbGkgb2xlaCBhc2FfaWQuXG5LbGllbiBIQVJVUyBtZW55ZXJ0YWthbiBBU0EgSUQgaW5pIGRpIHBhcmFtZXRlciAnYm94ZXMnIHBhZGEgQXBwIENhbGwuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzYV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVkZWVtX3RpY2tldCIsImRlc2MiOiJNZW5nZ3VuYWthbiAocmVkZWVtKSB0aWtldC4gQXNldCBkaXRyYW5zZmVyIGtlIGtvbnRyYWssIGxhbHUgZGliYWthciAoYnVybikuXG5LbGllbiBIQVJVUyBtZW55ZXJ0YWthbiBBU0EgSUQgaW5pIGRpIHBhcmFtZXRlciAnYm94ZXMnIHBhZGEgQXBwIENhbGwuIiwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja2V0X3hmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ldmVudF9kZXRhaWxzIiwiZGVzYyI6Ik1lbmdlbWJhbGlrYW4gc2VsdXJ1aCBkYXRhIEJveCB1bnR1ayBBU0EgSUQgdGVydGVudHUuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzYV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkV2ZW50RGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9teV9ldmVudHMiLCJkZXNjIjoiQ29udG9oIHZpZXcgbWV0aG9kLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjk4XSwiZXJyb3JNZXNzYWdlIjoiQVNBIElEIGJlbHVtIGRpaW5pc2lhbGlzYXNpIG9sZWggaW5pdGlhbGl6ZV9ldmVudF9hc2EuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc4XSwiZXJyb3JNZXNzYWdlIjoiRXZlbnQgQVNBIElEIHRpZGFrIGRpdGVtdWthbi4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODgsNTIxXSwiZXJyb3JNZXNzYWdlIjoiRXZlbnQgYmVsdW0gYWt0aWYuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA3XSwiZXJyb3JNZXNzYWdlIjoiRXZlbnQgc3VkYWggZGlpbmlzaWFsaXNhc2kuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE1XSwiZXJyb3JNZXNzYWdlIjoiRXZlbnQgdGlkYWsgZGl0ZW11a2FuLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNV0sImVycm9yTWVzc2FnZSI6IkhhbnlhIE9yZ2FuaXplciB5YW5nIGRhcGF0IG1lbnllbGVzYWlrYW4gaW5pc2lhbGlzYXNpLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyOV0sImVycm9yTWVzc2FnZSI6Ikp1bWxhaCBwZW1iYXlhcmFuIHNhbGFoLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzN10sImVycm9yTWVzc2FnZSI6Ikp1bWxhaCByZWRlZW0gdGlkYWsgc2VzdWFpLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgT3B0SW4gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMV0sImVycm9yTWVzc2FnZSI6IlBlbWJheWFyYW4gaGFydXMga2UgYWxhbWF0IFBsYXRmb3JtLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyOV0sImVycm9yTWVzc2FnZSI6IlBlbmVyaW1hIGFzZXQgaGFydXNsYWggUGxhdGZvcm0gaW5pLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxM10sImVycm9yTWVzc2FnZSI6IlN0b2sgdGlrZXQgaGFiaXMuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwXSwiZXJyb3JNZXNzYWdlIjoiU3VwcGx5IGhhcnVzIGxlYmloIGRhcmkgbm9sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEzXSwiZXJyb3JNZXNzYWdlIjoiVGlrZXQgZXZlbnQgdGlkYWsgdmFsaWQgYXRhdSB0aWRhayB0ZXJkYWZ0YXIgZGkgcGxhdGZvcm0uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI4LDYyN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZXZlbnRzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MSwxNThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDksMTY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NywyNzgsMjg4LDM0NywzNjYsNDk4LDYwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNThdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0NBMENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKbGRtVnVkSE5mWkdGMFlTSWdNSGd4TlRGbU4yTTNOU0FpZEc5MFlXeGZaWFpsYm5Seklnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hOQzB4TlFvZ0lDQWdMeThnSXlCSGJHOWlZV3dnVTNSdmNtRm5aUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlsZG1WdWRITWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlsZG1WdWRITWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hNZ29nSUNBZ0x5OGdZMnhoYzNNZ1JYWmxiblJVYVdOclpYUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxaR0kzWmpnM01pQXZMeUJ0WlhSb2IyUWdJbWx1YVhScFlXeHBlbVZmWlhabGJuUmZZWE5oS0hOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMEtYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmYVc1cGRHbGhiR2w2WlY5bGRtVnVkRjloYzJGZmNtOTFkR1ZBTlFvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qRXlDaUFnSUNBdkx5QmpiR0Z6Y3lCRmRtVnVkRlJwWTJ0bGRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVlUWTRNVGhpWmlBd2VEWmxPV0U1T1dRMklEQjRObVJrT1dRNU5EVWdNSGd6WkRFMk9EaGlPU0F3ZURRMk1XSXlOMk0ySUM4dklHMWxkR2h2WkNBaVptbHVZV3hwZW1WZlpYWmxiblJmWW05NEtIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ppZFhsZmRHbGphMlYwS0hWcGJuUTJOQ3h3WVhrc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21Wa1pXVnRYM1JwWTJ0bGRDaGhlR1psY2l4MWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZlpYWmxiblJmWkdWMFlXbHNjeWgxYVc1ME5qUXBLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5dGVWOWxkbVZ1ZEhNb0tYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHWnBibUZzYVhwbFgyVjJaVzUwWDJKdmVDQmlkWGxmZEdsamEyVjBJSEpsWkdWbGJWOTBhV05yWlhRZ1oyVjBYMlYyWlc1MFgyUmxkR0ZwYkhNZ1oyVjBYMjE1WDJWMlpXNTBjd29nSUNBZ1pYSnlDZ3B0WVdsdVgybHVhWFJwWVd4cGVtVmZaWFpsYm5SZllYTmhYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lkUGNIUkpiaWRkS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU5d2RFbHVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUM0IwU1c0Z0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZaUJwYm1sMGFXRnNhWHBsWDJWMlpXNTBYMkZ6WVFvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1WMlpXNTBYM1JwWTJ0bGRDNWpiMjUwY21GamRDNUZkbVZ1ZEZScFkydGxkQzVwYm1sMGFXRnNhWHBsWDJWMlpXNTBYMkZ6WVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVhWFJwWVd4cGVtVmZaWFpsYm5SZllYTmhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzblQzQjBTVzRuWFNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdZWE56WlhKMElITjFjSEJzZVNBK0lGVkpiblEyTkNnd0tTd2dJbE4xY0hCc2VTQm9ZWEoxY3lCc1pXSnBhQ0JrWVhKcElHNXZiQ0lLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklGTjFjSEJzZVNCb1lYSjFjeUJzWldKcGFDQmtZWEpwSUc1dmJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG96TUMwek9Rb2dJQ0FnTHk4Z0l5QXhMaUJKYm01bGNpQlVjbUZ1YzJGamRHbHZiam9nUW5WaGRDQkJVMEVnVkdsclpYUWdRbUZ5ZFFvZ0lDQWdMeThnY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDF6ZFhCd2JIa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQxdVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxemVXMWliMndzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG96TmdvZ0lDQWdMeThnWTJ4aGQySmhZMnM5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qTTNMVE00Q2lBZ0lDQXZMeUJ0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUTJ4aGQySmhZMnNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHUmxZMmx0WVd4elBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVmJtbDBUbUZ0WlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGUnZkR0ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qTXdMVE14Q2lBZ0lDQXZMeUFqSURFdUlFbHVibVZ5SUZSeVlXNXpZV04wYVc5dU9pQkNkV0YwSUVGVFFTQlVhV3RsZENCQ1lYSjFDaUFnSUNBdkx5QnlaWE4xYkhRZ1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG96TUMwek9Rb2dJQ0FnTHk4Z0l5QXhMaUJKYm01bGNpQlVjbUZ1YzJGamRHbHZiam9nUW5WaGRDQkJVMEVnVkdsclpYUWdRbUZ5ZFFvZ0lDQWdMeThnY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDF6ZFhCd2JIa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQxdVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxemVXMWliMndzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRnpjMlYwU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZORE10TkRnS0lDQWdJQzh2SUNNZ01pNGdTVzV1WlhJZ1ZISmhibk5oWTNScGIyNDZJRTl3ZEMxSmJpQkxiMjUwY21GcklHdGxJRUZUUVNCNVlXNW5JR0poY25VZ1pHbGlkV0YwSUNoWFlXcHBZaWtLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0c1bGQxOWhjMkZmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRBS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFRBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk5ETXRORFFLSUNBZ0lDOHZJQ01nTWk0Z1NXNXVaWElnVkhKaGJuTmhZM1JwYjI0NklFOXdkQzFKYmlCTGIyNTBjbUZySUd0bElFRlRRU0I1WVc1bklHSmhjblVnWkdsaWRXRjBJQ2hYWVdwcFlpa0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMEwyTnZiblJ5WVdOMExuQjVPalF6TFRRNENpQWdJQ0F2THlBaklESXVJRWx1Ym1WeUlGUnlZVzV6WVdOMGFXOXVPaUJQY0hRdFNXNGdTMjl1ZEhKaGF5QnJaU0JCVTBFZ2VXRnVaeUJpWVhKMUlHUnBZblZoZENBb1YyRnFhV0lwQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENodVpYZGZZWE5oWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdiM0puWVc1cGVtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCd2NtbGpaVDFWU1c1ME5qUW9NQ2tzSUNNZ1RtbHNZV2tnWkdWbVlYVnNkQ3dnWkdscGMya2daR2tnYzNSbGNDQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG8xTUMwMU9Rb2dJQ0FnTHk4Z0l5QXpMaUJOWlcxaWRXRjBJRUp2ZURvZ1RXVnVlV1ZrYVdGcllXNGdjMlZ0ZFdFZ1ptbGxiR1FnVTNSeWRXTjBJSFZ1ZEhWcklHbHVhWE5wWVd4cGMyRnphU0JDYjNnS0lDQWdJQzh2SUNNZ1MzVnVZMmtnUW05NElHRmtZV3hoYUNCdVpYZGZZWE5oWDJsa0NpQWdJQ0F2THlCbGRtVnVkRjlrWVhSaElEMGdSWFpsYm5SRVlYUmhLQW9nSUNBZ0x5OGdJQ0FnSUc5eVoyRnVhWHBsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEJ5YVdObFBWVkpiblEyTkNnd0tTd2dJeUJPYVd4aGFTQmtaV1poZFd4MExDQmthV2x6YVNCa2FTQnpkR1Z3SURJS0lDQWdJQzh2SUNBZ0lDQnpkWEJ3YkhrOWMzVndjR3g1TENBZ0l5QlRkRzlySUdGM1lXd0tJQ0FnSUM4dklDQWdJQ0IwYVdOclpYUnpYMkYyWVdsc1lXSnNaVDF6ZFhCd2JIa3NJQ01nVTNSdmF5QnpZV0YwSUdsdWFRb2dJQ0FnTHk4Z0lDQWdJR0Z6WVY5cFpEMXVaWGRmWVhOaFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUdselgyRmpkR2wyWlQxVlNXNTBOalFvTUNrZ0l5QlVZVzVrWVdrZ1ltVnNkVzBnWVd0MGFXWUtJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pZeENpQWdJQ0F2THlCelpXeG1MbVYyWlc1MGMxOWtZWFJoVzI1bGQxOWhjMkZmYVdSZElEMGdaWFpsYm5SZlpHRjBZUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVjJaVzUwYzE5a1lYUmhJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNuVDNCMFNXNG5YU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpYWmxiblJmZEdsamEyVjBMbU52Ym5SeVlXTjBMa1YyWlc1MFZHbGphMlYwTG1acGJtRnNhWHBsWDJWMlpXNTBYMkp2ZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtWnBibUZzYVhwbFgyVjJaVzUwWDJKdmVEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUXZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRvM055MDNPQW9nSUNBZ0x5OGdJeUF4TGlCQmJXSnBiQ0JFWVhSaElFVjJaVzUwSUdSaGNta2dRbTk0VFdGd0lDaENiM2dnYzNWa1lXZ2daR2xpZFdGMElHUnBJSE4wWlhBZ01Ta0tJQ0FnSUM4dklHVjRhWE4wY3lBOUlITmxiR1l1WlhabGJuUnpYMlJoZEdFdWJXRjVZbVVvWVhOaFgybGtLVnN4WFFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhabGJuUnpYMlJoZEdFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6TENBaVFWTkJJRWxFSUdKbGJIVnRJR1JwYVc1cGMybGhiR2x6WVhOcElHOXNaV2dnYVc1cGRHbGhiR2w2WlY5bGRtVnVkRjloYzJFdUlnb2dJQ0FnWVhOelpYSjBJQzh2SUVGVFFTQkpSQ0JpWld4MWJTQmthV2x1YVhOcFlXeHBjMkZ6YVNCdmJHVm9JR2x1YVhScFlXeHBlbVZmWlhabGJuUmZZWE5oTGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdaWFpsYm5SZlpHRjBZU0E5SUhObGJHWXVaWFpsYm5SelgyUmhkR0V1YldGNVltVW9ZWE5oWDJsa0tWc3dYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCaGMzTmxjblFnWlhabGJuUmZaR0YwWVM1cGMxOWhZM1JwZG1VZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpUlhabGJuUWdjM1ZrWVdnZ1pHbHBibWx6YVdGc2FYTmhjMmt1SWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEWTBJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVYyWlc1MElITjFaR0ZvSUdScGFXNXBjMmxoYkdsellYTnBMZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z1lYTnpaWEowSUdWMlpXNTBYMlJoZEdFdWIzSm5ZVzVwZW1WeUlEMDlJRlI0Ymk1elpXNWtaWElzSUNKSVlXNTVZU0JQY21kaGJtbDZaWElnZVdGdVp5QmtZWEJoZENCdFpXNTVaV3hsYzJGcGEyRnVJR2x1YVhOcFlXeHBjMkZ6YVM0aUNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSVlXNTVZU0JQY21kaGJtbDZaWElnZVdGdVp5QmtZWEJoZENCdFpXNTVaV3hsYzJGcGEyRnVJR2x1YVhOcFlXeHBjMkZ6YVM0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZPRFV0T0RZS0lDQWdJQzh2SUNNZ01pNGdSbWx1WVd4cGMyRnphU0JFWVhSaElFSnZlQW9nSUNBZ0x5OGdaWFpsYm5SZlpHRjBZUzV3Y21salpTQTlJSEJ5YVdObENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pnM0NpQWdJQ0F2THlCbGRtVnVkRjlrWVhSaExtbHpYMkZqZEdsMlpTQTlJRlZKYm5RMk5DZ3hLU0FqSUZSaGJtUmhhU0J6WldKaFoyRnBJR0ZyZEdsbUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk9Ea3RPVEFLSUNBZ0lDOHZJQ01nTXk0Z1UybHRjR0Z1SUd0bGJXSmhiR2tnUW05NElIbGhibWNnYzNWa1lXZ2daR2x0YjJScFptbHJZWE5wQ2lBZ0lDQXZMeUJ6Wld4bUxtVjJaVzUwYzE5a1lYUmhXMkZ6WVY5cFpGMGdQU0JsZG1WdWRGOWtZWFJoTG1OdmNIa29LUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUbzVNaTA1TXdvZ0lDQWdMeThnSXlBMExpQlZjR1JoZEdVZ1IyeHZZbUZzSUZOMFlYUmxJQ2hJYVhSMWJtZGhiaUJGZG1WdWRDa0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaWFpsYm5SekxuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlsZG1WdWRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZaWFpsYm5SeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDJWMlpXNTBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1WMlpXNTBYM1JwWTJ0bGRDNWpiMjUwY21GamRDNUZkbVZ1ZEZScFkydGxkQzVpZFhsZmRHbGphMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1luVjVYM1JwWTJ0bGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUXZZMjl1ZEhKaFkzUXVjSGs2T1RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG94TURrdE1URXdDaUFnSUNBdkx5QWpJREV1SUVGdFltbHNJRVJoZEdFZ1JYWmxiblFnWkdGeWFTQkNiM2hOWVhBS0lDQWdJQzh2SUdWNGFYTjBjeUE5SUhObGJHWXVaWFpsYm5SelgyUmhkR0V1YldGNVltVW9ZWE5oWDJsa0tWc3hYUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVYyWlc1MGMxOWtZWFJoSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKRmRtVnVkQ0JCVTBFZ1NVUWdkR2xrWVdzZ1pHbDBaVzExYTJGdUxpSUtJQ0FnSUdGemMyVnlkQ0F2THlCRmRtVnVkQ0JCVTBFZ1NVUWdkR2xrWVdzZ1pHbDBaVzExYTJGdUxnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG94TVRJS0lDQWdJQzh2SUdWMlpXNTBYMlJoZEdFZ1BTQnpaV3htTG1WMlpXNTBjMTlrWVhSaExtMWhlV0psS0dGellWOXBaQ2xiTUYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxkbVZ1ZEY5a1lYUmhMbWx6WDJGamRHbDJaU0E5UFNCVlNXNTBOalFvTVNrc0lDSkZkbVZ1ZENCaVpXeDFiU0JoYTNScFppNGlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmRtVnVkQ0JpWld4MWJTQmhhM1JwWmk0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZNVEUyQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYM04xY0hCc2VTQTlJR1YyWlc1MFgyUmhkR0V1ZEdsamEyVjBjMTloZG1GcGJHRmliR1VLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME9DQXZMeUEwT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUJ3Y21salpTQTlJR1YyWlc1MFgyUmhkR0V1Y0hKcFkyVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJRzl5WjJGdWFYcGxjaUE5SUdWMlpXNTBYMlJoZEdFdWIzSm5ZVzVwZW1WeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMEwyTnZiblJ5WVdOMExuQjVPakV5TUMweE1qRUtJQ0FnSUM4dklDTWdNaTRnVm1Gc2FXUmhjMmtnVUdWdFltVnNhV0Z1Q2lBZ0lDQXZMeUIwYjNSaGJGOXVaV1ZrWldRZ1BTQnhkSGtnS2lCd2NtbGpaUW9nSUNBZ1pHbG5JRFVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hNaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpkWEp5Wlc1MFgzTjFjSEJzZVNBK1BTQnhkSGtzSUNKVGRHOXJJSFJwYTJWMElHaGhZbWx6TGlJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ05nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJUZEc5cklIUnBhMlYwSUdoaFltbHpMZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSlFaVzFpWVhsaGNtRnVJR2hoY25WeklHdGxJR0ZzWVcxaGRDQlFiR0YwWm05eWJTNGlDaUFnSUNCa2FXY2dOZ29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmxiV0poZVdGeVlXNGdhR0Z5ZFhNZ2EyVWdZV3hoYldGMElGQnNZWFJtYjNKdExnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG94TWpRS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQTlQU0IwYjNSaGJGOXVaV1ZrWldRc0lDSktkVzFzWVdnZ2NHVnRZbUY1WVhKaGJpQnpZV3hoYUM0aUNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NuVnRiR0ZvSUhCbGJXSmhlV0Z5WVc0Z2MyRnNZV2d1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qRXlOaTB4TXpBS0lDQWdJQzh2SUNNZ015NGdTVzV1WlhJZ1ZISmhibk5oWTNScGIyNDZJRlJ5WVc1elptVnlJRUZNUjA4Z2EyVWdUM0puWVc1cGVtVnlDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWIzSm5ZVzVwZW1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMTBiM1JoYkY5dVpXVmtaV1FLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pFeU5pMHhNamNLSUNBZ0lDOHZJQ01nTXk0Z1NXNXVaWElnVkhKaGJuTmhZM1JwYjI0NklGUnlZVzV6Wm1WeUlFRk1SMDhnYTJVZ1QzSm5ZVzVwZW1WeUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZNVEkyTFRFek1Bb2dJQ0FnTHk4Z0l5QXpMaUJKYm01bGNpQlVjbUZ1YzJGamRHbHZiam9nVkhKaGJuTm1aWElnUVV4SFR5QnJaU0JQY21kaGJtbDZaWElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXZjbWRoYm1sNlpYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWFJ2ZEdGc1gyNWxaV1JsWkFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk1UTXlMVEV6TndvZ0lDQWdMeThnSXlBMExpQkpibTVsY2lCVWNtRnVjMkZqZEdsdmJqb2dWSEpoYm5ObVpYSWdRVk5CSUZScGEyVjBJR3RsSUZCbGJXSmxiR2tnS0UxcGJuUnBibWNwQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoaGMyRmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0lDTWdVR1Z0WW1Wc2FTQW9jR1Z1WjJseWFXMGdWSGh1SUdkeWIzVndLUW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXhkSGtLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUXZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TENBaklGQmxiV0psYkdrZ0tIQmxibWRwY21sdElGUjRiaUJuY205MWNDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk1UTXlMVEV6TXdvZ0lDQWdMeThnSXlBMExpQkpibTVsY2lCVWNtRnVjMkZqZEdsdmJqb2dWSEpoYm5ObVpYSWdRVk5CSUZScGEyVjBJR3RsSUZCbGJXSmxiR2tnS0UxcGJuUnBibWNwQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRveE16SXRNVE0zQ2lBZ0lDQXZMeUFqSURRdUlFbHVibVZ5SUZSeVlXNXpZV04wYVc5dU9pQlVjbUZ1YzJabGNpQkJVMEVnVkdsclpYUWdhMlVnVUdWdFltVnNhU0FvVFdsdWRHbHVaeWtLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0dGellWOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3Z0l5QlFaVzFpWld4cElDaHdaVzVuYVhKcGJTQlVlRzRnWjNKdmRYQXBDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYRjBlUW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUXZZMjl1ZEhKaFkzUXVjSGs2TVRNNUxURTBNQW9nSUNBZ0x5OGdJeUExTGlCVmNHUmhkR1VnUW05NE9pQkxkWEpoYm1kcElITjBiMnNnZEdsclpYUUtJQ0FnSUM4dklHVjJaVzUwWDJSaGRHRXVkR2xqYTJWMGMxOWhkbUZwYkdGaWJHVWdMVDBnY1hSNUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURRNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMEwyTnZiblJ5WVdOMExuQjVPakUwTVFvZ0lDQWdMeThnYzJWc1ppNWxkbVZ1ZEhOZlpHRjBZVnRoYzJGZmFXUmRJRDBnWlhabGJuUmZaR0YwWVM1amIzQjVLQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMEwyTnZiblJ5WVdOMExuQjVPakUwTXdvZ0lDQWdMeThnY21WMGRYSnVJR1YyWlc1MFgyUmhkR0V1ZEdsamEyVjBjMTloZG1GcGJHRmliR1VLSUNBZ0lHVjRkSEpoWTNRZ05EZ2dPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVsZG1WdWRGOTBhV05yWlhRdVkyOXVkSEpoWTNRdVJYWmxiblJVYVdOclpYUXVjbVZrWldWdFgzUnBZMnRsZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxaR1ZsYlY5MGFXTnJaWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6TWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hOekF0TVRjeENpQWdJQ0F2THlBaklERXVJRlpoYkdsa1lYTnBJRlJ5WVc1elptVnlJRlJwYTJWMElHdGxJRXR2Ym5SeVlXc0tJQ0FnSUM4dklIUnBZMnRsZEY5aGMyRmZhV1FnUFNCMGFXTnJaWFJmZUdabGNpNTRabVZ5WDJGemMyVjBMbWxrQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMEwyTnZiblJ5WVdOMExuQjVPakUzTXdvZ0lDQWdMeThnWlhocGMzUnpJRDBnYzJWc1ppNWxkbVZ1ZEhOZlpHRjBZUzV0WVhsaVpTaDBhV05yWlhSZllYTmhYMmxrS1ZzeFhRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGRtVnVkSE5mWkdGMFlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZNVGMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlWR2xyWlhRZ1pYWmxiblFnZEdsa1lXc2dkbUZzYVdRZ1lYUmhkU0IwYVdSaGF5QjBaWEprWVdaMFlYSWdaR2tnY0d4aGRHWnZjbTB1SWdvZ0lDQWdZWE56WlhKMElDOHZJRlJwYTJWMElHVjJaVzUwSUhScFpHRnJJSFpoYkdsa0lHRjBZWFVnZEdsa1lXc2dkR1Z5WkdGbWRHRnlJR1JwSUhCc1lYUm1iM0p0TGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hOellLSUNBZ0lDOHZJR1YyWlc1MFgyUmhkR0VnUFNCelpXeG1MbVYyWlc1MGMxOWtZWFJoTG0xaGVXSmxLSFJwWTJ0bGRGOWhjMkZmYVdRcFd6QmRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pFM053b2dJQ0FnTHk4Z1lYTnpaWEowSUdWMlpXNTBYMlJoZEdFdWFYTmZZV04wYVhabElEMDlJRlZKYm5RMk5DZ3hLU3dnSWtWMlpXNTBJR0psYkhWdElHRnJkR2xtTGlJS0lDQWdJSEIxYzJocGJuUWdOalFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGZG1WdWRDQmlaV3gxYlNCaGEzUnBaaTRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk1UZ3dDaUFnSUNBdkx5QmhjM05sY25RZ2RHbGphMlYwWDNobVpYSXVZWE56WlhSZmNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJbEJsYm1WeWFXMWhJR0Z6WlhRZ2FHRnlkWE5zWVdnZ1VHeGhkR1p2Y20wZ2FXNXBMaUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVpXNWxjbWx0WVNCaGMyVjBJR2hoY25WemJHRm9JRkJzWVhSbWIzSnRJR2x1YVM0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZNVGd4Q2lBZ0lDQXZMeUJoYzNObGNuUWdkR2xqYTJWMFgzaG1aWEl1WVhOelpYUmZZVzF2ZFc1MElEMDlJSEYwZVN3Z0lrcDFiV3hoYUNCeVpXUmxaVzBnZEdsa1lXc2djMlZ6ZFdGcExpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVwMWJXeGhhQ0J5WldSbFpXMGdkR2xrWVdzZ2MyVnpkV0ZwTGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJSHBsY205ZllXUmtjbVZ6Y3lBOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEM5amIyNTBjbUZqZEM1d2VUb3hOVFF0TVRVNUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaGhjM05sZEY5cFpDa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5elpXNWtaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajE2WlhKdlgyRmtaSEpsYzNNS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFF2WTI5dWRISmhZM1F1Y0hrNk1UVTNDaUFnSUNBdkx5QmhjM05sZEY5elpXNWtaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFUyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwTDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh6SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUXZZMjl1ZEhKaFkzUXVjSGs2TVRVMExURTFPUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvWVhOelpYUmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjMlZ1WkdWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWVtVnliMTloWkdSeVpYTnpDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG94TmpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBeFpEVXlOalUyTkRZMU5qVTJaREl3TmpRMk1UWmxNakEwTWpjMU56STJaVEl3TlRRMk9UWmlOalUzTkRJd056TTNOVFppTnpNMk5UY3pNbVVLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1bGRtVnVkRjkwYVdOclpYUXVZMjl1ZEhKaFkzUXVSWFpsYm5SVWFXTnJaWFF1WjJWMFgyVjJaVzUwWDJSbGRHRnBiSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZaWFpsYm5SZlpHVjBZV2xzY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhRdlkyOXVkSEpoWTNRdWNIazZNVGt3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMEwyTnZiblJ5WVdOMExuQjVPakU1TXdvZ0lDQWdMeThnWlhocGMzUnpJRDBnYzJWc1ppNWxkbVZ1ZEhOZlpHRjBZUzV0WVhsaVpTaGhjMkZmYVdRcFd6RmRDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxkbVZ1ZEhOZlpHRjBZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUXZZMjl1ZEhKaFkzUXVjSGs2TVRrMENpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpUlhabGJuUWdkR2xrWVdzZ1pHbDBaVzExYTJGdUxpSUtJQ0FnSUdGemMyVnlkQ0F2THlCRmRtVnVkQ0IwYVdSaGF5QmthWFJsYlhWcllXNHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBMMk52Ym5SeVlXTjBMbkI1T2pFNU5Rb2dJQ0FnTHk4Z1pYWmxiblJmWkdGMFlTQTlJSE5sYkdZdVpYWmxiblJ6WDJSaGRHRXViV0Y1WW1Vb1lYTmhYMmxrS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRDOWpiMjUwY21GamRDNXdlVG94T1RBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaWFpsYm5SZmRHbGphMlYwTG1OdmJuUnlZV04wTGtWMlpXNTBWR2xqYTJWMExtZGxkRjl0ZVY5bGRtVnVkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZiWGxmWlhabGJuUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkQzlqYjI1MGNtRmpkQzV3ZVRveU1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblJ2ZEdGc1gyVjJaVzUwY3k1MllXeDFaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDJWMlpXNTBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlsZG1WdWRITWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMEwyTnZiblJ5WVdOMExuQjVPakU1T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBSUJDWURDMlYyWlc1MGMxOWtZWFJoQkJVZmZIVU1kRzkwWVd4ZlpYWmxiblJ6TVJoQUFBTXFJMmN4RzBFQVNvQUU3YmY0Y2pZYUFJNEJBREl4R1JSRU1SaEVnZ1VFdW1nWXZ3UnVtcG5XQkczWjJVVUVQUmFJdVFSR0d5ZkdOaG9BamdVQW5RRGlBVzhCNUFIK0FERVpJaEl4R0JCRVFnQUtNUmtVTVJnVUVFUWlRellhQVVraldZRUNDRXNCRlJKRVZ3SUFOaG9DU1NOWmdRSUlTd0VWRWtSWEFnQTJHZ05KRlNRU1JCZEpSTEV5Q2tjQ3NpcXlLYklzSTdJalRMSWxUTEltU2JJaWdRT3lFQ095QWJPMFBMRXlDaU95RXJJVVNiSVJKYklRSTdJQnN6RUFJeFpNU3dGUVR3TVdURXNCVUV4UVR3SVdURXNCVUU4Q1VDaExBbEJNdnlsTVVMQWlRellhQVVrVkpCSkVTUmMyR2dKSkZTUVNSRXdXS0V4UVNiMUZBVVJKdmtoSmdVQmJGRVJKVndBZ01RQVNSRThDWENBaUZseEF2eU1xWlVRaUNDcE1aeWxNVUxBaVF6WWFBVWtWSkJKRUZ6RVdJZ2xKT0JBaUVrUTJHZ0pKRlNRU1JCZExBaFlvVEZCSnZVVUJSRW0rU0VtQlFGc2lFa1JKZ1RCYlN3R0JJRnRMQWxjQUlFc0ZUd0lMU3dKTEJnOUVTd1k0QnpJS0VrUlBCamdJU3dFU1JMR3lDTElISXJJUUk3SUJzN0V4QUVzRXNoS3lGRThFc2hFbHNoQWpzZ0d6VHdNSkZsd3dURXNCdjFjd0NDbE1VTEFpUXpFV0lnbEpPQkFsRWtRMkdnRkpGU1FTUkJkTEFUZ1JTUllvVEZCSnZVVUJSTDVJZ1VCYkloSkVTd0k0RkRJS0VrUlBBamdTU3dJU1JESURzVElLc2hPeUZMSVJzaElsc2hBanNnR3pnQ01WSDN4MUFCMVNaV1JsWlcwZ1pHRnVJRUoxY200Z1ZHbHJaWFFnYzNWcmMyVnpMckFpUXpZYUFVa1ZKQkpFRnhZb1RGQkp2VVVCUkw1SUtVeFFzQ0pESXlwbFJCWXBURkN3SWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjQsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
