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

namespace Arc56.Generated.atsoc1993.On_Chain_Petitions_V2.Petition_f12fa825
{


    public class PetitionProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PetitionProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ChildPetitionDetails : AVMObjectType
            {
                public byte[] PetitionTitle { get; set; }

                public byte[] PetitionText { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPetitionTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vPetitionTitle.From(PetitionTitle);
                    ret.AddRange(vPetitionTitle.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPetitionText = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vPetitionText.From(PetitionText);
                    ret.AddRange(vPetitionText.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ChildPetitionDetails Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ChildPetitionDetails();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPetitionTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vPetitionTitle.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePetitionTitle = vPetitionTitle.ToValue();
                    if (valuePetitionTitle is byte[] vPetitionTitleValue) { ret.PetitionTitle = vPetitionTitleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPetitionText = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vPetitionText.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePetitionText = vPetitionText.ToValue();
                    if (valuePetitionText is byte[] vPetitionTextValue) { ret.PetitionText = vPetitionTextValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ChildPetitionDetails);
                }
                public bool Equals(ChildPetitionDetails? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ChildPetitionDetails left, ChildPetitionDetails right)
                {
                    return EqualityComparer<ChildPetitionDetails>.Default.Equals(left, right);
                }
                public static bool operator !=(ChildPetitionDetails left, ChildPetitionDetails right)
                {
                    return !(left == right);
                }

            }

            public class Comment : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public ulong Time { get; set; }

                public byte[] Comment { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTime.From(Time);
                    ret.AddRange(vTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vComment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vComment.From(Comment);
                    ret.AddRange(vComment.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Comment Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Comment();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTime = vTime.ToValue();
                    if (valueTime is ulong vTimeValue) { ret.Time = vTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vComment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vComment.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueComment = vComment.ToValue();
                    if (valueComment is byte[] vCommentValue) { ret.Comment = vCommentValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Comment);
                }
                public bool Equals(Comment? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Comment left, Comment right)
                {
                    return EqualityComparer<Comment>.Default.Equals(left, right);
                }
                public static bool operator !=(Comment left, Comment right)
                {
                    return !(left == right);
                }

            }

            public class Signee : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Signee Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Signee();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Signee);
                }
                public bool Equals(Signee? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Signee left, Signee right)
                {
                    return EqualityComparer<Signee>.Default.Equals(left, right);
                }
                public static bool operator !=(Signee left, Signee right)
                {
                    return !(left == right);
                }

            }

            public class TimeSigned : AVMObjectType
            {
                public ulong TimeSigned { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeSigned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimeSigned.From(TimeSigned);
                    ret.AddRange(vTimeSigned.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TimeSigned Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TimeSigned();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeSigned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimeSigned.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimeSigned = vTimeSigned.ToValue();
                    if (valueTimeSigned is ulong vTimeSignedValue) { ret.TimeSigned = vTimeSignedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TimeSigned);
                }
                public bool Equals(TimeSigned? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TimeSigned left, TimeSigned right)
                {
                    return EqualityComparer<TimeSigned>.Default.Equals(left, right);
                }
                public static bool operator !=(TimeSigned left, TimeSigned right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="petition_master"> </param>
        /// <param name="petition_creator"> </param>
        public async Task AssignMasterAndPetitionCreator(ulong petition_master, Address petition_creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { petition_master });
            byte petition_masterRefIndex = (byte)(_appRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { petition_creator });
            byte petition_creatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 31, 222, 248, 19 };
            var petition_masterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); petition_masterAbi.From(petition_master);
            var petition_creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); petition_creatorAbi.From(petition_creator);

            var result = await base.CallApp(new List<object> { abiHandle, petition_masterRefIndex, petition_creatorRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssignMasterAndPetitionCreator_Transactions(ulong petition_master, Address petition_creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { petition_master });
            byte petition_masterRefIndex = (byte)(_appRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { petition_creator });
            byte petition_creatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 31, 222, 248, 19 };
            var petition_masterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); petition_masterAbi.From(petition_master);
            var petition_creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); petition_creatorAbi.From(petition_creator);

            return await base.MakeTransactionList(new List<object> { abiHandle, petition_masterRefIndex, petition_creatorRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="petition_title"> </param>
        /// <param name="petition_text"> </param>
        /// <param name="mbr_payment"> </param>
        public async Task<ulong> CreatePetition(PaymentTransaction mbr_payment, byte[] petition_title, byte[] petition_text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 107, 25, 15, 62 };
            var petition_titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); petition_titleAbi.From(petition_title);
            var petition_textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); petition_textAbi.From(petition_text);

            var result = await base.CallApp(new List<object> { abiHandle, petition_titleAbi, petition_textAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreatePetition_Transactions(PaymentTransaction mbr_payment, byte[] petition_title, byte[] petition_text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 107, 25, 15, 62 };
            var petition_titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); petition_titleAbi.From(petition_title);
            var petition_textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); petition_textAbi.From(petition_text);

