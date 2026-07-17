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

namespace Arc56.Generated.cusma.d_asa.MockRbacModule_a50dacd6
{


    //
    // 
    //    RBAC Module for testing
    //    
    //
    public class MockRbacModuleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockRbacModuleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RoleValidity : AVMObjectType
            {
                public ulong RoleValidityStart { get; set; }

                public ulong RoleValidityEnd { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleValidityStart = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRoleValidityStart.From(RoleValidityStart);
                    ret.AddRange(vRoleValidityStart.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleValidityEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRoleValidityEnd.From(RoleValidityEnd);
                    ret.AddRange(vRoleValidityEnd.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RoleValidity Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RoleValidity();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleValidityStart = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleValidityStart.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleValidityStart = vRoleValidityStart.ToValue();
                    if (valueRoleValidityStart is ulong vRoleValidityStartValue) { ret.RoleValidityStart = vRoleValidityStartValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleValidityEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoleValidityEnd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoleValidityEnd = vRoleValidityEnd.ToValue();
                    if (valueRoleValidityEnd is ulong vRoleValidityEndValue) { ret.RoleValidityEnd = vRoleValidityEndValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RoleValidity);
                }
                public bool Equals(RoleValidity? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RoleValidity left, RoleValidity right)
                {
                    return EqualityComparer<RoleValidity>.Default.Equals(left, right);
                }
                public static bool operator !=(RoleValidity left, RoleValidity right)
                {
                    return !(left == right);
                }

            }

            public class RbacGetAddressRolesReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

                public bool Field3 { get; set; }

                public bool Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RbacGetAddressRolesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RbacGetAddressRolesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is bool vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RbacGetAddressRolesReturn);
                }
                public bool Equals(RbacGetAddressRolesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RbacGetAddressRolesReturn left, RbacGetAddressRolesReturn right)
                {
                    return EqualityComparer<RbacGetAddressRolesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(RbacGetAddressRolesReturn left, RbacGetAddressRolesReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Update D-ASA application.
        ///</summary>
        public async Task ContractUpdate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 79, 4, 235 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ContractUpdate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 79, 4, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Rotate the arranger address.
        ///</summary>
        /// <param name="new_arranger">New arranger address. </param>
        public async Task<ulong> RbacRotateArranger(Algorand.Address new_arranger, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 247, 27, 45 };
            var new_arrangerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_arrangerAbi.From(new_arranger);

            var result = await base.CallApp(new List<object> { abiHandle, new_arrangerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RbacRotateArranger_Transactions(Algorand.Address new_arranger, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 247, 27, 45 };
            var new_arrangerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_arrangerAbi.From(new_arranger);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_arrangerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Non-normative helper to set the operation daemon address.
        ///</summary>
        /// <param name="address">Operation daemon address. </param>
        public async Task<ulong> RbacSetOpDaemon(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 4, 245, 211 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RbacSetOpDaemon_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 4, 245, 211 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Assign a role to an address.
        ///</summary>
        /// <param name="role_id">Role identifier. </param>
        /// <param name="role_address">Account role address. </param>
        /// <param name="validity">Inclusive validity interval for the assignment. RoleValidity</param>
        public async Task<ulong> RbacAssignRole(byte role_id, Algorand.Address role_address, Structs.RoleValidity validity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 52, 53, 80 };
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); role_idAbi.From(role_id);
            var role_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); role_addressAbi.From(role_address);

            var result = await base.CallApp(new List<object> { abiHandle, role_idAbi, role_addressAbi, validity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RbacAssignRole_Transactions(byte role_id, Algorand.Address role_address, Structs.RoleValidity validity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 52, 53, 80 };
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); role_idAbi.From(role_id);
            var role_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); role_addressAbi.From(role_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, role_idAbi, role_addressAbi, validity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke a role from an address.
        ///</summary>
        /// <param name="role_id">Role identifier. </param>
        /// <param name="role_address">Account role address. </param>
        public async Task<ulong> RbacRevokeRole(byte role_id, Algorand.Address role_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 190, 128, 189 };
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); role_idAbi.From(role_id);
            var role_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); role_addressAbi.From(role_address);

            var result = await base.CallApp(new List<object> { abiHandle, role_idAbi, role_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RbacRevokeRole_Transactions(byte role_id, Algorand.Address role_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 190, 128, 189 };
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); role_idAbi.From(role_id);
            var role_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); role_addressAbi.From(role_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, role_idAbi, role_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the asset-wide suspension status.
        ///</summary>
        /// <param name="suspended">Suspension status to apply. </param>
        public async Task<ulong> RbacContractSuspension(bool suspended, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 62, 72, 231 };
            var suspendedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); suspendedAbi.From(suspended);

            var result = await base.CallApp(new List<object> { abiHandle, suspendedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RbacContractSuspension_Transactions(bool suspended, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 62, 72, 231 };
            var suspendedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); suspendedAbi.From(suspended);

            return await base.MakeTransactionList(new List<object> { abiHandle, suspendedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set D-ASA default status
        ///</summary>
        /// <param name="defaulted">Default status </param>
        public async Task<ulong> RbacContractDefault(bool defaulted, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 36, 31, 163 };
            var defaultedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); defaultedAbi.From(defaulted);

            var result = await base.CallApp(new List<object> { abiHandle, defaultedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RbacContractDefault_Transactions(bool defaulted, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 36, 31, 163 };
            var defaultedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); defaultedAbi.From(defaulted);

            return await base.MakeTransactionList(new List<object> { abiHandle, defaultedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the arranger address.
        ///</summary>
        public async Task<Algorand.Address> RbacGetArranger(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 12, 130, 153 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> RbacGetArranger_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 12, 130, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Non-normative helper to get the active roles assigned to an address.
        ///</summary>
        /// <param name="address">Address to query. </param>
        public async Task<Structs.RbacGetAddressRolesReturn> RbacGetAddressRoles(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 6, 172, 210 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RbacGetAddressRolesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RbacGetAddressRoles_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 6, 172, 210 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the stored validity interval for a role assignment.
        ///</summary>
        /// <param name="role_id">Role identifier. </param>
        /// <param name="role_address">Account role address. </param>
        public async Task<Structs.RoleValidity> RbacGetRoleValidity(byte role_id, Algorand.Address role_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 114, 162, 238 };
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); role_idAbi.From(role_id);
            var role_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); role_addressAbi.From(role_address);

            var result = await base.SimApp(new List<object> { abiHandle, role_idAbi, role_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RoleValidity.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RbacGetRoleValidity_Transactions(byte role_id, Algorand.Address role_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 114, 162, 238 };
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); role_idAbi.From(role_id);
            var role_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); role_addressAbi.From(role_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, role_idAbi, role_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja1JiYWNNb2R1bGUiLCJkZXNjIjoiXG4gICAgUkJBQyBNb2R1bGUgZm9yIHRlc3RpbmdcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUm9sZVZhbGlkaXR5IjpbeyJuYW1lIjoicm9sZV92YWxpZGl0eV9zdGFydCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyb2xlX3ZhbGlkaXR5X2VuZCIsInR5cGUiOiJ1aW50NjQifV0sIlJiYWNHZXRBZGRyZXNzUm9sZXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNvbnRyYWN0X3VwZGF0ZSIsImRlc2MiOiJVcGRhdGUgRC1BU0EgYXBwbGljYXRpb24uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJOb25lLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyYmFjX3JvdGF0ZV9hcnJhbmdlciIsImRlc2MiOiJSb3RhdGUgdGhlIGFycmFuZ2VyIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYXJyYW5nZXIiLCJkZXNjIjoiTmV3IGFycmFuZ2VyIGFkZHJlc3MuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlVOSVggdGltZXN0YW1wIG9mIHRoZSByb2xlIGFzc2lnbm1lbnQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmJhY19zZXRfb3BfZGFlbW9uIiwiZGVzYyI6Ik5vbi1ub3JtYXRpdmUgaGVscGVyIHRvIHNldCB0aGUgb3BlcmF0aW9uIGRhZW1vbiBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOiJPcGVyYXRpb24gZGFlbW9uIGFkZHJlc3MuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlVOSVggdGltZXN0YW1wIG9mIHRoZSByb2xlIGFzc2lnbm1lbnQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmJhY19hc3NpZ25fcm9sZSIsImRlc2MiOiJBc3NpZ24gYSByb2xlIHRvIGFuIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZV9pZCIsImRlc2MiOiJSb2xlIGlkZW50aWZpZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZV9hZGRyZXNzIiwiZGVzYyI6IkFjY291bnQgcm9sZSBhZGRyZXNzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUm9sZVZhbGlkaXR5IiwibmFtZSI6InZhbGlkaXR5IiwiZGVzYyI6IkluY2x1c2l2ZSB2YWxpZGl0eSBpbnRlcnZhbCBmb3IgdGhlIGFzc2lnbm1lbnQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlVOSVggdGltZXN0YW1wIG9mIHRoZSByb2xlIGFzc2lnbm1lbnQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmJhY19yZXZva2Vfcm9sZSIsImRlc2MiOiJSZXZva2UgYSByb2xlIGZyb20gYW4gYWRkcmVzcy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlX2lkIiwiZGVzYyI6IlJvbGUgaWRlbnRpZmllci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlX2FkZHJlc3MiLCJkZXNjIjoiQWNjb3VudCByb2xlIGFkZHJlc3MuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlVOSVggdGltZXN0YW1wIG9mIHRoZSByb2xlIHJldm9jYXRpb24uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmJhY19jb250cmFjdF9zdXNwZW5zaW9uIiwiZGVzYyI6IlNldCB0aGUgYXNzZXQtd2lkZSBzdXNwZW5zaW9uIHN0YXR1cy4iLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN1c3BlbmRlZCIsImRlc2MiOiJTdXNwZW5zaW9uIHN0YXR1cyB0byBhcHBseS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVU5JWCB0aW1lc3RhbXAgb2YgdGhlIHN1c3BlbnNpb24gdXBkYXRlLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJiYWNfY29udHJhY3RfZGVmYXVsdCIsImRlc2MiOiJTZXQgRC1BU0EgZGVmYXVsdCBzdGF0dXMiLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlZmF1bHRlZCIsImRlc2MiOiJEZWZhdWx0IHN0YXR1cyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJiYWNfZ2V0X2FycmFuZ2VyIiwiZGVzYyI6IkdldCB0aGUgYXJyYW5nZXIgYWRkcmVzcy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IkN1cnJlbnQgYXJyYW5nZXIgYWRkcmVzcy4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJiYWNfZ2V0X2FkZHJlc3Nfcm9sZXMiLCJkZXNjIjoiTm9uLW5vcm1hdGl2ZSBoZWxwZXIgdG8gZ2V0IHRoZSBhY3RpdmUgcm9sZXMgYXNzaWduZWQgdG8gYW4gYWRkcmVzcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjoiQWRkcmVzcyB0byBxdWVyeS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJSYmFjR2V0QWRkcmVzc1JvbGVzUmV0dXJuIiwiZGVzYyI6IlJvbGVzIG1hc2sgaW4gdGhlIG9yZGVyOiBhY2NvdW50IG1hbmFnZXIsIHByaW1hcnkgZGVhbGVyLCB0cnVzdGVlLCBhdXRob3JpdHksIG9ic2VydmVyLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmJhY19nZXRfcm9sZV92YWxpZGl0eSIsImRlc2MiOiJHZXQgdGhlIHN0b3JlZCB2YWxpZGl0eSBpbnRlcnZhbCBmb3IgYSByb2xlIGFzc2lnbm1lbnQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZV9pZCIsImRlc2MiOiJSb2xlIGlkZW50aWZpZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZV9hZGRyZXNzIiwiZGVzYyI6IkFjY291bnQgcm9sZSBhZGRyZXNzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJSb2xlVmFsaWRpdHkiLCJkZXNjIjoiU3RvcmVkIHJvbGUgdmFsaWRpdHkgaW50ZXJ2YWwuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzk1OF0sImVycm9yTWVzc2FnZSI6IkRlZmF1bHRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NiwzNDUsMzcyLDQwMiw0MjUsNDQ4LDQ3Miw1MjgsNTU2LDU3Nyw1OTgsNjIwLDgyMyw4NDAsODU0LDg2OSw4ODRdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIGFjY291bnQgcm9sZSBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEzLDgxMywxMDExXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCByb2xlIGlkZW50aWZpZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDIsNjcyLDk1MF0sImVycm9yTWVzc2FnZSI6Ik5vdCBhdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU2XSwiZXJyb3JNZXNzYWdlIjoiVGltZSBldmVudHMgbXVzdCBiZSBzb3J0ZWQgaW4gc3RyaWN0bHkgYXNjZW5kaW5nIG9yZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTEwLDkyNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEJveE1hcCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODksOTQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hcnJhbmdlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRlZmF1bHRlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzMsNjYzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0OCwyNzYsMzExLDQ5Niw3MDMsNzg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMCw0ODYsNzc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzLmFiaV90eXBlcy5Sb2xlVmFsaWRpdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ016SWdOREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0F3ZURVeU0yRTBNVFV5TlRJeU15QXdlRFV5TTJFMU5EVXlOVE15TXlBd2VEVXlNMkUwTVRVMU5UUXlNeUF3ZURVeU0yRTBaRFJsTkRjeU15QXdlRFV5TTJFMU1EVTVORFF5TXlBd2VEVXlNMkUwWkRSbU5ETXlNeUFpWkdWbVlYVnNkR1ZrSWlBd2VEVXlNMkUwWmpVd05EUXlNeUFpWTI5dWRISmhZM1JmYzNWemNHVnVaR1ZrSWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qSTRMVEk1Q2lBZ0lDQXZMeUFqSUZKQ1FVTWdVbTlzWlhNS0lDQWdJQzh2SUhObGJHWXVZWEp5WVc1blpYSWdQU0JIYkc5aVlXeFRkR0YwWlNoQlkyTnZkVzUwS0Nrc0lHdGxlVDFqYzNRdVVGSkZSa2xZWDBsRVgwRlNVa0ZPUjBWU0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEVXlNMkUwTVRVeU5USXlNd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pNd0NpQWdJQ0F2THlCelpXeG1MbTl3WDJSaFpXMXZiaUE5SUVkc2IySmhiRk4wWVhSbEtFRmpZMjkxYm5Rb0tTd2dhMlY1UFdOemRDNVFVa1ZHU1ZoZlNVUmZUMUJmUkVGRlRVOU9LUW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlRFV5TTJFMFpqVXdORFF5TXdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qUTNMVFE0Q2lBZ0lDQXZMeUFqSUVOdmJuUnlZV04wSUVkdmRtVnlibUZ1WTJVS0lDQWdJQzh2SUhObGJHWXVZMjl1ZEhKaFkzUmZjM1Z6Y0dWdVpHVmtJRDBnUm1Gc2MyVUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltTnZiblJ5WVdOMFgzTjFjM0JsYm1SbFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pVd0xUVXhDaUFnSUNBdkx5QWpJRU52Ym5SeVlXTjBJRkJsY21admNtMWhibU5sQ2lBZ0lDQXZMeUJ6Wld4bUxtUmxabUYxYkhSbFpDQTlJRVpoYkhObENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKa1pXWmhkV3gwWldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnRmYlc5a2RXeGxYM0ppWVdNdlkyOXVkSEpoWTNRdWNIazZOZ29nSUNBZ0x5OGdZMnhoYzNNZ1RXOWphMUppWVdOTmIyUjFiR1VvVW1KaFkwMXZaSFZzWlNrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVkFNakFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGt4TkdZd05HVmlJQzh2SUcxbGRHaHZaQ0FpWTI5dWRISmhZM1JmZFhCa1lYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amIyNTBjbUZqZEY5MWNHUmhkR1ZmY205MWRHVkFOUW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphMTl0YjJSMWJHVmZjbUpoWXk5amIyNTBjbUZqZEM1d2VUbzJDaUFnSUNBdkx5QmpiR0Z6Y3lCTmIyTnJVbUpoWTAxdlpIVnNaU2hTWW1GalRXOWtkV3hsS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURneVpqY3hZakprSURCNFpXWXdOR1kxWkRNZ01IaGtaak0wTXpVMU1DQXdlRE5rWW1VNE1HSmtJREI0TVdVelpUUTRaVGNnTUhnek9USTBNV1poTXlBd2VEQXhNR000TWprNUlEQjROelF3Tm1GalpESWdNSGd4WVRjeVlUSmxaU0F2THlCdFpYUm9iMlFnSW5KaVlXTmZjbTkwWVhSbFgyRnljbUZ1WjJWeUtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVltRmpYM05sZEY5dmNGOWtZV1Z0YjI0b1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5KaVlXTmZZWE56YVdkdVgzSnZiR1VvZFdsdWREZ3NZV1JrY21WemN5d29kV2x1ZERZMExIVnBiblEyTkNrcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVltRmpYM0psZG05clpWOXliMnhsS0hWcGJuUTRMR0ZrWkhKbGMzTXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnlZbUZqWDJOdmJuUnlZV04wWDNOMWMzQmxibk5wYjI0b1ltOXZiQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkppWVdOZlkyOXVkSEpoWTNSZlpHVm1ZWFZzZENoaWIyOXNLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbUpoWTE5blpYUmZZWEp5WVc1blpYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbkppWVdOZloyVjBYMkZrWkhKbGMzTmZjbTlzWlhNb1lXUmtjbVZ6Y3lrb1ltOXZiQ3hpYjI5c0xHSnZiMndzWW05dmJDeGliMjlzS1NJc0lHMWxkR2h2WkNBaWNtSmhZMTluWlhSZmNtOXNaVjkyWVd4cFpHbDBlU2gxYVc1ME9DeGhaR1J5WlhOektTaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lISmlZV05mY205MFlYUmxYMkZ5Y21GdVoyVnlJSEppWVdOZmMyVjBYMjl3WDJSaFpXMXZiaUJ5WW1GalgyRnpjMmxuYmw5eWIyeGxJSEppWVdOZmNtVjJiMnRsWDNKdmJHVWdjbUpoWTE5amIyNTBjbUZqZEY5emRYTndaVzV6YVc5dUlISmlZV05mWTI5dWRISmhZM1JmWkdWbVlYVnNkQ0J5WW1GalgyZGxkRjloY25KaGJtZGxjaUJ5WW1GalgyZGxkRjloWkdSeVpYTnpYM0p2YkdWeklISmlZV05mWjJWMFgzSnZiR1ZmZG1Gc2FXUnBkSGtLSUNBZ0lHVnljZ29LYldGcGJsOWpiMjUwY21GamRGOTFjR1JoZEdWZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG94TlRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lWWEJrWVhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JpSUdOdmJuUnlZV04wWDNWd1pHRjBaUW9LYldGcGJsOWpjbVZoZEdWQU1qQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphMTl0YjJSMWJHVmZjbUpoWXk5amIyNTBjbUZqZEM1d2VUb3hOQW9nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJYMjF2WkhWc1pWOXlZbUZqTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QnpaV3htTG1GeWNtRnVaMlZ5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURVeU0yRTBNVFV5TlRJeU13b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOclgyMXZaSFZzWlY5eVltRmpMMk52Ym5SeVlXTjBMbkI1T2pFMENpQWdJQ0F2THlCQVlYSmpOQzVpWVhKbGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdiVzlrZFd4bGN5NXlZbUZqTGxKaVlXTk5iMlIxYkdVdVkyOXVkSEpoWTNSZmRYQmtZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyOXVkSEpoWTNSZmRYQmtZWFJsT2dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakUyTVMweE5qUUtJQ0FnSUM4dklDTWdWR2hsSUhKbFptVnlaVzVqWlNCcGJYQnNaVzFsYm5SaGRHbHZiaUJuY21GdWRITWdkR2hsSUhWd1pHRjBaU0J3WlhKdGFYTnphVzl1Y3lCMGJ5QjBhR1VnUVhKeVlXNW5aWEl1Q2lBZ0lDQXZMeUFqSU9LYW9PKzRqeUJYUVZKT1NVNUhPaUJCY0hCc2FXTmhkR2x2YmlCMWNHUmhkR1Z6SUcxMWMzUWdZbVVnWlhobFkzVjBaV1FnVmtWU1dTQmpZWEpsWm5Wc2JIa3NJR0Z6SUhSb1pYa0tJQ0FnSUM4dklDTWdiV2xuYUhRZ2FXNTBjbTlrZFdObElHSnlaV0ZyYVc1bklHTm9ZVzVuWlhNdUNpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZMkZzYkdWeVgybHpYMkZ5Y21GdVoyVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyRnpjMlZ5ZEY5allXeHNaWEpmYVhOZllYSnlZVzVuWlhJS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG94TlRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lWWEJrWVhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnRiMlIxYkdWekxuSmlZV011VW1KaFkwMXZaSFZzWlM1eVltRmpYM0p2ZEdGMFpWOWhjbkpoYm1kbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkppWVdOZmNtOTBZWFJsWDJGeWNtRnVaMlZ5T2dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakUyTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRveE9ERUtJQ0FnSUM4dklITmxiR1l1WDJGemMyVnlkRjlqWVd4c1pYSmZhWE5mWVhKeVlXNW5aWElvS1FvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgyTmhiR3hsY2w5cGMxOWhjbkpoYm1kbGNnb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pjd0NpQWdJQ0F2THlCaGMzTmxjblFnY205c1pWOWhaR1J5WlhOeklDRTlJRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01zSUdWeWNpNUpUbFpCVEVsRVgxSlBURVZmUVVSRVVrVlRVd29nSUNBZ1pIVndDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhZMk52ZFc1MElISnZiR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRTRNd29nSUNBZ0x5OGdjMlZzWmk1aGNuSmhibWRsY2k1MllXeDFaU0E5SUc1bGQxOWhjbkpoYm1kbGNnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEVXlNMkUwTVRVeU5USXlNd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3hPRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakUyTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2JXOWtkV3hsY3k1eVltRmpMbEppWVdOTmIyUjFiR1V1Y21KaFkxOXpaWFJmYjNCZlpHRmxiVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtSmhZMTl6WlhSZmIzQmZaR0ZsYlc5dU9nb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pFNE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3lNREFLSUNBZ0lDOHZJSE5sYkdZdVgyRnpjMlZ5ZEY5allXeHNaWEpmYVhOZllYSnlZVzVuWlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMk5oYkd4bGNsOXBjMTloY25KaGJtZGxjZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qSXdNUW9nSUNBZ0x5OGdjMlZzWmk1dmNGOWtZV1Z0YjI0dWRtRnNkV1VnUFNCaFpHUnlaWE56Q2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TlRJellUUm1OVEEwTkRJekNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pJd01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk1UZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ0YjJSMWJHVnpMbkppWVdNdVVtSmhZMDF2WkhWc1pTNXlZbUZqWDJGemMybG5ibDl5YjJ4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbUpoWTE5aGMzTnBaMjVmY205c1pUb0tJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRveU1EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekxtRmlhVjkwZVhCbGN5NVNiMnhsVm1Gc2FXUnBkSGtLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3lNamNLSUNBZ0lDOHZJSE5sYkdZdVgyRnpjMlZ5ZEY5allXeHNaWEpmYVhOZllYSnlZVzVuWlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMk5oYkd4bGNsOXBjMTloY25KaGJtZGxjZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qSXlPQW9nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDJselgyNXZkRjlqYjI1MGNtRmpkRjlrWldaaGRXeDBaV1FvS1FvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgybHpYMjV2ZEY5amIyNTBjbUZqZEY5a1pXWmhkV3gwWldRS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG95TWprS0lDQWdJQzh2SUhObGJHWXVYMkZ6YzJWeWRGOTJZV3hwWkY5eWIyeGxLSEp2YkdWZmFXUXVZWE5mZFdsdWREWTBLQ2twQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUY5aGMzTmxjblJmZG1Gc2FXUmZjbTlzWlFvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakl6TUFvZ0lDQWdMeThnWVhOelpYSjBJSEp2YkdWZllXUmtjbVZ6Y3lBaFBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQ0JsY25JdVNVNVdRVXhKUkY5U1QweEZYMEZFUkZKRlUxTUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWVdOamIzVnVkQ0J5YjJ4bElHRmtaSEpsYzNNS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG95TXpJS0lDQWdJQzh2SUhaaGJHbGthWFI1TG5KdmJHVmZkbUZzYVdScGRIbGZjM1JoY25RZ1BDQjJZV3hwWkdsMGVTNXliMnhsWDNaaGJHbGthWFI1WDJWdVpBb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBOENpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TWpNeExUSXpNd29nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0IyWVd4cFpHbDBlUzV5YjJ4bFgzWmhiR2xrYVhSNVgzTjBZWEowSUR3Z2RtRnNhV1JwZEhrdWNtOXNaVjkyWVd4cFpHbDBlVjlsYm1RS0lDQWdJQzh2SUNrc0lHVnljaTVKVGxaQlRFbEVYMU5QVWxSSlRrY0tJQ0FnSUdGemMyVnlkQ0F2THlCVWFXMWxJR1YyWlc1MGN5QnRkWE4wSUdKbElITnZjblJsWkNCcGJpQnpkSEpwWTNSc2VTQmhjMk5sYm1ScGJtY2diM0prWlhJS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG94TURnS0lDQWdJQzh2SUdsbUlISnZiR1ZmYVdRZ1BUMGdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZRVU5EVDFWT1ZGOU5RVTVCUjBWU0tUb0tJQ0FnSUdsdWRHTmZNeUF2THlBME1Bb2dJQ0FnUFQwS0lDQWdJR0o2SUhKaVlXTmZZWE56YVdkdVgzSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk1UQTVDaUFnSUNBdkx5QmhjM05sY25RZ2NtOXNaVjloWkdSeVpYTnpJRzV2ZENCcGJpQnpaV3htTG1GalkyOTFiblJmYldGdVlXZGxjaXdnWlhKeUxrbE9Wa0ZNU1VSZlVrOU1SVjlCUkVSU1JWTlRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROVEl6WVRSa05HVTBOekl6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWVdOamIzVnVkQ0J5YjJ4bElHRmtaSEpsYzNNS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG94TVRBS0lDQWdJQzh2SUhObGJHWXVZV05qYjNWdWRGOXRZVzVoWjJWeVczSnZiR1ZmWVdSa2NtVnpjMTBnUFNCMllXeHBaR2wwZVM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmY0hWMENncHlZbUZqWDJGemMybG5ibDl5YjJ4bFgyRm1kR1Z5WDJsdWJHbHVaV1JmYlc5a2RXeGxjeTV5WW1GakxsSmlZV05OYjJSMWJHVXVYM05sZEY5eWIyeGxRREV5T2dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakl6TmdvZ0lDQWdMeThnY21WMGRYSnVJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TWpBMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KaVlXTmZZWE56YVdkdVgzSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXhNZ29nSUNBZ0x5OGdhV1lnY205c1pWOXBaQ0E5UFNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5UVVrbE5RVkpaWDBSRlFVeEZVaWs2Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05UQUtJQ0FnSUQwOUNpQWdJQ0JpZWlCeVltRmpYMkZ6YzJsbmJsOXliMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXhNd29nSUNBZ0x5OGdZWE56WlhKMElISnZiR1ZmWVdSa2NtVnpjeUJ1YjNRZ2FXNGdjMlZzWmk1d2NtbHRZWEo1WDJSbFlXeGxjaXdnWlhKeUxrbE9Wa0ZNU1VSZlVrOU1SVjlCUkVSU1JWTlRDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROVEl6WVRVd05UazBOREl6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWVdOamIzVnVkQ0J5YjJ4bElHRmtaSEpsYzNNS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG94TVRRS0lDQWdJQzh2SUhObGJHWXVjSEpwYldGeWVWOWtaV0ZzWlhKYmNtOXNaVjloWkdSeVpYTnpYU0E5SUhaaGJHbGthWFI1TG1OdmNIa29LUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG95TXpVS0lDQWdJQzh2SUhObGJHWXVYM05sZEY5eWIyeGxLSEp2YkdWZmFXUXVZWE5mZFdsdWREWTBLQ2tzSUhKdmJHVmZZV1JrY21WemN5d2dkbUZzYVdScGRIa3BDaUFnSUNCaUlISmlZV05mWVhOemFXZHVYM0p2YkdWZllXWjBaWEpmYVc1c2FXNWxaRjl0YjJSMWJHVnpMbkppWVdNdVVtSmhZMDF2WkhWc1pTNWZjMlYwWDNKdmJHVkFNVElLQ25KaVlXTmZZWE56YVdkdVgzSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXhOZ29nSUNBZ0x5OGdhV1lnY205c1pWOXBaQ0E5UFNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5VVVsVlRWRVZGS1RvS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJNQW9nSUNBZ1BUMEtJQ0FnSUdKNklISmlZV05mWVhOemFXZHVYM0p2YkdWZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZNVEUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbTlzWlY5aFpHUnlaWE56SUc1dmRDQnBiaUJ6Wld4bUxuUnlkWE4wWldVc0lHVnljaTVKVGxaQlRFbEVYMUpQVEVWZlFVUkVVa1ZUVXdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURVeU0yRTFORFV5TlRNeU13b2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHRmpZMjkxYm5RZ2NtOXNaU0JoWkdSeVpYTnpDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk1URTRDaUFnSUNBdkx5QnpaV3htTG5SeWRYTjBaV1ZiY205c1pWOWhaR1J5WlhOelhTQTlJSFpoYkdsa2FYUjVMbU52Y0hrb0tRb2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3lNelVLSUNBZ0lDOHZJSE5sYkdZdVgzTmxkRjl5YjJ4bEtISnZiR1ZmYVdRdVlYTmZkV2x1ZERZMEtDa3NJSEp2YkdWZllXUmtjbVZ6Y3l3Z2RtRnNhV1JwZEhrcENpQWdJQ0JpSUhKaVlXTmZZWE56YVdkdVgzSnZiR1ZmWVdaMFpYSmZhVzVzYVc1bFpGOXRiMlIxYkdWekxuSmlZV011VW1KaFkwMXZaSFZzWlM1ZmMyVjBYM0p2YkdWQU1USUtDbkppWVdOZllYTnphV2R1WDNKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pFeU1Bb2dJQ0FnTHk4Z2FXWWdjbTlzWlY5cFpDQTlQU0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlCVlZSSVQxSkpWRmtwT2dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEY3dDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtSmhZMTloYzNOcFoyNWZjbTlzWlY5aFpuUmxjbDlwWmw5bGJITmxRRGtLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3hNakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnliMnhsWDJGa1pISmxjM01nYm05MElHbHVJSE5sYkdZdVlYVjBhRzl5YVhSNUxDQmxjbkl1U1U1V1FVeEpSRjlTVDB4RlgwRkVSRkpGVTFNS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMU1qTmhOREUxTlRVME1qTUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhZMk52ZFc1MElISnZiR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXlNZ29nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZEhsYmNtOXNaVjloWkdSeVpYTnpYU0E5SUhaaGJHbGthWFI1TG1OdmNIa29LUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG95TXpVS0lDQWdJQzh2SUhObGJHWXVYM05sZEY5eWIyeGxLSEp2YkdWZmFXUXVZWE5mZFdsdWREWTBLQ2tzSUhKdmJHVmZZV1JrY21WemN5d2dkbUZzYVdScGRIa3BDaUFnSUNCaUlISmlZV05mWVhOemFXZHVYM0p2YkdWZllXWjBaWEpmYVc1c2FXNWxaRjl0YjJSMWJHVnpMbkppWVdNdVVtSmhZMDF2WkhWc1pTNWZjMlYwWDNKdmJHVkFNVElLQ25KaVlXTmZZWE56YVdkdVgzSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXlOQW9nSUNBZ0x5OGdhV1lnY205c1pWOXBaQ0E5UFNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5UFFsTkZVbFpGVWlrNkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPREFLSUNBZ0lEMDlDaUFnSUNCaWVpQnlZbUZqWDJGemMybG5ibDl5YjJ4bFgyRm1kR1Z5WDJsdWJHbHVaV1JmYlc5a2RXeGxjeTV5WW1GakxsSmlZV05OYjJSMWJHVXVYM05sZEY5eWIyeGxRREV5Q2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZNVEkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbTlzWlY5aFpHUnlaWE56SUc1dmRDQnBiaUJ6Wld4bUxtOWljMlZ5ZG1WeUxDQmxjbkl1U1U1V1FVeEpSRjlTVDB4RlgwRkVSRkpGVTFNS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnMU1qTmhOR1EwWmpRek1qTUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhZMk52ZFc1MElISnZiR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXlOZ29nSUNBZ0x5OGdjMlZzWmk1dlluTmxjblpsY2x0eWIyeGxYMkZrWkhKbGMzTmRJRDBnZG1Gc2FXUnBkSGt1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZaUJ5WW1GalgyRnpjMmxuYmw5eWIyeGxYMkZtZEdWeVgybHViR2x1WldSZmJXOWtkV3hsY3k1eVltRmpMbEppWVdOTmIyUjFiR1V1WDNObGRGOXliMnhsUURFeUNnb0tMeThnYlc5a2RXeGxjeTV5WW1GakxsSmlZV05OYjJSMWJHVXVjbUpoWTE5eVpYWnZhMlZmY205c1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkppWVdOZmNtVjJiMnRsWDNKdmJHVTZDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk1qTTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME9Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk1qVTNDaUFnSUNBdkx5QnpaV3htTGw5aGMzTmxjblJmWTJGc2JHVnlYMmx6WDJGeWNtRnVaMlZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMkZ6YzJWeWRGOWpZV3hzWlhKZmFYTmZZWEp5WVc1blpYSUtJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRveU5UZ0tJQ0FnSUM4dklITmxiR1l1WDJGemMyVnlkRjlwYzE5dWIzUmZZMjl1ZEhKaFkzUmZaR1ZtWVhWc2RHVmtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyRnpjMlZ5ZEY5cGMxOXViM1JmWTI5dWRISmhZM1JmWkdWbVlYVnNkR1ZrQ2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZNalU1Q2lBZ0lDQXZMeUJ6Wld4bUxsOWhjM05sY25SZmRtRnNhV1JmY205c1pTaHliMnhsWDJsa0xtRnpYM1ZwYm5RMk5DZ3BLUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjM05sY25SZmRtRnNhV1JmY205c1pRb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhKdmJHVmZhV1FnSVQwZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlFWSlNRVTVIUlZJcExDQmxjbkl1U1U1V1FVeEpSRjlTVDB4RkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNakFLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCeWIyeGxJR2xrWlc1MGFXWnBaWElLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3hNekFLSUNBZ0lDOHZJR2xtSUhKdmJHVmZhV1FnUFQwZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlFVTkRUMVZPVkY5TlFVNUJSMFZTS1RvS0lDQWdJR2x1ZEdOZk15QXZMeUEwTUFvZ0lDQWdQVDBLSUNBZ0lHSjZJSEppWVdOZmNtVjJiMnRsWDNKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TVRNeENpQWdJQ0F2THlCaGMzTmxjblFnY205c1pWOWhaR1J5WlhOeklHbHVJSE5sYkdZdVlXTmpiM1Z1ZEY5dFlXNWhaMlZ5TENCbGNuSXVTVTVXUVV4SlJGOVNUMHhGWDBGRVJGSkZVMU1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGcxTWpOaE5HUTBaVFEzTWpNS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhZMk52ZFc1MElISnZiR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXpNZ29nSUNBZ0x5OGdaR1ZzSUhObGJHWXVZV05qYjNWdWRGOXRZVzVoWjJWeVczSnZiR1ZmWVdSa2NtVnpjMTBLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvS2NtSmhZMTl5WlhadmEyVmZjbTlzWlY5aFpuUmxjbDlwYm14cGJtVmtYMjF2WkhWc1pYTXVjbUpoWXk1U1ltRmpUVzlrZFd4bExsOWtaV3hsZEdWZmNtOXNaVUF4TWpvS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG95TmpFS0lDQWdJQzh2SUhKbGRIVnliaUJIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pJek9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVltRmpYM0psZG05clpWOXliMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3hNelFLSUNBZ0lDOHZJR2xtSUhKdmJHVmZhV1FnUFQwZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlVGSkpUVUZTV1Y5RVJVRk1SVklwT2dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEVXdDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtSmhZMTl5WlhadmEyVmZjbTlzWlY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3hNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnliMnhsWDJGa1pISmxjM01nYVc0Z2MyVnNaaTV3Y21sdFlYSjVYMlJsWVd4bGNpd2daWEp5TGtsT1ZrRk1TVVJmVWs5TVJWOUJSRVJTUlZOVENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE5USXpZVFV3TlRrME5ESXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWVdOamIzVnVkQ0J5YjJ4bElHRmtaSEpsYzNNS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG94TXpZS0lDQWdJQzh2SUdSbGJDQnpaV3htTG5CeWFXMWhjbmxmWkdWaGJHVnlXM0p2YkdWZllXUmtjbVZ6YzEwS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pJMk1Bb2dJQ0FnTHk4Z2MyVnNaaTVmWkdWc1pYUmxYM0p2YkdVb2NtOXNaVjlwWkM1aGMxOTFhVzUwTmpRb0tTd2djbTlzWlY5aFpHUnlaWE56S1FvZ0lDQWdZaUJ5WW1GalgzSmxkbTlyWlY5eWIyeGxYMkZtZEdWeVgybHViR2x1WldSZmJXOWtkV3hsY3k1eVltRmpMbEppWVdOTmIyUjFiR1V1WDJSbGJHVjBaVjl5YjJ4bFFERXlDZ3B5WW1GalgzSmxkbTlyWlY5eWIyeGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRveE16Z0tJQ0FnSUM4dklHbG1JSEp2YkdWZmFXUWdQVDBnVlVsdWREWTBLR1Z1ZFcxekxsSlBURVZmVkZKVlUxUkZSU2s2Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05qQUtJQ0FnSUQwOUNpQWdJQ0JpZWlCeVltRmpYM0psZG05clpWOXliMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXpPUW9nSUNBZ0x5OGdZWE56WlhKMElISnZiR1ZmWVdSa2NtVnpjeUJwYmlCelpXeG1MblJ5ZFhOMFpXVXNJR1Z5Y2k1SlRsWkJURWxFWDFKUFRFVmZRVVJFVWtWVFV3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEVXlNMkUxTkRVeU5UTXlNd29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUdGalkyOTFiblFnY205c1pTQmhaR1J5WlhOekNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TVRRd0NpQWdJQ0F2THlCa1pXd2djMlZzWmk1MGNuVnpkR1ZsVzNKdmJHVmZZV1JrY21WemMxMEtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qSTJNQW9nSUNBZ0x5OGdjMlZzWmk1ZlpHVnNaWFJsWDNKdmJHVW9jbTlzWlY5cFpDNWhjMTkxYVc1ME5qUW9LU3dnY205c1pWOWhaR1J5WlhOektRb2dJQ0FnWWlCeVltRmpYM0psZG05clpWOXliMnhsWDJGbWRHVnlYMmx1YkdsdVpXUmZiVzlrZFd4bGN5NXlZbUZqTGxKaVlXTk5iMlIxYkdVdVgyUmxiR1YwWlY5eWIyeGxRREV5Q2dweVltRmpYM0psZG05clpWOXliMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3hORElLSUNBZ0lDOHZJR2xtSUhKdmJHVmZhV1FnUFQwZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlFWVlVTRTlTU1ZSWktUb0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EzTUFvZ0lDQWdQVDBLSUNBZ0lHSjZJSEppWVdOZmNtVjJiMnRsWDNKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TVRRekNpQWdJQ0F2THlCaGMzTmxjblFnY205c1pWOWhaR1J5WlhOeklHbHVJSE5sYkdZdVlYVjBhRzl5YVhSNUxDQmxjbkl1U1U1V1FVeEpSRjlTVDB4RlgwRkVSRkpGVTFNS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMU1qTmhOREUxTlRVME1qTUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0JoWTJOdmRXNTBJSEp2YkdVZ1lXUmtjbVZ6Y3dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakUwTkFvZ0lDQWdMeThnWkdWc0lITmxiR1l1WVhWMGFHOXlhWFI1VzNKdmJHVmZZV1JrY21WemMxMEtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qSTJNQW9nSUNBZ0x5OGdjMlZzWmk1ZlpHVnNaWFJsWDNKdmJHVW9jbTlzWlY5cFpDNWhjMTkxYVc1ME5qUW9LU3dnY205c1pWOWhaR1J5WlhOektRb2dJQ0FnWWlCeVltRmpYM0psZG05clpWOXliMnhsWDJGbWRHVnlYMmx1YkdsdVpXUmZiVzlrZFd4bGN5NXlZbUZqTGxKaVlXTk5iMlIxYkdVdVgyUmxiR1YwWlY5eWIyeGxRREV5Q2dweVltRmpYM0psZG05clpWOXliMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3hORFlLSUNBZ0lDOHZJR2xtSUhKdmJHVmZhV1FnUFQwZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlQwSlRSVkpXUlZJcE9nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQTlQUW9nSUNBZ1lub2djbUpoWTE5eVpYWnZhMlZmY205c1pWOWhablJsY2w5cGJteHBibVZrWDIxdlpIVnNaWE11Y21KaFl5NVNZbUZqVFc5a2RXeGxMbDlrWld4bGRHVmZjbTlzWlVBeE1nb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pFME53b2dJQ0FnTHk4Z1lYTnpaWEowSUhKdmJHVmZZV1JrY21WemN5QnBiaUJ6Wld4bUxtOWljMlZ5ZG1WeUxDQmxjbkl1U1U1V1FVeEpSRjlTVDB4RlgwRkVSRkpGVTFNS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnMU1qTmhOR1EwWmpRek1qTUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0JoWTJOdmRXNTBJSEp2YkdVZ1lXUmtjbVZ6Y3dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakUwT0FvZ0lDQWdMeThnWkdWc0lITmxiR1l1YjJKelpYSjJaWEpiY205c1pWOWhaR1J5WlhOelhRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaUlISmlZV05mY21WMmIydGxYM0p2YkdWZllXWjBaWEpmYVc1c2FXNWxaRjl0YjJSMWJHVnpMbkppWVdNdVVtSmhZMDF2WkhWc1pTNWZaR1ZzWlhSbFgzSnZiR1ZBTVRJS0Nnb3ZMeUJ0YjJSMWJHVnpMbkppWVdNdVVtSmhZMDF2WkhWc1pTNXlZbUZqWDJOdmJuUnlZV04wWDNOMWMzQmxibk5wYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlZbUZqWDJOdmJuUnlZV04wWDNOMWMzQmxibk5wYjI0NkNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TWpZekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZPRElLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5eWIyeGxYMmx6WDJGamRHbDJaU2h6Wld4bUxtRjFkR2h2Y21sMGVTd2dWSGh1TG5ObGJtUmxjaWtzSUdWeWNpNVZUa0ZWVkVoUFVrbGFSVVFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcxTWpOaE5ERTFOVFUwTWpNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTmhiR3h6ZFdJZ1gzSnZiR1ZmYVhOZllXTjBhWFpsQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdGMWRHaHZjbWw2WldRS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG95TnprS0lDQWdJQzh2SUhObGJHWXVZMjl1ZEhKaFkzUmZjM1Z6Y0dWdVpHVmtJRDBnYzNWemNHVnVaR1ZrQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0pqYjI1MGNtRmpkRjl6ZFhOd1pXNWtaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakk0TUFvZ0lDQWdMeThnY21WMGRYSnVJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TWpZekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnRiMlIxYkdWekxuSmlZV011VW1KaFkwMXZaSFZzWlM1eVltRmpYMk52Ym5SeVlXTjBYMlJsWm1GMWJIUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WW1GalgyTnZiblJ5WVdOMFgyUmxabUYxYkhRNkNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TWpneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZOemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5eWIyeGxYMmx6WDJGamRHbDJaU2h6Wld4bUxuUnlkWE4wWldVc0lGUjRiaTV6Wlc1a1pYSXBMQ0JsY25JdVZVNUJWVlJJVDFKSldrVkVDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROVEl6WVRVME5USTFNekl6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUY5eWIyeGxYMmx6WDJGamRHbDJaUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0JoZFhSb2IzSnBlbVZrQ2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZNamsxQ2lBZ0lDQXZMeUJ6Wld4bUxtUmxabUYxYkhSbFpDQTlJR1JsWm1GMWJIUmxaQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlaR1ZtWVhWc2RHVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3lPVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakk0TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2JXOWtkV3hsY3k1eVltRmpMbEppWVdOTmIyUjFiR1V1Y21KaFkxOW5aWFJmWVhKeVlXNW5aWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVltRmpYMmRsZEY5aGNuSmhibWRsY2pvS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG96TURrS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtRnljbUZ1WjJWeUxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFV5TTJFME1UVXlOVEl5TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnljbUZ1WjJWeUlHVjRhWE4wY3dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPakk1T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYlc5a2RXeGxjeTV5WW1GakxsSmlZV05OYjJSMWJHVXVjbUpoWTE5blpYUmZZV1JrY21WemMxOXliMnhsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmlZV05mWjJWMFgyRmtaSEpsYzNOZmNtOXNaWE02Q2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZNekV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPak15T1FvZ0lDQWdMeThnYzJWc1ppNWZjbTlzWlY5cGMxOWhZM1JwZG1Vb2MyVnNaaTVoWTJOdmRXNTBYMjFoYm1GblpYSXNJR0ZrWkhKbGMzTXBMQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlRFV5TTJFMFpEUmxORGN5TXdvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdYM0p2YkdWZmFYTmZZV04wYVhabENpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TXpNd0NpQWdJQ0F2THlCelpXeG1MbDl5YjJ4bFgybHpYMkZqZEdsMlpTaHpaV3htTG5CeWFXMWhjbmxmWkdWaGJHVnlMQ0JoWkdSeVpYTnpLU3dLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcxTWpOaE5UQTFPVFEwTWpNS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRjl5YjJ4bFgybHpYMkZqZEdsMlpRb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pNek1Rb2dJQ0FnTHk4Z2MyVnNaaTVmY205c1pWOXBjMTloWTNScGRtVW9jMlZzWmk1MGNuVnpkR1ZsTENCaFpHUnlaWE56S1N3S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMU1qTmhOVFExTWpVek1qTUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUY5eWIyeGxYMmx6WDJGamRHbDJaUW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qTXpNZ29nSUNBZ0x5OGdjMlZzWmk1ZmNtOXNaVjlwYzE5aFkzUnBkbVVvYzJWc1ppNWhkWFJvYjNKcGRIa3NJR0ZrWkhKbGMzTXBMQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRFV5TTJFME1UVTFOVFF5TXdvZ0lDQWdaR2xuSURRS0lDQWdJR05oYkd4emRXSWdYM0p2YkdWZmFYTmZZV04wYVhabENpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TXpNekNpQWdJQ0F2THlCelpXeG1MbDl5YjJ4bFgybHpYMkZqZEdsMlpTaHpaV3htTG05aWMyVnlkbVZ5TENCaFpHUnlaWE56S1N3S0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnMU1qTmhOR1EwWmpRek1qTUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMkZzYkhOMVlpQmZjbTlzWlY5cGMxOWhZM1JwZG1VS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG96TVRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYzJWMFltbDBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2JXOWtkV3hsY3k1eVltRmpMbEppWVdOTmIyUjFiR1V1Y21KaFkxOW5aWFJmY205c1pWOTJZV3hwWkdsMGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkppWVdOZloyVjBYM0p2YkdWZmRtRnNhV1JwZEhrNkNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TXpNMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBPQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZNelUwQ2lBZ0lDQXZMeUJ5YjJ4bElEMGdjbTlzWlY5cFpDNWhjMTkxYVc1ME5qUW9LUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qTTFOUW9nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDNaaGJHbGtYM0p2YkdVb2NtOXNaU2tLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZllYTnpaWEowWDNaaGJHbGtYM0p2YkdVS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG96TlRjS0lDQWdJQzh2SUdOaGMyVWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZRVU5EVDFWT1ZGOU5RVTVCUjBWU0tUb0tJQ0FnSUdsdWRHTmZNeUF2THlBME1Bb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pNMk1nb2dJQ0FnTHk4Z1kyRnpaU0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlRVWtsTlFWSlpYMFJGUVV4RlVpazZDaUFnSUNCd2RYTm9hVzUwY3lBMU1DQTJNQ0EzTUNBNE1Bb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pNMU5pMHpPRE1LSUNBZ0lDOHZJRzFoZEdOb0lISnZiR1U2Q2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlCUTBOUFZVNVVYMDFCVGtGSFJWSXBPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sY25RZ2MyVnNaaTVmYUdGelgzSnZiR1VvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MbUZqWTI5MWJuUmZiV0Z1WVdkbGNpd2djbTlzWlY5aFpHUnlaWE56Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ2tzSUdWeWNpNUpUbFpCVEVsRVgxSlBURVZmUVVSRVVrVlRVd29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnlaWFIxY200Z2MyVnNaaTVoWTJOdmRXNTBYMjFoYm1GblpYSmJjbTlzWlY5aFpHUnlaWE56WFFvZ0lDQWdMeThnSUNBZ0lHTmhjMlVnVlVsdWREWTBLR1Z1ZFcxekxsSlBURVZmVUZKSlRVRlNXVjlFUlVGTVJWSXBPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sY25RZ2MyVnNaaTVmYUdGelgzSnZiR1VvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MbkJ5YVcxaGNubGZaR1ZoYkdWeUxDQnliMnhsWDJGa1pISmxjM01LSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLU3dnWlhKeUxrbE9Wa0ZNU1VSZlVrOU1SVjlCUkVSU1JWTlRDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lISmxkSFZ5YmlCelpXeG1MbkJ5YVcxaGNubGZaR1ZoYkdWeVczSnZiR1ZmWVdSa2NtVnpjMTBLSUNBZ0lDOHZJQ0FnSUNCallYTmxJRlZKYm5RMk5DaGxiblZ0Y3k1U1QweEZYMVJTVlZOVVJVVXBPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sY25RZ2MyVnNaaTVmYUdGelgzSnZiR1VvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MblJ5ZFhOMFpXVXNJSEp2YkdWZllXUmtjbVZ6Y3dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FwTENCbGNuSXVTVTVXUVV4SlJGOVNUMHhGWDBGRVJGSkZVMU1LSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdjbVYwZFhKdUlITmxiR1l1ZEhKMWMzUmxaVnR5YjJ4bFgyRmtaSEpsYzNOZENpQWdJQ0F2THlBZ0lDQWdZMkZ6WlNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5QlZWUklUMUpKVkZrcE9nb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGMzTmxjblFnYzJWc1ppNWZhR0Z6WDNKdmJHVW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0J6Wld4bUxtRjFkR2h2Y21sMGVTd2djbTlzWlY5aFpHUnlaWE56Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ2tzSUdWeWNpNUpUbFpCVEVsRVgxSlBURVZmUVVSRVVrVlRVd29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnlaWFIxY200Z2MyVnNaaTVoZFhSb2IzSnBkSGxiY205c1pWOWhaR1J5WlhOelhRb2dJQ0FnTHk4Z0lDQWdJR05oYzJVZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlQwSlRSVkpXUlZJcE9nb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGMzTmxjblFnYzJWc1ppNWZhR0Z6WDNKdmJHVW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0J6Wld4bUxtOWljMlZ5ZG1WeUxDQnliMnhsWDJGa1pISmxjM01LSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLU3dnWlhKeUxrbE9Wa0ZNU1VSZlVrOU1SVjlCUkVSU1JWTlRDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lISmxkSFZ5YmlCelpXeG1MbTlpYzJWeWRtVnlXM0p2YkdWZllXUmtjbVZ6YzEwS0lDQWdJQzh2SUNBZ0lDQmpZWE5sSUY4NkNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc5d0xtVnljaWhsY25JdVNVNVdRVXhKUkY5U1QweEZLUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J0WVhSamFDQnlZbUZqWDJkbGRGOXliMnhsWDNaaGJHbGthWFI1WDNOM2FYUmphRjlqWVhObFh6QkFNaUJ5WW1GalgyZGxkRjl5YjJ4bFgzWmhiR2xrYVhSNVgzTjNhWFJqYUY5allYTmxYekZBTXlCeVltRmpYMmRsZEY5eWIyeGxYM1poYkdsa2FYUjVYM04zYVhSamFGOWpZWE5sWHpKQU5DQnlZbUZqWDJkbGRGOXliMnhsWDNaaGJHbGthWFI1WDNOM2FYUmphRjlqWVhObFh6TkFOU0J5WW1GalgyZGxkRjl5YjJ4bFgzWmhiR2xrYVhSNVgzTjNhWFJqYUY5allYTmxYelJBTmdvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPak00TXdvZ0lDQWdMeThnYjNBdVpYSnlLR1Z5Y2k1SlRsWkJURWxFWDFKUFRFVXBDaUFnSUNCbGNuSWdMeThnU1c1MllXeHBaQ0J5YjJ4bElHbGtaVzUwYVdacFpYSUtDbkppWVdOZloyVjBYM0p2YkdWZmRtRnNhV1JwZEhsZmMzZHBkR05vWDJOaGMyVmZORUEyT2dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPak0zT1FvZ0lDQWdMeThnYzJWc1ppNXZZbk5sY25abGNpd2djbTlzWlY5aFpHUnlaWE56Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TlRJellUUmtOR1kwTXpJekNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TlRjS0lDQWdJQzh2SUhKbGRIVnliaUJ5YjJ4bFgyRmtaSEpsYzNNZ2FXNGdjbTlzWlY5dFlYQUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TXpjNExUTTRNQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WDJoaGMxOXliMnhsS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1l1YjJKelpYSjJaWElzSUhKdmJHVmZZV1JrY21WemN3b2dJQ0FnTHk4Z0tTd2daWEp5TGtsT1ZrRk1TVVJmVWs5TVJWOUJSRVJTUlZOVENpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0JoWTJOdmRXNTBJSEp2YkdVZ1lXUmtjbVZ6Y3dvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPak00TVFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWIySnpaWEoyWlhKYmNtOXNaVjloWkdSeVpYTnpYUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2dweVltRmpYMmRsZEY5eWIyeGxYM1poYkdsa2FYUjVYMkZtZEdWeVgybHViR2x1WldSZmJXOWtkV3hsY3k1eVltRmpMbEppWVdOTmIyUjFiR1V1Y21KaFkxOW5aWFJmY205c1pWOTJZV3hwWkdsMGVVQTRPZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qTXpOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVltRmpYMmRsZEY5eWIyeGxYM1poYkdsa2FYUjVYM04zYVhSamFGOWpZWE5sWHpOQU5Ub0tJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRvek56UUtJQ0FnSUM4dklITmxiR1l1WVhWMGFHOXlhWFI1TENCeWIyeGxYMkZrWkhKbGMzTUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzFNak5oTkRFMU5UVTBNak1LSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUbzFOd29nSUNBZ0x5OGdjbVYwZFhKdUlISnZiR1ZmWVdSa2NtVnpjeUJwYmlCeWIyeGxYMjFoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3pOek10TXpjMUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZhR0Z6WDNKdmJHVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNWhkWFJvYjNKcGRIa3NJSEp2YkdWZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z1pYSnlMa2xPVmtGTVNVUmZVazlNUlY5QlJFUlNSVk5UQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhZMk52ZFc1MElISnZiR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qTTNOZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WVhWMGFHOXlhWFI1VzNKdmJHVmZZV1JrY21WemMxMEtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qTXpOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJSEppWVdOZloyVjBYM0p2YkdWZmRtRnNhV1JwZEhsZllXWjBaWEpmYVc1c2FXNWxaRjl0YjJSMWJHVnpMbkppWVdNdVVtSmhZMDF2WkhWc1pTNXlZbUZqWDJkbGRGOXliMnhsWDNaaGJHbGthWFI1UURnS0NuSmlZV05mWjJWMFgzSnZiR1ZmZG1Gc2FXUnBkSGxmYzNkcGRHTm9YMk5oYzJWZk1rQTBPZ29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qTTJPUW9nSUNBZ0x5OGdjMlZzWmk1MGNuVnpkR1ZsTENCeWIyeGxYMkZrWkhKbGMzTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzFNak5oTlRRMU1qVXpNak1LSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUbzFOd29nSUNBZ0x5OGdjbVYwZFhKdUlISnZiR1ZmWVdSa2NtVnpjeUJwYmlCeWIyeGxYMjFoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUb3pOamd0TXpjd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZhR0Z6WDNKdmJHVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNTBjblZ6ZEdWbExDQnliMnhsWDJGa1pISmxjM01LSUNBZ0lDOHZJQ2tzSUdWeWNpNUpUbFpCVEVsRVgxSlBURVZmUVVSRVVrVlRVd29nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ1lXTmpiM1Z1ZENCeWIyeGxJR0ZrWkhKbGMzTUtJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRvek56RUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblJ5ZFhOMFpXVmJjbTlzWlY5aFpHUnlaWE56WFFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TXpNMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ2NtSmhZMTluWlhSZmNtOXNaVjkyWVd4cFpHbDBlVjloWm5SbGNsOXBibXhwYm1Wa1gyMXZaSFZzWlhNdWNtSmhZeTVTWW1GalRXOWtkV3hsTG5KaVlXTmZaMlYwWDNKdmJHVmZkbUZzYVdScGRIbEFPQW9LY21KaFkxOW5aWFJmY205c1pWOTJZV3hwWkdsMGVWOXpkMmwwWTJoZlkyRnpaVjh4UURNNkNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2TXpZMENpQWdJQ0F2THlCelpXeG1MbkJ5YVcxaGNubGZaR1ZoYkdWeUxDQnliMnhsWDJGa1pISmxjM01LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcxTWpOaE5UQTFPVFEwTWpNS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG8xTndvZ0lDQWdMeThnY21WMGRYSnVJSEp2YkdWZllXUmtjbVZ6Y3lCcGJpQnliMnhsWDIxaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG96TmpNdE16WTFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVmYUdGelgzSnZiR1VvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaTV3Y21sdFlYSjVYMlJsWVd4bGNpd2djbTlzWlY5aFpHUnlaWE56Q2lBZ0lDQXZMeUFwTENCbGNuSXVTVTVXUVV4SlJGOVNUMHhGWDBGRVJGSkZVMU1LSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHRmpZMjkxYm5RZ2NtOXNaU0JoWkdSeVpYTnpDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk16WTJDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV3Y21sdFlYSjVYMlJsWVd4bGNsdHliMnhsWDJGa1pISmxjM05kQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG96TXpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCeVltRmpYMmRsZEY5eWIyeGxYM1poYkdsa2FYUjVYMkZtZEdWeVgybHViR2x1WldSZmJXOWtkV3hsY3k1eVltRmpMbEppWVdOTmIyUjFiR1V1Y21KaFkxOW5aWFJmY205c1pWOTJZV3hwWkdsMGVVQTRDZ3B5WW1GalgyZGxkRjl5YjJ4bFgzWmhiR2xrYVhSNVgzTjNhWFJqYUY5allYTmxYekJBTWpvS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG96TlRrS0lDQWdJQzh2SUhObGJHWXVZV05qYjNWdWRGOXRZVzVoWjJWeUxDQnliMnhsWDJGa1pISmxjM01LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGcxTWpOaE5HUTBaVFEzTWpNS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG8xTndvZ0lDQWdMeThnY21WMGRYSnVJSEp2YkdWZllXUmtjbVZ6Y3lCcGJpQnliMnhsWDIxaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG96TlRndE16WXdDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVmYUdGelgzSnZiR1VvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaTVoWTJOdmRXNTBYMjFoYm1GblpYSXNJSEp2YkdWZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z1pYSnlMa2xPVmtGTVNVUmZVazlNUlY5QlJFUlNSVk5UQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhZMk52ZFc1MElISnZiR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qTTJNUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WVdOamIzVnVkRjl0WVc1aFoyVnlXM0p2YkdWZllXUmtjbVZ6YzEwS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pNek5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaUlISmlZV05mWjJWMFgzSnZiR1ZmZG1Gc2FXUnBkSGxmWVdaMFpYSmZhVzVzYVc1bFpGOXRiMlIxYkdWekxuSmlZV011VW1KaFkwMXZaSFZzWlM1eVltRmpYMmRsZEY5eWIyeGxYM1poYkdsa2FYUjVRRGdLQ2dvdkx5QnRiMlIxYkdWekxuSmlZV011VW1KaFkwMXZaSFZzWlM1ZmNtOXNaVjlwYzE5aFkzUnBkbVVvY205c1pWOXRZWEE2SUdKNWRHVnpMQ0J5YjJ4bFgyRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNsOXliMnhsWDJselgyRmpkR2wyWlRvS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG8xT1FvZ0lDQWdMeThnWkdWbUlGOXliMnhsWDJselgyRmpkR2wyWlNoelpXeG1MQ0J5YjJ4bFgyMWhjRG9nZEhsd0xsSmlZV05TYjJ4bExDQnliMnhsWDJGa1pISmxjM002SUVGalkyOTFiblFwSUMwK0lHSnZiMnc2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pVM0NpQWdJQ0F2THlCeVpYUjFjbTRnY205c1pWOWhaR1J5WlhOeklHbHVJSEp2YkdWZmJXRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPall3TFRZMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWZhR0Z6WDNKdmJHVW9jbTlzWlY5dFlYQXNJSEp2YkdWZllXUmtjbVZ6Y3lrZ1lXNWtJQ2dLSUNBZ0lDOHZJQ0FnSUNCeWIyeGxYMjFoY0Z0eWIyeGxYMkZrWkhKbGMzTmRMbkp2YkdWZmRtRnNhV1JwZEhsZmMzUmhjblFLSUNBZ0lDOHZJQ0FnSUNBOFBTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnSUNBZ0lEdzlJSEp2YkdWZmJXRndXM0p2YkdWZllXUmtjbVZ6YzEwdWNtOXNaVjkyWVd4cFpHbDBlVjlsYm1RS0lDQWdJQzh2SUNrS0lDQWdJR0o2SUY5eWIyeGxYMmx6WDJGamRHbDJaVjlpYjI5c1gyWmhiSE5sUURRS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG8yTVFvZ0lDQWdMeThnY205c1pWOXRZWEJiY205c1pWOWhaR1J5WlhOelhTNXliMnhsWDNaaGJHbGthWFI1WDNOMFlYSjBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVFMWhjQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPall5Q2lBZ0lDQXZMeUE4UFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRvMk1TMDJNZ29nSUNBZ0x5OGdjbTlzWlY5dFlYQmJjbTlzWlY5aFpHUnlaWE56WFM1eWIyeGxYM1poYkdsa2FYUjVYM04wWVhKMENpQWdJQ0F2THlBOFBTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdQRDBLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUbzJNUzAyTXdvZ0lDQWdMeThnY205c1pWOXRZWEJiY205c1pWOWhaR1J5WlhOelhTNXliMnhsWDNaaGJHbGthWFI1WDNOMFlYSjBDaUFnSUNBdkx5QThQU0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z1BEMGdjbTlzWlY5dFlYQmJjbTlzWlY5aFpHUnlaWE56WFM1eWIyeGxYM1poYkdsa2FYUjVYMlZ1WkFvZ0lDQWdZbm9nWDNKdmJHVmZhWE5mWVdOMGFYWmxYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPall6Q2lBZ0lDQXZMeUE4UFNCeWIyeGxYMjFoY0Z0eWIyeGxYMkZrWkhKbGMzTmRMbkp2YkdWZmRtRnNhV1JwZEhsZlpXNWtDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVFMWhjQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUbzJNaTAyTXdvZ0lDQWdMeThnUEQwZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFLSUNBZ0lDOHZJRHc5SUhKdmJHVmZiV0Z3VzNKdmJHVmZZV1JrY21WemMxMHVjbTlzWlY5MllXeHBaR2wwZVY5bGJtUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0ErUFFvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPall4TFRZekNpQWdJQ0F2THlCeWIyeGxYMjFoY0Z0eWIyeGxYMkZrWkhKbGMzTmRMbkp2YkdWZmRtRnNhV1JwZEhsZmMzUmhjblFLSUNBZ0lDOHZJRHc5SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNBdkx5QThQU0J5YjJ4bFgyMWhjRnR5YjJ4bFgyRmtaSEpsYzNOZExuSnZiR1ZmZG1Gc2FXUnBkSGxmWlc1a0NpQWdJQ0JpZWlCZmNtOXNaVjlwYzE5aFkzUnBkbVZmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvS1gzSnZiR1ZmYVhOZllXTjBhWFpsWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRvMk1DMDJOQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WDJoaGMxOXliMnhsS0hKdmJHVmZiV0Z3TENCeWIyeGxYMkZrWkhKbGMzTXBJR0Z1WkNBb0NpQWdJQ0F2THlBZ0lDQWdjbTlzWlY5dFlYQmJjbTlzWlY5aFpHUnlaWE56WFM1eWIyeGxYM1poYkdsa2FYUjVYM04wWVhKMENpQWdJQ0F2THlBZ0lDQWdQRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUM4dklDQWdJQ0E4UFNCeWIyeGxYMjFoY0Z0eWIyeGxYMkZrWkhKbGMzTmRMbkp2YkdWZmRtRnNhV1JwZEhsZlpXNWtDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWDNKdmJHVmZhWE5mWVdOMGFYWmxYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRjl5YjJ4bFgybHpYMkZqZEdsMlpWOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnRiMlIxYkdWekxuSmlZV011VW1KaFkwMXZaSFZzWlM1ZllYTnpaWEowWDJOaGJHeGxjbDlwYzE5aGNuSmhibWRsY2lncElDMCtJSFp2YVdRNkNsOWhjM05sY25SZlkyRnNiR1Z5WDJselgyRnljbUZ1WjJWeU9nb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2pZM0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZhWE5mWVhKeVlXNW5aWElvVkhodUxuTmxibVJsY2lrc0lHVnljaTVWVGtGVlZFaFBVa2xhUlVRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJRzF2WkhWc1pYTXZjbUpoWXk1d2VUbzFOQW9nSUNBZ0x5OGdjbVYwZFhKdUlISnZiR1ZmWVdSa2NtVnpjeUE5UFNCelpXeG1MbUZ5Y21GdVoyVnlMblpoYkhWbENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURVeU0yRTBNVFV5TlRJeU13b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZ5Y21GdVoyVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG8yTndvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVgybHpYMkZ5Y21GdVoyVnlLRlI0Ymk1elpXNWtaWElwTENCbGNuSXVWVTVCVlZSSVQxSkpXa1ZFQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdGMWRHaHZjbWw2WldRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUcxdlpIVnNaWE11Y21KaFl5NVNZbUZqVFc5a2RXeGxMbDloYzNObGNuUmZhWE5mYm05MFgyTnZiblJ5WVdOMFgyUmxabUYxYkhSbFpDZ3BJQzArSUhadmFXUTZDbDloYzNObGNuUmZhWE5mYm05MFgyTnZiblJ5WVdOMFgyUmxabUYxYkhSbFpEb0tJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRvNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1SbFptRjFiSFJsWkN3Z1pYSnlMa1JGUmtGVlRGUkZSQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltUmxabUYxYkhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVrWldaaGRXeDBaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUkdWbVlYVnNkR1ZrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ0YjJSMWJHVnpMbkppWVdNdVVtSmhZMDF2WkhWc1pTNWZZWE56WlhKMFgzWmhiR2xrWDNKdmJHVW9jbTlzWlY5cFpEb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGZZWE56WlhKMFgzWmhiR2xrWDNKdmJHVTZDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk9UTUtJQ0FnSUM4dklHUmxaaUJmWVhOelpYSjBYM1poYkdsa1gzSnZiR1VvYzJWc1ppd2djbTlzWlY5cFpEb2dWVWx1ZERZMEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZPVFF0TVRBeENpQWdJQ0F2THlCaGMzTmxjblFnY205c1pWOXBaQ0JwYmlBb0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZUMUJmUkVGRlRVOU9LU3dLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5QlEwTlBWVTVVWDAxQlRrRkhSVklwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgxQlNTVTFCVWxsZlJFVkJURVZTS1N3S0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb1pXNTFiWE11VWs5TVJWOVVVbFZUVkVWRktTd0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlCVlZSSVQxSkpWRmtwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgwOUNVMFZTVmtWU0tTd0tJQ0FnSUM4dklDa3NJR1Z5Y2k1SlRsWkJURWxFWDFKUFRFVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2prMUNpQWdJQ0F2THlCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5UFVGOUVRVVZOVDA0cExBb2dJQ0FnY0hWemFHbHVkQ0F5TlFvZ0lDQWdMeThnYlc5a2RXeGxjeTl5WW1GakxuQjVPamswTFRFd01Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhKdmJHVmZhV1FnYVc0Z0tBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaGxiblZ0Y3k1U1QweEZYMDlRWDBSQlJVMVBUaWtzQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlFVTkRUMVZPVkY5TlFVNUJSMFZTS1N3S0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb1pXNTFiWE11VWs5TVJWOVFVa2xOUVZKWlgwUkZRVXhGVWlrc0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZWRkpWVTFSRlJTa3NDaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLR1Z1ZFcxekxsSlBURVZmUVZWVVNFOVNTVlJaS1N3S0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb1pXNTFiWE11VWs5TVJWOVBRbE5GVWxaRlVpa3NDaUFnSUNBdkx5QXBMQ0JsY25JdVNVNVdRVXhKUkY5U1QweEZDaUFnSUNBOVBRb2dJQ0FnWW01NklGOWhjM05sY25SZmRtRnNhV1JmY205c1pWOWliMjlzWDNSeWRXVkFOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBdkx5QnRiMlIxYkdWekwzSmlZV011Y0hrNk9UWUtJQ0FnSUM4dklGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgwRkRRMDlWVGxSZlRVRk9RVWRGVWlrc0NpQWdJQ0JwYm5Salh6TWdMeThnTkRBS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG81TkMweE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCeWIyeGxYMmxrSUdsdUlDZ0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlQVUY5RVFVVk5UMDRwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgwRkRRMDlWVGxSZlRVRk9RVWRGVWlrc0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZVRkpKVFVGU1dWOUVSVUZNUlZJcExBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaGxiblZ0Y3k1U1QweEZYMVJTVlZOVVJVVXBMQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2hsYm5WdGN5NVNUMHhGWDBGVlZFaFBVa2xVV1Nrc0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZUMEpUUlZKV1JWSXBMQW9nSUNBZ0x5OGdLU3dnWlhKeUxrbE9Wa0ZNU1VSZlVrOU1SUW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZZWE56WlhKMFgzWmhiR2xrWDNKdmJHVmZZbTl2YkY5MGNuVmxRRFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qazNDaUFnSUNBdkx5QlZTVzUwTmpRb1pXNTFiWE11VWs5TVJWOVFVa2xOUVZKWlgwUkZRVXhGVWlrc0NpQWdJQ0J3ZFhOb2FXNTBJRFV3Q2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZPVFF0TVRBeENpQWdJQ0F2THlCaGMzTmxjblFnY205c1pWOXBaQ0JwYmlBb0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZUMUJmUkVGRlRVOU9LU3dLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5QlEwTlBWVTVVWDAxQlRrRkhSVklwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgxQlNTVTFCVWxsZlJFVkJURVZTS1N3S0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb1pXNTFiWE11VWs5TVJWOVVVbFZUVkVWRktTd0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlCVlZSSVQxSkpWRmtwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgwOUNVMFZTVmtWU0tTd0tJQ0FnSUM4dklDa3NJR1Z5Y2k1SlRsWkJURWxFWDFKUFRFVUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1gyRnpjMlZ5ZEY5MllXeHBaRjl5YjJ4bFgySnZiMnhmZEhKMVpVQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRvNU9Bb2dJQ0FnTHk4Z1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlZGSlZVMVJGUlNrc0NpQWdJQ0J3ZFhOb2FXNTBJRFl3Q2lBZ0lDQXZMeUJ0YjJSMWJHVnpMM0ppWVdNdWNIazZPVFF0TVRBeENpQWdJQ0F2THlCaGMzTmxjblFnY205c1pWOXBaQ0JwYmlBb0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZUMUJmUkVGRlRVOU9LU3dLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5QlEwTlBWVTVVWDAxQlRrRkhSVklwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgxQlNTVTFCVWxsZlJFVkJURVZTS1N3S0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb1pXNTFiWE11VWs5TVJWOVVVbFZUVkVWRktTd0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlCVlZSSVQxSkpWRmtwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgwOUNVMFZTVmtWU0tTd0tJQ0FnSUM4dklDa3NJR1Z5Y2k1SlRsWkJURWxFWDFKUFRFVUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1gyRnpjMlZ5ZEY5MllXeHBaRjl5YjJ4bFgySnZiMnhmZEhKMVpVQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUM4dklHMXZaSFZzWlhNdmNtSmhZeTV3ZVRvNU9Rb2dJQ0FnTHk4Z1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlFWVlVTRTlTU1ZSWktTd0tJQ0FnSUhCMWMyaHBiblFnTnpBS0lDQWdJQzh2SUcxdlpIVnNaWE12Y21KaFl5NXdlVG81TkMweE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCeWIyeGxYMmxrSUdsdUlDZ0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlQVUY5RVFVVk5UMDRwTEFvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNobGJuVnRjeTVTVDB4RlgwRkRRMDlWVGxSZlRVRk9RVWRGVWlrc0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZVRkpKVFVGU1dWOUVSVUZNUlZJcExBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaGxiblZ0Y3k1U1QweEZYMVJTVlZOVVJVVXBMQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2hsYm5WdGN5NVNUMHhGWDBGVlZFaFBVa2xVV1Nrc0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZUMEpUUlZKV1JWSXBMQW9nSUNBZ0x5OGdLU3dnWlhKeUxrbE9Wa0ZNU1VSZlVrOU1SUW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZZWE56WlhKMFgzWmhiR2xrWDNKdmJHVmZZbTl2YkY5MGNuVmxRRFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0x5OGdiVzlrZFd4bGN5OXlZbUZqTG5CNU9qRXdNQW9nSUNBZ0x5OGdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZUMEpUUlZKV1JWSXBMQW9nSUNBZ2NIVnphR2x1ZENBNE1Bb2dJQ0FnTHk4Z2JXOWtkV3hsY3k5eVltRmpMbkI1T2prMExURXdNUW9nSUNBZ0x5OGdZWE56WlhKMElISnZiR1ZmYVdRZ2FXNGdLQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2hsYm5WdGN5NVNUMHhGWDA5UVgwUkJSVTFQVGlrc0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtHVnVkVzF6TGxKUFRFVmZRVU5EVDFWT1ZGOU5RVTVCUjBWU0tTd0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlRVWtsTlFWSlpYMFJGUVV4RlVpa3NDaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLR1Z1ZFcxekxsSlBURVZmVkZKVlUxUkZSU2tzQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0dWdWRXMXpMbEpQVEVWZlFWVlVTRTlTU1ZSWktTd0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlQUWxORlVsWkZVaWtzQ2lBZ0lDQXZMeUFwTENCbGNuSXVTVTVXUVV4SlJGOVNUMHhGQ2lBZ0lDQTlQUW9nSUNBZ1lub2dYMkZ6YzJWeWRGOTJZV3hwWkY5eWIyeGxYMkp2YjJ4ZlptRnNjMlZBTndvS1gyRnpjMlZ5ZEY5MllXeHBaRjl5YjJ4bFgySnZiMnhmZEhKMVpVQTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDbDloYzNObGNuUmZkbUZzYVdSZmNtOXNaVjlpYjI5c1gyMWxjbWRsUURnNkNpQWdJQ0F2THlCdGIyUjFiR1Z6TDNKaVlXTXVjSGs2T1RRdE1UQXhDaUFnSUNBdkx5QmhjM05sY25RZ2NtOXNaVjlwWkNCcGJpQW9DaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLR1Z1ZFcxekxsSlBURVZmVDFCZlJFRkZUVTlPS1N3S0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb1pXNTFiWE11VWs5TVJWOUJRME5QVlU1VVgwMUJUa0ZIUlZJcExBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaGxiblZ0Y3k1U1QweEZYMUJTU1UxQlVsbGZSRVZCVEVWU0tTd0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9aVzUxYlhNdVVrOU1SVjlVVWxWVFZFVkZLU3dLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvWlc1MWJYTXVVazlNUlY5QlZWUklUMUpKVkZrcExBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaGxiblZ0Y3k1U1QweEZYMDlDVTBWU1ZrVlNLU3dLSUNBZ0lDOHZJQ2tzSUdWeWNpNUpUbFpCVEVsRVgxSlBURVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lISnZiR1VnYVdSbGJuUnBabWxsY2dvZ0lDQWdjbVYwYzNWaUNncGZZWE56WlhKMFgzWmhiR2xrWDNKdmJHVmZZbTl2YkY5bVlXeHpaVUEzT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdYMkZ6YzJWeWRGOTJZV3hwWkY5eWIyeGxYMkp2YjJ4ZmJXVnlaMlZBT0FvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFnS0NZS0JCVWZmSFVHVWpwQlVsSWpCbEk2VkZKVEl3WlNPa0ZWVkNNR1VqcE5Ua2NqQmxJNlVGbEVJd1pTT2sxUFF5TUpaR1ZtWVhWc2RHVmtCbEk2VDFCRUl4SmpiMjUwY21GamRGOXpkWE53Wlc1a1pXUXhHRUFBRVNreUEyY25DRElEWnljSkkyY25CeU5uTVJ0QkFHZUFCSkZQQk9zMkdnQ09BUUJPTVJrVVJERVlSSUlKQklMM0d5MEU3d1QxMHdUZk5EVlFCRDIrZ0wwRUhqNUk1d1E1SkIrakJBRU1ncGtFZEFhczBnUWFjcUx1TmhvQWpna0FJQUE4QUZRQkRnR2hBYjhCM1FIbkFqQUFNUm1CQkJJeEdCQkVRZ0FPTVJrVU1SZ1VFRVFwTVFCbklrT0lBc0FpUXpZYUFVa1ZKQkpFaUFLelNUSURFMFFwVEdjeUJ4WW9URkN3SWtNMkdnRkpGU1FTUklnQ2x5Y0lUR2N5QnhZb1RGQ3dJa00yR2dGSkZTSVNSRFlhQWtsT0Fra1ZKQkpFTmhvRFNVNERTUldCRUJKRWlBSm9pQUp1VHdJWFNVNERTWWdDYkRJRFR3TVRSRXNCSTF0UEFvRUlXd3hFSlJKQkFCY25CRXNEVUVtOVJRRVVSRXNDdnpJSEZpaE1VTEFpUTBtQk1oSkJBQkVuQlVzRFVFbTlSUUVVUkVzQ3YwTC8zMG1CUEJKQkFCQXFTd05RU2IxRkFSUkVTd0svUXYvSVNZRkdFa0VBRUN0TEExQkp2VVVCRkVSTEFyOUMvN0ZKZ1ZBU1FmK3FKd1pMQTFCSnZVVUJGRVJMQXI5Qy81azJHZ0ZKRlNJU1JEWWFBa2xPQWhVa0VrU0lBYnVJQWNFWFJ3S0lBY05KZ1JRVFJDVVNRUUFWSndSTEFsQkp2VVVCUkx4SU1nY1dLRXhRc0NKRFNZRXlFa0VBRHljRlN3SlFTYjFGQVVTOFNFTC80VW1CUEJKQkFBNHFTd0pRU2IxRkFVUzhTRUwvekVtQlJoSkJBQTRyU3dKUVNiMUZBVVM4U0VML3QwbUJVQkpCLzdBbkJrc0NVRW05UlFGRXZFaEMvNkUyR2dGSkZTSVNSQ05US3pFQWlBRDRSQ2NKVEdjeUJ4WW9URkN3SWtNMkdnRkpGU0lTUkNOVEtqRUFpQURhUkNjSFRHY3lCeFlvVEZDd0lrTWpLV1ZFS0V4UXNDSkROaG9CU1JVa0VrUW5CRXNCaUFDekp3VkxBb2dBckNwTEE0Z0FwaXRMQklnQW9DY0dUd1dJQUptQUFRQWpUd1pVSWs4RlZJRUNUd1JVZ1FOUEExU0JCRThDVkNoTVVMQWlRellhQVVrVkloSkVOaG9DU1U0Q0ZTUVNSQmRKaUFDb0pZTUVNanhHVUU4RmpnVUFQZ0F2QUNFQUV3QUJBQ2NHU3dGUVNiMUZBVVMrU0NoTVVMQWlReXRMQVZCSnZVVUJSTDVJUXYvc0trc0JVRW05UlFGRXZraEMvOTRuQlVzQlVFbTlSUUZFdmtoQy84OG5CRXNCVUVtOVJRRkV2a2hDLzhDS0FnR0FBSXYraS85UVNiMUZBVUVBSUlzQnZrUWpXeklIU1l3QURrRUFFWXNCdmtTQkNGdUxBQTlCQUFRaWpBQ0pJMEwvK1RFQUl5bGxSQkpFaVNNbkIyVkVGRVNKaWdFQWkvK0JHUkpBQUNlTC95VVNRQUFnaS8rQk1oSkFBQmlMLzRFOEVrQUFFSXYvZ1VZU1FBQUlpLytCVUJKQkFBTWlSSWtqUXYvNiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
