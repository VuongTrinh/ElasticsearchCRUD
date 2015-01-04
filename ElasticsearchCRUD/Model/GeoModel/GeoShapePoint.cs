﻿using ElasticsearchCRUD.Utils;

namespace ElasticsearchCRUD.Model.GeoModel
{
	public class GeoShapePoint : GeoType
	{
		public GeoPoint Coordinates { get; set; }

		public void WriteJson(ElasticsearchCrudJsonWriter elasticsearchCrudJsonWriter)
		{
			elasticsearchCrudJsonWriter.JsonWriter.WriteStartObject();
			JsonHelper.WriteValue("type", DefaultGeoShapes.Point, elasticsearchCrudJsonWriter);
			elasticsearchCrudJsonWriter.JsonWriter.WritePropertyName("coordinates");
			Coordinates.WriteJson(elasticsearchCrudJsonWriter);
			elasticsearchCrudJsonWriter.JsonWriter.WriteEndObject();
		}
	}
}