            return await base.MakeTransactionList(new List<object> { abiHandle, petition_titleAbi, petition_textAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="additional_text"> </param>
        /// <param name="mbr_payment"> </param>
        public async Task<ulong> AdditionalBoxCharactersOption(PaymentTransaction mbr_payment, byte[] additional_text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 5, 208, 164, 155 };
            var additional_textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); additional_textAbi.From(additional_text);

            var result = await base.CallApp(new List<object> { abiHandle, additional_textAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AdditionalBoxCharactersOption_Transactions(PaymentTransaction mbr_payment, byte[] additional_text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 5, 208, 164, 155 };
            var additional_textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); additional_textAbi.From(additional_text);

            return await base.MakeTransactionList(new List<object> { abiHandle, additional_textAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PrimePetition(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 126, 110, 129 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PrimePetition_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 126, 110, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="signer"> </param>
        /// <param name="mbr_payment"> </param>
        public async Task<ulong> SignPetition(PaymentTransaction mbr_payment, Algorand.Address signer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 39, 138, 10, 4 };
            var signerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); signerAbi.From(signer);

            var result = await base.CallApp(new List<object> { abiHandle, signerAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SignPetition_Transactions(PaymentTransaction mbr_payment, Algorand.Address signer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 39, 138, 10, 4 };
            var signerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); signerAbi.From(signer);

            return await base.MakeTransactionList(new List<object> { abiHandle, signerAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="text"> </param>
        /// <param name="mbr_payment"> </param>
        public async Task<ulong> AddComment(PaymentTransaction mbr_payment, byte[] text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 84, 150, 214, 18 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); textAbi.From(text);

            var result = await base.CallApp(new List<object> { abiHandle, textAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddComment_Transactions(PaymentTransaction mbr_payment, byte[] text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 84, 150, 214, 18 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); textAbi.From(text);

            return await base.MakeTransactionList(new List<object> { abiHandle, textAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGV0aXRpb24iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ2hpbGRQZXRpdGlvbkRldGFpbHMiOlt7Im5hbWUiOiJwZXRpdGlvbl90aXRsZSIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJwZXRpdGlvbl90ZXh0IiwidHlwZSI6ImJ5dGVbXSJ9XSwiQ29tbWVudCI6W3sibmFtZSI6ImFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29tbWVudCIsInR5cGUiOiJieXRlW10ifV0sIlNpZ25lZSI6W3sibmFtZSI6ImFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiVGltZVNpZ25lZCI6W3sibmFtZSI6InRpbWVfc2lnbmVkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2lnbl9tYXN0ZXJfYW5kX3BldGl0aW9uX2NyZWF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbGljYXRpb24iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXRpdGlvbl9tYXN0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXRpdGlvbl9jcmVhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9wZXRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXRpdGlvbl90aXRsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGV0aXRpb25fdGV4dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRpdGlvbmFsX2JveF9jaGFyYWN0ZXJzX29wdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRpdGlvbmFsX3RleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl9wYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJpbWVfcGV0aXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2lnbl9wZXRpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9jb21tZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl9wYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMDUsMjM1LDI2NSwyNzcsMzEwLDM0M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgVXBkYXRlQXBwbGljYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDIsNDgzLDUxNSw1MjcsNjM1LDY0NSw2ODUsNzEzXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTFdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDgsMjM4LDI2OCwyODAsMzEzLDM0NiwzNzFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzAzLDcyOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29tbWVudF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGV0aXRpb25fbWFzdGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNiw2MTYsNjc5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wZXRpdGlvbl9wcmltZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zaWduZWVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMSwyNTEsMjk2LDMyOV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ3WlhScGRHbHZiaTVRWlhScGRHbHZiaTVmWDJGc1oyOXdlVjlsYm5SeWVYQnZhVzUwWDNkcGRHaGZhVzVwZENncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWNHVjBhWFJwYjI1ZmNISnBiV1ZrSWlBaVkyOXRiV1Z1ZEY5amIzVnVkR1Z5SWlBd2VERTFNV1kzWXpjMUlEQjROakVnSW5OcFoyNWxaWE1pSUNKd1pYUnBkR2x2Ymw5dFlYTjBaWElpSUNKamNtVmhkR2x2Ymw5MGFXMWxJaUFpY0dWMGFYUnBiMjVmWTNKbFlYUnZjaUlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk1qVTFDaUFnSUNBdkx5QnpaV3htTG5OcFoyNWxaWE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5OcFoyNWxaWE1pQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNalUyQ2lBZ0lDQXZMeUJ6Wld4bUxtTnlaV0YwYVc5dVgzUnBiV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OeVpXRjBhVzl1WDNScGJXVWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk1qVTNDaUFnSUNBdkx5QnpaV3htTG5CbGRHbDBhVzl1WDIxaGMzUmxjaUE5SUVGd2NHeHBZMkYwYVc5dUtEQXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSndaWFJwZEdsdmJsOXRZWE4wWlhJaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TWpVNENpQWdJQ0F2THlCelpXeG1MbkJsZEdsMGFXOXVYMk55WldGMGIzSWdQU0JCWTJOdmRXNTBLQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbkJsZEdsMGFXOXVYMk55WldGMGIzSWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pJMk1Rb2dJQ0FnTHk4Z2MyVnNaaTVqYjIxdFpXNTBYMk52ZFc1MFpYSWdQU0JoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyOXRiV1Z1ZEY5amIzVnVkR1Z5SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNall6Q2lBZ0lDQXZMeUJ6Wld4bUxuQmxkR2wwYVc5dVgzQnlhVzFsWkNBOUlFWmhiSE5sQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3WlhScGRHbHZibDl3Y21sdFpXUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG95TlRNS0lDQWdJQzh2SUdOc1lYTnpJRkJsZEdsMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1USUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhNR1U0TVRnM01pQXdlREZtWkdWbU9ERXpJREI0Tm1JeE9UQm1NMlVnTUhnd05XUXdZVFE1WWlBd2VHVm1OMlUyWlRneElEQjRNamM0WVRCaE1EUWdNSGcxTkRrMlpEWXhNaUF2THlCdFpYUm9iMlFnSW5Wd1pHRjBaU2dwZG05cFpDSXNJRzFsZEdodlpDQWlZWE56YVdkdVgyMWhjM1JsY2w5aGJtUmZjR1YwYVhScGIyNWZZM0psWVhSdmNpaGhjSEJzYVdOaGRHbHZiaXhoWTJOdmRXNTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTnlaV0YwWlY5d1pYUnBkR2x2YmloaWVYUmxXMTBzWW5sMFpWdGRMSEJoZVNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1Ga1pHbDBhVzl1WVd4ZlltOTRYMk5vWVhKaFkzUmxjbk5mYjNCMGFXOXVLR0o1ZEdWYlhTeHdZWGtwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p3Y21sdFpWOXdaWFJwZEdsdmJpZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMybG5ibDl3WlhScGRHbHZiaWhoWkdSeVpYTnpMSEJoZVNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1Ga1pGOWpiMjF0Wlc1MEtHSjVkR1ZiWFN4d1lYa3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MWNHUmhkR1ZmY205MWRHVkFOU0J0WVdsdVgyRnpjMmxuYmw5dFlYTjBaWEpmWVc1a1gzQmxkR2wwYVc5dVgyTnlaV0YwYjNKZmNtOTFkR1ZBTmlCdFlXbHVYMk55WldGMFpWOXdaWFJwZEdsdmJsOXliM1YwWlVBM0lHMWhhVzVmWVdSa2FYUnBiMjVoYkY5aWIzaGZZMmhoY21GamRHVnljMTl2Y0hScGIyNWZjbTkxZEdWQU9DQnRZV2x1WDNCeWFXMWxYM0JsZEdsMGFXOXVYM0p2ZFhSbFFEa2diV0ZwYmw5emFXZHVYM0JsZEdsMGFXOXVYM0p2ZFhSbFFERXdJRzFoYVc1ZllXUmtYMk52YlcxbGJuUmZjbTkxZEdWQU1URUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TkRvS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TWpVekNpQWdJQ0F2THlCamJHRnpjeUJRWlhScGRHbHZiaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpHUmZZMjl0YldWdWRGOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk16a3pDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk1qVXpDaUFnSUNBdkx5QmpiR0Z6Y3lCUVpYUnBkR2x2YmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pNNU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJoWkdSZlkyOXRiV1Z1ZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6YVdkdVgzQmxkR2wwYVc5dVgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRvek5UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRveU5UTUtJQ0FnSUM4dklHTnNZWE56SUZCbGRHbDBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXpVMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSE5wWjI1ZmNHVjBhWFJwYjI0S0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY0hKcGJXVmZjR1YwYVhScGIyNWZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk16STRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnY0hKcGJXVmZjR1YwYVhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXUmthWFJwYjI1aGJGOWliM2hmWTJoaGNtRmpkR1Z5YzE5dmNIUnBiMjVmY205MWRHVkFPRG9LSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNekEyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNalV6Q2lBZ0lDQXZMeUJqYkdGemN5QlFaWFJwZEdsdmJpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRvek1EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWVdSa2FYUnBiMjVoYkY5aWIzaGZZMmhoY21GamRHVnljMTl2Y0hScGIyNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkzSmxZWFJsWDNCbGRHbDBhVzl1WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPakkzTlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPakkxTXdvZ0lDQWdMeThnWTJ4aGMzTWdVR1YwYVhScGIyNG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUb3lOelVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsWDNCbGRHbDBhVzl1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ6YzJsbmJsOXRZWE4wWlhKZllXNWtYM0JsZEdsMGFXOXVYMk55WldGMGIzSmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk1qWTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk1qVXpDaUFnSUNBdkx5QmpiR0Z6Y3lCUVpYUnBkR2x2YmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVhCd2JHbGpZWFJwYjI1ekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJZMk52ZFc1MGN3b2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRveU5qa0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWVhOemFXZHVYMjFoYzNSbGNsOWhibVJmY0dWMGFYUnBiMjVmWTNKbFlYUnZjZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TWpZMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lkVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlkZEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh5SUM4dklGVndaR0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV5T2dvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG95TlRNS0lDQWdJQzh2SUdOc1lYTnpJRkJsZEdsMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQmxkR2wwYVc5dUxuSmxablZ1WkY5bGVHTmxjM01vWlhoalpYTnpPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbkpsWm5WdVpGOWxlR05sYzNNNkNpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pndE9Rb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJ5WldaMWJtUmZaWGhqWlhOektHVjRZMlZ6Y3pvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qRXdMVEV6Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WlhoalpYTnpMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRveE1Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TVRBS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG94TUMweE13b2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXVjRZMlZ6Y3l3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ3WlhScGRHbHZiaTVRWlhScGRHbHZiaTUxY0dSaGRHVW9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVTZDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qSTJOd29nSUNBZ0x5OGdjMlZzWmk1cGMxOWpjbVZoZEc5eVgyOXlYMjFoYzNSbGNsOWpjbVZoZEc5eUtDa0tJQ0FnSUdOaGJHeHpkV0lnYVhOZlkzSmxZWFJ2Y2w5dmNsOXRZWE4wWlhKZlkzSmxZWFJ2Y2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnY0dWMGFYUnBiMjR1VUdWMGFYUnBiMjR1WVhOemFXZHVYMjFoYzNSbGNsOWhibVJmY0dWMGFYUnBiMjVmWTNKbFlYUnZjaWh3WlhScGRHbHZibDl0WVhOMFpYSTZJSFZwYm5RMk5Dd2djR1YwYVhScGIyNWZZM0psWVhSdmNqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnpjMmxuYmw5dFlYTjBaWEpmWVc1a1gzQmxkR2wwYVc5dVgyTnlaV0YwYjNJNkNpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pJMk9TMHlOekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCaGMzTnBaMjVmYldGemRHVnlYMkZ1WkY5d1pYUnBkR2x2Ymw5amNtVmhkRzl5S0hObGJHWXNJSEJsZEdsMGFXOXVYMjFoYzNSbGNqb2dRWEJ3YkdsallYUnBiMjRzSUhCbGRHbDBhVzl1WDJOeVpXRjBiM0k2SUVGalkyOTFiblFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk1qY3hDaUFnSUNBdkx5QnpaV3htTG1selgyTnlaV0YwYjNKZmIzSmZiV0Z6ZEdWeVgyTnlaV0YwYjNJb0tRb2dJQ0FnWTJGc2JITjFZaUJwYzE5amNtVmhkRzl5WDI5eVgyMWhjM1JsY2w5amNtVmhkRzl5Q2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPakkzTWdvZ0lDQWdMeThnYzJWc1ppNXdaWFJwZEdsdmJsOXRZWE4wWlhJZ1BTQndaWFJwZEdsdmJsOXRZWE4wWlhJS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5CbGRHbDBhVzl1WDIxaGMzUmxjaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNamN6Q2lBZ0lDQXZMeUJ6Wld4bUxuQmxkR2wwYVc5dVgyTnlaV0YwYjNJZ1BTQndaWFJwZEdsdmJsOWpjbVZoZEc5eUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKd1pYUnBkR2x2Ymw5amNtVmhkRzl5SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnY0dWMGFYUnBiMjR1VUdWMGFYUnBiMjR1WTNKbFlYUmxYM0JsZEdsMGFXOXVLSEJsZEdsMGFXOXVYM1JwZEd4bE9pQmllWFJsY3l3Z2NHVjBhWFJwYjI1ZmRHVjRkRG9nWW5sMFpYTXNJRzFpY2w5d1lYbHRaVzUwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1kzSmxZWFJsWDNCbGRHbDBhVzl1T2dvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG95TnpVdE1qZ3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWTNKbFlYUmxYM0JsZEdsMGFXOXVLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnY0dWMGFYUnBiMjVmZEdsMGJHVTZJRVI1Ym1GdGFXTkNlWFJsY3l3S0lDQWdJQzh2SUNBZ0lDQndaWFJwZEdsdmJsOTBaWGgwT2lCRWVXNWhiV2xqUW5sMFpYTXNDaUFnSUNBdkx5QWdJQ0FnYldKeVgzQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1TEFvZ0lDQWdMeThnS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNamd5Q2lBZ0lDQXZMeUJ6Wld4bUxtbHpYMk55WldGMGIzSmZiM0pmYldGemRHVnlYMk55WldGMGIzSW9LUW9nSUNBZ1kyRnNiSE4xWWlCcGMxOWpjbVZoZEc5eVgyOXlYMjFoYzNSbGNsOWpjbVZoZEc5eUNpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pJNE13b2dJQ0FnTHk4Z2MyVnNaaTV3WlhScGRHbHZibDlwYzE5dWIzUmZjSEpwYldWa0tDa0tJQ0FnSUdOaGJHeHpkV0lnY0dWMGFYUnBiMjVmYVhOZmJtOTBYM0J5YVcxbFpBb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRvMkNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeTV0YVc1ZlltRnNZVzVqWlFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVFdsdVFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pNd01TMHpNRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQkRhR2xzWkZCbGRHbDBhVzl1UkdWMFlXbHNjeWdLSUNBZ0lDOHZJQ0FnSUNCd1pYUnBkR2x2Ymw5MGFYUnNaVDF3WlhScGRHbHZibDkwYVhSc1pTNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdjR1YwYVhScGIyNWZkR1Y0ZEQxd1pYUnBkR2x2Ymw5MFpYaDBMbU52Y0hrb0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTkFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pJNU1Bb2dJQ0FnTHk4Z2MyVnNaaTV3WlhScGRHbHZibDlrWlhSaGFXeHpXMU4wY21sdVp5Z25JQ2NwWFNBOUlIQmxkR2wwYVc5dVgybHVabTh1WTI5d2VTZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQWlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TWpreENpQWdJQ0F2THlCelpXeG1MbU55WldGMGFXOXVYM1JwYldVZ1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTNKbFlYUnBiMjVmZEdsdFpTSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qWUtJQ0FnSUM4dklISmxkSFZ5YmlCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk1qazBDaUFnSUNBdkx5QnRZbkpmWTI5emRDQTlJSEJ2YzNSZmJXSnlJQzBnY0hKbFgyMWljZ29nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRveU9UVUtJQ0FnSUM4dklHVjRZMlZ6Y3lBOUlHMWljbDl3WVhsdFpXNTBMbUZ0YjNWdWRDQXRJRzFpY2w5amIzTjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkdsbklERUtJQ0FnSUMwS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TWprMkNpQWdJQ0F2THlCeVpXWjFibVJmWlhoalpYTnpLR1Y0WTJWemN6MWxlR05sYzNNcENpQWdJQ0JqWVd4c2MzVmlJSEpsWm5WdVpGOWxlR05sYzNNS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TWprM0NpQWdJQ0F2THlCeVpYUjFjbTRnYldKeVgyTnZjM1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSEJsZEdsMGFXOXVMbEJsZEdsMGFXOXVMbUZrWkdsMGFXOXVZV3hmWW05NFgyTm9ZWEpoWTNSbGNuTmZiM0IwYVc5dUtHRmtaR2wwYVc5dVlXeGZkR1Y0ZERvZ1lubDBaWE1zSUcxaWNsOXdZWGx0Wlc1ME9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tZV1JrYVhScGIyNWhiRjlpYjNoZlkyaGhjbUZqZEdWeWMxOXZjSFJwYjI0NkNpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pNd05pMHpNRGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCaFpHUnBkR2x2Ym1Gc1gySnZlRjlqYUdGeVlXTjBaWEp6WDI5d2RHbHZiaWh6Wld4bUxDQmhaR1JwZEdsdmJtRnNYM1JsZUhRNklFSjVkR1Z6TENCdFluSmZjR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0cElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG96TURnS0lDQWdJQzh2SUhObGJHWXVhWE5mWTNKbFlYUnZjbDl2Y2w5dFlYTjBaWEpmWTNKbFlYUnZjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHbHpYMk55WldGMGIzSmZiM0pmYldGemRHVnlYMk55WldGMGIzSUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk16QTVDaUFnSUNBdkx5QnpaV3htTG5CbGRHbDBhVzl1WDJselgyNXZkRjl3Y21sdFpXUW9LUW9nSUNBZ1kyRnNiSE4xWWlCd1pYUnBkR2x2Ymw5cGMxOXViM1JmY0hKcGJXVmtDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qTXhNUW9nSUNBZ0x5OGdZV1JrYVhScGIyNWhiRjlpYjNoZlpHVjBZV2xzY3lBOUlFSnZlRkpsWmloclpYazlZaWRoSnlrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMk1Rb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRvek1USUtJQ0FnSUM4dklHSnZlRjlzWlc1bmRHZ3NJR0p2ZUY5bGVHbHpkSE1nUFNCdmNDNUNiM2d1YkdWdVozUm9LR0ZrWkdsMGFXOXVZV3hmWW05NFgyUmxkR0ZwYkhNdWEyVjVLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG8yQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pNeE5Rb2dJQ0FnTHk4Z2FXWWdibTkwSUdKdmVGOWxlR2x6ZEhNNkNpQWdJQ0JpYm5vZ1lXUmthWFJwYjI1aGJGOWliM2hmWTJoaGNtRmpkR1Z5YzE5dmNIUnBiMjVmWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXpFeENpQWdJQ0F2THlCaFpHUnBkR2x2Ym1Gc1gySnZlRjlrWlhSaGFXeHpJRDBnUW05NFVtVm1LR3RsZVQxaUoyRW5LUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRFl4Q2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak14TmdvZ0lDQWdMeThnWVdSa2FYUnBiMjVoYkY5aWIzaGZaR1YwWVdsc2N5NXdkWFFvWVdSa2FYUnBiMjVoYkY5MFpYaDBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWIzaGZjSFYwQ2dwaFpHUnBkR2x2Ym1Gc1gySnZlRjlqYUdGeVlXTjBaWEp6WDI5d2RHbHZibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qWUtJQ0FnSUM4dklISmxkSFZ5YmlCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk16SXlDaUFnSUNBdkx5QnRZbkpmWTI5emRDQTlJSEJ2YzNSZmJXSnlJQzBnY0hKbFgyMWljZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUMwS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXpJekNpQWdJQ0F2THlCbGVHTmxjM01nUFNCdFluSmZjR0Y1YldWdWRDNWhiVzkxYm5RZ0xTQnRZbkpmWTI5emRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak15TkFvZ0lDQWdMeThnY21WbWRXNWtYMlY0WTJWemN5aGxlR05sYzNNOVpYaGpaWE56S1FvZ0lDQWdZMkZzYkhOMVlpQnlaV1oxYm1SZlpYaGpaWE56Q2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak15TlFvZ0lDQWdMeThnY21WMGRYSnVJRzFpY2w5amIzTjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWVdSa2FYUnBiMjVoYkY5aWIzaGZZMmhoY21GamRHVnljMTl2Y0hScGIyNWZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak14T0FvZ0lDQWdMeThnWVdSa2FYUnBiMjVoYkY5aWIzaGZaR1YwWVdsc2N5NXlaWE5wZW1Vb1ltOTRYMnhsYm1kMGFDQXJJR0ZrWkdsMGFXOXVZV3hmZEdWNGRDNXNaVzVuZEdncENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak14TVFvZ0lDQWdMeThnWVdSa2FYUnBiMjVoYkY5aWIzaGZaR1YwWVdsc2N5QTlJRUp2ZUZKbFppaHJaWGs5WWlkaEp5a0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzJNUW9nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUb3pNVGdLSUNBZ0lDOHZJR0ZrWkdsMGFXOXVZV3hmWW05NFgyUmxkR0ZwYkhNdWNtVnphWHBsS0dKdmVGOXNaVzVuZEdnZ0t5QmhaR1JwZEdsdmJtRnNYM1JsZUhRdWJHVnVaM1JvS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGMybDZaUW9nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUb3pNVEVLSUNBZ0lDOHZJR0ZrWkdsMGFXOXVZV3hmWW05NFgyUmxkR0ZwYkhNZ1BTQkNiM2hTWldZb2EyVjVQV0luWVNjcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5qRUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk16RTVDaUFnSUNBdkx5QmhaR1JwZEdsdmJtRnNYMkp2ZUY5a1pYUmhhV3h6TG5KbGNHeGhZMlVvWW05NFgyeGxibWQwYUN3Z1lXUmthWFJwYjI1aGJGOTBaWGgwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ1lpQmhaR1JwZEdsdmJtRnNYMkp2ZUY5amFHRnlZV04wWlhKelgyOXdkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRE1LQ2dvdkx5QndaWFJwZEdsdmJpNVFaWFJwZEdsdmJpNXdjbWx0WlY5d1pYUnBkR2x2YmlncElDMCtJSFp2YVdRNkNuQnlhVzFsWDNCbGRHbDBhVzl1T2dvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG96TXpBS0lDQWdJQzh2SUhObGJHWXVhWE5mWTNKbFlYUnZjbDl2Y2w5dFlYTjBaWEpmWTNKbFlYUnZjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHbHpYMk55WldGMGIzSmZiM0pmYldGemRHVnlYMk55WldGMGIzSUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk16TXhDaUFnSUNBdkx5QnpaV3htTG5CbGRHbDBhVzl1WDJselgyNXZkRjl3Y21sdFpXUW9LUW9nSUNBZ1kyRnNiSE4xWWlCd1pYUnBkR2x2Ymw5cGMxOXViM1JmY0hKcGJXVmtDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qTXpNZ29nSUNBZ0x5OGdjMlZzWmk1d1pYUnBkR2x2Ymw5d2NtbHRaV1FnUFNCVWNuVmxDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndaWFJwZEdsdmJsOXdjbWx0WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhCbGRHbDBhVzl1TGxCbGRHbDBhVzl1TG1selgyTnlaV0YwYjNKZmIzSmZiV0Z6ZEdWeVgyTnlaV0YwYjNJb0tTQXRQaUIyYjJsa09ncHBjMTlqY21WaGRHOXlYMjl5WDIxaGMzUmxjbDlqY21WaGRHOXlPZ29nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUb3pOREFLSUNBZ0lDOHZJSEpsZEhWeWJpQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNek0yQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOWpjbVZoZEc5eUtDa2diM0lnYzJWc1ppNXBjMTl0WVhOMFpYSmZZM0psWVhSdmNpZ3BDaUFnSUNCaWJub2dhWE5mWTNKbFlYUnZjbDl2Y2w5dFlYTjBaWEpmWTNKbFlYUnZjbDlpYjI5c1gzUnlkV1ZBTWdvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG96TkRRS0lDQWdJQzh2SUhKbGRIVnliaUJVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1Y0dWMGFYUnBiMjVmYldGemRHVnlMbU55WldGMGIzSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p3WlhScGRHbHZibDl0WVhOMFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0dWMGFYUnBiMjVmYldGemRHVnlJR1Y0YVhOMGN3b2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UTNKbFlYUnZjZ29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXpNMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXBjMTlqY21WaGRHOXlLQ2tnYjNJZ2MyVnNaaTVwYzE5dFlYTjBaWEpmWTNKbFlYUnZjaWdwQ2lBZ0lDQmllaUJwYzE5amNtVmhkRzl5WDI5eVgyMWhjM1JsY2w5amNtVmhkRzl5WDJKdmIyeGZabUZzYzJWQU13b0thWE5mWTNKbFlYUnZjbDl2Y2w5dFlYTjBaWEpmWTNKbFlYUnZjbDlpYjI5c1gzUnlkV1ZBTWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwcGMxOWpjbVZoZEc5eVgyOXlYMjFoYzNSbGNsOWpjbVZoZEc5eVgySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNek0yQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOWpjbVZoZEc5eUtDa2diM0lnYzJWc1ppNXBjMTl0WVhOMFpYSmZZM0psWVhSdmNpZ3BDaUFnSUNCaGMzTmxjblFLSUNBZ0lISmxkSE4xWWdvS2FYTmZZM0psWVhSdmNsOXZjbDl0WVhOMFpYSmZZM0psWVhSdmNsOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnBjMTlqY21WaGRHOXlYMjl5WDIxaGMzUmxjbDlqY21WaGRHOXlYMkp2YjJ4ZmJXVnlaMlZBTkFvS0NpOHZJSEJsZEdsMGFXOXVMbEJsZEdsMGFXOXVMbkJsZEdsMGFXOXVYMmx6WDI1dmRGOXdjbWx0WldRb0tTQXRQaUIyYjJsa09ncHdaWFJwZEdsdmJsOXBjMTl1YjNSZmNISnBiV1ZrT2dvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG96TlRJS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTV3WlhScGRHbHZibDl3Y21sdFpXUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd1pYUnBkR2x2Ymw5d2NtbHRaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHVjBhWFJwYjI1ZmNISnBiV1ZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QndaWFJwZEdsdmJpNVFaWFJwZEdsdmJpNXphV2R1WDNCbGRHbDBhVzl1S0hOcFoyNWxjam9nWW5sMFpYTXNJRzFpY2w5d1lYbHRaVzUwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS2MybG5ibDl3WlhScGRHbHZiam9LSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZNelUwTFRNMU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSE5wWjI1ZmNHVjBhWFJwYjI0b2MyVnNaaXdnYzJsbmJtVnlPaUJCWkdSeVpYTnpMQ0J0WW5KZmNHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUb3pORGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5CbGRHbDBhVzl1WDNCeWFXMWxaQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luQmxkR2wwYVc5dVgzQnlhVzFsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdaWFJwZEdsdmJsOXdjbWx0WldRZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXpVM0NpQWdJQ0F2THlCelpXeG1MbWx6WDJOeVpXRjBiM0pmYjNKZmJXRnpkR1Z5WDJOeVpXRjBiM0lvS1FvZ0lDQWdZMkZzYkhOMVlpQnBjMTlqY21WaGRHOXlYMjl5WDIxaGMzUmxjbDlqY21WaGRHOXlDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qTTROUW9nSUNBZ0x5OGdkR2x0WlY5emFXZHVaV1E5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak0zTmdvZ0lDQWdMeThnWVhOelpYSjBJSE5wWjI1bFpTQnViM1FnYVc0Z2MyVnNaaTV6YVdkdVlYUjFjbVZ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pZS0lDQWdJQzh2SUhKbGRIVnliaUJIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMbTFwYmw5aVlXeGhibU5sQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXpZMENpQWdJQ0F2THlCelpXeG1Mbk5wWjI1aGRIVnlaWE5iYzJsbmJtVmxYU0E5SUhScGJXVmZjMmxuYm1Wa0xtTnZjSGtvS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZOZ29nSUNBZ0x5OGdjbVYwZFhKdUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNdWJXbHVYMkpoYkdGdVkyVUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFMXBia0poYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUb3pPVEVLSUNBZ0lDOHZJSE5sYkdZdWMybG5ibVZsY3lBclBTQXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWMybG5ibVZsY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXphV2R1WldWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTnBaMjVsWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRvek5qa0tJQ0FnSUM4dklHMWljbDlqYjNOMElEMGdjRzl6ZEY5dFluSWdMU0J3Y21WZmJXSnlDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0F2THlCd2VYUm9iMjVmYVcxd2JHVnRaVzUwWVhScGIyNXpMMk52Ym5SeVlXTjBMM0JsZEdsMGFXOXVMbkI1T2pNM01Bb2dJQ0FnTHk4Z1pYaGpaWE56WDIxaWNpQTlJRzFpY2w5d1lYbHRaVzUwTG1GdGIzVnVkQ0F0SUcxaWNsOWpiM04wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk16Y3hDaUFnSUNBdkx5QnlaV1oxYm1SZlpYaGpaWE56S0dWNFkyVnpjejFsZUdObGMzTmZiV0p5S1FvZ0lDQWdZMkZzYkhOMVlpQnlaV1oxYm1SZlpYaGpaWE56Q2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak0zTWdvZ0lDQWdMeThnY21WMGRYSnVJRzFpY2w5amIzTjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QndaWFJwZEdsdmJpNVFaWFJwZEdsdmJpNWhaR1JmWTI5dGJXVnVkQ2gwWlhoME9pQmllWFJsY3l3Z2JXSnlYM0JoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BoWkdSZlkyOXRiV1Z1ZERvS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXprekxUTTVOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdGa1pGOWpiMjF0Wlc1MEtITmxiR1lzSUhSbGVIUTZJRVI1Ym1GdGFXTkNlWFJsY3l3Z2JXSnlYM0JoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhCNWRHaHZibDlwYlhCc1pXMWxiblJoZEdsdmJuTXZZMjl1ZEhKaFkzUXZjR1YwYVhScGIyNHVjSGs2TXprMUNpQWdJQ0F2THlCelpXeG1MbWx6WDJOeVpXRjBiM0pmYjNKZmJXRnpkR1Z5WDJOeVpXRjBiM0lvS1FvZ0lDQWdZMkZzYkhOMVlpQnBjMTlqY21WaGRHOXlYMjl5WDIxaGMzUmxjbDlqY21WaGRHOXlDaUFnSUNBdkx5QndlWFJvYjI1ZmFXMXdiR1Z0Wlc1MFlYUnBiMjV6TDJOdmJuUnlZV04wTDNCbGRHbDBhVzl1TG5CNU9qTTBPQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Y0dWMGFYUnBiMjVmY0hKcGJXVmtDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNHVjBhWFJwYjI1ZmNISnBiV1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmxkR2wwYVc5dVgzQnlhVzFsWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG8yQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPak01T1FvZ0lDQWdMeThnWVdSa2NtVnpjejFCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUbzBNREFLSUNBZ0lDOHZJSFJwYldVOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRvek9UZ3ROREF5Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZiVzFsYm5SelczTmxiR1l1WTI5dGJXVnVkRjlqYjNWdWRHVnlYU0E5SUVOdmJXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ1lXUmtjbVZ6Y3oxQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSFJwYldVOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQWdJR052YlcxbGJuUTlkR1Y0ZEM1amIzQjVLQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeVlRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUb3pPVGdLSUNBZ0lDOHZJSE5sYkdZdVkyOXRiV1Z1ZEhOYmMyVnNaaTVqYjIxdFpXNTBYMk52ZFc1MFpYSmRJRDBnUTI5dGJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpiMjF0Wlc1MFgyTnZkVzUwWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl0YldWdWRGOWpiM1Z1ZEdWeUlHVjRhWE4wY3dvZ0lDQWdMeThnY0hsMGFHOXVYMmx0Y0d4bGJXVnVkR0YwYVc5dWN5OWpiMjUwY21GamRDOXdaWFJwZEdsdmJpNXdlVG96T1RndE5EQXlDaUFnSUNBdkx5QnpaV3htTG1OdmJXMWxiblJ6VzNObGJHWXVZMjl0YldWdWRGOWpiM1Z1ZEdWeVhTQTlJRU52YlcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnWVdSa2NtVnpjejFCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1U5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNBZ0lHTnZiVzFsYm5ROWRHVjRkQzVqYjNCNUtDa0tJQ0FnSUM4dklDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ3ZVhSb2IyNWZhVzF3YkdWdFpXNTBZWFJwYjI1ekwyTnZiblJ5WVdOMEwzQmxkR2wwYVc5dUxuQjVPallLSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtMXBibDlpWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSEI1ZEdodmJsOXBiWEJzWlcxbGJuUmhkR2x2Ym5NdlkyOXVkSEpoWTNRdmNHVjBhWFJwYjI0dWNIazZOREExQ2lBZ0lDQXZMeUJ0WW5KZlkyOXpkQ0E5SUhCdmMzUmZiV0p5SUMwZ2NISmxYMjFpY2dvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ0x5OGdjSGwwYUc5dVgybHRjR3hsYldWdWRHRjBhVzl1Y3k5amIyNTBjbUZqZEM5d1pYUnBkR2x2Ymk1d2VUbzBNRFlLSUNBZ0lDOHZJR1Y0WTJWemN5QTlJRzFpY2w5d1lYbHRaVzUwTG1GdGIzVnVkQ0F0SUcxaWNsOWpiM04wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk5EQTNDaUFnSUNBdkx5QnlaV1oxYm1SZlpYaGpaWE56S0dWNFkyVnpjejFsZUdObGMzTXBDaUFnSUNCallXeHNjM1ZpSUhKbFpuVnVaRjlsZUdObGMzTUtJQ0FnSUM4dklIQjVkR2h2Ymw5cGJYQnNaVzFsYm5SaGRHbHZibk12WTI5dWRISmhZM1F2Y0dWMGFYUnBiMjR1Y0hrNk5ERXpDaUFnSUNBdkx5QnpaV3htTG1OdmJXMWxiblJmWTI5MWJuUmxjaUE5SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1WTI5dGJXVnVkRjlqYjNWdWRHVnlMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZMjl0YldWdWRGOWpiM1Z1ZEdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU52YlcxbGJuUmZZMjkxYm5SbGNpQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpiMjF0Wlc1MFgyTnZkVzUwWlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NIbDBhRzl1WDJsdGNHeGxiV1Z1ZEdGMGFXOXVjeTlqYjI1MGNtRmpkQzl3WlhScGRHbHZiaTV3ZVRvME1Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCdFluSmZZMjl6ZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFRQUVKZ2dQY0dWMGFYUnBiMjVmY0hKcGJXVmtEMk52YlcxbGJuUmZZMjkxYm5SbGNnUVZIM3gxQVdFSGMybG5ibVZsY3c5d1pYUnBkR2x2Ymw5dFlYTjBaWElOWTNKbFlYUnBiMjVmZEdsdFpSQndaWFJwZEdsdmJsOWpjbVZoZEc5eU1SaEFBQ0FuQkNObkp3WWpaeWNGSTJjbkJ6SURaeW1BQ0FBQUFBQUFBQUFBWnlnalp6RWJRUURwZ2djRW9PZ1ljZ1FmM3ZnVEJHc1pEejRFQmRDa213VHZmbTZCQkNlS0NnUUVWSmJXRWpZYUFJNEhBS1FBakFCckFFb0FQZ0FnQUFJalF6RVpGRVF4R0VRMkdnRXhGaUlKU1RnUUloSkVpQUc5RmlwTVVMQWlRekVaRkVReEdFUTJHZ0V4RmlJSlNUZ1FJaEpFaUFGakZpcE1VTEFpUXpFWkZFUXhHRVNJQVNRaVF6RVpGRVF4R0VRMkdnRlhBZ0F4RmlJSlNUZ1FJaEpFaUFERkZpcE1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnSXhGaUlKU1RnUUloSkVpQUJnRmlwTVVMQWlRekVaRkVReEdFUTJHZ0VYd0RJMkdnSVh3QnlJQURJaVF6RVpKQkpFTVJoRWlBQWhJa014R1VEL1NqRVlGRVFpUTRvQkFMRXhBSXYvc2dpeUJ5S3lFQ095QWJPSmlBQ2ppWW9DQUlnQW5DY0ZpLzVuSndlTC8yZUppZ01CaUFDTGlBQ2xNZ3B6QVVTTC9SVWtDQlpYQmdLQUFnQUVURkNML1ZDTC9sQ0FBU0M4U0lBQklFeS9Kd1l5QjJjeUNuTUJSRXdKaS84NENFc0JDWWovbEltS0FnR0lBRWVJQUdFcnZUSUtjd0ZNVGdKRVFBQVpLNHYrdnpJS2N3RkVpd0VKaS84NENFc0JDWWovWjR3QWlZditGWXNBU1U4Q0NDdE0weXRNaS82N1F2L1hpQUFIaUFBaEtDSm5pVEVBTWdrU1FBQU9NUUFqSndWbFJISUhSQkpCQUFNaVJJa2pRdi82SXlobFJCUkVpWW9DQVNNb1pVUkVpUC9STWdjV2kvNjlSUUVVUkRJS2N3RkVpLzVQQXI4eUNuTUJSQ01uQkdWRUlnZ25CRXhuVEFtTC96Z0lTd0VKaVA3bmlZb0NBWWovbWlNb1pVUkVNZ3B6QVVReEFESUhGbENBQWdBcVVJditVQ01wWlVSSnZFaE12eklLY3dGRVRBbUwvemdJU3dFSmlQNnVJeWxsUkJjaUNCWXBUR2VKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
