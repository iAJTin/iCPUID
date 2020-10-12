
namespace iTin.Core.ComponentModel
{
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    /// Class 
    /// </summary>
    public class ByteReader
    {
        #region constructor/s

        #region [private] ByteReader(byte[]): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="ByteReader"/> class.
        /// </summary>
        private ByteReader(byte[] data) => Data = data;
        #endregion

        #endregion

        #region public properties

        #region [public] (byte[]) Data: Gets a reference to original data.
        /// <summary>
        /// Gets a reference to original data
        /// </summary>
        /// <value>
        /// Array of bytes that contains original data
        /// </value>
        public byte[] Data { get; }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (ByteReader) FromByteArray(byte[]): 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>
        /// </returns>
        public static ByteReader FromByteArray(byte[] data) => new ByteReader(data);
        #endregion

        #endregion

        #region public methods

        #region [public] (byte) GetByte(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="offset">target byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        public byte GetByte(byte offset) => Data[offset];
        #endregion

        #region [public] (byte) GetBytes(byte, byte): Returns the stored array from start with specified lenght
        /// <summary>
        /// Returns the stored array from start with specified lenght.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <param name="lenght">lenght</param>
        /// <returns>
        /// The array value stored.
        /// </returns>
        public byte[] GetBytes(byte start, byte lenght)
        {
            var bytes = new Collection<byte>();
            for (byte i = start; i <= lenght; i++)
            {
                bytes.Add(Data[i]);
            }

            return (byte[])bytes.ToArray().Clone();
        }
        #endregion

        #region [public] (int) GetDoubleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="offset">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        public int GetDoubleWord(byte offset) => Data.GetDoubleWord(offset);
        #endregion

        #region [public] (long) GetQuadrupleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="offset">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        public long GetQuadrupleWord(byte offset) => Data.GetQuadrupleWord(offset);
        #endregion

        #region [protected] (int) GetWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="offset">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        public int GetWord(byte offset) => Data.GetWord(offset);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"Length = {Data.Length}";
        #endregion

        #endregion
    }
}
