/*
 * ========================================================================
 * Copyright(c) 2006-2010 PWMIS, All Rights Reserved.
 * Welcom use the PDF.NET (PWMIS Data Process Framework).
 * See more information,Please goto http://www.pwmis.com/sqlmap 
 * ========================================================================
 * ���������
 * 
 * ���ߣ���̫��     ʱ�䣺2008-10-12
 * �汾��V3.0
 * 
 * �޸��ߣ�         ʱ�䣺                
 * �޸�˵����
 * ========================================================================
*/
using System;
using System.Data;
namespace PWMIS.DataProvider.Data
{
	/// <summary>
    /// �������ݷ��ʳ����� ���� AdoHelper �� ,ʵ��ʹ�÷����μ� PWMIS.CommonDataProvider.Adapter.MyDB
	/// </summary>
	public abstract class AdoHelper:CommonDB
	{
		/// <summary>
		/// Ĭ�Ϲ��캯��
		/// </summary>
		public AdoHelper()
		{
			//
			// TODO: �ڴ˴����ӹ��캯���߼�
			//
		}

//		/// <summary>
//		/// ��ȡ����������ʵ��
//		/// </summary>
//		/// <returns>����������</returns>
//		protected override IDbDataAdapter  GetDataAdapter(IDbCommand command)
//		{
//			return null;
//		}

//		/// <summary>
//		/// ��ȡһ���²�������
//		/// </summary>
//		/// <returns>�ض�������Դ�Ĳ�������</returns>
//		public override IDataParameter GetParameter()
//		{
//			return null;
//		}

		/// <summary>
		/// �����������ݷ������ʵ��
		/// </summary>
		/// <param name="providerAssembly">�ṩ���������</param>
		/// <param name="providerType">�ṩ������</param>
		/// <returns></returns>
		public static AdoHelper  CreateHelper(string providerAssembly, string providerType)
		{
			return (AdoHelper)CommonDB.CreateInstance(providerAssembly,providerType);
		}

		/// <summary>
		/// ִ�в�����ֵ�Ĳ�ѯ
		/// </summary>
		/// <param name="connectionString">�����ַ���</param>
		/// <param name="commandType">��������</param>
		/// <param name="SQL">SQL</param>
		/// <returns>��Ӱ�������</returns>
		public virtual int ExecuteNonQuery(string connectionString,CommandType commandType,string SQL)
		{
			base.ConnectionString=connectionString;
			return base.ExecuteNonQuery(SQL,commandType,null);
		}

		/// <summary>
		/// ִ�в�����ֵ�Ĳ�ѯ
		/// </summary>
		/// <param name="connectionString">�����ַ���</param>
		/// <param name="commandType">��������</param>
		/// <param name="SQL">SQL</param>
		/// <param name="parameters">��������</param>
		/// <returns>��Ӱ�������</returns>
        public virtual int ExecuteNonQuery(string connectionString, CommandType commandType, string SQL, IDataParameter[] parameters)
		{
			base.ConnectionString=connectionString;
			return base.ExecuteNonQuery(SQL,commandType,parameters);
		}

		/// <summary>
		/// ִ�������Ķ�����ѯ
		/// </summary>
		/// <param name="connectionString">�����ַ���</param>
		/// <param name="commandType">��������</param>
		/// <param name="SQL">SQL</param>
		/// <param name="parameters">��������</param>
		/// <returns>�����Ķ���</returns>
		public IDataReader ExecuteReader(string connectionString,CommandType commandType,string SQL,IDataParameter[] parameters)
		{
			base.ConnectionString=connectionString;
			return base.ExecuteDataReader(SQL,commandType,parameters);
		}

		/// <summary>
		/// ִ�з������ݼ��Ĳ�ѯ
		/// </summary>
		/// <param name="connectionString">�����ַ���</param>
		/// <param name="commandType">��������</param>
		/// <param name="SQL">SQL</param>
		/// <param name="parameters">��������</param>
		/// <returns>���ݼ�</returns>
		public DataSet ExecuteDataSet(string connectionString,CommandType commandType,string SQL,IDataParameter[] parameters)
		{
			base.ConnectionString=connectionString;
			return base.ExecuteDataSet(SQL,commandType,parameters);
		}

        /// <summary>
        /// ִ�з������ݼ��Ĳ�ѯ
        /// </summary>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="commandType">��������</param>
        /// <param name="SQL">SQL</param>
        /// <returns>���ݼ�</returns>
        public DataSet ExecuteDataSet(string connectionString, CommandType commandType, string SQL)
        {
            base.ConnectionString = connectionString;
            return base.ExecuteDataSet(SQL, commandType, null);
        }

	
		/// <summary>
		/// ִ�з��ص�һֵ�ò�ѯ
		/// </summary>
		/// <param name="connectionString">�����ַ���</param>
		/// <param name="commandType">��������</param>
		/// <param name="SQL">SQL</param>
		/// <param name="parameters">��������</param>
		/// <returns>���</returns>
		public object ExecuteScalar(string connectionString,CommandType commandType,string SQL,IDataParameter[] parameters)
		{
			base.ConnectionString=connectionString;
			return base.ExecuteScalar (SQL,commandType,parameters);
		}
		

	}
}