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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJzdHJhY3RlZEFjY291bnRNQlIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWJzdHJhY3RBY2NvdW50Qm94TUJSRGF0YSI6W3sibmFtZSI6InBsdWdpbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibmFtZWRQbHVnaW5zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVzY3Jvd3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWxsb3dhbmNlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGVjdXRpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRvbWFpbktleXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXNjcm93RXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJuZXdFc2Nyb3dNaW50Q29zdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoibWJyIiwiZGVzYyI6IkNhbGN1bGF0ZSB0aGUgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50cyBmb3IgdmFyaW91cyBib3ggb3BlcmF0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93IiwiZGVzYyI6IlRoZSBlc2Nyb3cgbmFtZSB0byBjYWxjdWxhdGUgTUJSIGZvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0aG9kQ291bnQiLCJkZXNjIjoiVGhlIG51bWJlciBvZiBtZXRob2QgcmVzdHJpY3Rpb25zIG9uIHRoZSBwbHVnaW4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsdWdpbiIsImRlc2MiOiJUaGUgcGx1Z2luIG5hbWUgdG8gY2FsY3VsYXRlIG5hbWVkIHBsdWdpbiBNQlIgZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJncm91cHMiLCJkZXNjIjoiVGhlIG51bWJlciBvZiBleGVjdXRpb24gZ3JvdXBzIHRvIGNhbGN1bGF0ZSBNQlIgZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBYnN0cmFjdEFjY291bnRCb3hNQlJEYXRhIiwiZGVzYyI6IlRoZSBNQlIgY29zdHMgZm9yIHBsdWdpbnMsIG5hbWVkIHBsdWdpbnMsIGVzY3Jvd3MsIGFsbG93YW5jZXMsIGRvbWFpbiBrZXlzLCBleGVjdXRpb25zLCBhbmQgbmV3IGVzY3JvdyBjcmVhdGlvbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzhdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjYsOTEsMTgxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMsOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxzbWFydF9jb250cmFjdHMvYXJjNTgvYWNjb3VudC90eXBlcy50czo6RXNjcm93SW5mbz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OSw4NCwxMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQTRJRElnTkRBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXSnpkSEpoWTNSbFpFRmpZMjkxYm5STlFsSWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVROalpEaG1Oak1nTHk4Z2JXVjBhRzlrSUNKdFluSW9kV2x1ZERZMExITjBjbWx1Wnl4MWFXNTBOalFzYzNSeWFXNW5MSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXRZbkpmY205MWRHVkFNd29nSUNBZ1pYSnlDZ3B0WVdsdVgyMWljbDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2YldKeUxtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnYldKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdmJXSnlMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQlluTjBjbUZqZEdWa1FXTmpiM1Z1ZEUxQ1VpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02T2tGaWMzUnlZV04wWldSQlkyTnZkVzUwVFVKU0xtMWljbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xaWNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMjFpY2k1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhKbGRIVnliaUJOYVc1RmMyTnliM2R6VFVKU0lDc2dkR2hwY3k1ZlkyRnNZMEpEVUVJb1FubDBaWE1vWlhOamNtOTNLUzVzWlc1bmRHZ3BDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzl0WW5JdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUVKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTkRBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnS2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdmJXSnlMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEpsZEhWeWJpQk5hVzVGYzJOeWIzZHpUVUpTSUNzZ2RHaHBjeTVmWTJGc1kwSkRVRUlvUW5sMFpYTW9aWE5qY205M0tTNXNaVzVuZEdncENpQWdJQ0J3ZFhOb2FXNTBJREU1TXpBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdmJXSnlMbUZzWjI4dWRITTZOVGt0TmpJS0lDQWdJQzh2SUdOdmJuTjBJR1Z6WTNKdmQwbHVabThnUFNCaFltbERZV3hzUEhSNWNHVnZaaUJCWW5OMGNtRmpkR1ZrUVdOamIzVnVkQzV3Y205MGIzUjVjR1V1WVhKak5UaGZaMlYwUlhOamNtOTNjejRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMXRsYzJOeWIzZGRYUW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDIxaWNpNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QmhjbWR6T2lCYlcyVnpZM0p2ZDExZENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBeE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2YldKeUxtRnNaMjh1ZEhNNk5Ua3ROaklLSUNBZ0lDOHZJR052Ym5OMElHVnpZM0p2ZDBsdVptOGdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQkJZbk4wY21GamRHVmtRV05qYjNWdWRDNXdjbTkwYjNSNWNHVXVZWEpqTlRoZloyVjBSWE5qY205M2N6NG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cxdGxjMk55YjNkZFhRb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE5oWWpJNE9UVmlJQzh2SUcxbGRHaHZaQ0FpWVhKak5UaGZaMlYwUlhOamNtOTNjeWh6ZEhKcGJtZGJYU2tvZFdsdWREWTBMR0ZrWkhKbGMzTXNZbTl2YkNsYlhTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBME1Rb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwzUjVjR1Z6TG5Sek9qcEZjMk55YjNkSmJtWnZQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2YldKeUxtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklISmxkSFZ5YmlCTmFXNVFiSFZuYVc1TlFsSWdLeUIwYUdsekxsOWpZV3hqUWtOUVFpZ29UV1YwYUc5a1VtVnpkSEpwWTNScGIyNUNlWFJsVEdWdVozUm9JQ29nYldWMGFHOWtRMjkxYm5RcElDc2dRbmwwWlhNb1pYTmpjbTkzS1M1c1pXNW5kR2dwQ2lBZ0lDQndkWE5vYVc1MElESXdDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJQ29LSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdmJXSnlMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQkNiM2hEYjNOMFVHVnlRbmwwWlNBcUlHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEUXdNQW9nSUNBZ0tnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhKbGRIVnliaUJOYVc1UWJIVm5hVzVOUWxJZ0t5QjBhR2x6TGw5allXeGpRa05RUWlnb1RXVjBhRzlrVW1WemRISnBZM1JwYjI1Q2VYUmxUR1Z1WjNSb0lDb2diV1YwYUc5a1EyOTFiblFwSUNzZ1FubDBaWE1vWlhOamNtOTNLUzVzWlc1bmRHZ3BDaUFnSUNCd2RYTm9hVzUwSURNNE9UQXdDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOXRZbkl1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnY21WMGRYSnVJRTFwYms1aGJXVmtVR3gxWjJsdVRVSlNJQ3NnZEdocGN5NWZZMkZzWTBKRFVFSW9RbmwwWlhNb2JtRnRaU2t1YkdWdVozUm9LUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JzWlc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTBNREFLSUNBZ0lDb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMjFpY2k1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCeVpYUjFjbTRnVFdsdVRtRnRaV1JRYkhWbmFXNU5RbElnS3lCMGFHbHpMbDlqWVd4alFrTlFRaWhDZVhSbGN5aHVZVzFsS1M1c1pXNW5kR2dwQ2lBZ0lDQndkWE5vYVc1MElESXdOVEF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2YldKeUxtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklISmxkSFZ5YmlCTmFXNUJiR3h2ZDJGdVkyVk5RbElnS3lCMGFHbHpMbDlqWVd4alFrTlFRaWhDZVhSbGN5aGxjMk55YjNjcExteGxibWQwYUNrS0lDQWdJSEIxYzJocGJuUWdNamMzTURBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUhKbGRIVnliaUJOYVc1RWIyMWhhVzVMWlhselRVSlNJQ3NnZEdocGN5NWZZMkZzWTBKRFVFSW9RbmwwWlhNb1pHOXRZV2x1S1M1c1pXNW5kR2dwQ2lBZ0lDQndkWE5vYVc1MElERTFOekF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnY0hWemFHbHVkQ0F4TWpnd01Bb2dJQ0FnS2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdmJXSnlMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSEpsZEhWeWJpQk5hVzVGZUdWamRYUnBiMjV6VFVKU0lDc2dkR2hwY3k1ZlkyRnNZMEpEVUVJb1ozSnZkWEJ6SUNvZ016SXBDaUFnSUNCd2RYTm9hVzUwSURJek56QXdDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOXRZbkl1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnWlhOamNtOTNSWGhwYzNSek9pQmxjMk55YjNkSmJtWnZXekJkTG1Ga1pISmxjM01nSVQwOUlFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaWGgwY21GamRDQTJJRFF4Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dNeklLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU0FyQ2lBZ0lDQm5iRzlpWVd3Z1RXbHVRbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZiV0p5TG1Gc1oyOHVkSE02TnpNdE56VUtJQ0FnSUM4dklFNWxkME52YzNSR2IzSkJVa00xT0NBckNpQWdJQ0F2THlCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlNBckNpQWdJQ0F2THlCQlVrTTFPRmRoYkd4bGRFbEVjMEo1UVdOamIzVnVkSE5OWW5JZ0t3b2dJQ0FnY0hWemFHbHVkQ0F4TmpJeE1EQUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyMWljaTVoYkdkdkxuUnpPamN6TFRjMkNpQWdJQ0F2THlCT1pYZERiM04wUm05eVFWSkROVGdnS3dvZ0lDQWdMeThnUjJ4dlltRnNMbTFwYmtKaGJHRnVZMlVnS3dvZ0lDQWdMeThnUVZKRE5UaFhZV3hzWlhSSlJITkNlVUZqWTI5MWJuUnpUV0p5SUNzS0lDQWdJQzh2SUdWelkzSnZkM01LSUNBZ0lHUnBaeUEzQ2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzl0WW5JdVlXeG5ieTUwY3pvMk5DMDNPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdjR3gxWjJsdWN6b2dkR2hwY3k1d2JIVm5hVzV6VFdKeUtHVnpZM0p2ZHl3Z2JXVjBhRzlrUTI5MWJuUXBMQW9nSUNBZ0x5OGdJQ0J1WVcxbFpGQnNkV2RwYm5NNklIUm9hWE11Ym1GdFpXUlFiSFZuYVc1elRXSnlLSEJzZFdkcGJpa3NDaUFnSUNBdkx5QWdJR1Z6WTNKdmQzTXNDaUFnSUNBdkx5QWdJR0ZzYkc5M1lXNWpaWE02SUhSb2FYTXVZV3hzYjNkaGJtTmxjMDFpY2lobGMyTnliM2NwTEFvZ0lDQWdMeThnSUNCa2IyMWhhVzVMWlhsek9pQjBhR2x6TG1SdmJXRnBia3RsZVhOTlluSW9jR3gxWjJsdUtTd0tJQ0FnSUM4dklDQWdaWGhsWTNWMGFXOXVjem9nZEdocGN5NWxlR1ZqZFhScGIyNXpUV0p5S0dkeWIzVndjeWtzQ2lBZ0lDQXZMeUFnSUdWelkzSnZkMFY0YVhOMGN6b2daWE5qY205M1NXNW1iMXN3WFM1aFpHUnlaWE56SUNFOVBTQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJRzVsZDBWelkzSnZkMDFwYm5SRGIzTjBPaUFvQ2lBZ0lDQXZMeUFnSUNBZ1RtVjNRMjl6ZEVadmNrRlNRelU0SUNzS0lDQWdJQzh2SUNBZ0lDQkhiRzlpWVd3dWJXbHVRbUZzWVc1alpTQXJDaUFnSUNBdkx5QWdJQ0FnUVZKRE5UaFhZV3hzWlhSSlJITkNlVUZqWTI5MWJuUnpUV0p5SUNzS0lDQWdJQzh2SUNBZ0lDQmxjMk55YjNkekNpQWdJQ0F2THlBZ0lDa0tJQ0FnSUM4dklIMEtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdmJXSnlMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBZ0NrQU1tQVFRVkgzeDFNUnRCQUJpQUJCUE5qMk0yR2dDT0FRQUJBREVaRkRFWUVFUkNBQWd4R1JReEdCUVFRellhQVVrVkl4SkVGellhQWtraVdTUUlTd0VWRWtSWEFnQTJHZ05KRlNNU1JCYzJHZ1JKSWxra0NFc0JGUkpFVndJQU5ob0ZTUlVqRWtRWFN3TVZKVXNCQzRIa2xnRkxBUWl4U3dJV1Z3WUNUd2RRZ0FRQUFRQUNURkJQQjdJWWdBUTZzb2xic2hxeUdvRUdzaEFpc2dHenRENUpWd1FBU3dGWEFBUW9Fa1JKSWxtQktRc2tDRXdWRWtTQkZFOEhDMDhFQ0NVTGdmU3ZBZ2hQQlJVbEM0R1VvQUZMQVFpQnROZ0JUd1lJZ2RSNlR3TUlUd2FCZ0dRTGdaUzVBUWhQQlZjR0tWY0lJRElERXpJQmdiVHlDUWhMQndoUEJoWlBCaFpRVHdZV1VFOEZGbEJQQXhaUVR3TVdVSUFCQUNKUEJGUlFUQlpRS0V4UXNJRUJRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
