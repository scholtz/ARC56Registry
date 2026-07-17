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

namespace Arc56.Generated.Prathamesh_chougale_17.algo_dapp.AlgoRealmGameManager_121d6ec3
{


    //
    // 
    //    Main game manager contract for AlgoRealm
    //    Handles player registration, item management, and on-demand tokenization
    //    
    //
    public class AlgoRealmGameManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoRealmGameManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetPlayerStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetPlayerStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPlayerStatsReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPlayerStatsReturn);
                }
                public bool Equals(GetPlayerStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPlayerStatsReturn left, GetPlayerStatsReturn right)
                {
                    return EqualityComparer<GetPlayerStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPlayerStatsReturn left, GetPlayerStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetRecoveryStatusReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetRecoveryStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetRecoveryStatusReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetRecoveryStatusReturn);
                }
                public bool Equals(GetRecoveryStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetRecoveryStatusReturn left, GetRecoveryStatusReturn right)
                {
                    return EqualityComparer<GetRecoveryStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetRecoveryStatusReturn left, GetRecoveryStatusReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the game state - called once when contract is created
        ///</summary>
        public async Task<string> InitializeGame(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 90, 172, 59 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> InitializeGame_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 90, 172, 59 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new player in the game
        ///</summary>
        /// <param name="player_name"> </param>
        public async Task<string> RegisterPlayer(string player_name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 61, 24, 213 };
            var player_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); player_nameAbi.From(player_name);

            var result = await base.CallApp(new List<object> { abiHandle, player_nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterPlayer_Transactions(string player_name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 61, 24, 213 };
            var player_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); player_nameAbi.From(player_name);

            return await base.MakeTransactionList(new List<object> { abiHandle, player_nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new game item as an ASA
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="item_name"> </param>
        /// <param name="item_type"> </param>
        /// <param name="rarity"> </param>
        /// <param name="attack_power"> </param>
        /// <param name="defense_power"> </param>
        /// <param name="special_effect"> </param>
        public async Task<ulong> CreateGameItem(Address recipient, string item_name, string item_type, string rarity, ulong attack_power, ulong defense_power, string special_effect, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 42, 97, 132, 128 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var item_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); item_nameAbi.From(item_name);
            var item_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); item_typeAbi.From(item_type);
            var rarityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); rarityAbi.From(rarity);
            var attack_powerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); attack_powerAbi.From(attack_power);
            var defense_powerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); defense_powerAbi.From(defense_power);
            var special_effectAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); special_effectAbi.From(special_effect);

            var result = await base.CallApp(new List<object> { abiHandle, recipientRefIndex, item_nameAbi, item_typeAbi, rarityAbi, attack_powerAbi, defense_powerAbi, special_effectAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateGameItem_Transactions(Address recipient, string item_name, string item_type, string rarity, ulong attack_power, ulong defense_power, string special_effect, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 42, 97, 132, 128 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var item_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); item_nameAbi.From(item_name);
            var item_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); item_typeAbi.From(item_type);
            var rarityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); rarityAbi.From(rarity);
            var attack_powerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); attack_powerAbi.From(attack_power);
            var defense_powerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); defense_powerAbi.From(defense_power);
            var special_effectAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); special_effectAbi.From(special_effect);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientRefIndex, item_nameAbi, item_typeAbi, rarityAbi, attack_powerAbi, defense_powerAbi, special_effectAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///ON-DEMAND TOKENIZATION: Recover a lost game item
        ///This is the core feature for Task 6
        ///</summary>
        /// <param name="original_item_id"> </param>
        /// <param name="recovery_quest_proof"> </param>
        /// <param name="new_recipient"> </param>
        public async Task<ulong> RecoverLostItem(Address new_recipient, ulong original_item_id, byte[] recovery_quest_proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { original_item_id });
            byte original_item_idRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { new_recipient });
            byte new_recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 233, 63, 139 };
            var original_item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); original_item_idAbi.From(original_item_id);
            var recovery_quest_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recovery_quest_proofAbi.From(recovery_quest_proof);
            var new_recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_recipientAbi.From(new_recipient);

            var result = await base.CallApp(new List<object> { abiHandle, original_item_idRefIndex, recovery_quest_proofAbi, new_recipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecoverLostItem_Transactions(Address new_recipient, ulong original_item_id, byte[] recovery_quest_proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { original_item_id });
            byte original_item_idRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { new_recipient });
            byte new_recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 233, 63, 139 };
            var original_item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); original_item_idAbi.From(original_item_id);
            var recovery_quest_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recovery_quest_proofAbi.From(recovery_quest_proof);
            var new_recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_recipientAbi.From(new_recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, original_item_idRefIndex, recovery_quest_proofAbi, new_recipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///ON-DEMAND TOKENIZATION: Reissue seasonal event items
        ///Allows players to earn previous season items in new events
        ///</summary>
        /// <param name="event_name"> </param>
        /// <param name="participation_proof"> </param>
        /// <param name="recipient"> </param>
        public async Task<ulong> SeasonalEventReissue(Address recipient, string event_name, byte[] participation_proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 160, 209, 52, 208 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var participation_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); participation_proofAbi.From(participation_proof);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, event_nameAbi, participation_proofAbi, recipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SeasonalEventReissue_Transactions(Address recipient, string event_name, byte[] participation_proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 160, 209, 52, 208 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var participation_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); participation_proofAbi.From(participation_proof);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_nameAbi, participation_proofAbi, recipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Craft new items by combining existing ones
        ///Demonstrates atomic transactions
        ///</summary>
        /// <param name="material_1"> </param>
        /// <param name="material_2"> </param>
        /// <param name="recipe_id"> </param>
        public async Task<ulong> CraftItems(ulong material_1, ulong material_2, ulong recipe_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { material_1, material_2 });
            byte material_1RefIndex = (byte)(_assetRefBase + 0);
            byte material_2RefIndex = (byte)(_assetRefBase + 1);
            byte[] abiHandle = { 139, 205, 227, 150 };
            var material_1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); material_1Abi.From(material_1);
            var material_2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); material_2Abi.From(material_2);
            var recipe_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); recipe_idAbi.From(recipe_id);

            var result = await base.CallApp(new List<object> { abiHandle, material_1RefIndex, material_2RefIndex, recipe_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CraftItems_Transactions(ulong material_1, ulong material_2, ulong recipe_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { material_1, material_2 });
            byte material_1RefIndex = (byte)(_assetRefBase + 0);
            byte material_2RefIndex = (byte)(_assetRefBase + 1);
            byte[] abiHandle = { 139, 205, 227, 150 };
            var material_1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); material_1Abi.From(material_1);
            var material_2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); material_2Abi.From(material_2);
            var recipe_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); recipe_idAbi.From(recipe_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, material_1RefIndex, material_2RefIndex, recipe_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get player statistics
        ///</summary>
        /// <param name="player"> </param>
        public async Task<Structs.GetPlayerStatsReturn> GetPlayerStats(Address player, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { player });
            byte playerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 69, 214, 94, 203 };
            var playerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); playerAbi.From(player);

            var result = await base.SimApp(new List<object> { abiHandle, playerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPlayerStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPlayerStats_Transactions(Address player, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { player });
            byte playerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 69, 214, 94, 203 };
            var playerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); playerAbi.From(player);

            return await base.MakeTransactionList(new List<object> { abiHandle, playerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Advance to next season (only game master)
        ///</summary>
        public async Task<ulong> AdvanceSeason(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 82, 117, 31 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AdvanceSeason_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 82, 117, 31 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current game information
        ///</summary>
        public async Task<Structs.GetPlayerStatsReturn> GetGameInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 154, 127, 151 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPlayerStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetGameInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 154, 127, 151 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Claim an item that was created for the player.
        ///Player must have opted-in to the asset before calling this.
        ///</summary>
        /// <param name="item_id"> </param>
        public async Task<string> ClaimItem(ulong item_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { item_id });
            byte item_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 58, 213, 237, 213 };
            var item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); item_idAbi.From(item_id);

            var result = await base.CallApp(new List<object> { abiHandle, item_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ClaimItem_Transactions(ulong item_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { item_id });
            byte item_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 58, 213, 237, 213 };
            var item_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); item_idAbi.From(item_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, item_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get player's current recovery count and max allowed recoveries
        ///</summary>
        /// <param name="player"> </param>
        public async Task<Structs.GetRecoveryStatusReturn> GetRecoveryStatus(Address player, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { player });
            byte playerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 2, 184, 61, 0 };
            var playerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); playerAbi.From(player);

            var result = await base.SimApp(new List<object> { abiHandle, playerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetRecoveryStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRecoveryStatus_Transactions(Address player, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { player });
            byte playerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 2, 184, 61, 0 };
            var playerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); playerAbi.From(player);

            return await base.MakeTransactionList(new List<object> { abiHandle, playerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb1JlYWxtR2FtZU1hbmFnZXIiLCJkZXNjIjoiXG4gICAgTWFpbiBnYW1lIG1hbmFnZXIgY29udHJhY3QgZm9yIEFsZ29SZWFsbVxuICAgIEhhbmRsZXMgcGxheWVyIHJlZ2lzdHJhdGlvbiwgaXRlbSBtYW5hZ2VtZW50LCBhbmQgb24tZGVtYW5kIHRva2VuaXphdGlvblxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRQbGF5ZXJTdGF0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0UmVjb3ZlcnlTdGF0dXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplX2dhbWUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgZ2FtZSBzdGF0ZSAtIGNhbGxlZCBvbmNlIHdoZW4gY29udHJhY3QgaXMgY3JlYXRlZCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX3BsYXllciIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyBwbGF5ZXIgaW4gdGhlIGdhbWUiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGxheWVyX25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiLCJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9nYW1lX2l0ZW0iLCJkZXNjIjoiQ3JlYXRlIGEgbmV3IGdhbWUgaXRlbSBhcyBhbiBBU0EiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbV9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVtX3R5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJhcml0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXR0YWNrX3Bvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWZlbnNlX3Bvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVjaWFsX2VmZmVjdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY292ZXJfbG9zdF9pdGVtIiwiZGVzYyI6Ik9OLURFTUFORCBUT0tFTklaQVRJT046IFJlY292ZXIgYSBsb3N0IGdhbWUgaXRlbVxuVGhpcyBpcyB0aGUgY29yZSBmZWF0dXJlIGZvciBUYXNrIDYiLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmlnaW5hbF9pdGVtX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNvdmVyeV9xdWVzdF9wcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZWFzb25hbF9ldmVudF9yZWlzc3VlIiwiZGVzYyI6Ik9OLURFTUFORCBUT0tFTklaQVRJT046IFJlaXNzdWUgc2Vhc29uYWwgZXZlbnQgaXRlbXNcbkFsbG93cyBwbGF5ZXJzIHRvIGVhcm4gcHJldmlvdXMgc2Vhc29uIGl0ZW1zIGluIG5ldyBldmVudHMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZlbnRfbmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGljaXBhdGlvbl9wcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyYWZ0X2l0ZW1zIiwiZGVzYyI6IkNyYWZ0IG5ldyBpdGVtcyBieSBjb21iaW5pbmcgZXhpc3Rpbmcgb25lc1xuRGVtb25zdHJhdGVzIGF0b21pYyB0cmFuc2FjdGlvbnMiLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXRlcmlhbF8xIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hdGVyaWFsXzIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wbGF5ZXJfc3RhdHMiLCJkZXNjIjoiR2V0IHBsYXllciBzdGF0aXN0aWNzIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFBsYXllclN0YXRzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZHZhbmNlX3NlYXNvbiIsImRlc2MiOiJBZHZhbmNlIHRvIG5leHQgc2Vhc29uIChvbmx5IGdhbWUgbWFzdGVyKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9nYW1lX2luZm8iLCJkZXNjIjoiR2V0IGN1cnJlbnQgZ2FtZSBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0UGxheWVyU3RhdHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX2l0ZW0iLCJkZXNjIjoiQ2xhaW0gYW4gaXRlbSB0aGF0IHdhcyBjcmVhdGVkIGZvciB0aGUgcGxheWVyLlxuUGxheWVyIG11c3QgaGF2ZSBvcHRlZC1pbiB0byB0aGUgYXNzZXQgYmVmb3JlIGNhbGxpbmcgdGhpcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVtX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlY292ZXJ5X3N0YXR1cyIsImRlc2MiOiJHZXQgcGxheWVyJ3MgY3VycmVudCByZWNvdmVyeSBjb3VudCBhbmQgbWF4IGFsbG93ZWQgcmVjb3ZlcmllcyIsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGxheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFJlY292ZXJ5U3RhdHVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjozLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzODhdLCJlcnJvck1lc3NhZ2UiOiJBc3NldCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzddLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgZ2V0IG9yaWdpbmFsIGl0ZW0gbmFtZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDhdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHByb3ZpZGUgcGFydGljaXBhdGlvbiBwcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1NV0sImVycm9yTWVzc2FnZSI6Ik11c3QgcHJvdmlkZSByZWNvdmVyeSBxdWVzdCBwcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MiwyOTksMzI5LDM1OSwzNzYsNDEyLDQ0NSw0ODAsNTE1LDYwM10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3Qgb25lIG9mIE5vT3AsIE9wdEluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyMF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgZ2FtZSBtYXN0ZXIgY2FuIGFkdmFuY2Ugc2Vhc29uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQwXSwiZXJyb3JNZXNzYWdlIjoiT25seSBnYW1lIG1hc3RlciBjYW4gY3JlYXRlIGl0ZW1zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcmVnaXN0ZXJlZCBwbGF5ZXJzIGNhbiBjbGFpbSBpdGVtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMThdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHJlZ2lzdGVyZWQgcGxheWVycyBjYW4gY3JhZnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTAyXSwiZXJyb3JNZXNzYWdlIjoiT25seSByZWdpc3RlcmVkIHBsYXllcnMgY2FuIHBhcnRpY2lwYXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQyXSwiZXJyb3JNZXNzYWdlIjoiT25seSByZWdpc3RlcmVkIHBsYXllcnMgY2FuIHJlY292ZXIgaXRlbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDldLCJlcnJvck1lc3NhZ2UiOiJPcmlnaW5hbCBpdGVtIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOTAsMTQ2NV0sImVycm9yTWVzc2FnZSI6IlBsYXllciBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0OV0sImVycm9yTWVzc2FnZSI6IlJlY2lwaWVudCBtdXN0IGJlIHJlZ2lzdGVyZWQgcGxheWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTcwXSwiZXJyb3JNZXNzYWdlIjoiUmVjb3ZlcnkgbGltaXQgcmVhY2hlZCAtIG1heCAzIHJlY292ZXJpZXMgcGVyIHBsYXllciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwN10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NSwzMDIsMzMyLDM2MiwzNzksNDE1LDQ0OCw0ODMsNTE4LDU3Nl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzI1LDEzNjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmN1cnJlbnRfc2Vhc29uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzOCwxMzE4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nYW1lX21hc3RlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzMsODQ2LDkzOSwxMDk5LDEyMTUsMTI4NywxMzc2LDE0NjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzX3JlZ2lzdGVyZWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTY2LDE0NzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1heF9yZWNvdmVyeV9wZXJfaXRlbSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzA0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wbGF5ZXJfZXhwZXJpZW5jZSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wbGF5ZXJfbGV2ZWwgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTYxLDEzMTAsMTQ3MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGxheWVyX3JlY292ZXJ5X2NvdW50IGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwOCwxMzYxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9pdGVtc19jcmVhdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NSwxMzU2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9wbGF5ZXJzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzSmxZV3h0TG1OdmJuUnlZV04wTGtGc1oyOVNaV0ZzYlVkaGJXVk5ZVzVoWjJWeUxsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0F6Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW1selgzSmxaMmx6ZEdWeVpXUWlJREI0TURBZ0luQnNZWGxsY2w5eVpXTnZkbVZ5ZVY5amIzVnVkQ0lnSW5SdmRHRnNYM0JzWVhsbGNuTWlJQ0owYjNSaGJGOXBkR1Z0YzE5amNtVmhkR1ZrSWlBaVkzVnljbVZ1ZEY5elpXRnpiMjRpSUNKdFlYaGZjbVZqYjNabGNubGZjR1Z5WDJsMFpXMGlJQ0puWVcxbFgyMWhjM1JsY2lJZ0luQnNZWGxsY2w5c1pYWmxiQ0lnSW5Cc1lYbGxjbDlsZUhCbGNtbGxibU5sSWlBd2VEUXpOVEkwTVRRMk5UUTBOVFEwTldZME9UVTBORFUwWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nUVd4bmIxSmxZV3h0UjJGdFpVMWhibUZuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaU16VmhZV016WWlBd2VEZzBNMlF4T0dRMUlEQjRNbUUyTVRnME9EQWdNSGhsWW1VNU0yWTRZaUF3ZUdFd1pERXpOR1F3SURCNE9HSmpaR1V6T1RZZ01IZzBOV1EyTldWallpQXdlRE5pTlRJM05URm1JREI0TkRjNVlUZG1PVGNnTUhnellXUTFaV1JrTlNBd2VEQXlZamd6WkRBd0lDOHZJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaVjluWVcxbEtDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luSmxaMmx6ZEdWeVgzQnNZWGxsY2loemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pqY21WaGRHVmZaMkZ0WlY5cGRHVnRLR0ZqWTI5MWJuUXNjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5DeHpkSEpwYm1jcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpXTnZkbVZ5WDJ4dmMzUmZhWFJsYlNoaGMzTmxkQ3hpZVhSbFcxMHNZV05qYjNWdWRDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luTmxZWE52Ym1Gc1gyVjJaVzUwWDNKbGFYTnpkV1VvYzNSeWFXNW5MR0o1ZEdWYlhTeGhZMk52ZFc1MEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVkzSmhablJmYVhSbGJYTW9ZWE56WlhRc1lYTnpaWFFzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNCc1lYbGxjbDl6ZEdGMGN5aGhZMk52ZFc1MEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1Ga2RtRnVZMlZmYzJWaGMyOXVLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5bllXMWxYMmx1Wm04b0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1Oc1lXbHRYMmwwWlcwb1lYTnpaWFFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZmNtVmpiM1psY25sZmMzUmhkSFZ6S0dGalkyOTFiblFwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXBibWwwYVdGc2FYcGxYMmRoYldWZmNtOTFkR1ZBTlNCdFlXbHVYM0psWjJsemRHVnlYM0JzWVhsbGNsOXliM1YwWlVBMklHMWhhVzVmWTNKbFlYUmxYMmRoYldWZmFYUmxiVjl5YjNWMFpVQTNJRzFoYVc1ZmNtVmpiM1psY2w5c2IzTjBYMmwwWlcxZmNtOTFkR1ZBT0NCdFlXbHVYM05sWVhOdmJtRnNYMlYyWlc1MFgzSmxhWE56ZFdWZmNtOTFkR1ZBT1NCdFlXbHVYMk55WVdaMFgybDBaVzF6WDNKdmRYUmxRREV3SUcxaGFXNWZaMlYwWDNCc1lYbGxjbDl6ZEdGMGMxOXliM1YwWlVBeE1TQnRZV2x1WDJGa2RtRnVZMlZmYzJWaGMyOXVYM0p2ZFhSbFFERXlJRzFoYVc1ZloyVjBYMmRoYldWZmFXNW1iMTl5YjNWMFpVQXhNeUJ0WVdsdVgyTnNZV2x0WDJsMFpXMWZjbTkxZEdWQU1UUWdiV0ZwYmw5blpYUmZjbVZqYjNabGNubGZjM1JoZEhWelgzSnZkWFJsUURFMUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCamJHRnpjeUJCYkdkdlVtVmhiRzFIWVcxbFRXRnVZV2RsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmY21WamIzWmxjbmxmYzNSaGRIVnpYM0p2ZFhSbFFERTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95T1RnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWTJ4aGMzTWdRV3huYjFKbFlXeHRSMkZ0WlUxaGJtRm5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakk1T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZjbVZqYjNabGNubGZjM1JoZEhWekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyeGhhVzFmYVhSbGJWOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNamMwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nUVd4bmIxSmxZV3h0UjJGdFpVMWhibUZuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TnpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJqYkdGcGJWOXBkR1Z0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmWjJGdFpWOXBibVp2WDNKdmRYUmxRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU5qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWjJGdFpWOXBibVp2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpIWmhibU5sWDNObFlYTnZibDl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpVMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJoWkhaaGJtTmxYM05sWVhOdmJnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZjR3hoZVdWeVgzTjBZWFJ6WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nUVd4bmIxSmxZV3h0UjJGdFpVMWhibUZuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJME5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmY0d4aGVXVnlYM04wWVhSekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbUZtZEY5cGRHVnRjMTl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpFeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1FXeG5iMUpsWVd4dFIyRnRaVTFoYm1GblpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYTnpaWFJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJeE1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdOeVlXWjBYMmwwWlcxekNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObFlYTnZibUZzWDJWMlpXNTBYM0psYVhOemRXVmZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVGM0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nUVd4bmIxSmxZV3h0UjJGdFpVMWhibUZuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVGM0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdjMlZoYzI5dVlXeGZaWFpsYm5SZmNtVnBjM04xWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WldOdmRtVnlYMnh2YzNSZmFYUmxiVjl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCQmJHZHZVbVZoYkcxSFlXMWxUV0Z1WVdkbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYTnpaWFJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TVRFNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnY21WamIzWmxjbDlzYjNOMFgybDBaVzBLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgyZGhiV1ZmYVhSbGJWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRUZzWjI5U1pXRnNiVWRoYldWTllXNWhaMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TnpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVmZaMkZ0WlY5cGRHVnRDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxaMmx6ZEdWeVgzQnNZWGxsY2w5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0lzSUNKUGNIUkpiaUpkS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSE5vYkFvZ0lDQWdhVzUwWTE4eUlDOHZJRE1LSUNBZ0lDWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElHOXVaU0J2WmlCT2IwOXdMQ0JQY0hSSmJnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCamJHRnpjeUJCYkdkdlVtVmhiRzFIWVcxbFRXRnVZV2RsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaUxDQWlUM0IwU1c0aVhTa0tJQ0FnSUdOaGJHeHpkV0lnY21WbmFYTjBaWEpmY0d4aGVXVnlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5cGJtbDBhV0ZzYVhwbFgyZGhiV1ZmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2x1YVhScFlXeHBlbVZmWjJGdFpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNKbFlXeHRMbU52Ym5SeVlXTjBMa0ZzWjI5U1pXRnNiVWRoYldWTllXNWhaMlZ5TG1sdWFYUnBZV3hwZW1WZloyRnRaU2dwSUMwK0lHSjVkR1Z6T2dwcGJtbDBhV0ZzYVhwbFgyZGhiV1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzQnNZWGxsY25NdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmRHRnNYM0JzWVhsbGNuTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYVhSbGJYTmZZM0psWVhSbFpDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hmYVhSbGJYTmZZM0psWVhSbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdjMlZzWmk1amRYSnlaVzUwWDNObFlYTnZiaTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlZM1Z5Y21WdWRGOXpaV0Z6YjI0aUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklITmxiR1l1YldGNFgzSmxZMjkyWlhKNVgzQmxjbDlwZEdWdExuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RNcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdFlYaGZjbVZqYjNabGNubGZjR1Z5WDJsMFpXMGlDaUFnSUNCcGJuUmpYeklnTHk4Z013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJSE5sYkdZdVoyRnRaVjl0WVhOMFpYSXVkbUZzZFdVZ1BTQlVlRzR1YzJWdVpHVnlJQ0FqSUZObGRDQjBhR1VnWTNKbFlYUnZjaUJoY3lCbllXMWxJRzFoYzNSbGNnb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVoyRnRaVjl0WVhOMFpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVFXeG5iMUpsWVd4dElHbHVhWFJwWVd4cGVtVmtJU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa0ZzWjI5U1pXRnNiU0JwYm1sMGFXRnNhWHBsWkNFaUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzSmxZV3h0TG1OdmJuUnlZV04wTGtGc1oyOVNaV0ZzYlVkaGJXVk5ZVzVoWjJWeUxuSmxaMmx6ZEdWeVgzQnNZWGxsY2lod2JHRjVaWEpmYm1GdFpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncHlaV2RwYzNSbGNsOXdiR0Y1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qVXdMVFV4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lpd2dJazl3ZEVsdUlsMHBDaUFnSUNBdkx5QmtaV1lnY21WbmFYTjBaWEpmY0d4aGVXVnlLSE5sYkdZc0lIQnNZWGxsY2w5dVlXMWxPaUJUZEhKcGJtY3BJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzFNeTAxTkFvZ0lDQWdMeThnSXlCRGFHVmpheUJwWmlCMGFHbHpJR2x6SUdGdUlHOXdkQzFwYmlCallXeHNDaUFnSUNBdkx5QnBaaUJVZUc0dWIyNWZZMjl0Y0d4bGRHbHZiaUE5UFNCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs5d2RFbHVPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJRTl3ZEVsdUNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WbmFYTjBaWEpmY0d4aGVXVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzFOUzAxTmdvZ0lDQWdMeThnSXlCSmJtbDBhV0ZzYVhwbElHUmxabUYxYkhRZ2RtRnNkV1Z6SUdadmNpQnNiMk5oYkNCemRHRjBaU0IzYUdWdUlHOXdkR2x1WnlCcGJnb2dJQ0FnTHk4Z2MyVnNaaTV3YkdGNVpYSmZiR1YyWld4YlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luQnNZWGxsY2w5c1pYWmxiQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJ6Wld4bUxuQnNZWGxsY2w5bGVIQmxjbWxsYm1ObFcxUjRiaTV6Wlc1a1pYSmRJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljR3hoZVdWeVgyVjRjR1Z5YVdWdVkyVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdjMlZzWmk1d2JHRjVaWEpmY21WamIzWmxjbmxmWTI5MWJuUmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkJzWVhsbGNsOXlaV052ZG1WeWVWOWpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCelpXeG1MbWx6WDNKbFoybHpkR1Z5WldSYlZIaHVMbk5sYm1SbGNsMGdQU0JDYjI5c0tFWmhiSE5sS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlhWE5mY21WbmFYTjBaWEpsWkNJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVQzQjBaV1FnYVc0Z2RHOGdRV3huYjFKbFlXeHRJU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJazl3ZEdWa0lHbHVJSFJ2SUVGc1oyOVNaV0ZzYlNFaUNpQWdJQ0J5WlhSemRXSUtDbkpsWjJsemRHVnlYM0JzWVhsbGNsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qWXlMVFkwQ2lBZ0lDQXZMeUFqSUVadmNpQk9iMDl3SUdOaGJHeHpMQ0JvWVc1a2JHVWdjbVZuYVhOMGNtRjBhVzl1Q2lBZ0lDQXZMeUFqSUU1dmR5QjNaU0JqWVc0Z2MyRm1aV3g1SUdGalkyVnpjeUJzYjJOaGJDQnpkR0YwWlNCemFXNWpaU0JwZENCM1lYTWdhVzVwZEdsaGJHbDZaV1FnYjI0Z2IzQjBMV2x1Q2lBZ0lDQXZMeUJwWmlCelpXeG1MbWx6WDNKbFoybHpkR1Z5WldSYlZIaHVMbk5sYm1SbGNsMDZDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVhOZmNtVm5hWE4wWlhKbFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx6WDNKbFoybHpkR1Z5WldRZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCeVpXZHBjM1JsY2w5d2JHRjVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlFiR0Y1WlhJZ1lXeHlaV0ZrZVNCeVpXZHBjM1JsY21Wa0lpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVVHeGhlV1Z5SUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkNJS0lDQWdJSEpsZEhOMVlnb0tjbVZuYVhOMFpYSmZjR3hoZVdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk5qY3ROamdLSUNBZ0lDOHZJQ01nU1c1cGRHbGhiR2w2WlNCd2JHRjVaWElnYzNSaGRITWdabTl5SUdGamRIVmhiQ0J5WldkcGMzUnlZWFJwYjI0S0lDQWdJQzh2SUhObGJHWXVjR3hoZVdWeVgyeGxkbVZzVzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtERXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKd2JHRjVaWEpmYkdWMlpXd2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdjMlZzWmk1d2JHRjVaWEpmWlhod1pYSnBaVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luQnNZWGxsY2w5bGVIQmxjbWxsYm1ObElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklITmxiR1l1Y0d4aGVXVnlYM0psWTI5MlpYSjVYMk52ZFc1MFcxUjRiaTV6Wlc1a1pYSmRJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndiR0Y1WlhKZmNtVmpiM1psY25sZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnYzJWc1ppNXBjMTl5WldkcGMzUmxjbVZrVzFSNGJpNXpaVzVrWlhKZElEMGdRbTl2YkNoVWNuVmxLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFYTmZjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzQnNZWGxsY25NdWRtRnNkV1VnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEc5MFlXeGZjR3hoZVdWeWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXdiR0Y1WlhKeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZkR0ZzWDNCc1lYbGxjbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRvM05Rb2dJQ0FnTHk4Z2JHOW5LSEJzWVhsbGNsOXVZVzFsTG1KNWRHVnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsZGxiR052YldVZ2RHOGdRV3huYjFKbFlXeHRJU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbGRsYkdOdmJXVWdkRzhnUVd4bmIxSmxZV3h0SVNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdmNtVmhiRzB1WTI5dWRISmhZM1F1UVd4bmIxSmxZV3h0UjJGdFpVMWhibUZuWlhJdVkzSmxZWFJsWDJkaGJXVmZhWFJsYlNoeVpXTnBjR2xsYm5RNklHSjVkR1Z6TENCcGRHVnRYMjVoYldVNklHSjVkR1Z6TENCcGRHVnRYM1I1Y0dVNklHSjVkR1Z6TENCeVlYSnBkSGs2SUdKNWRHVnpMQ0JoZEhSaFkydGZjRzkzWlhJNklIVnBiblEyTkN3Z1pHVm1aVzV6WlY5d2IzZGxjam9nZFdsdWREWTBMQ0J6Y0dWamFXRnNYMlZtWm1WamREb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tZM0psWVhSbFgyZGhiV1ZmYVhSbGJUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZOemd0T0RnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOW5ZVzFsWDJsMFpXMG9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J5WldOcGNHbGxiblE2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2FYUmxiVjl1WVcxbE9pQlRkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdhWFJsYlY5MGVYQmxPaUJUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY21GeWFYUjVPaUJUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWVhSMFlXTnJYM0J2ZDJWeU9pQlZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWlc1elpWOXdiM2RsY2pvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lITndaV05wWVd4ZlpXWm1aV04wT2lCVGRISnBibWNzQ2lBZ0lDQXZMeUFwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklEY2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVuWVcxbFgyMWhjM1JsY2k1MllXeDFaU3dnSWs5dWJIa2daMkZ0WlNCdFlYTjBaWElnWTJGdUlHTnlaV0YwWlNCcGRHVnRjeUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKbllXMWxYMjFoYzNSbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVuWVcxbFgyMWhjM1JsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JuWVcxbElHMWhjM1JsY2lCallXNGdZM0psWVhSbElHbDBaVzF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2preENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXBjMTl5WldkcGMzUmxjbVZrVzNKbFkybHdhV1Z1ZEYwc0lDSlNaV05wY0dsbGJuUWdiWFZ6ZENCaVpTQnlaV2RwYzNSbGNtVmtJSEJzWVhsbGNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE53b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1selgzSmxaMmx6ZEdWeVpXUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5eVpXZHBjM1JsY21Wa0lHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZKbFkybHdhV1Z1ZENCdGRYTjBJR0psSUhKbFoybHpkR1Z5WldRZ2NHeGhlV1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2prMUxURXdPQW9nSUNBZ0x5OGdhWFJsYlY5aGMyRWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOWFYUmxiVjl1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFwZEdWdFgzVnVhWFJmYm1GdFpTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMVZTVzUwTmpRb01Ta3NJQ0FqSUZWdWFYRjFaU0JwZEdWdENpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWm5KdmVtVnVQVVpoYkhObExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnM5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQ0FnSXlCVmMyVWdiV2x1YVcxMWJTQjBjbUZ1YzJGamRHbHZiaUJtWldVS0lDQWdJQzh2SUNBZ0lDQWpJRk4wYjNKbElHSmhjMmxqSUdsMFpXMGdhVzVtYnlCcGJpQnViM1JsSUdacFpXeGtDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMXZjQzVqYjI1allYUW9hWFJsYlY5dVlXMWxMbUo1ZEdWekxDQnlZWEpwZEhrdVlubDBaWE1wTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNJQ0FqSUZWelpTQnRhVzVwYlhWdElIUnlZVzV6WVdOMGFXOXVJR1psWlFvZ0lDQWdaMnh2WW1Gc0lFMXBibFI0YmtabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3hNREVLSUNBZ0lDOHZJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakV3TWkweE1EUUtJQ0FnSUM4dklISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdZMnhoZDJKaFkyczlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdSMWNHNGdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94TURZdE1UQTNDaUFnSUNBdkx5QWpJRk4wYjNKbElHSmhjMmxqSUdsMFpXMGdhVzVtYnlCcGJpQnViM1JsSUdacFpXeGtDaUFnSUNBdkx5QnViM1JsUFc5d0xtTnZibU5oZENocGRHVnRYMjVoYldVdVlubDBaWE1zSUhKaGNtbDBlUzVpZVhSbGN5a3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMlpwWld4a0lFNXZkR1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJEYkdGM1ltRmphd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVp5WldWNlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z1pHVm1ZWFZzZEY5bWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxabUYxYkhSR2NtOTZaVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2T1RrS0lDQWdJQzh2SUdSbFkybHRZV3h6UFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2T1RnS0lDQWdJQzh2SUhSdmRHRnNQVlZKYm5RMk5DZ3hLU3dnSUNNZ1ZXNXBjWFZsSUdsMFpXMEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2T1RNdE9UUUtJQ0FnSUM4dklDTWdRM0psWVhSbElFRlRRU0JtYjNJZ2RHaGxJR2wwWlcwZ0tITnBiWEJzYVdacFpXUWdkMmwwYUc5MWRDQmpiMjF3YkdWNElHMWxkR0ZrWVhSaElITjBjblZqZENrS0lDQWdJQzh2SUdsMFpXMWZkVzVwZEY5dVlXMWxJRDBnVTNSeWFXNW5LQ0pCVEVkSlZFVk5JaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRVXhIU1ZSRlRTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnYVhSbGJWOWhjMkVnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdhVzUwWTE4eUlDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2prMUxURXdPQW9nSUNBZ0x5OGdhWFJsYlY5aGMyRWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOWFYUmxiVjl1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFwZEdWdFgzVnVhWFJmYm1GdFpTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMVZTVzUwTmpRb01Ta3NJQ0FqSUZWdWFYRjFaU0JwZEdWdENpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWm5KdmVtVnVQVVpoYkhObExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnM5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQ0FnSXlCVmMyVWdiV2x1YVcxMWJTQjBjbUZ1YzJGamRHbHZiaUJtWldVS0lDQWdJQzh2SUNBZ0lDQWpJRk4wYjNKbElHSmhjMmxqSUdsMFpXMGdhVzVtYnlCcGJpQnViM1JsSUdacFpXeGtDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMXZjQzVqYjI1allYUW9hWFJsYlY5dVlXMWxMbUo1ZEdWekxDQnlZWEpwZEhrdVlubDBaWE1wTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ6YzJWMFNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJsMFpXMXpYMk55WldGMFpXUXVkbUZzZFdVZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hmYVhSbGJYTmZZM0psWVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXBkR1Z0YzE5amNtVmhkR1ZrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNYMmwwWlcxelgyTnlaV0YwWldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3hNVFVLSUNBZ0lDOHZJR3h2WnloQ2VYUmxjeWhpSWtsMFpXMGdZM0psWVhSbFpDSXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORGszTkRZMU5tUXlNRFl6TnpJMk5UWXhOelEyTlRZMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QnlaWFIxY200Z2FYUmxiVjloYzJFdVkzSmxZWFJsWkY5aGMzTmxkQzVwWkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZzWjI5eVpXRnNiUzVqYjI1MGNtRmpkQzVCYkdkdlVtVmhiRzFIWVcxbFRXRnVZV2RsY2k1eVpXTnZkbVZ5WDJ4dmMzUmZhWFJsYlNodmNtbG5hVzVoYkY5cGRHVnRYMmxrT2lCMWFXNTBOalFzSUhKbFkyOTJaWEo1WDNGMVpYTjBYM0J5YjI5bU9pQmllWFJsY3l3Z2JtVjNYM0psWTJsd2FXVnVkRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LY21WamIzWmxjbDlzYjNOMFgybDBaVzA2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pFeE9DMHhNalFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlISmxZMjkyWlhKZmJHOXpkRjlwZEdWdEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdiM0pwWjJsdVlXeGZhWFJsYlY5cFpEb2dRWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNabGNubGZjWFZsYzNSZmNISnZiMlk2SUVKNWRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUc1bGQxOXlaV05wY0dsbGJuUTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3hNekFLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVEk1TFRFek1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVhWE5mY21WbmFYTjBaWEpsWkZzS0lDQWdJQzh2SUNBZ0lDQlVlRzR1YzJWdVpHVnlDaUFnSUNBdkx5QmRMQ0FpVDI1c2VTQnlaV2RwYzNSbGNtVmtJSEJzWVhsbGNuTWdZMkZ1SUhKbFkyOTJaWElnYVhSbGJYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3hNamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzSmxaMmx6ZEdWeVpXUmJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBjMTl5WldkcGMzUmxjbVZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveE1qa3RNVE14Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOXlaV2RwYzNSbGNtVmtXd29nSUNBZ0x5OGdJQ0FnSUZSNGJpNXpaVzVrWlhJS0lDQWdJQzh2SUYwc0lDSlBibXg1SUhKbFoybHpkR1Z5WldRZ2NHeGhlV1Z5Y3lCallXNGdjbVZqYjNabGNpQnBkR1Z0Y3lJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHpYM0psWjJsemRHVnlaV1FnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCeVpXZHBjM1JsY21Wa0lIQnNZWGxsY25NZ1kyRnVJSEpsWTI5MlpYSWdhWFJsYlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1UTXpMVEV6TmdvZ0lDQWdMeThnSXlCSFpYUWdiM0pwWjJsdVlXd2dhWFJsYlNCdFpYUmhaR0YwWVFvZ0lDQWdMeThnYjNKcFoybHVZV3hmYldWMFlXUmhkR0ZmY21WemNHOXVjMlVnUFNCdmNDNUJjM05sZEZCaGNtRnRjMGRsZEM1aGMzTmxkRjl0WlhSaFpHRjBZVjlvWVhOb0tBb2dJQ0FnTHk4Z0lDQWdJRzl5YVdkcGJtRnNYMmwwWlcxZmFXUUtJQ0FnSUM4dklDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFMWxkR0ZrWVhSaFNHRnphQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakV6TndvZ0lDQWdMeThnWVhOelpYSjBJRzl5YVdkcGJtRnNYMjFsZEdGa1lYUmhYM0psYzNCdmJuTmxXekJkTENBaVQzSnBaMmx1WVd3Z2FYUmxiU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBjbWxuYVc1aGJDQnBkR1Z0SUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveE16a3RNVFF3Q2lBZ0lDQXZMeUFqSUZabGNtbG1lU0J5WldOdmRtVnllU0J4ZFdWemRDQmpiMjF3YkdWMGFXOXVJQ2h6YVcxd2JHbG1hV1ZrSUMwZ2FXNGdjbVZoYkNCbllXMWxMQ0JqYUdWamF5QnhkV1Z6ZENCemVYTjBaVzBwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNabGNubGZjWFZsYzNSZmNISnZiMllnSVQwZ1FubDBaWE1vS1N3Z0lrMTFjM1FnY0hKdmRtbGtaU0J5WldOdmRtVnllU0J4ZFdWemRDQndjbTl2WmlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnY0hKdmRtbGtaU0J5WldOdmRtVnllU0J4ZFdWemRDQndjbTl2WmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveE5ESXRNVFF6Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJSEpsWTI5MlpYSjVJR3hwYldsMGN3b2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5eVpXTnZkbVZ5ZVY5amIzVnVkQ0E5SUhObGJHWXVjR3hoZVdWeVgzSmxZMjkyWlhKNVgyTnZkVzUwVzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljR3hoZVdWeVgzSmxZMjkyWlhKNVgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHeGhlV1Z5WDNKbFkyOTJaWEo1WDJOdmRXNTBJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94TkRVS0lDQWdJQzh2SUdOMWNuSmxiblJmY21WamIzWmxjbmxmWTI5MWJuUWdQQ0J6Wld4bUxtMWhlRjl5WldOdmRtVnllVjl3WlhKZmFYUmxiUzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW0xaGVGOXlaV052ZG1WeWVWOXdaWEpmYVhSbGJTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WVhoZmNtVmpiM1psY25sZmNHVnlYMmwwWlcwZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94TkRRdE1UUTJDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJR04xY25KbGJuUmZjbVZqYjNabGNubGZZMjkxYm5RZ1BDQnpaV3htTG0xaGVGOXlaV052ZG1WeWVWOXdaWEpmYVhSbGJTNTJZV3gxWlFvZ0lDQWdMeThnS1N3Z0lsSmxZMjkyWlhKNUlHeHBiV2wwSUhKbFlXTm9aV1FnTFNCdFlYZ2dNeUJ5WldOdmRtVnlhV1Z6SUhCbGNpQndiR0Y1WlhJaUNpQWdJQ0JoYzNObGNuUWdMeThnVW1WamIzWmxjbmtnYkdsdGFYUWdjbVZoWTJobFpDQXRJRzFoZUNBeklISmxZMjkyWlhKcFpYTWdjR1Z5SUhCc1lYbGxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94TkRndE1UUTVDaUFnSUNBdkx5QWpJRWRsZENCdmNtbG5hVzVoYkNCcGRHVnRJRzVoYldVZ1ptOXlJRzVsZHlCQlUwRUtJQ0FnSUM4dklHOXlhV2RwYm1Gc1gyNWhiV1ZmY21WemNHOXVjMlVnUFNCdmNDNUJjM05sZEZCaGNtRnRjMGRsZEM1aGMzTmxkRjl1WVcxbEtHOXlhV2RwYm1Gc1gybDBaVzFmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhST1lXMWxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVFV3Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0pwWjJsdVlXeGZibUZ0WlY5eVpYTndiMjV6WlZzd1hTd2dJa05oYm01dmRDQm5aWFFnYjNKcFoybHVZV3dnYVhSbGJTQnVZVzFsSWdvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMkZ1Ym05MElHZGxkQ0J2Y21sbmFXNWhiQ0JwZEdWdElHNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TVRVMENpQWdJQ0F2THlCeVpXTnZkbVZ5ZVY5dWIzUmxJRDBnYjNBdVkyOXVZMkYwS0VKNWRHVnpLR0lpVWtWRFQxWkZVa1ZFWDBsVVJVMWZJaWtzSUhKbFkyOTJaWEo1WDNGMVpYTjBYM0J5YjI5bUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5USTBOVFF6TkdZMU5qUTFOVEkwTlRRME5XWTBPVFUwTkRVMFpEVm1DaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94TlRVdE1UWTNDaUFnSUNBdkx5QnlaV052ZG1WeVpXUmZhWFJsYlY5aGMyRWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOWNtVmpiM1psY21Wa1gyNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBWTjBjbWx1WnlnaVFVeEhVa1ZEVDFZaUtTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHUmxabUYxYkhSZlpuSnZlbVZ1UFVaaGJITmxMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhkMkpoWTJzOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTENBZ0l5QlZjMlVnYldsdWFXMTFiU0IwY21GdWMyRmpkR2x2YmlCbVpXVUtJQ0FnSUM4dklDQWdJQ0J1YjNSbFBYSmxZMjkyWlhKNVgyNXZkR1VzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakUyTlFvZ0lDQWdMeThnWm1WbFBVZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTd2dJQ01nVlhObElHMXBibWx0ZFcwZ2RISmhibk5oWTNScGIyNGdabVZsQ2lBZ0lDQm5iRzlpWVd3Z1RXbHVWSGh1Um1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVFl5TFRFMk5Bb2dJQ0FnTHk4Z2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnWm5KbFpYcGxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QmpiR0YzWW1GamF6MUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWkhWd2JpQXpDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJuSmxaWHBsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVW1WelpYSjJaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTFoYm1GblpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUJrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWbVlYVnNkRVp5YjNwbGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR1JsWTJsdFlXeHpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSR1ZqYVcxaGJITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVFU0Q2lBZ0lDQXZMeUIwYjNSaGJEMVZTVzUwTmpRb01Ta3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGUnZkR0ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pFMU53b2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBWTjBjbWx1WnlnaVFVeEhVa1ZEVDFZaUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBaVFVeEhVa1ZEVDFZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1UVXlMVEUxTXdvZ0lDQWdMeThnSXlCRGNtVmhkR1VnVGtWWElFRlRRU0IzYVhSb0lITmhiV1VnY0hKdmNHVnlkR2xsY3lCaWRYUWdiV0Z5YTJWa0lHRnpJSEpsWTI5MlpYSmxaQW9nSUNBZ0x5OGdjbVZqYjNabGNtVmtYMjVoYldVZ1BTQlRkSEpwYm1jb0lsSkZRMDlXUlZKRlJGOUpWRVZOSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpVWtWRFQxWkZVa1ZFWDBsVVJVMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklISmxZMjkyWlhKbFpGOXBkR1Z0WDJGellTQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCcGJuUmpYeklnTHk4Z1lXTm1ad29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVFUxTFRFMk53b2dJQ0FnTHk4Z2NtVmpiM1psY21Wa1gybDBaVzFmWVhOaElEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFhKbFkyOTJaWEpsWkY5dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxVGRISnBibWNvSWtGTVIxSkZRMDlXSWlrc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXWmhkV3gwWDJaeWIzcGxiajFHWVd4elpTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dnSUNNZ1ZYTmxJRzFwYm1sdGRXMGdkSEpoYm5OaFkzUnBiMjRnWm1WbENpQWdJQ0F2THlBZ0lDQWdibTkwWlQxeVpXTnZkbVZ5ZVY5dWIzUmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRnpjMlYwU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1UY3lMVEUzTXdvZ0lDQWdMeThnSXlCVmNHUmhkR1VnY0d4aGVXVnlJSEpsWTI5MlpYSjVJR052ZFc1MENpQWdJQ0F2THlCelpXeG1MbkJzWVhsbGNsOXlaV052ZG1WeWVWOWpiM1Z1ZEZ0VWVHNHVjMlZ1WkdWeVhTQTlJR04xY25KbGJuUmZjbVZqYjNabGNubGZZMjkxYm5RZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndiR0Y1WlhKZmNtVmpiM1psY25sZlkyOTFiblFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNVGMxQ2lBZ0lDQXZMeUJzYjJjb1FubDBaWE1vWWlKSmRHVnRJSEpsWTI5MlpYSmxaQ0lwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRrM05EWTFObVF5TURjeU5qVTJNelptTnpZMk5UY3lOalUyTkFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pFM05nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbFkyOTJaWEpsWkY5cGRHVnRYMkZ6WVM1amNtVmhkR1ZrWDJGemMyVjBMbWxrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNKbFlXeHRMbU52Ym5SeVlXTjBMa0ZzWjI5U1pXRnNiVWRoYldWTllXNWhaMlZ5TG5ObFlYTnZibUZzWDJWMlpXNTBYM0psYVhOemRXVW9aWFpsYm5SZmJtRnRaVG9nWW5sMFpYTXNJSEJoY25ScFkybHdZWFJwYjI1ZmNISnZiMlk2SUdKNWRHVnpMQ0J5WldOcGNHbGxiblE2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q25ObFlYTnZibUZzWDJWMlpXNTBYM0psYVhOemRXVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakUzT0MweE9ERUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhObFlYTnZibUZzWDJWMlpXNTBYM0psYVhOemRXVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd2daWFpsYm5SZmJtRnRaVG9nVTNSeWFXNW5MQ0J3WVhKMGFXTnBjR0YwYVc5dVgzQnliMjltT2lCQ2VYUmxjeXdnY21WamFYQnBaVzUwT2lCQlkyTnZkVzUwQ2lBZ0lDQXZMeUFwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94T0RZS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpYM0psWjJsemRHVnlaV1JiVkhodUxuTmxibVJsY2wwc0lDSlBibXg1SUhKbFoybHpkR1Z5WldRZ2NHeGhlV1Z5Y3lCallXNGdjR0Z5ZEdsamFYQmhkR1VpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFYTmZjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzSmxaMmx6ZEdWeVpXUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J5WldkcGMzUmxjbVZrSUhCc1lYbGxjbk1nWTJGdUlIQmhjblJwWTJsd1lYUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakU0TndvZ0lDQWdMeThnWVhOelpYSjBJSEJoY25ScFkybHdZWFJwYjI1ZmNISnZiMllnSVQwZ1FubDBaWE1vS1N3Z0lrMTFjM1FnY0hKdmRtbGtaU0J3WVhKMGFXTnBjR0YwYVc5dUlIQnliMjltSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1RYVnpkQ0J3Y205MmFXUmxJSEJoY25ScFkybHdZWFJwYjI0Z2NISnZiMllLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCelpXRnpiMjVoYkY5dWIzUmxJRDBnYjNBdVkyOXVZMkYwS0VKNWRHVnpLR0lpVTBWQlUwOU9RVXhmSWlrc0lIQmhjblJwWTJsd1lYUnBiMjVmY0hKdmIyWXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFNelExTkRFMU16Um1OR1UwTVRSak5XWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakU1TXkweU1ETUtJQ0FnSUM4dklITmxZWE52Ym1Gc1gyRnpZU0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMXpaV0Z6YjI1aGJGOXBkR1Z0WDI1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFZOMGNtbHVaeWdpUVV4SFUwVkJVMDRpS1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQxVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWm5KdmVtVnVQVVpoYkhObExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBVZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTd2dJQ01nVlhObElHMXBibWx0ZFcwZ2RISmhibk5oWTNScGIyNGdabVZsQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDF6WldGemIyNWhiRjl1YjNSbExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU1ERUtJQ0FnSUM4dklHWmxaVDFIYkc5aVlXd3ViV2x1WDNSNGJsOW1aV1VzSUNBaklGVnpaU0J0YVc1cGJYVnRJSFJ5WVc1ellXTjBhVzl1SUdabFpRb2dJQ0FnWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94T1RrS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJd01Bb2dJQ0FnTHk4Z2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1RtOTBaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qRTVPQW9nSUNBZ0x5OGdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWm1GMWJIUkdjbTk2Wlc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1UazNDaUFnSUNBdkx5QmtaV05wYldGc2N6MVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxZMmx0WVd4ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qRTVOZ29nSUNBZ0x5OGdkRzkwWVd3OVZVbHVkRFkwS0RFcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG94T1RVS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQxVGRISnBibWNvSWtGTVIxTkZRVk5PSWlrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGTVIxTkZRVk5PSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pFNE9TMHhPVEFLSUNBZ0lDOHZJQ01nUTNKbFlYUmxJSE5sWVhOdmJtRnNJR2wwWlcwZ1ltRnpaV1FnYjI0Z1pYWmxiblFLSUNBZ0lDOHZJSE5sWVhOdmJtRnNYMmwwWlcxZmJtRnRaU0E5SUZOMGNtbHVaeWdpVTBWQlUwOU9RVXhmU1ZSRlRTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsTkZRVk5QVGtGTVgwbFVSVTBpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3hPVE1LSUNBZ0lDOHZJSE5sWVhOdmJtRnNYMkZ6WVNBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0JwYm5Salh6SWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1Ua3pMVEl3TXdvZ0lDQWdMeThnYzJWaGMyOXVZV3hmWVhOaElEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFhObFlYTnZibUZzWDJsMFpXMWZibUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlVM1J5YVc1bktDSkJURWRUUlVGVFRpSXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQVlZKYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3oxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTENBZ0l5QlZjMlVnYldsdWFXMTFiU0IwY21GdWMyRmpkR2x2YmlCbVpXVUtJQ0FnSUM4dklDQWdJQ0J1YjNSbFBYTmxZWE52Ym1Gc1gyNXZkR1VzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lNRGdLSUNBZ0lDOHZJR3h2WnloQ2VYUmxjeWhpSWxObFlYTnZibUZzSUdsMFpXMGdhWE56ZFdWa0lpa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFNelkxTmpFM016Wm1ObVUyTVRaak1qQTJPVGMwTmpVMlpESXdOamszTXpjek56VTJOVFkwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpBNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWaGMyOXVZV3hmWVhOaExtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdmNtVmhiRzB1WTI5dWRISmhZM1F1UVd4bmIxSmxZV3h0UjJGdFpVMWhibUZuWlhJdVkzSmhablJmYVhSbGJYTW9iV0YwWlhKcFlXeGZNVG9nZFdsdWREWTBMQ0J0WVhSbGNtbGhiRjh5T2lCMWFXNTBOalFzSUhKbFkybHdaVjlwWkRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtTnlZV1owWDJsMFpXMXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TVRFdE1qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCamNtRm1kRjlwZEdWdGN5Z0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxDQnRZWFJsY21saGJGOHhPaUJCYzNObGRDd2diV0YwWlhKcFlXeGZNam9nUVhOelpYUXNJSEpsWTJsd1pWOXBaRG9nVlVsdWREWTBDaUFnSUNBdkx5QXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lNVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzSmxaMmx6ZEdWeVpXUmJWSGh1TG5ObGJtUmxjbDBzSUNKUGJteDVJSEpsWjJsemRHVnlaV1FnY0d4aGVXVnljeUJqWVc0Z1kzSmhablFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFYTmZjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzSmxaMmx6ZEdWeVpXUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J5WldkcGMzUmxjbVZrSUhCc1lYbGxjbk1nWTJGdUlHTnlZV1owQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJeU55MHlNellLSUNBZ0lDOHZJR055WVdaMFpXUmZZWE5oSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQV055WVdaMFpXUmZhWFJsYlY5dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxVGRISnBibWNvSWtGTVIwTlNRVVpVSWlrc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXWmhkV3gwWDJaeWIzcGxiajFHWVd4elpTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBVZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTd2dJQ01nVlhObElHMXBibWx0ZFcwZ2RISmhibk5oWTNScGIyNGdabVZsQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDFDZVhSbGN5aGlJa05TUVVaVVJVUmZTVlJGVFNJcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU16UUtJQ0FnSUM4dklHWmxaVDFIYkc5aVlXd3ViV2x1WDNSNGJsOW1aV1VzSUNBaklGVnpaU0J0YVc1cGJYVnRJSFJ5WVc1ellXTjBhVzl1SUdabFpRb2dJQ0FnWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TXpNS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJek5Rb2dJQ0FnTHk4Z2JtOTBaVDFDZVhSbGN5aGlJa05TUVVaVVJVUmZTVlJGVFNJcExBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZzBNelV5TkRFME5qVTBORFUwTkRWbU5EazFORFExTkdRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1qTXlDaUFnSUNBdkx5QmtaV1poZFd4MFgyWnliM3BsYmoxR1lXeHpaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSR1ZtWVhWc2RFWnliM3BsYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU16RUtJQ0FnSUM4dklHUmxZMmx0WVd4elBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1qTXdDaUFnSUNBdkx5QjBiM1JoYkQxVlNXNTBOalFvTVNrc0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakl5T1FvZ0lDQWdMeThnZFc1cGRGOXVZVzFsUFZOMGNtbHVaeWdpUVV4SFExSkJSbFFpS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUFpUVV4SFExSkJSbFFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpJMExUSXlOUW9nSUNBZ0x5OGdJeUJEY21WaGRHVWdZM0poWm5SbFpDQnBkR1Z0SUdKaGMyVmtJRzl1SUhKbFkybHdaUW9nSUNBZ0x5OGdZM0poWm5SbFpGOXBkR1Z0WDI1aGJXVWdQU0JUZEhKcGJtY29Ja05TUVVaVVJVUmZTVlJGVFNJcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVExSkJSbFJGUkY5SlZFVk5JZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1qSTNDaUFnSUNBdkx5QmpjbUZtZEdWa1gyRnpZU0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpJM0xUSXpOZ29nSUNBZ0x5OGdZM0poWm5SbFpGOWhjMkVnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlZM0poWm5SbFpGOXBkR1Z0WDI1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFZOMGNtbHVaeWdpUVV4SFExSkJSbFFpS1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQxVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWm5KdmVtVnVQVVpoYkhObExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtWldVOVIyeHZZbUZzTG0xcGJsOTBlRzVmWm1WbExDQWdJeUJWYzJVZ2JXbHVhVzExYlNCMGNtRnVjMkZqZEdsdmJpQm1aV1VLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxQVUo1ZEdWektHSWlRMUpCUmxSRlJGOUpWRVZOSWlrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TkRJS0lDQWdJQzh2SUd4dlp5aENlWFJsY3loaUlrbDBaVzBnWTNKaFpuUmxaQ0lwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRrM05EWTFObVF5TURZek56STJNVFkyTnpRMk5UWTBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNalF6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZM0poWm5SbFpGOWhjMkV1WTNKbFlYUmxaRjloYzNObGRDNXBaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnNaMjl5WldGc2JTNWpiMjUwY21GamRDNUJiR2R2VW1WaGJHMUhZVzFsVFdGdVlXZGxjaTVuWlhSZmNHeGhlV1Z5WDNOMFlYUnpLSEJzWVhsbGNqb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRNkNtZGxkRjl3YkdGNVpYSmZjM1JoZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qSTBOUzB5TkRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZjR3hoZVdWeVgzTjBZWFJ6S0hObGJHWXNJSEJzWVhsbGNqb2dRV05qYjNWdWRDa2dMVDRnZEhWd2JHVmJWVWx1ZERZMExDQlZTVzUwTmpRc0lGVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXhJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpRNENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXBjMTl5WldkcGMzUmxjbVZrVzNCc1lYbGxjbDBzSUNKUWJHRjVaWElnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKcGMxOXlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOZmNtVm5hWE4wWlhKbFpDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUWJHRjVaWElnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNalV3Q2lBZ0lDQXZMeUJ6Wld4bUxuQnNZWGxsY2w5c1pYWmxiRnR3YkdGNVpYSmRMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWNHeGhlV1Z5WDJ4bGRtVnNJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0d4aGVXVnlYMnhsZG1Wc0lHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lOVEVLSUNBZ0lDOHZJSE5sYkdZdWNHeGhlV1Z5WDJWNGNHVnlhV1Z1WTJWYmNHeGhlV1Z5WFN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0p3YkdGNVpYSmZaWGh3WlhKcFpXNWpaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Cc1lYbGxjbDlsZUhCbGNtbGxibU5sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU5USUtJQ0FnSUM4dklITmxiR1l1Y0d4aGVXVnlYM0psWTI5MlpYSjVYMk52ZFc1MFczQnNZWGxsY2wwc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YkdGNVpYSmZjbVZqYjNabGNubGZZMjkxYm5RaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdiR0Y1WlhKZmNtVmpiM1psY25sZlkyOTFiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKbFlXeHRMMk52Ym5SeVlXTjBMbkI1T2pJME9TMHlOVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNXdiR0Y1WlhKZmJHVjJaV3hiY0d4aGVXVnlYU3dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MbkJzWVhsbGNsOWxlSEJsY21sbGJtTmxXM0JzWVhsbGNsMHNDaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNXdiR0Y1WlhKZmNtVmpiM1psY25sZlkyOTFiblJiY0d4aGVXVnlYU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhiR2R2Y21WaGJHMHVZMjl1ZEhKaFkzUXVRV3huYjFKbFlXeHRSMkZ0WlUxaGJtRm5aWEl1WVdSMllXNWpaVjl6WldGemIyNG9LU0F0UGlCMWFXNTBOalE2Q21Ga2RtRnVZMlZmYzJWaGMyOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TlRrS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1bllXMWxYMjFoYzNSbGNpNTJZV3gxWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltZGhiV1ZmYldGemRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kaGJXVmZiV0Z6ZEdWeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpVNExUSTJNQW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WjJGdFpWOXRZWE4wWlhJdWRtRnNkV1VLSUNBZ0lDOHZJQ2tzSUNKUGJteDVJR2RoYldVZ2JXRnpkR1Z5SUdOaGJpQmhaSFpoYm1ObElITmxZWE52YmlJS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHZGhiV1VnYldGemRHVnlJR05oYmlCaFpIWmhibU5sSUhObFlYTnZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TmpFS0lDQWdJQzh2SUhObGJHWXVZM1Z5Y21WdWRGOXpaV0Z6YjI0dWRtRnNkV1VnS3owZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OMWNuSmxiblJmYzJWaGMyOXVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OMWNuSmxiblJmYzJWaGMyOXVJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbU4xY25KbGJuUmZjMlZoYzI5dUlnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakkyTWdvZ0lDQWdMeThnYkc5bktFSjVkR1Z6S0dJaVUyVmhjMjl1SUdGa2RtRnVZMlZrSWlrcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU16WTFOakUzTXpabU5tVXlNRFl4TmpRM05qWXhObVUyTXpZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lOak1LSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1OMWNuSmxiblJmYzJWaGMyOXVMblpoYkhWbENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzSmxZV3h0TG1OdmJuUnlZV04wTGtGc1oyOVNaV0ZzYlVkaGJXVk5ZVzVoWjJWeUxtZGxkRjluWVcxbFgybHVabThvS1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwblpYUmZaMkZ0WlY5cGJtWnZPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TmprS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNHeGhlV1Z5Y3k1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBiM1JoYkY5d2JHRjVaWEp6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNCc1lYbGxjbk1nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakkzTUFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5cGRHVnRjMTlqY21WaGRHVmtMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNYMmwwWlcxelgyTnlaV0YwWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmFYUmxiWE5mWTNKbFlYUmxaQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbVZoYkcwdlkyOXVkSEpoWTNRdWNIazZNamN4Q2lBZ0lDQXZMeUJ6Wld4bUxtTjFjbkpsYm5SZmMyVmhjMjl1TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltTjFjbkpsYm5SZmMyVmhjMjl1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTjFjbkpsYm5SZmMyVmhjMjl1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95TmpndE1qY3lDaUFnSUNBdkx5QnlaWFIxY200Z0tBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZdWRHOTBZV3hmY0d4aGVXVnljeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxuUnZkR0ZzWDJsMFpXMXpYMk55WldGMFpXUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdjMlZzWmk1amRYSnlaVzUwWDNObFlYTnZiaTUyWVd4MVpTd0tJQ0FnSUM4dklDa0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJHZHZjbVZoYkcwdVkyOXVkSEpoWTNRdVFXeG5iMUpsWVd4dFIyRnRaVTFoYm1GblpYSXVZMnhoYVcxZmFYUmxiU2hwZEdWdFgybGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BqYkdGcGJWOXBkR1Z0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU56UXRNamMxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQmpiR0ZwYlY5cGRHVnRLSE5sYkdZc0lHbDBaVzFmYVdRNklFRnpjMlYwS1NBdFBpQlRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21WaGJHMHZZMjl1ZEhKaFkzUXVjSGs2TWpnd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXBjMTl5WldkcGMzUmxjbVZrVzFSNGJpNXpaVzVrWlhKZExDQWlUMjVzZVNCeVpXZHBjM1JsY21Wa0lIQnNZWGxsY25NZ1kyRnVJR05zWVdsdElHbDBaVzF6SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltbHpYM0psWjJsemRHVnlaV1FpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMxOXlaV2RwYzNSbGNtVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY21WbmFYTjBaWEpsWkNCd2JHRjVaWEp6SUdOaGJpQmpiR0ZwYlNCcGRHVnRjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WldGc2JTOWpiMjUwY21GamRDNXdlVG95T0RJdE1qZ3pDaUFnSUNBdkx5QWpJRlpsY21sbWVTQjBhR1VnWVhOelpYUWdaWGhwYzNSekNpQWdJQ0F2THlCdFlXNWhaMlZ5WDNKbGMzQnZibk5sSUQwZ2IzQXVRWE56WlhSUVlYSmhiWE5IWlhRdVlYTnpaWFJmYldGdVlXZGxjaWhwZEdWdFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qSTROQW9nSUNBZ0x5OGdZWE56WlhKMElHMWhibUZuWlhKZmNtVnpjRzl1YzJWYk1GMHNJQ0pCYzNObGRDQnViM1FnWm05MWJtUWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRWE56WlhRZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qSTROeTB5T1RNS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ2FYUmxiU0IwYnlCMGFHVWdjR3hoZVdWeUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5YVhSbGJWOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lPVElLSUNBZ0lDOHZJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0JuYkc5aVlXd2dUV2x1VkhodVJtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakk0T1FvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtVmhiRzB2WTI5dWRISmhZM1F1Y0hrNk1qa3dDaUFnSUNBdkx5QmhjM05sZEY5aGJXOTFiblE5VlVsdWREWTBLREVwTEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVpXRnNiUzlqYjI1MGNtRmpkQzV3ZVRveU9EY3RNamc0Q2lBZ0lDQXZMeUFqSUZSeVlXNXpabVZ5SUdsMFpXMGdkRzhnZEdobElIQnNZWGxsY2dvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lPRGN0TWprekNpQWdJQ0F2THlBaklGUnlZVzV6Wm1WeUlHbDBaVzBnZEc4Z2RHaGxJSEJzWVhsbGNnb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBWVkpiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdsMFpXMWZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakk1TlFvZ0lDQWdMeThnYkc5bktFSjVkR1Z6S0dJaVNYUmxiU0JqYkdGcGJXVmtJaWtwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwT1RjME5qVTJaREl3TmpNMll6WXhOamsyWkRZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlaV0ZzYlM5amIyNTBjbUZqZEM1d2VUb3lPVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lrbDBaVzBnYzNWalkyVnpjMloxYkd4NUlHTnNZV2x0WldRaElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVNYUmxiU0J6ZFdOalpYTnpablZzYkhrZ1kyeGhhVzFsWkNFaUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzSmxZV3h0TG1OdmJuUnlZV04wTGtGc1oyOVNaV0ZzYlVkaGJXVk5ZVzVoWjJWeUxtZGxkRjl5WldOdmRtVnllVjl6ZEdGMGRYTW9jR3hoZVdWeU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRNkNtZGxkRjl5WldOdmRtVnllVjl6ZEdGMGRYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPakk1T0MweU9Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmY21WamIzWmxjbmxmYzNSaGRIVnpLSE5sYkdZc0lIQnNZWGxsY2pvZ1FXTmpiM1Z1ZENrZ0xUNGdkSFZ3YkdWYlZVbHVkRFkwTENCVlNXNTBOalJkT2dvZ0lDQWdjSEp2ZEc4Z01TQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0psWVd4dEwyTnZiblJ5WVdOMExuQjVPak13TVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWFYTmZjbVZuYVhOMFpYSmxaRnR3YkdGNVpYSmRMQ0FpVUd4aGVXVnlJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVhOZmNtVm5hWE4wWlhKbFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx6WDNKbFoybHpkR1Z5WldRZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnVUd4aGVXVnlJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmxZV3h0TDJOdmJuUnlZV04wTG5CNU9qTXdNZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Y0d4aGVXVnlYM0psWTI5MlpYSjVYMk52ZFc1MFczQnNZWGxsY2wwc0lITmxiR1l1YldGNFgzSmxZMjkyWlhKNVgzQmxjbDlwZEdWdExuWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndiR0Y1WlhKZmNtVmpiM1psY25sZlkyOTFiblFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2JHRjVaWEpmY21WamIzWmxjbmxmWTI5MWJuUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJXRjRYM0psWTI5MlpYSjVYM0JsY2w5cGRHVnRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xaGVGOXlaV052ZG1WeWVWOXdaWEpmYVhSbGJTQmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBRURKZ3dFRlI5OGRRMXBjMTl5WldkcGMzUmxjbVZrQVFBVmNHeGhlV1Z5WDNKbFkyOTJaWEo1WDJOdmRXNTBEWFJ2ZEdGc1gzQnNZWGxsY25NVGRHOTBZV3hmYVhSbGJYTmZZM0psWVhSbFpBNWpkWEp5Wlc1MFgzTmxZWE52YmhWdFlYaGZjbVZqYjNabGNubGZjR1Z5WDJsMFpXMExaMkZ0WlY5dFlYTjBaWElNY0d4aGVXVnlYMnhsZG1Wc0VYQnNZWGxsY2w5bGVIQmxjbWxsYm1ObERFTlNRVVpVUlVSZlNWUkZUVEViUVFCVWdnc0VzMXFzT3dTRVBSalZCQ3BoaElBRTYray9pd1NnMFRUUUJJdk40NVlFUmRaZXl3UTdVblVmQkVlYWY1Y0VPdFh0MVFRQ3VEMEFOaG9BamdzQlRRRXNBUFVBMGdDdkFJNEFhZ0JaQURzQUhRQUNJa014R1JSRU1SaEVOaG9CRjhBY2lBU1JUQlpNRmxBb1RGQ3dJME14R1JSRU1SaEVOaG9CRjhBd2lBUWdTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFaUFQNFR3SVdUd0lXVHdJV1RnSlFURkFvVEZDd0kwTXhHUlJFTVJoRWlBT3lGaWhNVUxBalF6RVpGRVF4R0VRMkdnRVh3QnlJQTNwUEFoWlBBaFpQQWhaT0FsQk1VQ2hNVUxBalF6RVpGRVF4R0VRMkdnRVh3REEyR2dJWHdEQTJHZ01YaUFNRUZpaE1VTEFqUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTVh3QnlJQW0wV0tFeFFzQ05ETVJrVVJERVlSRFlhQVJmQU1EWWFBbGNDQURZYUF4ZkFISWdCcWhZb1RGQ3dJME14R1JSRU1SaEVOaG9CRjhBY05ob0NWd0lBTmhvRFZ3SUFOaG9FVndJQU5ob0ZGellhQmhjMkdnZFhBZ0NJQVEwV0tFeFFzQ05ESXpFWmtDUWFSREVZUkRZYUFWY0NBSWdBVlVrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWUZFU0lBQTVKRlJaWEJnSk1VQ2hNVUxBalF5Y0VJbWNuQlNKbkp3WWpaeWNISkdjbkNERUFaNEFXUVd4bmIxSmxZV3h0SUdsdWFYUnBZV3hwZW1Wa0lZbUtBUUV4R1NNU1FRQXZNUUFuQ1NKbU1RQW5DaUptTVFBckltWXhBQ2txWm9BV1QzQjBaV1FnYVc0Z2RHOGdRV3huYjFKbFlXeHRJWWt4QUNJcFkwUXFFMEVBSElBWlVHeGhlV1Z5SUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWklreEFDY0pJMll4QUNjS0ltWXhBQ3NpWmpFQUtZQUJnR1lpSndSbFJDTUlKd1JNWjR2L3NJQVZWMlZzWTI5dFpTQjBieUJCYkdkdlVtVmhiRzBoaVlvSEFURUFJaWNJWlVRU1JJdjVJaWxqUkNvVFJMRXlBRElLUndPTCtvdjhVTElGc2l5eUs3SXFzaWtpc2lRaXNpTWpzaUtBQjBGTVIwbFVSVTJ5Sll2NnNpWWtzaEN5QWJPMFBDSW5CV1ZFSXdnbkJVeG5nQXhKZEdWdElHTnlaV0YwWldTd2lZb0RBVEVBSWlsalJDb1RSSXY5Y1FaSUZVU0wvb0FBRTBReEFDSXJZMFFpSndkbFJFc0JEVVNML1hFRVNCVkVnQTlTUlVOUFZrVlNSVVJmU1ZSRlRWK0wvbEN4TWdBeUNrY0RUd1d5QmJJc3NpdXlLcklwSXJJa0lySWpJN0lpZ0FoQlRFZFNSVU5QVnJJbGdBNVNSVU5QVmtWU1JVUmZTVlJGVGJJbUpMSVFzZ0d6dER4TUl3Z3hBQ3RQQW1hQURrbDBaVzBnY21WamIzWmxjbVZrc0ltS0F3RXhBQ0lwWTBRcUUwU0wvb0FBRTBTQUNWTkZRVk5QVGtGTVg0ditVTEV5QURJS1NVOERzZ1d5S3JJcElySWtJcklqSTdJaWdBaEJURWRUUlVGVFRySWxnQTFUUlVGVFQwNUJURjlKVkVWTnNpWWtzaEN5QWJPMFBJQVVVMlZoYzI5dVlXd2dhWFJsYlNCcGMzTjFaV1N3aVlvREFURUFJaWxqUkNvVFJMRXlBRElLSnd1eUJiSXBJcklrSXJJakk3SWlnQWhCVEVkRFVrRkdWTElsSnd1eUppU3lFTElCczdROGdBeEpkR1Z0SUdOeVlXWjBaV1N3aVlvQkE0di9JaWxqUkNvVFJJdi9JaWNKWTBTTC95SW5DbU5FaS84aUsyTkVpVEVBSWljSVpVUVNSQ0luQm1WRUl3Z25Ca3NCWjRBUFUyVmhjMjl1SUdGa2RtRnVZMlZrc0lraUp3UmxSQ0luQldWRUlpY0daVVNKaWdFQk1RQWlLV05FS2hORWkvOXhCMGd5QXhORXNUSUFNUUNMLzdJUkk3SVNzaFNCQkxJUXNnR3pnQXhKZEdWdElHTnNZV2x0WldTd2dCcEpkR1Z0SUhOMVkyTmxjM05tZFd4c2VTQmpiR0ZwYldWa0lZbUtBUUtML3lJcFkwUXFFMFNML3lJclkwUWlKd2RsUklrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
