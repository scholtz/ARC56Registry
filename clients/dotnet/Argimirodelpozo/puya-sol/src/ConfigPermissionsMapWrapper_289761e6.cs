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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.ConfigPermissionsMapWrapper_289761e6
{


    public class ConfigPermissionsMapWrapperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConfigPermissionsMapWrapperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ConfigPermissionValues : AVMObjectType
            {
                public bool CanSetUsingAsCollateral { get; set; }

                public bool CanUpdateUserRiskPremium { get; set; }

                public bool CanUpdateUserDynamicConfig { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanSetUsingAsCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCanSetUsingAsCollateral.From(CanSetUsingAsCollateral);
                    ret.AddRange(vCanSetUsingAsCollateral.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserRiskPremium = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCanUpdateUserRiskPremium.From(CanUpdateUserRiskPremium);
                    ret.AddRange(vCanUpdateUserRiskPremium.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserDynamicConfig = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCanUpdateUserDynamicConfig.From(CanUpdateUserDynamicConfig);
                    ret.AddRange(vCanUpdateUserDynamicConfig.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ConfigPermissionValues Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ConfigPermissionValues();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanSetUsingAsCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCanSetUsingAsCollateral.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCanSetUsingAsCollateral = vCanSetUsingAsCollateral.ToValue();
                    if (valueCanSetUsingAsCollateral is bool vCanSetUsingAsCollateralValue) { ret.CanSetUsingAsCollateral = vCanSetUsingAsCollateralValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserRiskPremium = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCanUpdateUserRiskPremium.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCanUpdateUserRiskPremium = vCanUpdateUserRiskPremium.ToValue();
                    if (valueCanUpdateUserRiskPremium is bool vCanUpdateUserRiskPremiumValue) { ret.CanUpdateUserRiskPremium = vCanUpdateUserRiskPremiumValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserDynamicConfig = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCanUpdateUserDynamicConfig.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCanUpdateUserDynamicConfig = vCanUpdateUserDynamicConfig.ToValue();
                    if (valueCanUpdateUserDynamicConfig is bool vCanUpdateUserDynamicConfigValue) { ret.CanUpdateUserDynamicConfig = vCanUpdateUserDynamicConfigValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ConfigPermissionValues);
                }
                public bool Equals(ConfigPermissionValues? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ConfigPermissionValues left, ConfigPermissionValues right)
                {
                    return EqualityComparer<ConfigPermissionValues>.Default.Equals(left, right);
                }
                public static bool operator !=(ConfigPermissionValues left, ConfigPermissionValues right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="status"> </param>
        public async Task<ulong> SetFullPermissions(bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 175, 173, 155 };
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            var result = await base.SimApp(new List<object> { abiHandle, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetFullPermissions_Transactions(bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 175, 173, 155 };
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="perms"> </param>
        /// <param name="status"> </param>
        public async Task<ulong> SetCanSetUsingAsCollateral(ulong perms, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 254, 42, 244 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            var result = await base.SimApp(new List<object> { abiHandle, permsAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetCanSetUsingAsCollateral_Transactions(ulong perms, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 254, 42, 244 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, permsAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="perms"> </param>
        /// <param name="status"> </param>
        public async Task<ulong> SetCanUpdateUserRiskPremium(ulong perms, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 77, 14, 1 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            var result = await base.SimApp(new List<object> { abiHandle, permsAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetCanUpdateUserRiskPremium_Transactions(ulong perms, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 77, 14, 1 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, permsAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="perms"> </param>
        /// <param name="status"> </param>
        public async Task<ulong> SetCanUpdateUserDynamicConfig(ulong perms, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 182, 111, 195 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            var result = await base.SimApp(new List<object> { abiHandle, permsAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetCanUpdateUserDynamicConfig_Transactions(ulong perms, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 182, 111, 195 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, permsAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="perms"> </param>
        public async Task<bool> CanSetUsingAsCollateral(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 164, 108, 62 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            var result = await base.SimApp(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanSetUsingAsCollateral_Transactions(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 164, 108, 62 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            return await base.MakeTransactionList(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="perms"> </param>
        public async Task<bool> CanUpdateUserRiskPremium(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 68, 224, 92 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            var result = await base.SimApp(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanUpdateUserRiskPremium_Transactions(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 68, 224, 92 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            return await base.MakeTransactionList(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="perms"> </param>
        public async Task<bool> CanUpdateUserDynamicConfig(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 201, 108, 17 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            var result = await base.SimApp(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanUpdateUserDynamicConfig_Transactions(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 201, 108, 17 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            return await base.MakeTransactionList(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<bool> Eq(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 152, 42, 216 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.SimApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Eq_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 152, 42, 216 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="perms"> </param>
        public async Task<Structs.ConfigPermissionValues> GetConfigPermissionValues(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 137, 202, 179 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            var result = await base.SimApp(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ConfigPermissionValues.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConfigPermissionValues_Transactions(ulong perms, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 137, 202, 179 };
            var permsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permsAbi.From(perms);

            return await base.MakeTransactionList(new List<object> { abiHandle, permsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uZmlnUGVybWlzc2lvbnNNYXBXcmFwcGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNvbmZpZ1Blcm1pc3Npb25WYWx1ZXMiOlt7Im5hbWUiOiJjYW5TZXRVc2luZ0FzQ29sbGF0ZXJhbCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiY2FuVXBkYXRlVXNlclJpc2tQcmVtaXVtIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJjYW5VcGRhdGVVc2VyRHluYW1pY0NvbmZpZyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNldEZ1bGxQZXJtaXNzaW9ucyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRDYW5TZXRVc2luZ0FzQ29sbGF0ZXJhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXR1cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Q2FuVXBkYXRlVXNlclJpc2tQcmVtaXVtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRDYW5VcGRhdGVVc2VyRHluYW1pY0NvbmZpZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXR1cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuU2V0VXNpbmdBc0NvbGxhdGVyYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5VcGRhdGVVc2VyUmlza1ByZW1pdW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5VcGRhdGVVc2VyRHluYW1pY0NvbmZpZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVxIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb25maWdQZXJtaXNzaW9uVmFsdWVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iihib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJDb25maWdQZXJtaXNzaW9uVmFsdWVzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ4OCw1NTcsNjI2LDY3M10sImVycm9yTWVzc2FnZSI6IkFCSSBib29sIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODQsMjU4LDI2NiwzMTYsMzY2LDQxNiw0NzgsNTQ3LDYxNl0sImVycm9yTWVzc2FnZSI6IkFCSSB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU1LDUyNCw1OTMsNjUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MiwyMjUsMjM2LDI5NCwzNDQsMzk0LDQ0NCw1MTMsNTgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc4LDI1MiwzMTAsMzYwLDQxMCw0NzIsNTQxLDYxMCw2NjhdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndWM0poY0hCbGNpNXpiMnd1UTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhCWGNtRndjR1Z5TG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F5TlRVZ01DQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdNSGd3TUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURNS0lDQWdJSEIxYzJocGJuUWdOREE1TmdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdjM1J2Y21VZ05Rb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoa1pXRm1ZV1E1WWlBd2VHVmlabVV5WVdZMElEQjRNbVUwWkRCbE1ERWdNSGczTldJMk5tWmpNeUF3ZUdVeVlUUTJZek5sSURCNE5qZzBOR1V3TldNZ01IaGpNV001Tm1NeE1TQXdlRE5sT1RneVlXUTRJREI0T0RBNE9XTmhZak1nTHk4Z2JXVjBhRzlrSUNKelpYUkdkV3hzVUdWeWJXbHpjMmx2Ym5Nb1ltOXZiQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZEVOaGJsTmxkRlZ6YVc1blFYTkRiMnhzWVhSbGNtRnNLSFZwYm5RMk5DeGliMjlzS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYzJWMFEyRnVWWEJrWVhSbFZYTmxjbEpwYzJ0UWNtVnRhWFZ0S0hWcGJuUTJOQ3hpYjI5c0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWMyVjBRMkZ1VlhCa1lYUmxWWE5sY2tSNWJtRnRhV05EYjI1bWFXY29kV2x1ZERZMExHSnZiMndwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqWVc1VFpYUlZjMmx1WjBGelEyOXNiR0YwWlhKaGJDaDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWTJGdVZYQmtZWFJsVlhObGNsSnBjMnRRY21WdGFYVnRLSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKallXNVZjR1JoZEdWVmMyVnlSSGx1WVcxcFkwTnZibVpwWnloMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlaWEVvZFdsdWREWTBMSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUkRiMjVtYVdkUVpYSnRhWE56YVc5dVZtRnNkV1Z6S0hWcGJuUTJOQ2tvWW05dmJDeGliMjlzTEdKdmIyd3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXpaWFJHZFd4c1VHVnliV2x6YzJsdmJuTmZjbTkxZEdWQU5TQnRZV2x1WDNObGRFTmhibE5sZEZWemFXNW5RWE5EYjJ4c1lYUmxjbUZzWDNKdmRYUmxRRFlnYldGcGJsOXpaWFJEWVc1VmNHUmhkR1ZWYzJWeVVtbHphMUJ5WlcxcGRXMWZjbTkxZEdWQU55QnRZV2x1WDNObGRFTmhibFZ3WkdGMFpWVnpaWEpFZVc1aGJXbGpRMjl1Wm1sblgzSnZkWFJsUURnZ2JXRnBibDlqWVc1VFpYUlZjMmx1WjBGelEyOXNiR0YwWlhKaGJGOXliM1YwWlVBNUlHMWhhVzVmWTJGdVZYQmtZWFJsVlhObGNsSnBjMnRRY21WdGFYVnRYM0p2ZFhSbFFERXdJRzFoYVc1ZlkyRnVWWEJrWVhSbFZYTmxja1I1Ym1GdGFXTkRiMjVtYVdkZmNtOTFkR1ZBTVRFZ2JXRnBibDlsY1Y5eWIzVjBaVUF4TWlCdFlXbHVYMmRsZEVOdmJtWnBaMUJsY20xcGMzTnBiMjVXWVd4MVpYTmZjbTkxZEdWQU1UTUtJQ0FnSUdWeWNnb0tiV0ZwYmw5blpYUkRiMjVtYVdkUVpYSnRhWE56YVc5dVZtRnNkV1Z6WDNKdmRYUmxRREV6T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREU1Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREl3T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01qVTFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQjJZV3hwWkdGMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01qVTFDaUFnSUNBbUNpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0E0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQmpZV3hzYzNWaUlFTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbWRsZEVOdmJtWnBaMUJsY20xcGMzTnBiMjVXWVd4MVpYTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4T1RvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TUFvS2JXRnBibDlsY1Y5eWIzVjBaVUF4TWpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTFPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTWpVMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZDU1NCMllXeHBaR0YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTWpVMUNpQWdJQ0FtQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNalUxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNalUxQ2lBZ0lDQW1DaUFnSUNCallXeHNjM1ZpSUVOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xtVnhDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREkwT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREkxQ2dwdFlXbHVYMk5oYmxWd1pHRjBaVlZ6WlhKRWVXNWhiV2xqUTI5dVptbG5YM0p2ZFhSbFFERXhPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTVDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETXdPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTWpVMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZDU1NCMllXeHBaR0YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTWpVMUNpQWdJQ0FtQ2lBZ0lDQmpZV3hzYzNWaUlFTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbU5oYmxWd1pHRjBaVlZ6WlhKRWVXNWhiV2xqUTI5dVptbG5DaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREk1T2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE13Q2dwdFlXbHVYMk5oYmxWd1pHRjBaVlZ6WlhKU2FYTnJVSEpsYldsMWJWOXliM1YwWlVBeE1Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek5Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek5Ub0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREkxTlFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREkxTlFvZ0lDQWdKZ29nSUNBZ1kyRnNiSE4xWWlCRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNWpZVzVWY0dSaGRHVlZjMlZ5VW1semExQnlaVzFwZFcwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU16UTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU16VUtDbTFoYVc1ZlkyRnVVMlYwVlhOcGJtZEJjME52Ykd4aGRHVnlZV3hmY205MWRHVkFPVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ01nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpPUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBNRG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURJMU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURJMU5Rb2dJQ0FnSmdvZ0lDQWdZMkZzYkhOMVlpQkRiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzVqWVc1VFpYUlZjMmx1WjBGelEyOXNiR0YwWlhKaGJBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpPVG9LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBNQW9LYldGcGJsOXpaWFJEWVc1VmNHUmhkR1ZWYzJWeVJIbHVZVzFwWTBOdmJtWnBaMTl5YjNWMFpVQTRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFEwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFExT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01qVTFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQjJZV3hwWkdGMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01qVTFDaUFnSUNBbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ1ltOXZiQ0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlFTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbk5sZEVOaGJsVndaR0YwWlZWelpYSkVlVzVoYldsalEyOXVabWxuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNalUxQ2lBZ0lDQW1DaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTkRRNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTkRVS0NtMWhhVzVmYzJWMFEyRnVWWEJrWVhSbFZYTmxjbEpwYzJ0UWNtVnRhWFZ0WDNKdmRYUmxRRGM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JpZFhKNUlESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWRYSjVJREVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTkRrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTlRBNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlOVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FVSkpJSFpoYkdsa1lYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXlOVFVLSUNBZ0lDWUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQmliMjlzSUhaaGJHbGtZWFJwYjI0S0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEF1YzJWMFEyRnVWWEJrWVhSbFZYTmxjbEpwYzJ0UWNtVnRhWFZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNalUxQ2lBZ0lDQW1DaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTkRrNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTlRBS0NtMWhhVzVmYzJWMFEyRnVVMlYwVlhOcGJtZEJjME52Ykd4aGRHVnlZV3hmY205MWRHVkFOam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKMWNua2dNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTlRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklESTFOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklESTFOUW9nSUNBZ0pnb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklHSnZiMndnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQkRiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzV6WlhSRFlXNVRaWFJWYzJsdVowRnpRMjlzYkdGMFpYSmhiQW9nSUNBZ2FXNTBZMTh4SUM4dklESTFOUW9nSUNBZ0pnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFUwT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFUxQ2dwdFlXbHVYM05sZEVaMWJHeFFaWEp0YVhOemFXOXVjMTl5YjNWMFpVQTFPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU9Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk1Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnWW05dmJDQjJZV3hwWkdGMGFXOXVDaUFnSUNCallXeHNjM1ZpSUVOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xuTmxkRVoxYkd4UVpYSnRhWE56YVc5dWN3b2dJQ0FnYVc1MFkxOHhJQzh2SURJMU5Rb2dJQ0FnSmdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEVTVPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWXdDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjRmR5WVhCd1pYSXVjMjlzTGtOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xuTmxkRVoxYkd4UVpYSnRhWE56YVc5dWN5aHpkR0YwZFhNNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncERiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzV6WlhSR2RXeHNVR1Z5YldsemMybHZibk02Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQXFDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMME52Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3VjNKaGNIQmxjaTV6YjJ3dVEyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVjMlYwUTJGdVUyVjBWWE5wYm1kQmMwTnZiR3hoZEdWeVlXd29jMlZzWmpvZ2RXbHVkRFkwTENCemRHRjBkWE02SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNXpaWFJEWVc1VFpYUlZjMmx1WjBGelEyOXNiR0YwWlhKaGJEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUVOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xsOXpaWFJUZEdGMGRYTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEJYY21Gd2NHVnlMbk52YkM1RGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNXpaWFJEWVc1VmNHUmhkR1ZWYzJWeVVtbHphMUJ5WlcxcGRXMG9jMlZzWmpvZ2RXbHVkRFkwTENCemRHRjBkWE02SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNXpaWFJEWVc1VmNHUmhkR1ZWYzJWeVVtbHphMUJ5WlcxcGRXMDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnUTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVgzTmxkRk4wWVhSMWN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjRmR5WVhCd1pYSXVjMjlzTGtOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xuTmxkRU5oYmxWd1pHRjBaVlZ6WlhKRWVXNWhiV2xqUTI5dVptbG5LSE5sYkdZNklIVnBiblEyTkN3Z2MzUmhkSFZ6T2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVjMlYwUTJGdVZYQmtZWFJsVlhObGNrUjVibUZ0YVdORGIyNW1hV2M2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVYM05sZEZOMFlYUjFjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0ZkeVlYQndaWEl1YzI5c0xrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbWRsZEVOdmJtWnBaMUJsY20xcGMzTnBiMjVXWVd4MVpYTW9jMlZzWmpvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVaMlYwUTI5dVptbG5VR1Z5YldsemMybHZibFpoYkhWbGN6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbU5oYmxObGRGVnphVzVuUVhORGIyeHNZWFJsY21Gc0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbU5oYmxWd1pHRjBaVlZ6WlhKRWVXNWhiV2xqUTI5dVptbG5DaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRU52Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TG1OaGJsVndaR0YwWlZWelpYSlNhWE5yVUhKbGJXbDFiUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJSE4zWVhBS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjRmR5WVhCd1pYSXVjMjlzTGtOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xtTmhibE5sZEZWemFXNW5RWE5EYjJ4c1lYUmxjbUZzS0hObGJHWTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1allXNVRaWFJWYzJsdVowRnpRMjlzYkdGMFpYSmhiRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZMkZzYkhOMVlpQkRiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzVmWjJWMFUzUmhkSFZ6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd1YzSmhjSEJsY2k1emIyd3VRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEF1WTJGdVZYQmtZWFJsVlhObGNsSnBjMnRRY21WdGFYVnRLSE5sYkdZNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncERiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzVqWVc1VmNHUmhkR1ZWYzJWeVVtbHphMUJ5WlcxcGRXMDZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCallXeHNjM1ZpSUVOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xsOW5aWFJUZEdGMGRYTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEJYY21Gd2NHVnlMbk52YkM1RGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNWpZVzVWY0dSaGRHVlZjMlZ5UkhsdVlXMXBZME52Ym1acFp5aHpaV3htT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVZMkZ1VlhCa1lYUmxWWE5sY2tSNWJtRnRhV05EYjI1bWFXYzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCallXeHNjM1ZpSUVOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xsOW5aWFJUZEdGMGRYTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEJYY21Gd2NHVnlMbk52YkM1RGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNWxjU2h6Wld4bU9pQjFhVzUwTmpRc0lHOTBhR1Z5T2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVaWEU2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5RGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNGZHlZWEJ3WlhJdWMyOXNMa052Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TGw5elpYUlRkR0YwZFhNb2MyVnNaam9nZFdsdWREWTBMQ0J0WVhOck9pQjFhVzUwTmpRc0lITjBZWFIxY3pvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbDl6WlhSVGRHRjBkWE02Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5vZ1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVYM05sZEZOMFlYUjFjMTkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0I4Q2lBZ0lDQnlaWFJ6ZFdJS0NrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbDl6WlhSVGRHRjBkWE5mZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekVnTHk4Z01qVTFDaUFnSUNCZUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJQ1lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhCWGNtRndjR1Z5TG5OdmJDNURiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzVmWjJWMFUzUmhkSFZ6S0RJcFh6QW9jMlZzWmpvZ2RXbHVkRFkwTENCdFlYTnJPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LUTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVgyZGxkRk4wWVhSMWN6b0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjRmR5WVhCd1pYSXVjMjlzTGtOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xsOW5aWFJUZEdGMGRYTW9NaWxmTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5RGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNGZHlZWEJ3WlhJdWMyOXNMa052Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TGw5blpYUlRkR0YwZFhNb01pbGZNU2h6Wld4bU9pQjFhVzUwTmpRc0lHMWhjMnM2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndWM0poY0hCbGNpNXpiMnd1UTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVgyZGxkRk4wWVhSMWN5Z3lLVjh4T2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnSmdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lDRTlDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd1YzSmhjSEJsY2k1emIyd3VRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEJYY21Gd2NHVnlMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFmOEJBQWdtQWdRVkgzeDFBUUNBQUVjRGdZQWdyMGsxQlRVQU5BQ0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQVhFQTFBREVZUUFBQ0lrTXhHUlJFTVJoRWdna0UzcSt0bXdUci9pcjBCQzVORGdFRWRiWnZ3d1RpcEd3K0JHaEU0RndFd2Nsc0VRUSttQ3JZQklDSnlyTTJHZ0NPQ1FIcUFhVUJZQUViQU9rQXR3Q0ZBRUFBQVFBMkdnRkpGU1VTUkJkRkFqRVdRUUFyTVJZaUNUZ0lGRVJMQVVrakRrUWpHalFBZ1JpdlN3R0JXRnNpQ0JaUVhFQTFBSWdDRVNoTVVMQWlReVJDLzljMkdnRkpGU1VTUkJkRkJEWWFBa2tWSlJKRUYwVURNUlpCQUNZeEZpSUpPQWdVUkVzRFNTTU9SQ01hU3dOSkl3NUVJeHFJQWlJcEpFOENWQ2hNVUxBaVF5UkMvOXcyR2dGSkZTVVNSQmRGQWpFV1FRQWVNUllpQ1RnSUZFUkxBVWtqRGtRakdvZ0I1U2trVHdKVUtFeFFzQ0pESkVMLzVEWWFBVWtWSlJKRUYwVUNNUlpCQUI0eEZpSUpPQWdVUkVzQlNTTU9SQ01haUFHb0tTUlBBbFFvVEZDd0lrTWtRdi9rTmhvQlNSVWxFa1FYUlFJeEZrRUFIakVXSWdrNENCUkVTd0ZKSXc1RUl4cUlBV3dwSkU4Q1ZDaE1VTEFpUXlSQy8rUTJHZ0ZKRlNVU1JCZEZBallhQWtrVkloSkVKRk5GQVRFV1FRQWxNUllpQ1RnSUZFUkxBVWtqRGtRakdrc0JTVTRDSWc1RVRJZ0E1eU1hRmloTVVMQWlReVJDLzkwMkdnRkpGU1VTUkJkRkFqWWFBa2tWSWhKRUpGTkZBVEVXUVFBbE1SWWlDVGdJRkVSTEFVa2pEa1FqR2tzQlNVNENJZzVFVElnQWxTTWFGaWhNVUxBaVF5UkMvOTAyR2dGSkZTVVNSQmRGQWpZYUFra1ZJaEpFSkZORkFURVdRUUFsTVJZaUNUZ0lGRVJMQVVrakRrUWpHa3NCU1U0Q0lnNUVUSWdBUkNNYUZpaE1VTEFpUXlSQy85MDJHZ0ZKRlNJU1JDUlRSUUV4RmtFQUdURVdJZ2s0Q0JSRVJ3SWlEa1NJQUEwakdoWW9URkN3SWtNa1F2L3BpZ0VCaS8rQkJ3dUppZ0lCaS80aWkvK0lBSFdKaWdJQmkvNkJBb3YvaUFCb2lZb0NBWXYrZ1FTTC80Z0FXNG1LQVFHTC80Z0FLU2trVHdKVWkvK0lBRFFwSkU4Q1ZJdi9pQUFmS1NSUEFsUWtVMDhDSWs4Q1ZFd2tVNEVDVEZTSmlnRUJpLzhpaUFBMmlZb0JBWXYvZ1FLSUFDdUppZ0VCaS8rQkJJZ0FJSW1LQWdHTC9vdi9Fb21LQXdHTC8wRUFCb3Y5aS80WmlZditJeHVML1JxSmlnSUJpLzZMLzRnQUFZbUtBZ0dML292L0dpUVRpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
