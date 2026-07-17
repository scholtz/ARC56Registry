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

namespace Arc56.Generated.aorumbayev.puya.AppExpectingEffects_ebfed50b
{


    public class AppExpectingEffectsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AppExpectingEffectsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CreateGroupReturn : AVMObjectType
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

                public static CreateGroupReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CreateGroupReturn();
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
                    return Equals(obj as CreateGroupReturn);
                }
                public bool Equals(CreateGroupReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CreateGroupReturn left, CreateGroupReturn right)
                {
                    return EqualityComparer<CreateGroupReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(CreateGroupReturn left, CreateGroupReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_create"> </param>
        /// <param name="app_create"> </param>
        public async Task<Structs.CreateGroupReturn> CreateGroup(AssetConfigurationTransaction asset_create, ApplicationCallTransaction app_create, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_create, app_create });
            byte[] abiHandle = { 109, 58, 4, 57 };

            var result = await base.CallApp(new List<object> { abiHandle, asset_create, app_create }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CreateGroupReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CreateGroup_Transactions(AssetConfigurationTransaction asset_create, ApplicationCallTransaction app_create, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_create, app_create });
            byte[] abiHandle = { 109, 58, 4, 57 };

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_create, app_create }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_call"> </param>
        public async Task LogGroup(ApplicationCallTransaction app_call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { app_call });
            byte[] abiHandle = { 98, 160, 239, 98 };

            var result = await base.CallApp(new List<object> { abiHandle, app_call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogGroup_Transactions(ApplicationCallTransaction app_call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { app_call });
            byte[] abiHandle = { 98, 160, 239, 98 };

            return await base.MakeTransactionList(new List<object> { abiHandle, app_call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXBwRXhwZWN0aW5nRWZmZWN0cyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDcmVhdGVHcm91cFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9ncm91cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2ZnIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfY3JlYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2NyZWF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJDcmVhdGVHcm91cFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ19ncm91cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2NhbGwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODhdLCJlcnJvck1lc3NhZ2UiOiJBUkM0IHByZWZpeCBpcyB2YWxpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0LDY2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcsNjldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXBwIGNyZWF0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjVdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCBjcmVhdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ5XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgY29ycmVjdCBhcHAgaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzRdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBjb3JyZWN0IGFzc2V0IGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgY29ycmVjdCBtZXRob2QgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTczXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgbG9ncyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBhY2ZnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTcsOTFdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFwcGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ05nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUNpQWdJQ0F2THlCbmNtOTFjRjl6YVdSbFgyVm1abVZqZEhNdlkyOXVkSEpoWTNRdWNIazZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1FYQndSWGh3WldOMGFXNW5SV1ptWldOMGN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMlpETmhNRFF6T1NBd2VEWXlZVEJsWmpZeUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgyZHliM1Z3S0dGalptY3NZWEJ3YkNrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW14dloxOW5jbTkxY0NoaGNIQnNLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJOeVpXRjBaVjluY205MWNGOXliM1YwWlVBeklHMWhhVzVmYkc5blgyZHliM1Z3WDNKdmRYUmxRRFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUM4dklHZHliM1Z3WDNOcFpHVmZaV1ptWldOMGN5OWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkJjSEJGZUhCbFkzUnBibWRGWm1abFkzUnpLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJ4dloxOW5jbTkxY0Y5eWIzVjBaVUEwT2dvZ0lDQWdMeThnWjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TDJOdmJuUnlZV04wTG5CNU9qUUtJQ0FnSUM4dklHTnNZWE56SUVGd2NFVjRjR1ZqZEdsdVowVm1abVZqZEhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHlJQzh2SUdGd2NHd0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGNIQnNDaUFnSUNBdkx5Qm5jbTkxY0Y5emFXUmxYMlZtWm1WamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCc2IyZGZaM0p2ZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxYMmR5YjNWd1gzSnZkWFJsUURNNkNpQWdJQ0F2THlCbmNtOTFjRjl6YVdSbFgyVm1abVZqZEhNdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdkeWIzVndYM05wWkdWZlpXWm1aV04wY3k5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCQmNIQkZlSEJsWTNScGJtZEZabVpsWTNSektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUJoWTJabkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVdObVp3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdZWEJ3YkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Z3Y0d3S0lDQWdJQzh2SUdkeWIzVndYM05wWkdWZlpXWm1aV04wY3k5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdZM0psWVhSbFgyZHliM1Z3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEYzZDaUFnSUNBdkx5Qm5jbTkxY0Y5emFXUmxYMlZtWm1WamRITXZZMjl1ZEhKaFkzUXVjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdRWEJ3Ulhod1pXTjBhVzVuUldabVpXTjBjeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbWR5YjNWd1gzTnBaR1ZmWldabVpXTjBjeTVqYjI1MGNtRmpkQzVCY0hCRmVIQmxZM1JwYm1kRlptWmxZM1J6TG1OeVpXRjBaVjluY205MWNDaGhjM05sZEY5amNtVmhkR1U2SUhWcGJuUTJOQ3dnWVhCd1gyTnlaV0YwWlRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkRvS1kzSmxZWFJsWDJkeWIzVndPZ29nSUNBZ0x5OGdaM0p2ZFhCZmMybGtaVjlsWm1abFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVdE1UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHTnlaV0YwWlY5bmNtOTFjQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMk55WldGMFpUb2daM1I0Ymk1QmMzTmxkRU52Ym1acFoxUnlZVzV6WVdOMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOWpjbVZoZEdVNklHZDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNWSEpoYm5OaFkzUnBiMjRzQ2lBZ0lDQXZMeUFwSUMwK0lIUjFjR3hsVzFWSmJuUTJOQ3dnVlVsdWREWTBYVG9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnTHk4Z1ozSnZkWEJmYzJsa1pWOWxabVpsWTNSekwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWE56WlhSZlkzSmxZWFJsTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FzSUNKbGVIQmxZM1JsWkNCaGMzTmxkQ0JqY21WaGRHVmtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmRIaHVjeUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWVhOelpYUWdZM0psWVhSbFpBb2dJQ0FnTHk4Z1ozSnZkWEJmYzJsa1pWOWxabVpsWTNSekwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJ2Y0M1bllXbGtLR0Z6YzJWMFgyTnlaV0YwWlM1bmNtOTFjRjlwYm1SbGVDa2dQVDBnWVhOelpYUmZZM0psWVhSbExtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaM1I0Ym5NZ1IzSnZkWEJKYm1SbGVBb2dJQ0FnWjJGcFpITUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnTHk4Z1ozSnZkWEJmYzJsa1pWOWxabVpsWTNSekwyTnZiblJ5WVdOMExuQjVPakV5TFRFMENpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lHOXdMbWRoYVdRb1lYTnpaWFJmWTNKbFlYUmxMbWR5YjNWd1gybHVaR1Y0S1NBOVBTQmhjM05sZEY5amNtVmhkR1V1WTNKbFlYUmxaRjloYzNObGRDNXBaQW9nSUNBZ0x5OGdLU3dnSW1WNGNHVmpkR1ZrSUdOdmNuSmxZM1FnWVhOelpYUWdhV1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZMjl5Y21WamRDQmhjM05sZENCcFpBb2dJQ0FnTHk4Z1ozSnZkWEJmYzJsa1pWOWxabVpsWTNSekwyTnZiblJ5WVdOMExuQjVPakUxQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEJ3WDJOeVpXRjBaUzVqY21WaGRHVmtYMkZ3Y0M1cFpDd2dJbVY0Y0dWamRHVmtJR0Z3Y0NCamNtVmhkR1ZrSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCRGNtVmhkR1ZrUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWVhCd0lHTnlaV0YwWldRS0lDQWdJQzh2SUdkeWIzVndYM05wWkdWZlpXWm1aV04wY3k5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdiM0F1WjJGcFpDaGhjSEJmWTNKbFlYUmxMbWR5YjNWd1gybHVaR1Y0S1NBOVBTQmhjSEJmWTNKbFlYUmxMbU55WldGMFpXUmZZWEJ3TG1sa0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdkaGFXUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUM4dklHZHliM1Z3WDNOcFpHVmZaV1ptWldOMGN5OWpiMjUwY21GamRDNXdlVG94TmkweE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQnZjQzVuWVdsa0tHRndjRjlqY21WaGRHVXVaM0p2ZFhCZmFXNWtaWGdwSUQwOUlHRndjRjlqY21WaGRHVXVZM0psWVhSbFpGOWhjSEF1YVdRS0lDQWdJQzh2SUNrc0lDSmxlSEJsWTNSbFpDQmpiM0p5WldOMElHRndjQ0JwWkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JqYjNKeVpXTjBJR0Z3Y0NCcFpBb2dJQ0FnTHk4Z1ozSnZkWEJmYzJsa1pWOWxabVpsWTNSekwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWE56WlhSZlkzSmxZWFJsTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FzSUdGd2NGOWpjbVZoZEdVdVkzSmxZWFJsWkY5aGNIQXVhV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TG1OdmJuUnlZV04wTGtGd2NFVjRjR1ZqZEdsdVowVm1abVZqZEhNdWJHOW5YMmR5YjNWd0tHRndjRjlqWVd4c09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNteHZaMTluY205MWNEb0tJQ0FnSUM4dklHZHliM1Z3WDNOcFpHVmZaV1ptWldOMGN5OWpiMjUwY21GamRDNXdlVG95TWkweU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2JHOW5YMmR5YjNWd0tITmxiR1lzSUdGd2NGOWpZV3hzT2lCbmRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JGUnlZVzV6WVdOMGFXOXVLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCbmNtOTFjRjl6YVdSbFgyVm1abVZqZEhNdlkyOXVkSEpoWTNRdWNIazZNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjSEJmWTJGc2JDNWhjSEJmWVhKbmN5Z3dLU0E5UFNCaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaM1I0Ym5OaGN5QkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUdkeWIzVndYM05wWkdWZlpXWm1aV04wY3k5amIyNTBjbUZqZEM1d2VUb3lOQzB5TmdvZ0lDQWdMeThnWVhOelpYSjBJR0Z3Y0Y5allXeHNMbUZ3Y0Y5aGNtZHpLREFwSUQwOUlHRnlZelF1WVhKak5GOXphV2R1WVhSMWNtVW9DaUFnSUNBdkx5QWdJQ0FnSW5OdmJXVmZkbUZzZFdVb0tYVnBiblEyTkNJS0lDQWdJQzh2SUNrc0lDSmxlSEJsWTNSbFpDQmpiM0p5WldOMElHMWxkR2h2WkNCallXeHNaV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTXpRM09XVTJOU0F2THlCdFpYUm9iMlFnSW5OdmJXVmZkbUZzZFdVb0tYVnBiblEyTkNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZMjl5Y21WamRDQnRaWFJvYjJRZ1kyRnNiR1ZrQ2lBZ0lDQXZMeUJuY205MWNGOXphV1JsWDJWbVptVmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGNIQmZZMkZzYkM1dWRXMWZiRzluY3lBOVBTQXhMQ0FpWlhod1pXTjBaV1FnYkc5bmN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdUblZ0VEc5bmN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdiRzluY3dvZ0lDQWdMeThnWjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQzVtY205dFgyeHZaeWhoY0hCZlkyRnNiQzVzWVhOMFgyeHZaeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJVa00wSUhCeVpXWnBlQ0JwY3lCMllXeHBaQW9nSUNBZ0x5OGdaM0p2ZFhCZmMybGtaVjlsWm1abFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlBOVBTQW9ZWEJ3WDJOaGJHd3VaM0p2ZFhCZmFXNWtaWGdnS3lBeEtTQXFJRWRzYjJKaGJDNW5jbTkxY0Y5emFYcGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNBcUNpQWdJQ0F2THlCbmNtOTFjRjl6YVdSbFgyVm1abVZqZEhNdlkyOXVkSEpoWTNRdWNIazZNamt0TXpBS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMExtWnliMjFmYkc5bktHRndjRjlqWVd4c0xteGhjM1JmYkc5bktRb2dJQ0FnTHk4Z1BUMGdLR0Z3Y0Y5allXeHNMbWR5YjNWd1gybHVaR1Y0SUNzZ01Ta2dLaUJIYkc5aVlXd3VaM0p2ZFhCZmMybDZaUW9nSUNBZ2FYUnZZZ29nSUNBZ1lqMDlDaUFnSUNBdkx5Qm5jbTkxY0Y5emFXUmxYMlZtWm1WamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpndE16RUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalF1Wm5KdmJWOXNiMmNvWVhCd1gyTmhiR3d1YkdGemRGOXNiMmNwQ2lBZ0lDQXZMeUFnSUNBZ1BUMGdLR0Z3Y0Y5allXeHNMbWR5YjNWd1gybHVaR1Y0SUNzZ01Ta2dLaUJIYkc5aVlXd3VaM0p2ZFhCZmMybDZaUW9nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQVFBR0pnRUVGUjk4ZFRFYlFRQllnZ0lFYlRvRU9RUmlvTzlpTmhvQWpnSUFHQUFDSTBNeEdSUkVNUmhFTVJZaUNVazRFQ1FTUklnQVdpSkRNUmtVUkRFWVJERVdnUUlKU1RnUWdRTVNSREVXSWdsSk9CQWtFa1NJQUJaTUZrd1dVQ2hNVUxBaVF6RVpRUCs0TVJnVVJDSkRpZ0lDaS80NFBFbEVpLzQ0RmoxTEFSSkVpLzg0UFVsRWkvODRGajFMQVJKRWlZb0JBSXYvSThJYWdBVFRSNTVsRWtTTC96ZzdJaEpFaS84NFBrbFhCQUJNVndBRUtCSkVpLzg0RmlJSU1nUUxGcWhFaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
