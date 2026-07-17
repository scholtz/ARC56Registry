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

namespace Arc56.Generated.asastats.permission_dapp.PermissionDApp_c1c660a9
{


    //
    // 
    //    A permission-based dApp that allows only the creator to manage boxes.
    //    
    //
    public class PermissionDAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PermissionDAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Write a value to a box. Only the creator can call this method.
        ///</summary>
        /// <param name="box_name">The name of the box (should be 32 bytes) </param>
        /// <param name="value">The string value to write to the box </param>
        public async Task WriteBox(byte[] box_name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 200, 50, 25 };
            var box_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); box_nameAbi.From(box_name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, box_nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WriteBox_Transactions(byte[] box_name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 200, 50, 25 };
            var box_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); box_nameAbi.From(box_name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, box_nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete a box. Only the creator can call this method.
        ///</summary>
        /// <param name="box_name">The name of the box to delete (should be 32 bytes) </param>
        public async Task DeleteBox(byte[] box_name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 164, 35, 219 };
            var box_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); box_nameAbi.From(box_name);

            var result = await base.CallApp(new List<object> { abiHandle, box_nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBox_Transactions(byte[] box_name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 164, 35, 219 };
            var box_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); box_nameAbi.From(box_name);

            return await base.MakeTransactionList(new List<object> { abiHandle, box_nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGVybWlzc2lvbkRBcHAiLCJkZXNjIjoiXG4gICAgQSBwZXJtaXNzaW9uLWJhc2VkIGRBcHAgdGhhdCBhbGxvd3Mgb25seSB0aGUgY3JlYXRvciB0byBtYW5hZ2UgYm94ZXMuXG4gICAgIiwibmV0d29ya3MiOnsiU0dPMUdLU3p5RTdJRVBJdFR4Q0J5dzl4OEZtbnJDRGV4aTkvY09VSk9pST0iOnsiYXBwSUQiOjc1MDA5NDg2NX19LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6IndyaXRlX2JveCIsImRlc2MiOiJXcml0ZSBhIHZhbHVlIHRvIGEgYm94LiBPbmx5IHRoZSBjcmVhdG9yIGNhbiBjYWxsIHRoaXMgbWV0aG9kLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3hfbmFtZSIsImRlc2MiOiJUaGUgbmFtZSBvZiB0aGUgYm94IChzaG91bGQgYmUgMzIgYnl0ZXMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJUaGUgc3RyaW5nIHZhbHVlIHRvIHdyaXRlIHRvIHRoZSBib3giLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlX2JveCIsImRlc2MiOiJEZWxldGUgYSBib3guIE9ubHkgdGhlIGNyZWF0b3IgY2FuIGNhbGwgdGhpcyBtZXRob2QuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveF9uYW1lIiwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSBib3ggdG8gZGVsZXRlIChzaG91bGQgYmUgMzIgYnl0ZXMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiIsIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQyLDE4NV0sImVycm9yTWVzc2FnZSI6IkJveCBuYW1lIG11c3QgYmUgZXhhY3RseSAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBkZWxldGUgYXBwbGljYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGRlbGV0ZSBib3hlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiB1cGRhdGUgYXBwbGljYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIHdyaXRlIHRvIGJveGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MCw3MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MSwxMDUsMTYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTksMTEzLDE3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF5SURFZ01DQXpNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmdvZ0lDQWdMeThnWTJ4aGMzTWdVR1Z5YldsemMybHZia1JCY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TVFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhobU9XTTRNekl4T1NBd2VERTRZVFF5TTJSaUlDOHZJRzFsZEdodlpDQWlkM0pwZEdWZlltOTRLR0o1ZEdWYlhTeHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWc1pYUmxYMkp2ZUNoaWVYUmxXMTBwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSGR5YVhSbFgySnZlQ0JrWld4bGRHVmZZbTk0Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UWTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yQ2lBZ0lDQXZMeUJqYkdGemN5QlFaWEp0YVhOemFXOXVSRUZ3Y0NoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ1pYSnlDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TVRvS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qWUtJQ0FnSUM4dklHTnNZWE56SUZCbGNtMXBjM05wYjI1RVFYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCemQybDBZMmdnYldGcGJsOWpjbVZoZEdWZllYQndiR2xqWVhScGIyNUFNVElnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZZ2JXRnBibDkxY0dSaGRHVmZZWEJ3YkdsallYUnBiMjVBTVRNZ2JXRnBibDlrWld4bGRHVmZZWEJ3YkdsallYUnBiMjVBTVRRS0lDQWdJR1Z5Y2dvS2JXRnBibDlrWld4bGRHVmZZWEJ3YkdsallYUnBiMjVBTVRRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpndE5EQUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpDaUFnSUNBdkx5QXBMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJrWld4bGRHVWdZWEJ3YkdsallYUnBiMjRpQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQmtaV3hsZEdVZ1lYQndiR2xqWVhScGIyNEtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWZllYQndiR2xqWVhScGIyNUFNVE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNamt0TXpFS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExDQWlUMjVzZVNCamNtVmhkRzl5SUdOaGJpQjFjR1JoZEdVZ1lYQndiR2xqWVhScGIyNGlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCMWNHUmhkR1VnWVhCd2JHbGpZWFJwYjI0S0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI1QU1USTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TlFvZ0lDQWdMeThnUUdGeVl6UXVZbUZ5WlcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJrWVhCd0xtTnZiblJ5WVdOMExsQmxjbTFwYzNOcGIyNUVRWEJ3TG5keWFYUmxYMkp2ZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHlhWFJsWDJKdmVEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dZM0psWVhSdmNpQmpZVzRnZDNKcGRHVWdkRzhnWW05NFpYTWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQjNjbWwwWlNCMGJ5QmliM2hsY3dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklHRmpkSFZoYkY5aWIzaGZibUZ0WlNBOUlHOXdMbVY0ZEhKaFkzUW9ZbTk0WDI1aGJXVmZZbmwwWlhNc0lESXNJR0ZqZEhWaGJGOWliM2hmYm1GdFpWOXNaVzVuZEdncENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpRS0lDQWdJQzh2SUdGamRIVmhiRjkyWVd4MVpTQTlJRzl3TG1WNGRISmhZM1FvZG1Gc2RXVmZZbmwwWlhNc0lESXNJR0ZqZEhWaGJGOTJZV3gxWlY5c1pXNW5kR2dwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTmdvZ0lDQWdMeThnWVhOelpYSjBJR0ZqZEhWaGJGOWliM2hmYm1GdFpWOXNaVzVuZEdnZ1BUMGdNeklzSUNKQ2IzZ2dibUZ0WlNCdGRYTjBJR0psSUdWNFlXTjBiSGtnTXpJZ1lubDBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzVoYldVZ2JYVnpkQ0JpWlNCbGVHRmpkR3g1SURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMk9DMDNNQW9nSUNBZ0x5OGdJeUJUYVcxd2JHVWdZWEJ3Y205aFkyZzZJR0ZzZDJGNWN5QmtaV3hsZEdVZ2RHaGxJR0p2ZUNCbWFYSnpkQ0JwWmlCcGRDQmxlR2x6ZEhNc0lIUm9aVzRnWTNKbFlYUmxJR2wwQ2lBZ0lDQXZMeUFqSUZSb2FYTWdZWFp2YVdSeklIUm9aU0JzWlc1bmRHZ2dZMjl0Y0dGeWFYTnZiaUJwYzNOMVpRb2dJQ0FnTHk4Z1gyeGxibWQwYUN3Z1pYaHBjM1J6SUQwZ2IzQXVRbTk0TG14bGJtZDBhQ2hoWTNSMVlXeGZZbTk0WDI1aGJXVXBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QnBaaUJsZUdsemRITTZDaUFnSUNCaWVpQjNjbWwwWlY5aWIzaGZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzNNZ29nSUNBZ0x5OGdiM0F1UW05NExtUmxiR1YwWlNoaFkzUjFZV3hmWW05NFgyNWhiV1VwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NncDNjbWwwWlY5aWIzaGZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOelF0TnpVS0lDQWdJQzh2SUNNZ1YzSnBkR1VnZEc4Z1ltOTRJQ2hqY21WaGRHVWdibVYzSUdKdmVDa0tJQ0FnSUM4dklHOXdMa0p2ZUM1d2RYUW9ZV04wZFdGc1gySnZlRjl1WVcxbExDQmhZM1IxWVd4ZmRtRnNkV1VwQ2lBZ0lDQmtkWEF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWkdGd2NDNWpiMjUwY21GamRDNVFaWEp0YVhOemFXOXVSRUZ3Y0M1a1pXeGxkR1ZmWW05NFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFgySnZlRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR1JsYkdWMFpTQmliM2hsY3lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdSbGJHVjBaU0JpYjNobGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPVElLSUNBZ0lDOHZJR0ZqZEhWaGJGOWliM2hmYm1GdFpTQTlJRzl3TG1WNGRISmhZM1FvWW05NFgyNWhiV1ZmWW5sMFpYTXNJRElzSUdGamRIVmhiRjlpYjNoZmJtRnRaVjlzWlc1bmRHZ3BDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGamRIVmhiRjlpYjNoZmJtRnRaVjlzWlc1bmRHZ2dQVDBnTXpJc0lDSkNiM2dnYm1GdFpTQnRkWE4wSUdKbElHVjRZV04wYkhrZ016SWdZbmwwWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUc1aGJXVWdiWFZ6ZENCaVpTQmxlR0ZqZEd4NUlETXlJR0o1ZEdWekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzVOaTA1TndvZ0lDQWdMeThnSXlCRVpXeGxkR1VnZEdobElHSnZlQW9nSUNBZ0x5OGdiM0F1UW05NExtUmxiR1YwWlNoaFkzUjFZV3hmWW05NFgyNWhiV1VwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQWdFQUlERWJRUUFkTVJrVVJERVlSSUlDQlBuSU1oa0VHS1FqMnpZYUFJNENBQzRBZFFBeEdZMEdBQmYvNy8vdi8rOEFEQUFCQURFWVJERUFNZ2tTUkNORE1SaEVNUUF5Q1JKRUkwTXhHQlJFSTBNMkdnRkpKRmxKSWdoTEFoVVNSRFlhQWtra1dVa2lDRXNDRlJKRU1RQXlDUkpFVHdNaVN3UllTVTRDVGdSUEFpSlBBbGhPQWt3bEVrUzlSUUZCQUFSTEFieElTcjhqUXpZYUFVa2tXVWtpQ0VzQ0ZSSkVNUUF5Q1JKRVRDSkxBbGhNSlJKRXZFZ2pRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
