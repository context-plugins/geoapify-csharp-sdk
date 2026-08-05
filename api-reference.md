# Reference

> Source: [GeoapifyClient](GeoapifyClient.cs)

## AddressAutocompleteApi

> Source: [AddressAutocompleteApi](Api/AddressAutocompleteApi.cs)

<details>
<summary><code>Task&lt;GeocodeAutocompleteResponse&gt; GetAddressAutocomplete(string text, string apiKey, Format? format, Type3? type, int? limit, string? lang, string? filter, string? bias, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint returns a list of suggested addresses and associated location details (such as country, city, street, and more) based on the partial text provided by the user. It helps implement autocomplete functionality for address inputs, enhancing user experience by offering real-time suggestions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AddressAutocompleteApi.GetAddressAutocomplete(text,
        apiKey,
        format,
        type,
        limit,
        lang,
        filter,
        bias);
    // TODO: Handle 'response' of type GeocodeAutocompleteResponse
}
catch (SdkException<GetAddressAutocompleteError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAddressAutocompleteError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>text</code> | <code>string</code> | The partial address or place name to autocomplete. This input is used to generate location-based suggestions. |
| <code>apiKey</code> | <code>string</code> | Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at [https://myprojects.geoapify.com/](https://myprojects.geoapify.com/). The Free plan includes up to 3,000 requests per day. |
| <code>format</code> | <code>[Format?](Models/Enums/Format.cs)</code> | The format of the response data. Supported formats include JSON, XML, and GeoJSON. |
| <code>type</code> | <code>[Type3?](Models/Enums/Type3.cs)</code> | Defines the location type to be searched. Available types include:<br><br>- `country`: Search for countries.<br>- `state`: Search for states or regions.<br>- `city`: Search for cities or towns.<br>- `postcode`: Search for postal codes.<br>- `street`: Search for specific streets.<br>- `amenity`: Search for points of interest (e.g., schools, parks, etc.).<br>- `locality`: Search for administrative areas, which can include postcodes, districts, cities, counties, and states. |
| <code>limit</code> | <code>int?</code> | The maximum number of results to return. This limits the number of address suggestions displayed. |
| <code>lang</code> | <code>string?</code> | Result language in [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format (e.g., 'en' for English). |
| <code>filter</code> | <code>string?</code> | Refine your search results based on specific geographic criteria. You can apply the following filters to make the suggestions more relevant:<br><br>- **By circle**:  <br>  Use `circle:lon,lat,radiusMeters` to search for places within a circular area, defined by longitude, latitude, and radius in meters.  <br>  Example: `filter=circle:-87.770231,41.878968,5000`<br>  <br>- **By rectangle**:  <br>  Use `rect:lon1,lat1,lon2,lat2` to search within a rectangular area defined by two longitude and latitude points (southwest and northeast corners).  <br>  Example: `filter=rect:-89.097540,39.668983,-88.399274,40.383412`<br>  <br>- **By country**:  <br>  Use a comma-separated list of ISO 3166-1 Alpha-2 country codes in lowercase to filter results by country. Use `'auto'` to detect the country by IP address, or `'none'` to skip country filtering.  <br>  Example: `filter=countrycode:de,es,fr`<br>  <br>- **By place**:  <br>  Use `place:placeId` to search within a specific boundary, such as a city, district, or postcode, using a `place_id` returned by other Geoapify APIs (Geocoding, Reverse Geocoding, Places, or Boundaries APIs).  <br>  Example: `filter=place:51f07665660fc4024059dc0a96dfac6c...` |
| <code>bias</code> | <code>string?</code> | Prioritize search results based on proximity to a point, radius, bounding box, or country without limiting the search area. This is useful for displaying nearby results first while allowing global search:<br><br>- **By circle**:  <br>  Use `circle:lon,lat,radiusMeters` to prioritize results from within a circular area, and then search worldwide.  <br>  Example: `bias=circle:-87.770231,41.878968,5000`<br>  <br>- **By rectangle**:  <br>  Use `rect:lon1,lat1,lon2,lat2` to prioritize results from within a rectangular area (defined by two longitude and latitude points representing the southwest and northeast corners), and then search globally.  <br>  Example: `bias=rect:-89.097540,39.668983,-88.399274,40.383412`<br>  <br>- **By country**:  <br>  Use comma-separated ISO 3166-1 Alpha-2 country codes in lowercase to prioritize results from those countries first. Use `'auto'` to detect the country by IP address, or `'none'` to skip country bias.  <br>  Example: `bias=countrycode:de,es,fr`<br>  <br>- **By location**:  <br>  Use `proximity:lon,lat` to prioritize results based on distance from a specific longitude and latitude.  <br>  Example: `bias=proximity:41.2257145,52.971411` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeocodeAutocompleteResponse](Models/AnyOf/GeocodeAutocompleteResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAddressAutocompleteError](Errors/GetAddressAutocompleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IpGeolocationApi

> Source: [IpGeolocationApi](Api/IpGeolocationApi.cs)

<details>
<summary><code>Task&lt;IpgeolocationResponse&gt; GetIpgeolocation(string apiKey, string? ip, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns location details such as country, city, currency, and language based on the specified IP address. If no IP address is provided, the user's own IP address will be automatically detected and used for the lookup. This API can help customize user experiences, such as localizing content or payment forms based on location.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IpGeolocationApi.GetIpgeolocation(apiKey, ip);
    // TODO: Handle 'response' of type IpgeolocationResponse
}
catch (SdkException<GetIpgeolocationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetIpgeolocationError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | Your Geoapify API key used to authenticate the request. Sign up for a free API key at [https://myprojects.geoapify.com/](https://myprojects.geoapify.com/), which includes up to 3,000 requests per day on the Free plan. |
| <code>ip</code> | <code>string?</code> | The IP address to retrieve location information for. If not provided, the request will use the client's IP address automatically. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IpgeolocationResponse](Models/IpgeolocationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetIpgeolocationError](Errors/GetIpgeolocationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IsolineApi

> Source: [IsolineApi](Api/IsolineApi.cs)

<details>
<summary><code>Task&lt;IsolineResponse&gt; GetIsoline(string apiKey, double lat, double lon, Type5 type, Mode mode, string range, string? avoid, TrafficEnum? traffic, RouteTypeEnum? routeType, double? maxSpeed, UnitsEnum? units, string? id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns isolines (Isochrones or Isodistances) based on a specified location, travel mode, and range. Isochrones represent areas accessible within a given travel time, while isodistances represent areas reachable within a certain distance.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IsolineApi.GetIsoline(apiKey,
        lat,
        lon,
        type,
        mode,
        range,
        avoid,
        traffic,
        routeType,
        maxSpeed,
        units,
        id);
    // TODO: Handle 'response' of type IsolineResponse
}
catch (SdkException<GetIsolineError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetIsolineError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at [https://myprojects.geoapify.com/](https://myprojects.geoapify.com/). The Free plan includes up to 3,000 requests per day. |
| <code>lat</code> | <code>double</code> | The latitude of the location from which to calculate the isoline. |
| <code>lon</code> | <code>double</code> | The longitude of the location from which to calculate the isoline. |
| <code>type</code> | <code>[Type5](Models/Enums/Type5.cs)</code> | Specifies whether to calculate an isochrone (based on travel time) or an isodistance (based on distance). |
| <code>mode</code> | <code>[Mode](Models/Enums/Mode.cs)</code> | Determines how the accessible area is calculated based on the type of transportation or movement.<br><br>Available options include:<br>- `drive`: Standard car or automobile.<br>- `light_truck`: Light-duty truck.<br>- `medium_truck`: Medium-duty truck.<br>- `truck`: General truck.<br>- `heavy_truck`: Heavy-duty truck.<br>- `truck_dangerous_goods`: Truck carrying hazardous materials.<br>- `long_truck`: Long or articulated truck.<br>- `bus`: Public or private bus.<br>- `scooter`: Motorized scooter.<br>- `motorcycle`: Motorbike.<br>- `bicycle`: Standard bicycle.<br>- `mountain_bike`: Mountain bike.<br>- `road_bike`: Road bicycle.<br>- `walk`: Walking on foot.<br>- `hike`: Hiking, often on trails or rugged terrain.<br>- `transit`: Public transit routes (based on real-time data).<br>- `approximated_transit`: Estimated public transit routes (without real-time data).<br><br>Selecting the appropriate travel mode helps generate an isoline that accurately reflects the time or distance accessible for the specified mode. |
| <code>range</code> | <code>string</code> | The range value for the isoline. For isochrones, the range is specified in seconds (travel time). For isodistances, it is specified in meters (travel distance). |
| <code>avoid</code> | <code>string?</code> | Specifies road types or specific locations to avoid during routing. Use this to exclude features like toll roads, highways, ferries, or particular geographic areas. |
| <code>traffic</code> | <code>[TrafficEnum?](Models/Enums/TrafficEnum.cs)</code> | The traffic model to be used in route calculations. The default value is `free_flow`, which does not consider real-time traffic. Alternatively, use `approximated` for a traffic-influenced model. |
| <code>routeType</code> | <code>[RouteTypeEnum?](Models/Enums/RouteTypeEnum.cs)</code> | Defines the type of route to calculate. Options include `balanced` for a mix of efficiency and speed, `short` for the shortest route, and `less_maneuvers` to minimize turns or complexity. The default is `balanced`. |
| <code>maxSpeed</code> | <code>double?</code> | The maximum speed that a vehicle can travel. This applies to driving mode, all truck modes, and bus modes. The max_speed should be specified within the range of 10 to 252 KPH (6.5 - 155 MPH). For trucks, the standard setting is 90 kilometers per hour (KPH), while for automobiles and buses, it's set at 140 KPH by default. |
| <code>units</code> | <code>[UnitsEnum?](Models/Enums/UnitsEnum.cs)</code> | Specifies the units of measurement for distances in the response. The default is metric. Use `imperial` for miles, feet, etc. |
| <code>id</code> | <code>string?</code> | ID of previously generated isoline. This parameter allows you to retrieve previously calculated isolines within a 24-hour window without recalculating them. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IsolineResponse](Models/IsolineResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetIsolineError](Errors/GetIsolineError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MapMatchingApi

> Source: [MapMatchingApi](Api/MapMatchingApi.cs)

<details>
<summary><code>Task&lt;MapMatchingResponse&gt; MapMatching(string apiKey, MapmatchingRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Aligns geographical coordinates, such as GPS tracks, to the nearest roads and pathways on the existing road network. This endpoint supports various travel modes, including driving, walking, and cycling, to ensure accurate route matching based on the mode of transportation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MapMatchingApi.MapMatching(apiKey, body);
    // TODO: Handle 'response' of type MapMatchingResponse
}
catch (SdkException<MapMatchingError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type MapMatchingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at [https://myprojects.geoapify.com/](https://myprojects.geoapify.com/). The Free plan includes up to 3,000 requests per day. |
| <code>body</code> | <code>[MapmatchingRequest](Models/MapmatchingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MapMatchingResponse](Models/MapMatchingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MapMatchingError](Errors/MapMatchingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PlacesApi

> Source: [PlacesApi](Api/PlacesApi.cs)

<details>
<summary><code>Task GetPlaces(string apiKey, string categories, string? conditions, string? filter, string? bias, int? limit, int? offset, string? lang, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns points of interest based on specified location and filters. You can filter places by category, conditions (e.g., wheelchair accessible), and geometry (bounding box, circle, etc.).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PlacesApi.GetPlaces(apiKey, categories, conditions, filter, bias, limit, offset, lang, name);
}
catch (SdkException<GetPlacesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetPlacesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | The API key for Geoapify services. |
| <code>categories</code> | <code>string</code> | Comma-separated list of place categories (e.g., catering.restaurant, catering.cafe). |
| <code>conditions</code> | <code>string?</code> | Filter results by conditions (e.g., wheelchair accessibility, internet access). Check supported values for conditions. |
| <code>filter</code> | <code>string?</code> | Filter results by geometry. For example, use `rect:lon1,lat1,lon2,lat2` for a bounding box or `circle:lon,lat,radiusMeters` for a circle. |
| <code>bias</code> | <code>string?</code> | Search places near the specified location. Note, the search will prioritize places within 50km. |
| <code>limit</code> | <code>int?</code> | Maximum number of results per page. |
| <code>offset</code> | <code>int?</code> | Offset to the first result index for pagination. |
| <code>lang</code> | <code>string?</code> | The language of the result. Supports 2-character ISO 639-1 language codes (e.g., "en"). |
| <code>name</code> | <code>string?</code> | Filter places by the given name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPlacesError](Errors/GetPlacesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ReverseGeocodingApi

> Source: [ReverseGeocodingApi](Api/ReverseGeocodingApi.cs)

<details>
<summary><code>Task&lt;GeocodeReverseResponse&gt; GetReverseGeocode(double lat, double lon, string apiKey, Format? format, int? limit, Type3? type, string? lang, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an address and its components (such as city, postcode, street, etc.) based on the provided latitude and longitude coordinates. Use this endpoint to convert coordinates into a human-readable address for various use cases, such as map applications or location-based services.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ReverseGeocodingApi.GetReverseGeocode(lat, lon, apiKey, format, limit, type, lang);
    // TODO: Handle 'response' of type GeocodeReverseResponse
}
catch (SdkException<GetReverseGeocodeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetReverseGeocodeError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>lat</code> | <code>double</code> | The latitude of the location to reverse geocode. |
| <code>lon</code> | <code>double</code> | The longitude of the location to reverse geocode. |
| <code>apiKey</code> | <code>string</code> | Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at [https://myprojects.geoapify.com/](https://myprojects.geoapify.com/). The Free plan includes up to 3,000 requests per day. |
| <code>format</code> | <code>[Format?](Models/Enums/Format.cs)</code> | The format of the response (JSON, XML, or GeoJSON). |
| <code>limit</code> | <code>int?</code> | The maximum number of results to return. |
| <code>type</code> | <code>[Type3?](Models/Enums/Type3.cs)</code> | Defines the location type to be searched. Available types include:<br><br>- `country`: Search for countries.<br>- `state`: Search for states or regions.<br>- `city`: Search for cities or towns.<br>- `postcode`: Search for postal codes.<br>- `street`: Search for specific streets.<br>- `amenity`: Search for points of interest (e.g., schools, parks, etc.). |
| <code>lang</code> | <code>string?</code> | Result language in [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format (e.g., 'en' for English). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeocodeReverseResponse](Models/AnyOf/GeocodeReverseResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetReverseGeocodeError](Errors/GetReverseGeocodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RouteMatrixApi

> Source: [RouteMatrixApi](Api/RouteMatrixApi.cs)

<details>
<summary><code>Task&lt;RouteMatrixResponse&gt; GenerateRouteMatrix(string apiKey, RoutematrixRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a time-distance matrix for the specified source and target locations, providing valuable data for route optimization and travel analytics. The API supports various transportation modes, including driving, walking, and cycling, making it ideal for logistics, route planning, and other mobility applications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RouteMatrixApi.GenerateRouteMatrix(apiKey, body);
    // TODO: Handle 'response' of type RouteMatrixResponse
}
catch (SdkException<GenerateRouteMatrixError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GenerateRouteMatrixError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at [https://myprojects.geoapify.com/](https://myprojects.geoapify.com/). The Free plan includes up to 3,000 requests per day. |
| <code>body</code> | <code>[RoutematrixRequest](Models/RoutematrixRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RouteMatrixResponse](Models/RouteMatrixResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GenerateRouteMatrixError](Errors/GenerateRouteMatrixError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RoutingApi

> Source: [RoutingApi](Api/RoutingApi.cs)

<details>
<summary><code>Task&lt;RoutingResponse&gt; CalculateRoute(string apiKey, string waypoints, Mode mode, RouteTypeEnum? type, UnitsEnum? units, string? lang, string? avoid, string? details, TrafficEnum? traffic, int? maxSpeed, Format? format, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculates the optimal route between two or more waypoints for various transportation modes, including cars, trucks, bicycles, and walking. The API allows customization through parameters such as road type avoidance (e.g., tolls, highways) and specific route preferences (e.g., shortest or fastest). The response includes detailed directions and turn-by-turn navigation for seamless travel planning.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoutingApi.CalculateRoute(apiKey,
        waypoints,
        mode,
        type,
        units,
        lang,
        avoid,
        details,
        traffic,
        maxSpeed,
        format);
    // TODO: Handle 'response' of type RoutingResponse
}
catch (SdkException<CalculateRouteError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CalculateRouteError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>apiKey</code> | <code>string</code> | Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at [https://myprojects.geoapify.com/](https://myprojects.geoapify.com/). The Free plan includes up to 3,000 requests per day. |
| <code>waypoints</code> | <code>string</code> | A list of coordinates representing the waypoints for the route. Each coordinate is specified as a latitude, longitude pair. <br><br>Multiple waypoints should be separated by a vertical bar (`\|`). At least two waypoints (a start and an endpoint) are required, but additional waypoints can be added to customize the route. <br><br>Example format: <br>"50.679023,4.569876\|50.661705,4.578667" |
| <code>mode</code> | <code>[Mode](Models/Enums/Mode.cs)</code> | Specifies how the route will be optimized based on the selected transportation type.<br><br>Available options include:<br>- `drive`: Standard car or automobile.<br>- `light_truck`: Light-duty truck.<br>- `medium_truck`: Medium-duty truck.<br>- `truck`: General truck.<br>- `heavy_truck`: Heavy-duty truck.<br>- `truck_dangerous_goods`: Truck carrying dangerous goods.<br>- `long_truck`: Long or articulated truck.<br>- `bus`: Public or private bus.<br>- `scooter`: Motorized scooter.<br>- `motorcycle`: Motorbike.<br>- `bicycle`: Standard bicycle.<br>- `mountain_bike`: Mountain bike.<br>- `road_bike`: Road bicycle.<br>- `walk`: Walking on foot.<br>- `hike`: Hiking on trails or difficult terrain.<br>- `transit`: Public transit routes.<br>- `approximated_transit`: Estimated public transit routes (without real-time data).<br><br>Choose the appropriate mode for more accurate route calculations. |
| <code>type</code> | <code>[RouteTypeEnum?](Models/Enums/RouteTypeEnum.cs)</code> | Specifies the type of route optimization to apply. This parameter determines how the route will be optimized based on user preferences:<br><br>- `balanced`: Provides a balanced route, optimizing for both travel time and distance.<br>- `short`: Prioritizes the shortest possible route in terms of distance, potentially ignoring other factors like travel time.<br>- `less_maneuvers`: Reduces the number of turns or complex maneuvers, providing a simpler route, which can be useful for larger vehicles or ease of navigation. |
| <code>units</code> | <code>[UnitsEnum?](Models/Enums/UnitsEnum.cs)</code> | Specifies the units of measurement for distance in the response. Choose between:<br><br>- `metric`: Uses kilometers and meters.<br>- `imperial`: Uses miles and feet.<br><br>If not specified, the default is `metric`. Select the appropriate units based on the region or user preferences. |
| <code>lang</code> | <code>string?</code> | Result language in [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format (e.g., 'en' for English). |
| <code>avoid</code> | <code>string?</code> | Specifies the types of roads or locations to avoid during route calculation. You can customize this option by adding one or more types, separated by a vertical bar (`\|`), and even assign importance to some avoid types on a scale from 0 to 1.<br><br>Available options include:<br><br>- **tolls**: Avoid roads with tolls. You can specify importance as `tolls:importance`, where `importance` is a value between 0 and 1 (with 1 being the most important). This option works with modes like `drive`, `truck`, `light_truck`, `medium_truck`, `truck_dangerous_goods`, `heavy_truck`, `long_truck`, and `bus`.<br>  - Example: `avoid=tolls` or `avoid=tolls:0.8`<br><br>- **ferries**: Avoid routes that include ferries. You can specify importance as `ferries:importance` (similar to tolls). <br>  - Example: `avoid=ferries` or `avoid=ferries:0.9`<br><br>- **highways**: Avoid highways. You can also specify importance as `highways:importance`. This option works with driving-related modes.<br>  - Example: `avoid=highways` or `avoid=highways:0.7`<br><br>- **location**: Avoid specific geographic locations. You can provide a latitude and longitude pair in the format `location:lat,lon` or `location_lonlat:lon,lat` to avoid certain areas (e.g., closed roads or barriers).<br>  - Example: `avoid=location:35.234045,-80.836392` or `avoid=location_lonlat:-80.836392,35.234045`<br><br>Note: The routing algorithm will take your avoids into account but may still include them if there are no alternative routes. Using the `avoid` parameter may increase calculation time and add extra cost to the API call. |
| <code>details</code> | <code>string?</code> | Specifies additional details to include in the response. You can request multiple types of information, separated by commas. Available options include:<br><br>- `instruction_details`: Provides more granular step-by-step navigation instructions.<br>- `route_details`: Includes detailed information about the route, such as distances and durations for each segment.<br>- `elevation`: Adds elevation data along the route, showing the changes in altitude.<br><br>You can combine these options as needed to get more comprehensive routing information. |
| <code>traffic</code> | <code>[TrafficEnum?](Models/Enums/TrafficEnum.cs)</code> | Specifies the traffic model to use during route calculation. The available options are:<br><br>- `free_flow`: The default option. Calculates the route optimistically, assuming no traffic delays or congestion.<br>- `approximated`: Adjusts the route by accounting for potential traffic, decreasing speed on roads that are likely to be congested.<br><br>This parameter is only applicable to motorized vehicle modes, such as `drive`, `truck`, and other similar modes. |
| <code>maxSpeed</code> | <code>int?</code> | The maximum allowable speed for the route, specified in kilometers per hour (KPH). |
| <code>format</code> | <code>[Format?](Models/Enums/Format.cs)</code> | The desired output format for the response, options include 'geojson', 'json', or 'xml'. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RoutingResponse](Models/AnyOf/RoutingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CalculateRouteError](Errors/CalculateRouteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

