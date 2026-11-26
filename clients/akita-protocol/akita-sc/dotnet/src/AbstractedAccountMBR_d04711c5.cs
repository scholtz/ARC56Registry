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

namespace Arc56.Generated.akita_protocol.akita_sc.AbstractedAccountMBR_d04711c5
{


    public class AbstractedAccountMBRProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AbstractedAccountMBRProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AbstractAccountBoxMbrData : AVMObjectType
            {
                public ulong Plugins { get; set; }

                public ulong NamedPlugins { get; set; }

                public ulong Escrows { get; set; }

                public ulong Allowances { get; set; }

                public ulong Executions { get; set; }

                public ulong DomainKeys { get; set; }

                public bool EscrowExists { get; set; }

                public ulong NewEscrowMintCost { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugins = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPlugins.From(Plugins);
                    ret.AddRange(vPlugins.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNamedPlugins = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNamedPlugins.From(NamedPlugins);
                    ret.AddRange(vNamedPlugins.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEscrows.From(Escrows);
                    ret.AddRange(vEscrows.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAllowances = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAllowances.From(Allowances);
                    ret.AddRange(vAllowances.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExecutions.From(Executions);
                    ret.AddRange(vExecutions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDomainKeys = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDomainKeys.From(DomainKeys);
                    ret.AddRange(vDomainKeys.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vEscrowExists.From(EscrowExists);
                    ret.AddRange(vEscrowExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewEscrowMintCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNewEscrowMintCost.From(NewEscrowMintCost);
                    ret.AddRange(vNewEscrowMintCost.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AbstractAccountBoxMbrData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AbstractAccountBoxMbrData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugins = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPlugins.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePlugins = vPlugins.ToValue();
                    if (valuePlugins is ulong vPluginsValue) { ret.Plugins = vPluginsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNamedPlugins = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNamedPlugins.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNamedPlugins = vNamedPlugins.ToValue();
                    if (valueNamedPlugins is ulong vNamedPluginsValue) { ret.NamedPlugins = vNamedPluginsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEscrows.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrows = vEscrows.ToValue();
                    if (valueEscrows is ulong vEscrowsValue) { ret.Escrows = vEscrowsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAllowances = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAllowances.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAllowances = vAllowances.ToValue();
                    if (valueAllowances is ulong vAllowancesValue) { ret.Allowances = vAllowancesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExecutions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutions = vExecutions.ToValue();
                    if (valueExecutions is ulong vExecutionsValue) { ret.Executions = vExecutionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDomainKeys = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDomainKeys.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDomainKeys = vDomainKeys.ToValue();
                    if (valueDomainKeys is ulong vDomainKeysValue) { ret.DomainKeys = vDomainKeysValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vEscrowExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowExists = vEscrowExists.ToValue();
                    if (valueEscrowExists is bool vEscrowExistsValue) { ret.EscrowExists = vEscrowExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewEscrowMintCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNewEscrowMintCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewEscrowMintCost = vNewEscrowMintCost.ToValue();
                    if (valueNewEscrowMintCost is ulong vNewEscrowMintCostValue) { ret.NewEscrowMintCost = vNewEscrowMintCostValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AbstractAccountBoxMbrData);
                }
                public bool Equals(AbstractAccountBoxMbrData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AbstractAccountBoxMbrData left, AbstractAccountBoxMbrData right)
                {
                    return EqualityComparer<AbstractAccountBoxMbrData>.Default.Equals(left, right);
                }
                public static bool operator !=(AbstractAccountBoxMbrData left, AbstractAccountBoxMbrData right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Calculate the minimum balance requirements for various box operations
        ///</summary>
        /// <param name="appId"> </param>
        /// <param name="escrow">The escrow name to calculate MBR for </param>
        /// <param name="methodCount">The number of method restrictions on the plugin </param>
        /// <param name="plugin">The plugin name to calculate named plugin MBR for </param>
        /// <param name="groups">The number of execution groups to calculate MBR for </param>
        public async Task<Structs.AbstractAccountBoxMbrData> Mbr(ulong appId, string escrow, ulong methodCount, string plugin, ulong groups, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 205, 143, 99 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var methodCountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); methodCountAbi.From(methodCount);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); pluginAbi.From(plugin);
            var groupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupsAbi.From(groups);

            var result = await base.SimApp(new List<object> { abiHandle, appIdAbi, escrowAbi, methodCountAbi, pluginAbi, groupsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AbstractAccountBoxMbrData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Mbr_Transactions(ulong appId, string escrow, ulong methodCount, string plugin, ulong groups, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 205, 143, 99 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);
            var methodCountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); methodCountAbi.From(methodCount);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); pluginAbi.From(plugin);
            var groupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupsAbi.From(groups);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi, escrowAbi, methodCountAbi, pluginAbi, groupsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJzdHJhY3RlZEFjY291bnRNQlIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWJzdHJhY3RBY2NvdW50Qm94TUJSRGF0YSI6W3sibmFtZSI6InBsdWdpbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibmFtZWRQbHVnaW5zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVzY3Jvd3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWxsb3dhbmNlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGVjdXRpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRvbWFpbktleXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXNjcm93RXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJuZXdFc2Nyb3dNaW50Q29zdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoibWJyIiwiZGVzYyI6IkNhbGN1bGF0ZSB0aGUgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50cyBmb3IgdmFyaW91cyBib3ggb3BlcmF0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93IiwiZGVzYyI6IlRoZSBlc2Nyb3cgbmFtZSB0byBjYWxjdWxhdGUgTUJSIGZvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0aG9kQ291bnQiLCJkZXNjIjoiVGhlIG51bWJlciBvZiBtZXRob2QgcmVzdHJpY3Rpb25zIG9uIHRoZSBwbHVnaW4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsdWdpbiIsImRlc2MiOiJUaGUgcGx1Z2luIG5hbWUgdG8gY2FsY3VsYXRlIG5hbWVkIHBsdWdpbiBNQlIgZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJncm91cHMiLCJkZXNjIjoiVGhlIG51bWJlciBvZiBleGVjdXRpb24gZ3JvdXBzIHRvIGNhbGN1bGF0ZSBNQlIgZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBYnN0cmFjdEFjY291bnRCb3hNQlJEYXRhIiwiZGVzYyI6IlRoZSBNQlIgY29zdHMgZm9yIHBsdWdpbnMsIG5hbWVkIHBsdWdpbnMsIGVzY3Jvd3MsIGFsbG93YW5jZXMsIGRvbWFpbiBrZXlzLCBleGVjdXRpb25zLCBhbmQgbmV3IGVzY3JvdyBjcmVhdGlvbi5cbkEgZ3JhbnQgdGhhdCB1c2VzIGFuIGVzY3JvdyBieSBkZWZhdWx0IGFsc28gc3RvcmVzIHRoYXQgZXNjcm93J3MgbmFtZSwgd2hpY2ggdGhpcyBkb2VzIG5vdCBxdW90ZTogdGhlIFNESydzXG5gZGVmYXVsdEVzY3Jvd0dyYW50TWJyYCBkb2VzLiBgbmFtZWRQbHVnaW5zYCBpcyBmb3IgYW4gYWxpYXMgb2YgYSBncmFudCBvbiBgZXNjcm93YCAocGFzcyAnJyBmb3IgYSBncmFudCBvblxudGhlIG1haW4gYWNjb3VudCBvciBvbmUgdGhhdCB1c2VzIGl0cyBlc2Nyb3cgYnkgZGVmYXVsdCkuIFRoZSByZXR1cm4gdHlwZSBpcyB0aGUgb25lIHRoZSBkZXBsb3llZCBoZWxwZXIgaGFzLCBzbyBhbiBTREsgcmVhZHMgZWl0aGVyLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODJdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjYsOTEsMTg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMsOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxzbWFydF9jb250cmFjdHMvYXJjNTgvYWNjb3VudC90eXBlcy50czo6RXNjcm93SW5mbz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OSw4NCwxMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQTBNREFnT0NBeUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXSnpkSEpoWTNSbFpFRmpZMjkxYm5STlFsSWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVROalpEaG1Oak1nTHk4Z2JXVjBhRzlrSUNKdFluSW9kV2x1ZERZMExITjBjbWx1Wnl4MWFXNTBOalFzYzNSeWFXNW5MSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXRZbkpmY205MWRHVkFNd29nSUNBZ1pYSnlDZ3B0WVdsdVgyMWljbDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2YldKeUxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnYldKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdmJXSnlMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQlluTjBjbUZqZEdWa1FXTmpiM1Z1ZEUxQ1VpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02T2tGaWMzUnlZV04wWldSQlkyTnZkVzUwVFVKU0xtMWljbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xaWNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMjFpY2k1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUhKbGRIVnliaUJOYVc1RmMyTnliM2R6VFVKU0lDc2dUV2x1UlhOamNtOTNVbVZtYzAxQ1VpQXJJSFJvYVhNdVgyTmhiR05DUTFCQ0tFSjVkR1Z6S0dWelkzSnZkeWt1YkdWdVozUm9LU0FxSURJS0lDQWdJR1JwWnlBekNpQWdJQ0JzWlc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTBNREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzl0WW5JdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUUxcGJrVnpZM0p2ZDNOTlFsSWdLeUJOYVc1RmMyTnliM2RTWldaelRVSlNJQ3NnZEdocGN5NWZZMkZzWTBKRFVFSW9RbmwwWlhNb1pYTmpjbTkzS1M1c1pXNW5kR2dwSUNvZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT0RBd0NpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESTFOREF3Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzl0WW5JdVlXeG5ieTUwY3pvMk5DMDJOd29nSUNBZ0x5OGdZMjl1YzNRZ1pYTmpjbTkzU1c1bWJ5QTlJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFRmljM1J5WVdOMFpXUkJZMk52ZFc1MExuQnliM1J2ZEhsd1pTNWhjbU0xT0Y5blpYUkZjMk55YjNkelBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlcyVnpZM0p2ZDExZENpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdGeVozTTZJRnRiWlhOamNtOTNYVjBLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREV3TURBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOXRZbkl1WVd4bmJ5NTBjem8yTkMwMk53b2dJQ0FnTHk4Z1kyOXVjM1FnWlhOamNtOTNTVzVtYnlBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUVGaWMzUnlZV04wWldSQlkyTnZkVzUwTG5CeWIzUnZkSGx3WlM1aGNtTTFPRjluWlhSRmMyTnliM2R6UGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiVzJWelkzSnZkMTFkQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE0yRmlNamc1TldJZ0x5OGdiV1YwYUc5a0lDSmhjbU0xT0Y5blpYUkZjMk55YjNkektITjBjbWx1WjF0ZEtTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aWIyOXNLVnRkSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRFF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2ZEhsd1pYTXVkSE02T2tWelkzSnZkMGx1Wm04K0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOXRZbkl1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnY21WMGRYSnVJRTFwYmxCc2RXZHBiazFDVWlBcklIUm9hWE11WDJOaGJHTkNRMUJDS0NoTlpYUm9iMlJTWlhOMGNtbGpkR2x2YmtKNWRHVk1aVzVuZEdnZ0tpQnRaWFJvYjJSRGIzVnVkQ2tnS3lCQ2VYUmxjeWhsYzJOeWIzY3BMbXhsYm1kMGFDa0tJQ0FnSUhCMWMyaHBiblFnTWpBS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ0tnb2dJQ0FnWkdsbklEUUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTBNREFLSUNBZ0lDb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMjFpY2k1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCeVpYUjFjbTRnVFdsdVVHeDFaMmx1VFVKU0lDc2dkR2hwY3k1ZlkyRnNZMEpEVUVJb0tFMWxkR2h2WkZKbGMzUnlhV04wYVc5dVFubDBaVXhsYm1kMGFDQXFJRzFsZEdodlpFTnZkVzUwS1NBcklFSjVkR1Z6S0dWelkzSnZkeWt1YkdWdVozUm9LUW9nSUNBZ2NIVnphR2x1ZENBek9Ea3dNQW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhKbGRIVnliaUJOYVc1T1lXMWxaRkJzZFdkcGJrMUNVaUFySUhSb2FYTXVYMk5oYkdOQ1ExQkNLRUo1ZEdWektHNWhiV1VwTG14bGJtZDBhQ0FySUVKNWRHVnpLR3RsZVVWelkzSnZkeWt1YkdWdVozUm9LUW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOXRZbkl1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnY21WMGRYSnVJRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2diR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOREF3Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzl0WW5JdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUUxcGJrNWhiV1ZrVUd4MVoybHVUVUpTSUNzZ2RHaHBjeTVmWTJGc1kwSkRVRUlvUW5sMFpYTW9ibUZ0WlNrdWJHVnVaM1JvSUNzZ1FubDBaWE1vYTJWNVJYTmpjbTkzS1M1c1pXNW5kR2dwQ2lBZ0lDQndkWE5vYVc1MElESXdOVEF3Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzl0WW5JdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUUxcGJrRnNiRzkzWVc1alpVMUNVaUFySUhSb2FYTXVYMk5oYkdOQ1ExQkNLRUo1ZEdWektHVnpZM0p2ZHlrdWJHVnVaM1JvS1FvZ0lDQWdjSFZ6YUdsdWRDQXlOemN3TUFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOXRZbkl1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnY21WMGRYSnVJRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2diR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOREF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdUV2x1Ukc5dFlXbHVTMlY1YzAxQ1VpQXJJSFJvYVhNdVgyTmhiR05DUTFCQ0tFSjVkR1Z6S0dSdmJXRnBiaWt1YkdWdVozUm9LUW9nSUNBZ2NIVnphR2x1ZENBeE5UY3dNQW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhKbGRIVnliaUJDYjNoRGIzTjBVR1Z5UW5sMFpTQXFJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCd2RYTm9hVzUwSURFeU9EQXdDaUFnSUNBcUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOXRZbkl1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnY21WMGRYSnVJRTFwYmtWNFpXTjFkR2x2Ym5OTlFsSWdLeUIwYUdsekxsOWpZV3hqUWtOUVFpaG5jbTkxY0hNZ0tpQXpNaWtLSUNBZ0lIQjFjMmhwYm5RZ01qTTNNREFLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMjFpY2k1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCbGMyTnliM2RGZUdsemRITTZJR1Z6WTNKdmQwbHVabTliTUYwdVlXUmtjbVZ6Y3lBaFBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JsZUhSeVlXTjBJRFlnTkRFS0lDQWdJR1Y0ZEhKaFkzUWdPQ0F6TWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUVkc2IySmhiQzV0YVc1Q1lXeGhibU5sSUNzS0lDQWdJR2RzYjJKaGJDQk5hVzVDWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzl0WW5JdVlXeG5ieTUwY3pvM09DMDRNQW9nSUNBZ0x5OGdUbVYzUTI5emRFWnZja0ZTUXpVNElDc0tJQ0FnSUM4dklFZHNiMkpoYkM1dGFXNUNZV3hoYm1ObElDc0tJQ0FnSUM4dklFRlNRelU0VjJGc2JHVjBTVVJ6UW5sQlkyTnZkVzUwYzAxaWNpQXJDaUFnSUNCd2RYTm9hVzUwSURFMk1qRXdNQW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TnpndE9ERUtJQ0FnSUM4dklFNWxkME52YzNSR2IzSkJVa00xT0NBckNpQWdJQ0F2THlCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlNBckNpQWdJQ0F2THlCQlVrTTFPRmRoYkd4bGRFbEVjMEo1UVdOamIzVnVkSE5OWW5JZ0t3b2dJQ0FnTHk4Z1pYTmpjbTkzY3dvZ0lDQWdaR2xuSURjS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDIxaWNpNWhiR2R2TG5Sek9qWTVMVGd6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0J3YkhWbmFXNXpPaUIwYUdsekxuQnNkV2RwYm5OTlluSW9aWE5qY205M0xDQnRaWFJvYjJSRGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUc1aGJXVmtVR3gxWjJsdWN6b2dkR2hwY3k1dVlXMWxaRkJzZFdkcGJuTk5ZbklvY0d4MVoybHVMQ0JsYzJOeWIzY3BMQW9nSUNBZ0x5OGdJQ0JsYzJOeWIzZHpMQW9nSUNBZ0x5OGdJQ0JoYkd4dmQyRnVZMlZ6T2lCMGFHbHpMbUZzYkc5M1lXNWpaWE5OWW5Jb1pYTmpjbTkzS1N3S0lDQWdJQzh2SUNBZ1pHOXRZV2x1UzJWNWN6b2dkR2hwY3k1a2IyMWhhVzVMWlhselRXSnlLSEJzZFdkcGJpa3NDaUFnSUNBdkx5QWdJR1Y0WldOMWRHbHZibk02SUhSb2FYTXVaWGhsWTNWMGFXOXVjMDFpY2lobmNtOTFjSE1wTEFvZ0lDQWdMeThnSUNCbGMyTnliM2RGZUdsemRITTZJR1Z6WTNKdmQwbHVabTliTUYwdVlXUmtjbVZ6Y3lBaFBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J1WlhkRmMyTnliM2ROYVc1MFEyOXpkRG9nS0FvZ0lDQWdMeThnSUNBZ0lFNWxkME52YzNSR2IzSkJVa00xT0NBckNpQWdJQ0F2THlBZ0lDQWdSMnh2WW1Gc0xtMXBia0poYkdGdVkyVWdLd29nSUNBZ0x5OGdJQ0FnSUVGU1F6VTRWMkZzYkdWMFNVUnpRbmxCWTJOdmRXNTBjMDFpY2lBckNpQWdJQ0F2THlBZ0lDQWdaWE5qY205M2N3b2dJQ0FnTHk4Z0lDQXBDaUFnSUNBdkx5QjlDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBSkFEQ0FJbUFRUVZIM3gxTVJ0QkFCaUFCQlBOajJNMkdnQ09BUUFCQURFWkZERVlFRVJDQUFneEdSUXhHQlFRUXpZYUFVa1ZKQkpFRnpZYUFra2lXU1VJU3dFVkVrUlhBZ0EyR2dOSkZTUVNSQmMyR2dSSklsa2xDRXNCRlJKRVZ3SUFOaG9GU1JVa0VrUVhTd01WSTBzQkMwc0JnYUFHQzRHNHhnRUlzVXNDRmxjR0FrOEhVSUFFQUFFQUFreFFUd2V5R0lBRU9yS0pXN0lhc2hxQkJySVFJcklCczdRK1NWY0VBRXNCVndBRUtCSkVTU0paZ1NrTEpRaE1GUkpFZ1JSUEJ3dExCQWdqQzRIMHJ3SUlUd1lWU1U4R0NDTUxnWlNnQVFpQnROZ0JUd1lJSTA4REM0SFVlZ2hQQm9HQVpBdUJsTGtCQ0U4RlZ3WXBWd2dnTWdNVE1nR0J0UElKQ0VzSENFOEdGazhHRmxCUEJoWlFUd1VXVUU4REZsQlBBeFpRZ0FFQUlrOEVWRkJNRmxBb1RGQ3dnUUZEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
